﻿using System;
using System.Net;
using log4net;

namespace OutlookGoogleCalendarSync {
    class Social {
        private static readonly ILog log = LogManager.GetLogger(typeof(Social));

        public static void Donate() {
            System.Diagnostics.Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=RT46CXQDSSYWJ&item_name=Outlook Google Calendar Sync from " + Settings.Instance.GaccountEmail);
        }

        #region Social
        public static void Google_goToCommunity() {
            System.Diagnostics.Process.Start("https://plus.google.com/communities/114412828247015553563");
        }
        public static void Google_share() {
            System.Diagnostics.Process.Start("https://plus.google.com/share?&url=http://bit.ly/ogcalsync");
        }

        public static void Twitter_tweet() {
            string text = "I'm using this Outlook-Google calendar sync tool - completely #free and feature loaded. #recommend";
            System.Diagnostics.Process.Start("http://twitter.com/intent/tweet?&url=http://bit.ly/ogcalsync&text=" + urlEncode(text) + "&via=ogcalsync");
        }
        public static void Twitter_follow() {
            System.Diagnostics.Process.Start("https://twitter.com/OGcalsync");
        }

        public static void Facebook_share() {
            System.Diagnostics.Process.Start("http://www.facebook.com/sharer/sharer.php?u=http://bit.ly/ogcalsync");
        }
        public static void RSS_follow() {
            System.Diagnostics.Process.Start("https://github.com/phw198/outlookgooglecalendarsync/releases.atom");
        }
        public static void Linkedin_share() {
            string text = "I'm using this Outlook-Google calendar sync tool - completely #free and feature loaded. #recommend";
            System.Diagnostics.Process.Start("http://www.linkedin.com/shareArticle?mini=true&url=http://bit.ly/ogcalsync&summary=" + urlEncode(text));
        }

        private static String urlEncode(String text) {
            return text.Replace("#", "%23");
        }
        #endregion

        public static void TrackVersions() {
            if (System.Diagnostics.Debugger.IsAttached) return;

            //OUTLOOK CLIENT
            String outlookVersion = "Unknown";
            try {
                switch (OutlookOgcs.Factory.OutlookVersion) {
                    case 11: outlookVersion = "2003"; break;
                    case 12: outlookVersion = "2007"; break;
                    case 14: outlookVersion = "2010"; break;
                    case 15: outlookVersion = "2013"; break;
                    case 16: outlookVersion = "2016"; break;
                    case 17: outlookVersion = "2019"; break;
                    default: outlookVersion = "Unknown-" + OutlookOgcs.Factory.OutlookVersion; break;
                }
            } catch (System.Exception ex) {
                log.Error("Failed determining Outlook client version.");
                OGCSexception.Analyse(ex);
                outlookVersion = "Unknown";
            }
            Analytics.Send(Analytics.Category.outlook, Analytics.Action.version, outlookVersion);

            //OGCS APPLICATION
            Analytics.Send(Analytics.Category.ogcs, Analytics.Action.version, System.Windows.Forms.Application.ProductVersion);
        }

        public static void TrackSync() {
            //Use an API that isn't used anywhere else - can use to see how many syncs are happening
            if (System.Diagnostics.Debugger.IsAttached) return;
            GoogleOgcs.Calendar.Instance.GetSetting("locale");
        }
    }

    public class Analytics {
        private static readonly ILog log = LogManager.GetLogger(typeof(Analytics));

        public enum Category {
            ogcs,
            outlook,
            squirrel
        }
        public enum Action {
            download,
            install,
            setting,
            uninstall,
            upgrade,
            version
        }
        
        public static void Send(Category category, Action action, String label) {
            String cid = GoogleOgcs.Authenticator.HashedGmailAccount ?? "1";
            String baseAnalyticsUrl = "https://www.google-analytics.com/collect?v=1&t=event&tid=UA-19426033-4&cid=" + cid;

            String analyticsUrl = baseAnalyticsUrl + "&ec=" + category.ToString() + "&ea=" + action.ToString() + "&el=" + System.Net.WebUtility.UrlEncode(label);
            log.Debug("Retrieving URL: " + analyticsUrl);
            if (System.Diagnostics.Debugger.IsAttached) return;

            WebClient wc = new WebClient();
            wc.Headers.Add("user-agent", Settings.Instance.Proxy.BrowserUserAgent);
            wc.DownloadStringCompleted += new DownloadStringCompletedEventHandler(sendTelemetry_completed);
            wc.DownloadStringAsync(new Uri(analyticsUrl), analyticsUrl);
        }

        private static void sendTelemetry_completed(object sender, DownloadStringCompletedEventArgs e) {
            if (e.Error != null) {
                log.Warn("Failed to access URL " + e.UserState.ToString());
                log.Error(e.Error.Message);
                if (e.Error.InnerException != null) log.Error(e.Error.InnerException.Message);
                if (e.Error is WebException) {
                    WebException we = e.Error as WebException;
                    if (we.Response != null) {
                        log.Debug("Reading response.");
                        System.IO.Stream stream = we.Response.GetResponseStream();
                        System.IO.StreamReader sr = new System.IO.StreamReader(stream);
                        log.Error(sr.ReadToEnd());
                    }
                }
            }
        }
    }
}
