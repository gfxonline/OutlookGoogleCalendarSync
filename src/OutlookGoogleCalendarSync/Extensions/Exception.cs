﻿using log4net;
using System;
using System.ComponentModel;

namespace OutlookGoogleCalendarSync {
    class UserCancelledSyncException : System.Exception {
        public UserCancelledSyncException() { }
        public UserCancelledSyncException(string message) : base(message) { }
        public UserCancelledSyncException(string message, System.Exception inner) : base(message, inner) { }
    }

    class OGCSexception {
        private static readonly ILog log = LogManager.GetLogger(typeof(OGCSexception));

        public static void Analyse(String warnDetail, System.Exception ex, Boolean includeStackTrace = false) {
            log.Warn(warnDetail);
            Analyse(ex, includeStackTrace: includeStackTrace);
        }
        public static void Analyse(System.Exception ex, Boolean includeStackTrace = false) {
            log.Error(ex.GetType().FullName + ": " + ex.Message);
            int errorCode = getErrorCode(ex);
            log.Error("Code: 0x" + errorCode.ToString("X8") + ";" + errorCode.ToString());

            if (ex.InnerException != null) {
                log.Error("InnerException:-");
                Analyse(ex.InnerException, false);
            }
            if (includeStackTrace) log.Error(ex.StackTrace);
        }

        public static String GetErrorCode(System.Exception ex, UInt32 mask = 0xFFFFFFFF) {
            UInt32 maskedCode = (uint)(getErrorCode(ex) & mask);
            return "0x" + maskedCode.ToString("X8");
        }

        private static int getErrorCode(System.Exception ex) {
            try {
                var w32ex = ex as Win32Exception;
                if (w32ex == null) {
                    w32ex = ex.InnerException as Win32Exception;
                }
                if (w32ex != null) {
                    return w32ex.ErrorCode;
                }
            } catch {
                log.Error("Failed to obtain Win32Exception.");
            }
            try {
                return System.Runtime.InteropServices.Marshal.GetHRForException(ex);
            } catch {
                log.Error("Failed to get HResult.");
            }
            return -1;
        }

        public static void AnalyseAggregate(AggregateException agex, Boolean throwError = true) {
            foreach (System.Exception ex in agex.InnerExceptions) {
                if (ex is ApplicationException) {
                    if (!String.IsNullOrEmpty(ex.Message)) Forms.Main.Instance.Console.UpdateWithError(null, ex);
                    else log.Error(agex.Message);

                } else if (ex is Google.Apis.Auth.OAuth2.Responses.TokenResponseException) {
                    AnalyseTokenResponse(ex as Google.Apis.Auth.OAuth2.Responses.TokenResponseException, throwError);

                } else Analyse(ex);
            }
        }
        
        public static void AnalyseTokenResponse(Google.Apis.Auth.OAuth2.Responses.TokenResponseException ex, Boolean throwError = true) {
            String instructions = "On the Settings > Google tab, please disconnect and re-authenticate your account.";

            log.Warn("Token response error: " + ex.Message);
            if (ex.Error.Error == "access_denied")
                Forms.Main.Instance.Console.Update("Failed to obtain Calendar access from Google - it's possible your access has been revoked.<br/>" + instructions, Console.Markup.error, notifyBubble: true);

            else if ("invalid_client;unauthorized_client".Contains(ex.Error.Error))
                Forms.Main.Instance.Console.Update("Invalid authentication token. Account requires reauthorising.\r\n" + instructions, Console.Markup.error, notifyBubble: true);

            else if (ex.Error.Error == "invalid_grant")
                Forms.Main.Instance.Console.Update("Google has revoked your authentication token. Account requires reauthorising.<br/>" + instructions, Console.Markup.error, notifyBubble: true);

            else {
                log.Warn("Unknown web exception.");
                Forms.Main.Instance.Console.UpdateWithError("Unable to communicate with Google. The following error occurred:", ex, notifyBubble: true);
            }
            if (throwError) throw ex;
        }

        public static String FriendlyMessage(System.Exception ex) {
            if (ex is Google.GoogleApiException) {
                Google.GoogleApiException gaex = ex as Google.GoogleApiException;
                return gaex.Error.Message + " [" + gaex.Error.Code + "=" + gaex.HttpStatusCode + "]";
            } else {
                return ex.Message;
            }
        }
    }
}
