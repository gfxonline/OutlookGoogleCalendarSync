﻿using log4net;
using System;
using System.Threading;
using System.Windows.Forms;

namespace OutlookGoogleCalendarSync {
    public partial class Splash : Form {
        private static readonly ILog log = LogManager.GetLogger(typeof(Splash));
        
        private static Thread splashThread;
        private static Splash splash;
        private static ToolTip ToolTips;
        private static Boolean donor;
        private static DateTime subscribed;
        private static Boolean initialised = false;

        public Splash() {
            InitializeComponent();
        }

        public static void ShowMe() {
            if (splashThread == null) {
                splashThread = new Thread(new ThreadStart(doShowSplash));
                splashThread.IsBackground = true;
                splashThread.Start();
                while (!initialised) {
                    //Stop the program continuing until splash screen has finished accessing settings.xml
                    Thread.Sleep(50);
                }
            }
        }
        private static void doShowSplash() {
            try {
                if (splash == null)
                    splash = new Splash();

                splash.lVersion.Text = "v" + Application.ProductVersion;
                String completedSyncs = XMLManager.ImportElement("CompletedSyncs", Program.SettingsFile) ?? "0";
                if (completedSyncs == "0")
                    splash.lSyncCount.Visible = false;
                else {
                    splash.lSyncCount.Text = splash.lSyncCount.Text.Replace("{syncs}", String.Format("{0:n0}", completedSyncs));
                    splash.lSyncCount.Left = (splash.panel1.Width - (splash.lSyncCount.Width)) / 2;
                }
                //Load settings directly from XML
                donor = true;// (XMLManager.ImportElement("Donor", Program.SettingsFile) ?? "false") == "true";

                String subscribedDate = XMLManager.ImportElement("Subscribed", Program.SettingsFile);
                if (string.IsNullOrEmpty(subscribedDate)) subscribedDate = "01-Jan-2000";
                subscribed = DateTime.Parse(subscribedDate);
                Boolean hideSplash = true;//(XMLManager.ImportElement("HideSplashScreen", Program.SettingsFile) ?? "false") == "true";
                initialised = true;

                splash.cbHideSplash.Checked = hideSplash;
                if (subscribed == DateTime.Parse("01-Jan-2000") && !donor) {
                    ToolTips = new ToolTip();
                    ToolTips.AutoPopDelay = 10000;
                    ToolTips.InitialDelay = 500;
                    ToolTips.ReshowDelay = 200;
                    ToolTips.ShowAlways = true;

                    ToolTips.SetToolTip(splash.cbHideSplash, "Donate £10 or more to enable this feature.");
                } else if (hideSplash) {
                    log.Debug("Suppressing splash screen.");
                    return;
                }
                splash.TopLevel = true;
                splash.TopMost = true;
                log.Debug("Showing splash screen.");
                Application.Run(splash);
                log.Debug("Disposed of splash screen.");
                splashThread.Abort();
            } finally {
                initialised = true;
            }
        }

        public static void CloseMe() {
            if (splash.InvokeRequired) {
                splash.Invoke(new MethodInvoker(CloseMe));
            } else {
                if (!splash.IsDisposed) splash.Close();
            }
        }

        private void pbDonate_Click(object sender, EventArgs e) {
            Social.Donate();
            this.Close();
        }

        private void pbSocialGplusCommunity_Click(object sender, EventArgs e) {
            Social.Google_goToCommunity();
            this.Close();
        }

        private void pbSocialTwitterFollow_Click(object sender, EventArgs e) {
            Social.Twitter_follow();
            this.Close();
        }

        private void Splash_Shown(object sender, EventArgs e) {
            splash.Tag = DateTime.Now;
            while (DateTime.Now < ((DateTime)splash.Tag).AddSeconds((System.Diagnostics.Debugger.IsAttached ? 2 : 8)) && !splash.IsDisposed) {
                splash.BringToFront();
                splash.TopLevel = true;
                splash.TopMost = true;
                Application.DoEvents();
                System.Threading.Thread.Sleep(100);
            }
            CloseMe();
        }

        private void cbHideSplash_CheckedChanged(object sender, EventArgs e) {
            if (!this.Visible) return;

            if (subscribed == DateTime.Parse("01-Jan-2000") && !donor) {
                this.cbHideSplash.CheckedChanged -= cbHideSplash_CheckedChanged;
                cbHideSplash.Checked = false;
                this.cbHideSplash.CheckedChanged += cbHideSplash_CheckedChanged;
                ToolTips.Show(ToolTips.GetToolTip(cbHideSplash), cbHideSplash, 5000);
                return;
            }
            if (cbHideSplash.Checked) {
                this.Visible = false;
                while (!Settings.InstanceInitialiased() && !MainForm.Instance.IsHandleCreated) {
                    log.Debug("Waiting for settings and form to initialise in order to save HideSplashScreen preference.");
                    System.Threading.Thread.Sleep(2000);
                }
                Settings.Instance.HideSplashScreen = true;
                CloseMe();
            }
        }
    }
}
