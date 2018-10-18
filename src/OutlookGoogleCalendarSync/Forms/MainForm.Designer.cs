﻿namespace OutlookGoogleCalendarSync.Forms {
    partial class Main {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Disposes resources used by the form.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            System.Boolean notificationTrayExited = false;
            try {
                notificationTrayExited = Forms.Main.Instance.NotificationTray.Exited;
            } catch {
                notificationTrayExited = true;
            }
            if (Settings.Instance.MinimiseNotClose && !notificationTrayExited &&
                this.WindowState != System.Windows.Forms.FormWindowState.Minimized) {
                this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            } else {
                if (disposing) {
                    if (components != null) {
                        components.Dispose();
                    }
                }
                base.Dispose(disposing);
            }
        }

        /// <summary>
        /// This method is required for Windows Forms designer support.
        /// Do not change the method contents inside the source code editor. The Forms designer might
        /// not be able to load this method if it was changed manually.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabApp = new System.Windows.Forms.TabControl();
            this.tabPage_Sync = new System.Windows.Forms.TabPage();
            this.cbMuteClicks = new System.Windows.Forms.CheckBox();
            this.consolePanel = new System.Windows.Forms.Panel();
            this.consoleWebBrowser = new System.Windows.Forms.WebBrowser();
            this.tbSyncNote = new System.Windows.Forms.RichTextBox();
            this.panelSyncNote = new System.Windows.Forms.Panel();
            this.cbVerboseOutput = new System.Windows.Forms.CheckBox();
            this.lNextSyncVal = new System.Windows.Forms.Label();
            this.lLastSyncVal = new System.Windows.Forms.Label();
            this.lNextSync = new System.Windows.Forms.Label();
            this.lLastSync = new System.Windows.Forms.Label();
            this.bSyncNow = new System.Windows.Forms.Button();
            this.tabPage_Settings = new System.Windows.Forms.TabPage();
            this.lSettingInfo = new System.Windows.Forms.Label();
            this.tabAppSettings = new System.Windows.Forms.TabControl();
            this.tabOutlook = new System.Windows.Forms.TabPage();
            this.cbOutlookCalendars = new System.Windows.Forms.ComboBox();
            this.lFilterCategories = new System.Windows.Forms.Label();
            this.cbCategoryFilter = new System.Windows.Forms.ComboBox();
            this.clbCategories = new System.Windows.Forms.CheckedListBox();
            this.msCategories = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miCatSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.miCatSelectNone = new System.Windows.Forms.ToolStripMenuItem();
            this.miCatRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label32 = new System.Windows.Forms.Label();
            this.urlDateFormats = new System.Windows.Forms.LinkLabel();
            this.btTestOutlookFilter = new System.Windows.Forms.Button();
            this.tbOutlookDateFormatResult = new System.Windows.Forms.TextBox();
            this.tbOutlookDateFormat = new System.Windows.Forms.TextBox();
            this.cbOutlookDateFormat = new System.Windows.Forms.ComboBox();
            this.txtDateFormats = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lOutlookCalendar = new System.Windows.Forms.Label();
            this.rbOutlookDefaultMB = new System.Windows.Forms.RadioButton();
            this.rbOutlookSharedCal = new System.Windows.Forms.RadioButton();
            this.ddMailboxName = new System.Windows.Forms.ComboBox();
            this.cbOnlyRespondedInvites = new System.Windows.Forms.CheckBox();
            this.rbOutlookAltMB = new System.Windows.Forms.RadioButton();
            this.tabGoogle = new System.Windows.Forms.TabPage();
            this.gbDeveloperOptions = new System.Windows.Forms.GroupBox();
            this.llAPIConsole = new System.Windows.Forms.LinkLabel();
            this.cbShowClientSecret = new System.Windows.Forms.CheckBox();
            this.lGoogleAPIInstructions = new System.Windows.Forms.TextBox();
            this.tbClientSecret = new System.Windows.Forms.TextBox();
            this.tbClientID = new System.Windows.Forms.TextBox();
            this.lClientID = new System.Windows.Forms.Label();
            this.lSecret = new System.Windows.Forms.Label();
            this.cbShowDeveloperOptions = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btResetGCal = new System.Windows.Forms.Button();
            this.lGoogleHelp = new System.Windows.Forms.Label();
            this.lGoogleCalendar = new System.Windows.Forms.Label();
            this.bGetGoogleCalendars = new System.Windows.Forms.Button();
            this.cbGoogleCalendars = new System.Windows.Forms.ComboBox();
            this.tabSyncOptions = new System.Windows.Forms.TabPage();
            this.WhatPostit = new System.Windows.Forms.Panel();
            this.tbWhatHelp = new System.Windows.Forms.RichTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.panelSyncOptions = new System.Windows.Forms.Panel();
            this.pbExpandHow = new System.Windows.Forms.PictureBox();
            this.gbSyncOptions_How = new System.Windows.Forms.GroupBox();
            this.howMorePanel = new System.Windows.Forms.Panel();
            this.cbColour = new System.Windows.Forms.CheckBox();
            this.tbTargetCalendar = new System.Windows.Forms.DomainUpDown();
            this.tbCreatedItemsOnly = new System.Windows.Forms.DomainUpDown();
            this.cbAvailable = new System.Windows.Forms.CheckBox();
            this.lTargetSyncCondition = new System.Windows.Forms.Label();
            this.cbPrivate = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btObfuscateRules = new System.Windows.Forms.Button();
            this.cbOfuscate = new System.Windows.Forms.CheckBox();
            this.syncDirection = new System.Windows.Forms.ComboBox();
            this.cbMergeItems = new System.Windows.Forms.CheckBox();
            this.cbDisableDeletion = new System.Windows.Forms.CheckBox();
            this.cbConfirmOnDelete = new System.Windows.Forms.CheckBox();
            this.howObfuscatePanel = new System.Windows.Forms.Panel();
            this.btCloseRegexRules = new System.Windows.Forms.Button();
            this.cbObfuscateDirection = new System.Windows.Forms.ComboBox();
            this.label31 = new System.Windows.Forms.Label();
            this.dgObfuscateRegex = new System.Windows.Forms.DataGridView();
            this.regexFind = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regexReplace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lDirection = new System.Windows.Forms.Label();
            this.pbExpandWhat = new System.Windows.Forms.PictureBox();
            this.pbExpandWhen = new System.Windows.Forms.PictureBox();
            this.gbSyncOptions_When = new System.Windows.Forms.GroupBox();
            this.cbOutlookPush = new System.Windows.Forms.CheckBox();
            this.cbIntervalUnit = new System.Windows.Forms.ComboBox();
            this.tbInterval = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDaysInTheFuture = new System.Windows.Forms.NumericUpDown();
            this.tbDaysInThePast = new System.Windows.Forms.NumericUpDown();
            this.lDaysInFuture = new System.Windows.Forms.Label();
            this.lDaysInPast = new System.Windows.Forms.Label();
            this.lDateRange = new System.Windows.Forms.Label();
            this.gbSyncOptions_What = new System.Windows.Forms.GroupBox();
            this.cbAddColours = new System.Windows.Forms.CheckBox();
            this.cbCloakEmail = new System.Windows.Forms.CheckBox();
            this.lDNDand = new System.Windows.Forms.Label();
            this.dtDNDend = new System.Windows.Forms.DateTimePicker();
            this.dtDNDstart = new System.Windows.Forms.DateTimePicker();
            this.cbAddDescription_OnlyToGoogle = new System.Windows.Forms.CheckBox();
            this.cbAddReminders = new System.Windows.Forms.CheckBox();
            this.lAttributes = new System.Windows.Forms.Label();
            this.cbAddAttendees = new System.Windows.Forms.CheckBox();
            this.cbAddDescription = new System.Windows.Forms.CheckBox();
            this.cbReminderDND = new System.Windows.Forms.CheckBox();
            this.cbUseGoogleDefaultReminder = new System.Windows.Forms.CheckBox();
            this.lWhatInfo = new System.Windows.Forms.Label();
            this.tabAppBehaviour = new System.Windows.Forms.TabPage();
            this.tbStartupDelay = new System.Windows.Forms.NumericUpDown();
            this.cbHideSplash = new System.Windows.Forms.CheckBox();
            this.cbMinimiseNotClose = new System.Windows.Forms.CheckBox();
            this.cbPortable = new System.Windows.Forms.CheckBox();
            this.gbProxy = new System.Windows.Forms.GroupBox();
            this.rbProxyNone = new System.Windows.Forms.RadioButton();
            this.rbProxyIE = new System.Windows.Forms.RadioButton();
            this.rbProxyCustom = new System.Windows.Forms.RadioButton();
            this.txtProxyPassword = new System.Windows.Forms.TextBox();
            this.cbProxyAuthRequired = new System.Windows.Forms.CheckBox();
            this.txtProxyPort = new System.Windows.Forms.TextBox();
            this.txtProxyUser = new System.Windows.Forms.TextBox();
            this.txtProxyServer = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btLogLocation = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbLoggingLevel = new System.Windows.Forms.ComboBox();
            this.cbShowBubbleTooltips = new System.Windows.Forms.CheckBox();
            this.cbMinimiseToTray = new System.Windows.Forms.CheckBox();
            this.cbStartInTray = new System.Windows.Forms.CheckBox();
            this.cbCreateFiles = new System.Windows.Forms.CheckBox();
            this.cbStartOnStartup = new System.Windows.Forms.CheckBox();
            this.bSave = new System.Windows.Forms.Button();
            this.tabPage_Help = new System.Windows.Forms.TabPage();
            this.tbTS2 = new System.Windows.Forms.TextBox();
            this.linkTShoot_logfile = new System.Windows.Forms.LinkLabel();
            this.tbTS4 = new System.Windows.Forms.TextBox();
            this.linkTShoot_issue = new System.Windows.Forms.LinkLabel();
            this.linkTShoot_loglevel = new System.Windows.Forms.LinkLabel();
            this.label27 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label24 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tbTS3 = new System.Windows.Forms.TextBox();
            this.tbTS1 = new System.Windows.Forms.TextBox();
            this.tbTS0 = new System.Windows.Forms.TextBox();
            this.tabPage_About = new System.Windows.Forms.TabPage();
            this.lDonateTip = new System.Windows.Forms.Label();
            this.dgAbout = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbAlphaReleases = new System.Windows.Forms.CheckBox();
            this.btCheckForUpdate = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.lAboutURL = new System.Windows.Forms.LinkLabel();
            this.lAboutMain = new System.Windows.Forms.Label();
            this.pbDonate = new System.Windows.Forms.PictureBox();
            this.GappBrowser = new System.Windows.Forms.WebBrowser();
            this.tabPage_Social = new System.Windows.Forms.TabPage();
            this.pbSocialDonate = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lMilestoneBlurb = new System.Windows.Forms.Label();
            this.btSocialTweet = new System.Windows.Forms.Button();
            this.lMilestone = new System.Windows.Forms.Label();
            this.btSocialGplus = new System.Windows.Forms.Button();
            this.btSocialFB = new System.Windows.Forms.Button();
            this.btSocialLinkedin = new System.Windows.Forms.Button();
            this.btSocialRSSfeed = new System.Windows.Forms.Button();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.pbSocialGplusCommunity = new System.Windows.Forms.PictureBox();
            this.pbSocialTwitterFollow = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.cbCloudLogging = new System.Windows.Forms.CheckBox();
            this.tbConnectedAcc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ddCategoryColour = new OutlookGoogleCalendarSync.Extensions.ColourPicker();
            this.cbLocation = new System.Windows.Forms.CheckBox();
            this.tabApp.SuspendLayout();
            this.tabPage_Sync.SuspendLayout();
            this.consolePanel.SuspendLayout();
            this.tabPage_Settings.SuspendLayout();
            this.tabAppSettings.SuspendLayout();
            this.tabOutlook.SuspendLayout();
            this.msCategories.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabGoogle.SuspendLayout();
            this.gbDeveloperOptions.SuspendLayout();
            this.tabSyncOptions.SuspendLayout();
            this.WhatPostit.SuspendLayout();
            this.panelSyncOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExpandHow)).BeginInit();
            this.gbSyncOptions_How.SuspendLayout();
            this.howMorePanel.SuspendLayout();
            this.howObfuscatePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgObfuscateRegex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExpandWhat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExpandWhen)).BeginInit();
            this.gbSyncOptions_When.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDaysInTheFuture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDaysInThePast)).BeginInit();
            this.gbSyncOptions_What.SuspendLayout();
            this.tabAppBehaviour.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbStartupDelay)).BeginInit();
            this.gbProxy.SuspendLayout();
            this.tabPage_Help.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage_About.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAbout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDonate)).BeginInit();
            this.tabPage_Social.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSocialDonate)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSocialGplusCommunity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSocialTwitterFollow)).BeginInit();
            this.SuspendLayout();
            // 
            // tabApp
            // 
            this.tabApp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabApp.Controls.Add(this.tabPage_Sync);
            this.tabApp.Controls.Add(this.tabPage_Settings);
            this.tabApp.Controls.Add(this.tabPage_Help);
            this.tabApp.Controls.Add(this.tabPage_About);
            this.tabApp.Controls.Add(this.tabPage_Social);
            this.tabApp.Location = new System.Drawing.Point(12, 12);
            this.tabApp.Multiline = true;
            this.tabApp.Name = "tabApp";
            this.tabApp.SelectedIndex = 0;
            this.tabApp.Size = new System.Drawing.Size(495, 568);
            this.tabApp.TabIndex = 0;
            this.tabApp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tabApp_KeyDown);
            this.tabApp.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tabApp_KeyUp);
            // 
            // tabPage_Sync
            // 
            this.tabPage_Sync.BackColor = System.Drawing.Color.White;
            this.tabPage_Sync.Controls.Add(this.cbMuteClicks);
            this.tabPage_Sync.Controls.Add(this.consolePanel);
            this.tabPage_Sync.Controls.Add(this.tbSyncNote);
            this.tabPage_Sync.Controls.Add(this.panelSyncNote);
            this.tabPage_Sync.Controls.Add(this.cbVerboseOutput);
            this.tabPage_Sync.Controls.Add(this.lNextSyncVal);
            this.tabPage_Sync.Controls.Add(this.lLastSyncVal);
            this.tabPage_Sync.Controls.Add(this.lNextSync);
            this.tabPage_Sync.Controls.Add(this.lLastSync);
            this.tabPage_Sync.Controls.Add(this.bSyncNow);
            this.tabPage_Sync.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Sync.Name = "tabPage_Sync";
            this.tabPage_Sync.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Sync.Size = new System.Drawing.Size(487, 542);
            this.tabPage_Sync.TabIndex = 0;
            this.tabPage_Sync.Text = "Sync";
            // 
            // cbMuteClicks
            // 
            this.cbMuteClicks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMuteClicks.AutoSize = true;
            this.cbMuteClicks.Location = new System.Drawing.Point(383, 500);
            this.cbMuteClicks.Name = "cbMuteClicks";
            this.cbMuteClicks.Size = new System.Drawing.Size(80, 17);
            this.cbMuteClicks.TabIndex = 39;
            this.cbMuteClicks.Text = "Mute clicks";
            this.cbMuteClicks.UseVisualStyleBackColor = true;
            this.cbMuteClicks.CheckedChanged += new System.EventHandler(this.cbMuteClicks_CheckedChanged);
            // 
            // consolePanel
            // 
            this.consolePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.consolePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.consolePanel.Controls.Add(this.consoleWebBrowser);
            this.consolePanel.Location = new System.Drawing.Point(3, 57);
            this.consolePanel.Name = "consolePanel";
            this.consolePanel.Size = new System.Drawing.Size(478, 421);
            this.consolePanel.TabIndex = 38;
            // 
            // consoleWebBrowser
            // 
            this.consoleWebBrowser.AllowWebBrowserDrop = false;
            this.consoleWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consoleWebBrowser.IsWebBrowserContextMenuEnabled = false;
            this.consoleWebBrowser.Location = new System.Drawing.Point(0, 0);
            this.consoleWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.consoleWebBrowser.Name = "consoleWebBrowser";
            this.consoleWebBrowser.ScriptErrorsSuppressed = true;
            this.consoleWebBrowser.Size = new System.Drawing.Size(474, 417);
            this.consoleWebBrowser.TabIndex = 38;
            this.consoleWebBrowser.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Console_KeyDown);
            // 
            // tbSyncNote
            // 
            this.tbSyncNote.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbSyncNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tbSyncNote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSyncNote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbSyncNote.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSyncNote.Location = new System.Drawing.Point(112, 486);
            this.tbSyncNote.Name = "tbSyncNote";
            this.tbSyncNote.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.tbSyncNote.Size = new System.Drawing.Size(262, 52);
            this.tbSyncNote.TabIndex = 1;
            this.tbSyncNote.Text = "";
            this.tbSyncNote.Visible = false;
            this.tbSyncNote.Click += new System.EventHandler(this.tbSyncNote_Click);
            // 
            // panelSyncNote
            // 
            this.panelSyncNote.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panelSyncNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panelSyncNote.Location = new System.Drawing.Point(107, 481);
            this.panelSyncNote.Name = "panelSyncNote";
            this.panelSyncNote.Size = new System.Drawing.Size(270, 58);
            this.panelSyncNote.TabIndex = 35;
            this.panelSyncNote.Visible = false;
            // 
            // cbVerboseOutput
            // 
            this.cbVerboseOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbVerboseOutput.AutoSize = true;
            this.cbVerboseOutput.Location = new System.Drawing.Point(383, 484);
            this.cbVerboseOutput.Name = "cbVerboseOutput";
            this.cbVerboseOutput.Size = new System.Drawing.Size(98, 17);
            this.cbVerboseOutput.TabIndex = 5;
            this.cbVerboseOutput.Text = "Verbose output";
            this.cbVerboseOutput.UseVisualStyleBackColor = true;
            this.cbVerboseOutput.CheckedChanged += new System.EventHandler(this.cbVerboseOutput_CheckedChanged);
            // 
            // lNextSyncVal
            // 
            this.lNextSyncVal.Location = new System.Drawing.Point(271, 28);
            this.lNextSyncVal.Name = "lNextSyncVal";
            this.lNextSyncVal.Size = new System.Drawing.Size(216, 26);
            this.lNextSyncVal.TabIndex = 4;
            this.lNextSyncVal.Text = "Unknown";
            // 
            // lLastSyncVal
            // 
            this.lLastSyncVal.Location = new System.Drawing.Point(22, 28);
            this.lLastSyncVal.Name = "lLastSyncVal";
            this.lLastSyncVal.Size = new System.Drawing.Size(224, 26);
            this.lLastSyncVal.TabIndex = 3;
            this.lLastSyncVal.Text = "N/A";
            // 
            // lNextSync
            // 
            this.lNextSync.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNextSync.Location = new System.Drawing.Point(252, 14);
            this.lNextSync.Name = "lNextSync";
            this.lNextSync.Size = new System.Drawing.Size(232, 14);
            this.lNextSync.TabIndex = 2;
            this.lNextSync.Text = "Next scheduled:-";
            // 
            // lLastSync
            // 
            this.lLastSync.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLastSync.Location = new System.Drawing.Point(5, 14);
            this.lLastSync.Name = "lLastSync";
            this.lLastSync.Size = new System.Drawing.Size(251, 14);
            this.lLastSync.TabIndex = 2;
            this.lLastSync.Text = "Last successful:-";
            // 
            // bSyncNow
            // 
            this.bSyncNow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bSyncNow.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bSyncNow.Location = new System.Drawing.Point(3, 484);
            this.bSyncNow.Name = "bSyncNow";
            this.bSyncNow.Size = new System.Drawing.Size(98, 31);
            this.bSyncNow.TabIndex = 0;
            this.bSyncNow.Text = "Start Sync";
            this.bSyncNow.UseVisualStyleBackColor = true;
            this.bSyncNow.Click += new System.EventHandler(this.Sync_Click);
            // 
            // tabPage_Settings
            // 
            this.tabPage_Settings.BackColor = System.Drawing.Color.White;
            this.tabPage_Settings.Controls.Add(this.lSettingInfo);
            this.tabPage_Settings.Controls.Add(this.tabAppSettings);
            this.tabPage_Settings.Controls.Add(this.bSave);
            this.tabPage_Settings.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Settings.Name = "tabPage_Settings";
            this.tabPage_Settings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Settings.Size = new System.Drawing.Size(487, 542);
            this.tabPage_Settings.TabIndex = 1;
            this.tabPage_Settings.Text = "Settings";
            // 
            // lSettingInfo
            // 
            this.lSettingInfo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lSettingInfo.AutoSize = true;
            this.lSettingInfo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lSettingInfo.Location = new System.Drawing.Point(131, 495);
            this.lSettingInfo.Name = "lSettingInfo";
            this.lSettingInfo.Size = new System.Drawing.Size(176, 26);
            this.lSettingInfo.TabIndex = 27;
            this.lSettingInfo.Text = "Settings will take effect immediately,\r\nbut to make them persist, hit Save.";
            this.lSettingInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabAppSettings
            // 
            this.tabAppSettings.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabAppSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabAppSettings.Controls.Add(this.tabOutlook);
            this.tabAppSettings.Controls.Add(this.tabGoogle);
            this.tabAppSettings.Controls.Add(this.tabSyncOptions);
            this.tabAppSettings.Controls.Add(this.tabAppBehaviour);
            this.tabAppSettings.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabAppSettings.ItemSize = new System.Drawing.Size(35, 75);
            this.tabAppSettings.Location = new System.Drawing.Point(6, 7);
            this.tabAppSettings.Multiline = true;
            this.tabAppSettings.Name = "tabAppSettings";
            this.tabAppSettings.SelectedIndex = 0;
            this.tabAppSettings.Size = new System.Drawing.Size(475, 470);
            this.tabAppSettings.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabAppSettings.TabIndex = 20;
            this.tabAppSettings.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabAppSettings_DrawItem);
            // 
            // tabOutlook
            // 
            this.tabOutlook.BackColor = System.Drawing.Color.White;
            this.tabOutlook.Controls.Add(this.cbOutlookCalendars);
            this.tabOutlook.Controls.Add(this.lFilterCategories);
            this.tabOutlook.Controls.Add(this.cbCategoryFilter);
            this.tabOutlook.Controls.Add(this.clbCategories);
            this.tabOutlook.Controls.Add(this.groupBox1);
            this.tabOutlook.Controls.Add(this.label11);
            this.tabOutlook.Controls.Add(this.lOutlookCalendar);
            this.tabOutlook.Controls.Add(this.rbOutlookDefaultMB);
            this.tabOutlook.Controls.Add(this.rbOutlookSharedCal);
            this.tabOutlook.Controls.Add(this.ddMailboxName);
            this.tabOutlook.Controls.Add(this.cbOnlyRespondedInvites);
            this.tabOutlook.Controls.Add(this.rbOutlookAltMB);
            this.tabOutlook.Location = new System.Drawing.Point(79, 4);
            this.tabOutlook.Name = "tabOutlook";
            this.tabOutlook.Padding = new System.Windows.Forms.Padding(3);
            this.tabOutlook.Size = new System.Drawing.Size(392, 462);
            this.tabOutlook.TabIndex = 0;
            this.tabOutlook.Text = "  Outlook";
            // 
            // cbOutlookCalendars
            // 
            this.cbOutlookCalendars.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbOutlookCalendars.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOutlookCalendars.FormattingEnabled = true;
            this.cbOutlookCalendars.Location = new System.Drawing.Point(96, 118);
            this.cbOutlookCalendars.Name = "cbOutlookCalendars";
            this.cbOutlookCalendars.Size = new System.Drawing.Size(288, 21);
            this.cbOutlookCalendars.TabIndex = 24;
            this.cbOutlookCalendars.SelectedIndexChanged += new System.EventHandler(this.cbOutlookCalendar_SelectedIndexChanged);
            // 
            // lFilterCategories
            // 
            this.lFilterCategories.AutoSize = true;
            this.lFilterCategories.Location = new System.Drawing.Point(11, 151);
            this.lFilterCategories.Name = "lFilterCategories";
            this.lFilterCategories.Size = new System.Drawing.Size(81, 13);
            this.lFilterCategories.TabIndex = 44;
            this.lFilterCategories.Text = "Filter categories";
            // 
            // cbCategoryFilter
            // 
            this.cbCategoryFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoryFilter.FormattingEnabled = true;
            this.cbCategoryFilter.Items.AddRange(new object[] {
            "Exclude",
            "Include"});
            this.cbCategoryFilter.Location = new System.Drawing.Point(96, 148);
            this.cbCategoryFilter.Name = "cbCategoryFilter";
            this.cbCategoryFilter.Size = new System.Drawing.Size(105, 21);
            this.cbCategoryFilter.TabIndex = 43;
            this.cbCategoryFilter.SelectedIndexChanged += new System.EventHandler(this.cbCategoryFilter_SelectedIndexChanged);
            // 
            // clbCategories
            // 
            this.clbCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clbCategories.CheckOnClick = true;
            this.clbCategories.ContextMenuStrip = this.msCategories;
            this.clbCategories.FormattingEnabled = true;
            this.clbCategories.Items.AddRange(new object[] {
            "Category1",
            "Category2",
            "Category3",
            "Category4"});
            this.clbCategories.Location = new System.Drawing.Point(207, 148);
            this.clbCategories.Name = "clbCategories";
            this.clbCategories.Size = new System.Drawing.Size(177, 139);
            this.clbCategories.Sorted = true;
            this.clbCategories.TabIndex = 42;
            this.clbCategories.SelectedIndexChanged += new System.EventHandler(this.clbCategories_SelectedIndexChanged);
            // 
            // msCategories
            // 
            this.msCategories.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miCatSelectAll,
            this.miCatSelectNone,
            this.miCatRefresh});
            this.msCategories.Name = "msCategories";
            this.msCategories.ShowImageMargin = false;
            this.msCategories.ShowItemToolTips = false;
            this.msCategories.Size = new System.Drawing.Size(148, 70);
            // 
            // miCatSelectAll
            // 
            this.miCatSelectAll.Name = "miCatSelectAll";
            this.miCatSelectAll.Size = new System.Drawing.Size(147, 22);
            this.miCatSelectAll.Text = "Select All";
            this.miCatSelectAll.Click += new System.EventHandler(this.miCatSelectAll_Click);
            // 
            // miCatSelectNone
            // 
            this.miCatSelectNone.Name = "miCatSelectNone";
            this.miCatSelectNone.Size = new System.Drawing.Size(147, 22);
            this.miCatSelectNone.Text = "Select None";
            this.miCatSelectNone.Click += new System.EventHandler(this.miCatSelectNone_Click);
            // 
            // miCatRefresh
            // 
            this.miCatRefresh.Name = "miCatRefresh";
            this.miCatRefresh.Size = new System.Drawing.Size(147, 22);
            this.miCatRefresh.Text = "Refresh Categories";
            this.miCatRefresh.Click += new System.EventHandler(this.miCatRefresh_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label32);
            this.groupBox1.Controls.Add(this.urlDateFormats);
            this.groupBox1.Controls.Add(this.btTestOutlookFilter);
            this.groupBox1.Controls.Add(this.tbOutlookDateFormatResult);
            this.groupBox1.Controls.Add(this.tbOutlookDateFormat);
            this.groupBox1.Controls.Add(this.cbOutlookDateFormat);
            this.groupBox1.Controls.Add(this.txtDateFormats);
            this.groupBox1.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox1.Location = new System.Drawing.Point(6, 296);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 160);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Regional Date Format";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label32.Location = new System.Drawing.Point(10, 109);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(79, 13);
            this.label32.TabIndex = 42;
            this.label32.Text = "Current Format:";
            // 
            // urlDateFormats
            // 
            this.urlDateFormats.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.urlDateFormats.AutoSize = true;
            this.urlDateFormats.BackColor = System.Drawing.Color.Transparent;
            this.urlDateFormats.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlDateFormats.Location = new System.Drawing.Point(45, 51);
            this.urlDateFormats.Margin = new System.Windows.Forms.Padding(0);
            this.urlDateFormats.Name = "urlDateFormats";
            this.urlDateFormats.Size = new System.Drawing.Size(82, 13);
            this.urlDateFormats.TabIndex = 41;
            this.urlDateFormats.TabStop = true;
            this.urlDateFormats.Text = "different formats";
            this.urlDateFormats.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.urlDateFormats.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.urlDateFormats_LinkClicked);
            // 
            // btTestOutlookFilter
            // 
            this.btTestOutlookFilter.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btTestOutlookFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTestOutlookFilter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btTestOutlookFilter.Location = new System.Drawing.Point(284, 128);
            this.btTestOutlookFilter.Name = "btTestOutlookFilter";
            this.btTestOutlookFilter.Size = new System.Drawing.Size(75, 23);
            this.btTestOutlookFilter.TabIndex = 40;
            this.btTestOutlookFilter.Text = "Test";
            this.btTestOutlookFilter.UseVisualStyleBackColor = true;
            this.btTestOutlookFilter.Click += new System.EventHandler(this.btTestOutlookFilter_Click);
            // 
            // tbOutlookDateFormatResult
            // 
            this.tbOutlookDateFormatResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOutlookDateFormatResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbOutlookDateFormatResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOutlookDateFormatResult.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tbOutlookDateFormatResult.Location = new System.Drawing.Point(90, 109);
            this.tbOutlookDateFormatResult.Name = "tbOutlookDateFormatResult";
            this.tbOutlookDateFormatResult.Size = new System.Drawing.Size(278, 13);
            this.tbOutlookDateFormatResult.TabIndex = 39;
            this.tbOutlookDateFormatResult.Text = "The date format result";
            // 
            // tbOutlookDateFormat
            // 
            this.tbOutlookDateFormat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOutlookDateFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOutlookDateFormat.Location = new System.Drawing.Point(155, 79);
            this.tbOutlookDateFormat.Name = "tbOutlookDateFormat";
            this.tbOutlookDateFormat.ReadOnly = true;
            this.tbOutlookDateFormat.Size = new System.Drawing.Size(213, 20);
            this.tbOutlookDateFormat.TabIndex = 38;
            this.tbOutlookDateFormat.TextChanged += new System.EventHandler(this.tbOutlookDateFormat_TextChanged);
            this.tbOutlookDateFormat.Leave += new System.EventHandler(this.tbOutlookDateFormat_Leave);
            // 
            // cbOutlookDateFormat
            // 
            this.cbOutlookDateFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOutlookDateFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOutlookDateFormat.FormattingEnabled = true;
            this.cbOutlookDateFormat.Location = new System.Drawing.Point(8, 79);
            this.cbOutlookDateFormat.Name = "cbOutlookDateFormat";
            this.cbOutlookDateFormat.Size = new System.Drawing.Size(140, 21);
            this.cbOutlookDateFormat.TabIndex = 37;
            this.cbOutlookDateFormat.SelectedIndexChanged += new System.EventHandler(this.cbOutlookDateFormat_SelectedIndexChanged);
            // 
            // txtDateFormats
            // 
            this.txtDateFormats.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDateFormats.BackColor = System.Drawing.SystemColors.Window;
            this.txtDateFormats.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDateFormats.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateFormats.Location = new System.Drawing.Point(6, 25);
            this.txtDateFormats.Multiline = true;
            this.txtDateFormats.Name = "txtDateFormats";
            this.txtDateFormats.Size = new System.Drawing.Size(362, 45);
            this.txtDateFormats.TabIndex = 36;
            this.txtDateFormats.Text = "Hopefully you will not need to adjust this.\r\nHowever, Microsoft\'s support of \"non" +
    "-standard\" locales is poor.\r\nTry different formats  if no Outlook appointments a" +
    "re being returned.";
            this.txtDateFormats.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label11.Location = new System.Drawing.Point(67, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(268, 15);
            this.label11.TabIndex = 26;
            this.label11.Text = "Select the Outlook Calendar to Synchronise";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lOutlookCalendar
            // 
            this.lOutlookCalendar.AutoSize = true;
            this.lOutlookCalendar.Location = new System.Drawing.Point(11, 121);
            this.lOutlookCalendar.Name = "lOutlookCalendar";
            this.lOutlookCalendar.Size = new System.Drawing.Size(81, 13);
            this.lOutlookCalendar.TabIndex = 25;
            this.lOutlookCalendar.Text = "Select calendar";
            // 
            // rbOutlookDefaultMB
            // 
            this.rbOutlookDefaultMB.AutoSize = true;
            this.rbOutlookDefaultMB.Checked = true;
            this.rbOutlookDefaultMB.Location = new System.Drawing.Point(14, 46);
            this.rbOutlookDefaultMB.Name = "rbOutlookDefaultMB";
            this.rbOutlookDefaultMB.Size = new System.Drawing.Size(97, 17);
            this.rbOutlookDefaultMB.TabIndex = 18;
            this.rbOutlookDefaultMB.TabStop = true;
            this.rbOutlookDefaultMB.Text = "Default mailbox";
            this.rbOutlookDefaultMB.UseVisualStyleBackColor = true;
            this.rbOutlookDefaultMB.CheckedChanged += new System.EventHandler(this.rbOutlookDefaultMB_CheckedChanged);
            // 
            // rbOutlookSharedCal
            // 
            this.rbOutlookSharedCal.AutoSize = true;
            this.rbOutlookSharedCal.Location = new System.Drawing.Point(14, 93);
            this.rbOutlookSharedCal.Name = "rbOutlookSharedCal";
            this.rbOutlookSharedCal.Size = new System.Drawing.Size(104, 17);
            this.rbOutlookSharedCal.TabIndex = 19;
            this.rbOutlookSharedCal.Text = "Shared Calendar";
            this.rbOutlookSharedCal.UseVisualStyleBackColor = true;
            this.rbOutlookSharedCal.CheckedChanged += new System.EventHandler(this.rbOutlookSharedCal_CheckedChanged);
            // 
            // ddMailboxName
            // 
            this.ddMailboxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ddMailboxName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddMailboxName.FormattingEnabled = true;
            this.ddMailboxName.Location = new System.Drawing.Point(126, 68);
            this.ddMailboxName.Name = "ddMailboxName";
            this.ddMailboxName.Size = new System.Drawing.Size(258, 21);
            this.ddMailboxName.Sorted = true;
            this.ddMailboxName.TabIndex = 16;
            this.ddMailboxName.SelectedIndexChanged += new System.EventHandler(this.ddMailboxName_SelectedIndexChanged);
            // 
            // cbOnlyRespondedInvites
            // 
            this.cbOnlyRespondedInvites.AutoSize = true;
            this.cbOnlyRespondedInvites.Location = new System.Drawing.Point(14, 184);
            this.cbOnlyRespondedInvites.Name = "cbOnlyRespondedInvites";
            this.cbOnlyRespondedInvites.Size = new System.Drawing.Size(190, 17);
            this.cbOnlyRespondedInvites.TabIndex = 45;
            this.cbOnlyRespondedInvites.Text = "Only sync invites I\'ve responded to";
            this.cbOnlyRespondedInvites.UseVisualStyleBackColor = true;
            this.cbOnlyRespondedInvites.CheckedChanged += new System.EventHandler(this.cbOnlyRespondedInvites_CheckedChanged);
            // 
            // rbOutlookAltMB
            // 
            this.rbOutlookAltMB.AutoSize = true;
            this.rbOutlookAltMB.Location = new System.Drawing.Point(14, 69);
            this.rbOutlookAltMB.Name = "rbOutlookAltMB";
            this.rbOutlookAltMB.Size = new System.Drawing.Size(113, 17);
            this.rbOutlookAltMB.TabIndex = 17;
            this.rbOutlookAltMB.Text = "Alternative mailbox";
            this.rbOutlookAltMB.UseVisualStyleBackColor = true;
            this.rbOutlookAltMB.CheckedChanged += new System.EventHandler(this.rbOutlookAltMB_CheckedChanged);
            // 
            // tabGoogle
            // 
            this.tabGoogle.BackColor = System.Drawing.Color.White;
            this.tabGoogle.Controls.Add(this.label7);
            this.tabGoogle.Controls.Add(this.tbConnectedAcc);
            this.tabGoogle.Controls.Add(this.gbDeveloperOptions);
            this.tabGoogle.Controls.Add(this.cbShowDeveloperOptions);
            this.tabGoogle.Controls.Add(this.label13);
            this.tabGoogle.Controls.Add(this.label12);
            this.tabGoogle.Controls.Add(this.btResetGCal);
            this.tabGoogle.Controls.Add(this.lGoogleHelp);
            this.tabGoogle.Controls.Add(this.lGoogleCalendar);
            this.tabGoogle.Controls.Add(this.bGetGoogleCalendars);
            this.tabGoogle.Controls.Add(this.cbGoogleCalendars);
            this.tabGoogle.Location = new System.Drawing.Point(79, 4);
            this.tabGoogle.Name = "tabGoogle";
            this.tabGoogle.Padding = new System.Windows.Forms.Padding(3);
            this.tabGoogle.Size = new System.Drawing.Size(392, 462);
            this.tabGoogle.TabIndex = 1;
            this.tabGoogle.Text = "  Google";
            // 
            // gbDeveloperOptions
            // 
            this.gbDeveloperOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDeveloperOptions.Controls.Add(this.llAPIConsole);
            this.gbDeveloperOptions.Controls.Add(this.cbShowClientSecret);
            this.gbDeveloperOptions.Controls.Add(this.lGoogleAPIInstructions);
            this.gbDeveloperOptions.Controls.Add(this.tbClientSecret);
            this.gbDeveloperOptions.Controls.Add(this.tbClientID);
            this.gbDeveloperOptions.Controls.Add(this.lClientID);
            this.gbDeveloperOptions.Controls.Add(this.lSecret);
            this.gbDeveloperOptions.Location = new System.Drawing.Point(14, 227);
            this.gbDeveloperOptions.Name = "gbDeveloperOptions";
            this.gbDeveloperOptions.Size = new System.Drawing.Size(364, 171);
            this.gbDeveloperOptions.TabIndex = 31;
            this.gbDeveloperOptions.TabStop = false;
            this.gbDeveloperOptions.Text = "Google OAuth API";
            this.gbDeveloperOptions.Visible = false;
            // 
            // llAPIConsole
            // 
            this.llAPIConsole.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.llAPIConsole.AutoSize = true;
            this.llAPIConsole.Location = new System.Drawing.Point(44, 89);
            this.llAPIConsole.Name = "llAPIConsole";
            this.llAPIConsole.Size = new System.Drawing.Size(273, 13);
            this.llAPIConsole.TabIndex = 5;
            this.llAPIConsole.TabStop = true;
            this.llAPIConsole.Text = "https://console.developers.google.com/apis/credentials";
            this.llAPIConsole.Visible = false;
            this.llAPIConsole.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llAPIConsole_LinkClicked);
            // 
            // cbShowClientSecret
            // 
            this.cbShowClientSecret.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbShowClientSecret.AutoSize = true;
            this.cbShowClientSecret.Enabled = false;
            this.cbShowClientSecret.Location = new System.Drawing.Point(299, 143);
            this.cbShowClientSecret.Name = "cbShowClientSecret";
            this.cbShowClientSecret.Size = new System.Drawing.Size(53, 17);
            this.cbShowClientSecret.TabIndex = 29;
            this.cbShowClientSecret.Text = "Show";
            this.cbShowClientSecret.UseVisualStyleBackColor = true;
            this.cbShowClientSecret.Visible = false;
            this.cbShowClientSecret.CheckedChanged += new System.EventHandler(this.cbShowClientSecret_CheckedChanged);
            // 
            // lGoogleAPIInstructions
            // 
            this.lGoogleAPIInstructions.BackColor = System.Drawing.SystemColors.Window;
            this.lGoogleAPIInstructions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lGoogleAPIInstructions.Location = new System.Drawing.Point(13, 20);
            this.lGoogleAPIInstructions.Multiline = true;
            this.lGoogleAPIInstructions.Name = "lGoogleAPIInstructions";
            this.lGoogleAPIInstructions.ReadOnly = true;
            this.lGoogleAPIInstructions.Size = new System.Drawing.Size(339, 71);
            this.lGoogleAPIInstructions.TabIndex = 4;
            this.lGoogleAPIInstructions.Text = resources.GetString("lGoogleAPIInstructions.Text");
            this.lGoogleAPIInstructions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lGoogleAPIInstructions.Visible = false;
            // 
            // tbClientSecret
            // 
            this.tbClientSecret.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbClientSecret.Location = new System.Drawing.Point(63, 140);
            this.tbClientSecret.Name = "tbClientSecret";
            this.tbClientSecret.ReadOnly = true;
            this.tbClientSecret.Size = new System.Drawing.Size(230, 20);
            this.tbClientSecret.TabIndex = 3;
            this.tbClientSecret.UseSystemPasswordChar = true;
            this.tbClientSecret.Visible = false;
            this.tbClientSecret.TextChanged += new System.EventHandler(this.tbClientSecret_TextChanged);
            // 
            // tbClientID
            // 
            this.tbClientID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbClientID.Location = new System.Drawing.Point(63, 114);
            this.tbClientID.Name = "tbClientID";
            this.tbClientID.ReadOnly = true;
            this.tbClientID.Size = new System.Drawing.Size(289, 20);
            this.tbClientID.TabIndex = 2;
            this.tbClientID.Visible = false;
            this.tbClientID.TextChanged += new System.EventHandler(this.tbClientID_TextChanged);
            // 
            // lClientID
            // 
            this.lClientID.AutoSize = true;
            this.lClientID.Location = new System.Drawing.Point(10, 117);
            this.lClientID.Name = "lClientID";
            this.lClientID.Size = new System.Drawing.Size(47, 13);
            this.lClientID.TabIndex = 0;
            this.lClientID.Text = "Client ID";
            this.lClientID.Visible = false;
            // 
            // lSecret
            // 
            this.lSecret.AutoSize = true;
            this.lSecret.Location = new System.Drawing.Point(10, 143);
            this.lSecret.Name = "lSecret";
            this.lSecret.Size = new System.Drawing.Size(38, 13);
            this.lSecret.TabIndex = 1;
            this.lSecret.Text = "Secret";
            this.lSecret.Visible = false;
            // 
            // cbShowDeveloperOptions
            // 
            this.cbShowDeveloperOptions.AutoSize = true;
            this.cbShowDeveloperOptions.Location = new System.Drawing.Point(14, 204);
            this.cbShowDeveloperOptions.Name = "cbShowDeveloperOptions";
            this.cbShowDeveloperOptions.Size = new System.Drawing.Size(193, 17);
            this.cbShowDeveloperOptions.TabIndex = 30;
            this.cbShowDeveloperOptions.Text = "Show advanced/developer options";
            this.cbShowDeveloperOptions.UseVisualStyleBackColor = true;
            this.cbShowDeveloperOptions.CheckedChanged += new System.EventHandler(this.cbShowDeveloperOptions_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(153, 134);
            this.label13.MaximumSize = new System.Drawing.Size(200, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(189, 26);
            this.label13.TabIndex = 28;
            this.label13.Text = "Disconnect the Google account the application is using to synchronise with\r\n";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label12.Location = new System.Drawing.Point(68, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(263, 15);
            this.label12.TabIndex = 27;
            this.label12.Text = "Select the Google Calendar to Synchronise";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btResetGCal
            // 
            this.btResetGCal.BackColor = System.Drawing.Color.Transparent;
            this.btResetGCal.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btResetGCal.ForeColor = System.Drawing.Color.Red;
            this.btResetGCal.Location = new System.Drawing.Point(34, 136);
            this.btResetGCal.Name = "btResetGCal";
            this.btResetGCal.Size = new System.Drawing.Size(115, 23);
            this.btResetGCal.TabIndex = 10;
            this.btResetGCal.Text = "Disconnect Account";
            this.btResetGCal.UseVisualStyleBackColor = false;
            this.btResetGCal.Click += new System.EventHandler(this.btResetGCal_Click);
            // 
            // lGoogleHelp
            // 
            this.lGoogleHelp.Location = new System.Drawing.Point(155, 75);
            this.lGoogleHelp.MaximumSize = new System.Drawing.Size(220, 52);
            this.lGoogleHelp.Name = "lGoogleHelp";
            this.lGoogleHelp.Size = new System.Drawing.Size(199, 52);
            this.lGoogleHelp.TabIndex = 9;
            this.lGoogleHelp.Text = "If this is the first time, you\'ll need to authorise the app to connect.\r\nJust tak" +
    "es a few clicks and your password is never exposed.";
            // 
            // lGoogleCalendar
            // 
            this.lGoogleCalendar.Location = new System.Drawing.Point(11, 173);
            this.lGoogleCalendar.Name = "lGoogleCalendar";
            this.lGoogleCalendar.Size = new System.Drawing.Size(81, 14);
            this.lGoogleCalendar.TabIndex = 8;
            this.lGoogleCalendar.Text = "Select calendar";
            // 
            // bGetGoogleCalendars
            // 
            this.bGetGoogleCalendars.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bGetGoogleCalendars.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bGetGoogleCalendars.Location = new System.Drawing.Point(34, 89);
            this.bGetGoogleCalendars.Name = "bGetGoogleCalendars";
            this.bGetGoogleCalendars.Size = new System.Drawing.Size(115, 23);
            this.bGetGoogleCalendars.TabIndex = 7;
            this.bGetGoogleCalendars.Text = "Retrieve Calendars";
            this.bGetGoogleCalendars.UseVisualStyleBackColor = true;
            this.bGetGoogleCalendars.Click += new System.EventHandler(this.GetMyGoogleCalendars_Click);
            // 
            // cbGoogleCalendars
            // 
            this.cbGoogleCalendars.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbGoogleCalendars.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGoogleCalendars.FormattingEnabled = true;
            this.cbGoogleCalendars.Location = new System.Drawing.Point(97, 170);
            this.cbGoogleCalendars.Name = "cbGoogleCalendars";
            this.cbGoogleCalendars.Size = new System.Drawing.Size(281, 21);
            this.cbGoogleCalendars.TabIndex = 6;
            this.cbGoogleCalendars.SelectedIndexChanged += new System.EventHandler(this.cbGoogleCalendars_SelectedIndexChanged);
            // 
            // tabSyncOptions
            // 
            this.tabSyncOptions.BackColor = System.Drawing.Color.White;
            this.tabSyncOptions.Controls.Add(this.WhatPostit);
            this.tabSyncOptions.Controls.Add(this.label15);
            this.tabSyncOptions.Controls.Add(this.panelSyncOptions);
            this.tabSyncOptions.Location = new System.Drawing.Point(79, 4);
            this.tabSyncOptions.Name = "tabSyncOptions";
            this.tabSyncOptions.Size = new System.Drawing.Size(392, 462);
            this.tabSyncOptions.TabIndex = 2;
            this.tabSyncOptions.Text = "  Sync Options";
            // 
            // WhatPostit
            // 
            this.WhatPostit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.WhatPostit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.WhatPostit.Controls.Add(this.tbWhatHelp);
            this.WhatPostit.Location = new System.Drawing.Point(89, 388);
            this.WhatPostit.Name = "WhatPostit";
            this.WhatPostit.Size = new System.Drawing.Size(211, 68);
            this.WhatPostit.TabIndex = 34;
            // 
            // tbWhatHelp
            // 
            this.tbWhatHelp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbWhatHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tbWhatHelp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbWhatHelp.Cursor = System.Windows.Forms.Cursors.Help;
            this.tbWhatHelp.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbWhatHelp.Location = new System.Drawing.Point(12, 4);
            this.tbWhatHelp.Name = "tbWhatHelp";
            this.tbWhatHelp.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.tbWhatHelp.Size = new System.Drawing.Size(193, 64);
            this.tbWhatHelp.TabIndex = 1;
            this.tbWhatHelp.Text = "Google event descriptions don\'t support rich text (RTF) and truncate at 8Kb. So m" +
    "ake sure you REALLY want to 2-way sync descriptions!";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label15.Location = new System.Drawing.Point(121, 13);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(153, 15);
            this.label15.TabIndex = 35;
            this.label15.Text = "Synchronisation Options";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelSyncOptions
            // 
            this.panelSyncOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSyncOptions.AutoScroll = true;
            this.panelSyncOptions.Controls.Add(this.pbExpandHow);
            this.panelSyncOptions.Controls.Add(this.gbSyncOptions_How);
            this.panelSyncOptions.Controls.Add(this.pbExpandWhat);
            this.panelSyncOptions.Controls.Add(this.pbExpandWhen);
            this.panelSyncOptions.Controls.Add(this.gbSyncOptions_When);
            this.panelSyncOptions.Controls.Add(this.gbSyncOptions_What);
            this.panelSyncOptions.Location = new System.Drawing.Point(4, 31);
            this.panelSyncOptions.Name = "panelSyncOptions";
            this.panelSyncOptions.Size = new System.Drawing.Size(385, 355);
            this.panelSyncOptions.TabIndex = 42;
            // 
            // pbExpandHow
            // 
            this.pbExpandHow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbExpandHow.Image = global::OutlookGoogleCalendarSync.Properties.Resources.expand;
            this.pbExpandHow.Location = new System.Drawing.Point(1, 0);
            this.pbExpandHow.Name = "pbExpandHow";
            this.pbExpandHow.Size = new System.Drawing.Size(20, 20);
            this.pbExpandHow.TabIndex = 42;
            this.pbExpandHow.TabStop = false;
            this.pbExpandHow.Click += new System.EventHandler(this.pbExpandHow_Click);
            // 
            // gbSyncOptions_How
            // 
            this.gbSyncOptions_How.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSyncOptions_How.Controls.Add(this.howMorePanel);
            this.gbSyncOptions_How.Controls.Add(this.btObfuscateRules);
            this.gbSyncOptions_How.Controls.Add(this.cbOfuscate);
            this.gbSyncOptions_How.Controls.Add(this.syncDirection);
            this.gbSyncOptions_How.Controls.Add(this.cbMergeItems);
            this.gbSyncOptions_How.Controls.Add(this.cbDisableDeletion);
            this.gbSyncOptions_How.Controls.Add(this.cbConfirmOnDelete);
            this.gbSyncOptions_How.Controls.Add(this.howObfuscatePanel);
            this.gbSyncOptions_How.Controls.Add(this.lDirection);
            this.gbSyncOptions_How.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSyncOptions_How.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.gbSyncOptions_How.Location = new System.Drawing.Point(10, 2);
            this.gbSyncOptions_How.Name = "gbSyncOptions_How";
            this.gbSyncOptions_How.Size = new System.Drawing.Size(368, 193);
            this.gbSyncOptions_How.TabIndex = 40;
            this.gbSyncOptions_How.TabStop = false;
            this.gbSyncOptions_How.Text = "  How";
            // 
            // howMorePanel
            // 
            this.howMorePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.howMorePanel.Controls.Add(this.ddCategoryColour);
            this.howMorePanel.Controls.Add(this.cbColour);
            this.howMorePanel.Controls.Add(this.tbTargetCalendar);
            this.howMorePanel.Controls.Add(this.tbCreatedItemsOnly);
            this.howMorePanel.Controls.Add(this.cbAvailable);
            this.howMorePanel.Controls.Add(this.lTargetSyncCondition);
            this.howMorePanel.Controls.Add(this.cbPrivate);
            this.howMorePanel.Controls.Add(this.label6);
            this.howMorePanel.Location = new System.Drawing.Point(5, 101);
            this.howMorePanel.Name = "howMorePanel";
            this.howMorePanel.Size = new System.Drawing.Size(353, 85);
            this.howMorePanel.TabIndex = 48;
            // 
            // cbColour
            // 
            this.cbColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbColour.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbColour.Location = new System.Drawing.Point(48, 60);
            this.cbColour.Name = "cbColour";
            this.cbColour.Size = new System.Drawing.Size(132, 17);
            this.cbColour.TabIndex = 44;
            this.cbColour.Text = "Set colour/category to";
            this.cbColour.UseVisualStyleBackColor = true;
            this.cbColour.CheckedChanged += new System.EventHandler(this.cbColour_CheckedChanged);
            // 
            // tbTargetCalendar
            // 
            this.tbTargetCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTargetCalendar.Items.Add("Google calendar");
            this.tbTargetCalendar.Items.Add("Outlook calendar");
            this.tbTargetCalendar.Items.Add("target calendar");
            this.tbTargetCalendar.Location = new System.Drawing.Point(187, 3);
            this.tbTargetCalendar.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.tbTargetCalendar.Name = "tbTargetCalendar";
            this.tbTargetCalendar.ReadOnly = true;
            this.tbTargetCalendar.Size = new System.Drawing.Size(102, 20);
            this.tbTargetCalendar.TabIndex = 36;
            this.tbTargetCalendar.Text = "target calendar";
            this.tbTargetCalendar.Wrap = true;
            this.tbTargetCalendar.SelectedItemChanged += new System.EventHandler(this.tbTargetCalendar_SelectedItemChanged);
            // 
            // tbCreatedItemsOnly
            // 
            this.tbCreatedItemsOnly.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCreatedItemsOnly.Items.Add("all items");
            this.tbCreatedItemsOnly.Items.Add("items created");
            this.tbCreatedItemsOnly.Location = new System.Drawing.Point(48, 3);
            this.tbCreatedItemsOnly.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.tbCreatedItemsOnly.Name = "tbCreatedItemsOnly";
            this.tbCreatedItemsOnly.ReadOnly = true;
            this.tbCreatedItemsOnly.Size = new System.Drawing.Size(85, 20);
            this.tbCreatedItemsOnly.TabIndex = 41;
            this.tbCreatedItemsOnly.Text = "all items";
            this.tbCreatedItemsOnly.Wrap = true;
            this.tbCreatedItemsOnly.SelectedItemChanged += new System.EventHandler(this.tbCreatedItemsOnly_SelectedItemChanged);
            // 
            // cbAvailable
            // 
            this.cbAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAvailable.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbAvailable.Location = new System.Drawing.Point(48, 42);
            this.cbAvailable.Name = "cbAvailable";
            this.cbAvailable.Size = new System.Drawing.Size(163, 17);
            this.cbAvailable.TabIndex = 40;
            this.cbAvailable.Text = "Set entries as free/available";
            this.cbAvailable.UseVisualStyleBackColor = true;
            this.cbAvailable.CheckedChanged += new System.EventHandler(this.cbAvailable_CheckedChanged);
            // 
            // lTargetSyncCondition
            // 
            this.lTargetSyncCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTargetSyncCondition.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lTargetSyncCondition.Location = new System.Drawing.Point(133, 5);
            this.lTargetSyncCondition.Name = "lTargetSyncCondition";
            this.lTargetSyncCondition.Size = new System.Drawing.Size(59, 14);
            this.lTargetSyncCondition.TabIndex = 39;
            this.lTargetSyncCondition.Text = "synced to";
            // 
            // cbPrivate
            // 
            this.cbPrivate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPrivate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbPrivate.Location = new System.Drawing.Point(48, 24);
            this.cbPrivate.Name = "cbPrivate";
            this.cbPrivate.Size = new System.Drawing.Size(139, 17);
            this.cbPrivate.TabIndex = 35;
            this.cbPrivate.Text = "Set entries as private";
            this.cbPrivate.UseVisualStyleBackColor = true;
            this.cbPrivate.CheckedChanged += new System.EventHandler(this.cbPrivate_CheckedChanged);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(26, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 14);
            this.label6.TabIndex = 42;
            this.label6.Text = "For";
            // 
            // btObfuscateRules
            // 
            this.btObfuscateRules.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btObfuscateRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btObfuscateRules.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btObfuscateRules.Location = new System.Drawing.Point(301, 46);
            this.btObfuscateRules.Name = "btObfuscateRules";
            this.btObfuscateRules.Size = new System.Drawing.Size(40, 21);
            this.btObfuscateRules.TabIndex = 40;
            this.btObfuscateRules.Text = "Rules";
            this.btObfuscateRules.UseVisualStyleBackColor = true;
            this.btObfuscateRules.Click += new System.EventHandler(this.btObfuscateRules_Click);
            // 
            // cbOfuscate
            // 
            this.cbOfuscate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOfuscate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbOfuscate.Location = new System.Drawing.Point(193, 49);
            this.cbOfuscate.Name = "cbOfuscate";
            this.cbOfuscate.Size = new System.Drawing.Size(152, 17);
            this.cbOfuscate.TabIndex = 39;
            this.cbOfuscate.Text = "Word obfuscation";
            this.cbOfuscate.UseVisualStyleBackColor = true;
            this.cbOfuscate.CheckedChanged += new System.EventHandler(this.cbOfuscate_CheckedChanged);
            // 
            // syncDirection
            // 
            this.syncDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.syncDirection.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.syncDirection.FormattingEnabled = true;
            this.syncDirection.Location = new System.Drawing.Point(53, 22);
            this.syncDirection.Name = "syncDirection";
            this.syncDirection.Size = new System.Drawing.Size(288, 21);
            this.syncDirection.TabIndex = 37;
            this.syncDirection.SelectedIndexChanged += new System.EventHandler(this.syncDirection_SelectedIndexChanged);
            // 
            // cbMergeItems
            // 
            this.cbMergeItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMergeItems.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbMergeItems.Location = new System.Drawing.Point(35, 49);
            this.cbMergeItems.Name = "cbMergeItems";
            this.cbMergeItems.Size = new System.Drawing.Size(152, 17);
            this.cbMergeItems.TabIndex = 36;
            this.cbMergeItems.Text = "Merge with existing entries";
            this.cbMergeItems.UseVisualStyleBackColor = true;
            this.cbMergeItems.CheckedChanged += new System.EventHandler(this.cbMergeItems_CheckedChanged);
            // 
            // cbDisableDeletion
            // 
            this.cbDisableDeletion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDisableDeletion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbDisableDeletion.Location = new System.Drawing.Point(35, 67);
            this.cbDisableDeletion.Name = "cbDisableDeletion";
            this.cbDisableDeletion.Size = new System.Drawing.Size(106, 17);
            this.cbDisableDeletion.TabIndex = 33;
            this.cbDisableDeletion.Text = "Disable deletions";
            this.cbDisableDeletion.UseVisualStyleBackColor = true;
            this.cbDisableDeletion.CheckedChanged += new System.EventHandler(this.cbDisableDeletion_CheckedChanged);
            // 
            // cbConfirmOnDelete
            // 
            this.cbConfirmOnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbConfirmOnDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbConfirmOnDelete.Location = new System.Drawing.Point(35, 85);
            this.cbConfirmOnDelete.Name = "cbConfirmOnDelete";
            this.cbConfirmOnDelete.Size = new System.Drawing.Size(111, 17);
            this.cbConfirmOnDelete.TabIndex = 34;
            this.cbConfirmOnDelete.Text = "Confirm deletions";
            this.cbConfirmOnDelete.UseVisualStyleBackColor = true;
            this.cbConfirmOnDelete.CheckedChanged += new System.EventHandler(this.cbConfirmOnDelete_CheckedChanged);
            // 
            // howObfuscatePanel
            // 
            this.howObfuscatePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.howObfuscatePanel.Controls.Add(this.btCloseRegexRules);
            this.howObfuscatePanel.Controls.Add(this.cbObfuscateDirection);
            this.howObfuscatePanel.Controls.Add(this.label31);
            this.howObfuscatePanel.Controls.Add(this.dgObfuscateRegex);
            this.howObfuscatePanel.Location = new System.Drawing.Point(5, 109);
            this.howObfuscatePanel.Name = "howObfuscatePanel";
            this.howObfuscatePanel.Size = new System.Drawing.Size(354, 138);
            this.howObfuscatePanel.TabIndex = 46;
            // 
            // btCloseRegexRules
            // 
            this.btCloseRegexRules.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btCloseRegexRules.BackColor = System.Drawing.Color.Red;
            this.btCloseRegexRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCloseRegexRules.ForeColor = System.Drawing.SystemColors.Window;
            this.btCloseRegexRules.Location = new System.Drawing.Point(332, 5);
            this.btCloseRegexRules.Name = "btCloseRegexRules";
            this.btCloseRegexRules.Size = new System.Drawing.Size(20, 21);
            this.btCloseRegexRules.TabIndex = 49;
            this.btCloseRegexRules.Text = "X";
            this.btCloseRegexRules.UseVisualStyleBackColor = false;
            this.btCloseRegexRules.Click += new System.EventHandler(this.btCloseRegexRules_Click);
            // 
            // cbObfuscateDirection
            // 
            this.cbObfuscateDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbObfuscateDirection.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbObfuscateDirection.FormattingEnabled = true;
            this.cbObfuscateDirection.Location = new System.Drawing.Point(88, 5);
            this.cbObfuscateDirection.Name = "cbObfuscateDirection";
            this.cbObfuscateDirection.Size = new System.Drawing.Size(226, 21);
            this.cbObfuscateDirection.TabIndex = 46;
            this.cbObfuscateDirection.SelectedIndexChanged += new System.EventHandler(this.cbObfuscateDirection_SelectedIndexChanged);
            // 
            // label31
            // 
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label31.Location = new System.Drawing.Point(1, 8);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(90, 14);
            this.label31.TabIndex = 47;
            this.label31.Text = "Obfuscate from:";
            // 
            // dgObfuscateRegex
            // 
            this.dgObfuscateRegex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgObfuscateRegex.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgObfuscateRegex.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgObfuscateRegex.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgObfuscateRegex.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgObfuscateRegex.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.regexFind,
            this.regexReplace});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgObfuscateRegex.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgObfuscateRegex.Location = new System.Drawing.Point(2, 30);
            this.dgObfuscateRegex.Name = "dgObfuscateRegex";
            this.dgObfuscateRegex.RowHeadersWidth = 27;
            this.dgObfuscateRegex.ShowCellToolTips = false;
            this.dgObfuscateRegex.Size = new System.Drawing.Size(351, 99);
            this.dgObfuscateRegex.TabIndex = 45;
            this.dgObfuscateRegex.Leave += new System.EventHandler(this.dgObfuscateRegex_Leave);
            // 
            // regexFind
            // 
            this.regexFind.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.regexFind.HeaderText = "Find";
            this.regexFind.Name = "regexFind";
            // 
            // regexReplace
            // 
            this.regexReplace.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.regexReplace.HeaderText = "Replace";
            this.regexReplace.Name = "regexReplace";
            // 
            // lDirection
            // 
            this.lDirection.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDirection.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lDirection.Location = new System.Drawing.Point(1, 25);
            this.lDirection.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lDirection.Name = "lDirection";
            this.lDirection.Size = new System.Drawing.Size(55, 14);
            this.lDirection.TabIndex = 38;
            this.lDirection.Text = "Direction:";
            this.lDirection.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pbExpandWhat
            // 
            this.pbExpandWhat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbExpandWhat.Image = global::OutlookGoogleCalendarSync.Properties.Resources.expand;
            this.pbExpandWhat.Location = new System.Drawing.Point(1, 280);
            this.pbExpandWhat.Name = "pbExpandWhat";
            this.pbExpandWhat.Size = new System.Drawing.Size(20, 20);
            this.pbExpandWhat.TabIndex = 44;
            this.pbExpandWhat.TabStop = false;
            this.pbExpandWhat.Click += new System.EventHandler(this.pbExpandWhat_Click);
            // 
            // pbExpandWhen
            // 
            this.pbExpandWhen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbExpandWhen.Image = global::OutlookGoogleCalendarSync.Properties.Resources.expand;
            this.pbExpandWhen.Location = new System.Drawing.Point(1, 164);
            this.pbExpandWhen.Name = "pbExpandWhen";
            this.pbExpandWhen.Size = new System.Drawing.Size(20, 20);
            this.pbExpandWhen.TabIndex = 43;
            this.pbExpandWhen.TabStop = false;
            this.pbExpandWhen.Click += new System.EventHandler(this.pbExpandWhen_Click);
            // 
            // gbSyncOptions_When
            // 
            this.gbSyncOptions_When.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSyncOptions_When.Controls.Add(this.cbOutlookPush);
            this.gbSyncOptions_When.Controls.Add(this.cbIntervalUnit);
            this.gbSyncOptions_When.Controls.Add(this.tbInterval);
            this.gbSyncOptions_When.Controls.Add(this.label1);
            this.gbSyncOptions_When.Controls.Add(this.tbDaysInTheFuture);
            this.gbSyncOptions_When.Controls.Add(this.tbDaysInThePast);
            this.gbSyncOptions_When.Controls.Add(this.lDaysInFuture);
            this.gbSyncOptions_When.Controls.Add(this.lDaysInPast);
            this.gbSyncOptions_When.Controls.Add(this.lDateRange);
            this.gbSyncOptions_When.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSyncOptions_When.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.gbSyncOptions_When.Location = new System.Drawing.Point(10, 168);
            this.gbSyncOptions_When.Name = "gbSyncOptions_When";
            this.gbSyncOptions_When.Size = new System.Drawing.Size(368, 119);
            this.gbSyncOptions_When.TabIndex = 41;
            this.gbSyncOptions_When.TabStop = false;
            this.gbSyncOptions_When.Text = "  When";
            // 
            // cbOutlookPush
            // 
            this.cbOutlookPush.AutoSize = true;
            this.cbOutlookPush.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOutlookPush.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbOutlookPush.Location = new System.Drawing.Point(75, 95);
            this.cbOutlookPush.Name = "cbOutlookPush";
            this.cbOutlookPush.Size = new System.Drawing.Size(191, 17);
            this.cbOutlookPush.TabIndex = 42;
            this.cbOutlookPush.Text = "Push Outlook changes immediately";
            this.cbOutlookPush.UseVisualStyleBackColor = true;
            this.cbOutlookPush.CheckedChanged += new System.EventHandler(this.cbOutlookPush_CheckedChanged);
            // 
            // cbIntervalUnit
            // 
            this.cbIntervalUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIntervalUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIntervalUnit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbIntervalUnit.FormattingEnabled = true;
            this.cbIntervalUnit.Items.AddRange(new object[] {
            "Minutes",
            "Hours"});
            this.cbIntervalUnit.Location = new System.Drawing.Point(143, 69);
            this.cbIntervalUnit.Name = "cbIntervalUnit";
            this.cbIntervalUnit.Size = new System.Drawing.Size(84, 21);
            this.cbIntervalUnit.TabIndex = 41;
            this.cbIntervalUnit.SelectedIndexChanged += new System.EventHandler(this.cbIntervalUnit_SelectedIndexChanged);
            // 
            // tbInterval
            // 
            this.tbInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInterval.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbInterval.Location = new System.Drawing.Point(94, 70);
            this.tbInterval.Maximum = new decimal(new int[] {
            121,
            0,
            0,
            0});
            this.tbInterval.Name = "tbInterval";
            this.tbInterval.Size = new System.Drawing.Size(45, 20);
            this.tbInterval.TabIndex = 40;
            this.tbInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbInterval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbInterval.ValueChanged += new System.EventHandler(this.tbMinuteOffsets_ValueChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(10, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 14);
            this.label1.TabIndex = 39;
            this.label1.Text = "Schedule every:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbDaysInTheFuture
            // 
            this.tbDaysInTheFuture.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDaysInTheFuture.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbDaysInTheFuture.Location = new System.Drawing.Point(94, 46);
            this.tbDaysInTheFuture.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.tbDaysInTheFuture.Name = "tbDaysInTheFuture";
            this.tbDaysInTheFuture.Size = new System.Drawing.Size(45, 20);
            this.tbDaysInTheFuture.TabIndex = 38;
            this.tbDaysInTheFuture.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbDaysInTheFuture.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.tbDaysInTheFuture.ValueChanged += new System.EventHandler(this.tbDaysInTheFuture_ValueChanged);
            // 
            // tbDaysInThePast
            // 
            this.tbDaysInThePast.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDaysInThePast.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbDaysInThePast.Location = new System.Drawing.Point(94, 22);
            this.tbDaysInThePast.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.tbDaysInThePast.Name = "tbDaysInThePast";
            this.tbDaysInThePast.Size = new System.Drawing.Size(45, 20);
            this.tbDaysInThePast.TabIndex = 36;
            this.tbDaysInThePast.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbDaysInThePast.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbDaysInThePast.ValueChanged += new System.EventHandler(this.tbDaysInThePast_ValueChanged);
            // 
            // lDaysInFuture
            // 
            this.lDaysInFuture.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDaysInFuture.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lDaysInFuture.Location = new System.Drawing.Point(140, 48);
            this.lDaysInFuture.Name = "lDaysInFuture";
            this.lDaysInFuture.Size = new System.Drawing.Size(104, 20);
            this.lDaysInFuture.TabIndex = 34;
            this.lDaysInFuture.Text = "days in the future";
            // 
            // lDaysInPast
            // 
            this.lDaysInPast.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDaysInPast.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lDaysInPast.Location = new System.Drawing.Point(140, 24);
            this.lDaysInPast.Name = "lDaysInPast";
            this.lDaysInPast.Size = new System.Drawing.Size(87, 18);
            this.lDaysInPast.TabIndex = 35;
            this.lDaysInPast.Text = "days in the past";
            // 
            // lDateRange
            // 
            this.lDateRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDateRange.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lDateRange.Location = new System.Drawing.Point(30, 24);
            this.lDateRange.Name = "lDateRange";
            this.lDateRange.Size = new System.Drawing.Size(66, 14);
            this.lDateRange.TabIndex = 37;
            this.lDateRange.Text = "Date range:";
            this.lDateRange.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // gbSyncOptions_What
            // 
            this.gbSyncOptions_What.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSyncOptions_What.Controls.Add(this.cbCloakEmail);
            this.gbSyncOptions_What.Controls.Add(this.lDNDand);
            this.gbSyncOptions_What.Controls.Add(this.dtDNDend);
            this.gbSyncOptions_What.Controls.Add(this.dtDNDstart);
            this.gbSyncOptions_What.Controls.Add(this.cbAddDescription_OnlyToGoogle);
            this.gbSyncOptions_What.Controls.Add(this.cbAddReminders);
            this.gbSyncOptions_What.Controls.Add(this.lAttributes);
            this.gbSyncOptions_What.Controls.Add(this.cbAddAttendees);
            this.gbSyncOptions_What.Controls.Add(this.cbAddDescription);
            this.gbSyncOptions_What.Controls.Add(this.cbReminderDND);
            this.gbSyncOptions_What.Controls.Add(this.cbUseGoogleDefaultReminder);
            this.gbSyncOptions_What.Controls.Add(this.lWhatInfo);
            this.gbSyncOptions_What.Controls.Add(this.cbLocation);
            this.gbSyncOptions_What.Controls.Add(this.cbAddColours);
            this.gbSyncOptions_What.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSyncOptions_What.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.gbSyncOptions_What.Location = new System.Drawing.Point(10, 284);
            this.gbSyncOptions_What.Name = "gbSyncOptions_What";
            this.gbSyncOptions_What.Size = new System.Drawing.Size(368, 155);
            this.gbSyncOptions_What.TabIndex = 39;
            this.gbSyncOptions_What.TabStop = false;
            this.gbSyncOptions_What.Text = "  What";
            // 
            // cbAddColours
            // 
            this.cbAddColours.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAddColours.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbAddColours.Location = new System.Drawing.Point(45, 96);
            this.cbAddColours.Name = "cbAddColours";
            this.cbAddColours.Size = new System.Drawing.Size(115, 17);
            this.cbAddColours.TabIndex = 43;
            this.cbAddColours.Text = "Colours/categories";
            this.cbAddColours.UseVisualStyleBackColor = true;
            this.cbAddColours.CheckedChanged += new System.EventHandler(this.cbAddColours_CheckedChanged);
            // 
            // cbCloakEmail
            // 
            this.cbCloakEmail.Checked = true;
            this.cbCloakEmail.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCloakEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCloakEmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbCloakEmail.Location = new System.Drawing.Point(126, 78);
            this.cbCloakEmail.Name = "cbCloakEmail";
            this.cbCloakEmail.Size = new System.Drawing.Size(150, 17);
            this.cbCloakEmail.TabIndex = 41;
            this.cbCloakEmail.Text = "Cloak email in Google";
            this.cbCloakEmail.UseVisualStyleBackColor = true;
            this.cbCloakEmail.CheckedChanged += new System.EventHandler(this.cbCloakEmail_CheckedChanged);
            // 
            // lDNDand
            // 
            this.lDNDand.AutoSize = true;
            this.lDNDand.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDNDand.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lDNDand.Location = new System.Drawing.Point(266, 131);
            this.lDNDand.Name = "lDNDand";
            this.lDNDand.Size = new System.Drawing.Size(25, 13);
            this.lDNDand.TabIndex = 40;
            this.lDNDand.Text = "and";
            // 
            // dtDNDend
            // 
            this.dtDNDend.CustomFormat = "HH:mm";
            this.dtDNDend.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDNDend.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDNDend.Location = new System.Drawing.Point(291, 128);
            this.dtDNDend.Name = "dtDNDend";
            this.dtDNDend.ShowUpDown = true;
            this.dtDNDend.Size = new System.Drawing.Size(50, 20);
            this.dtDNDend.TabIndex = 39;
            this.dtDNDend.Value = new System.DateTime(2016, 5, 8, 6, 0, 0, 0);
            this.dtDNDend.ValueChanged += new System.EventHandler(this.dtDNDend_ValueChanged);
            // 
            // dtDNDstart
            // 
            this.dtDNDstart.CustomFormat = "HH:mm";
            this.dtDNDstart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDNDstart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDNDstart.Location = new System.Drawing.Point(216, 128);
            this.dtDNDstart.Name = "dtDNDstart";
            this.dtDNDstart.ShowUpDown = true;
            this.dtDNDstart.Size = new System.Drawing.Size(50, 20);
            this.dtDNDstart.TabIndex = 38;
            this.dtDNDstart.Value = new System.DateTime(2016, 5, 7, 22, 0, 0, 0);
            this.dtDNDstart.ValueChanged += new System.EventHandler(this.dtDNDstart_ValueChanged);
            // 
            // cbAddDescription_OnlyToGoogle
            // 
            this.cbAddDescription_OnlyToGoogle.Checked = true;
            this.cbAddDescription_OnlyToGoogle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAddDescription_OnlyToGoogle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAddDescription_OnlyToGoogle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbAddDescription_OnlyToGoogle.Location = new System.Drawing.Point(126, 60);
            this.cbAddDescription_OnlyToGoogle.Name = "cbAddDescription_OnlyToGoogle";
            this.cbAddDescription_OnlyToGoogle.Size = new System.Drawing.Size(150, 17);
            this.cbAddDescription_OnlyToGoogle.TabIndex = 34;
            this.cbAddDescription_OnlyToGoogle.Text = "1-way: Outlook to Google";
            this.cbAddDescription_OnlyToGoogle.UseVisualStyleBackColor = true;
            this.cbAddDescription_OnlyToGoogle.CheckedChanged += new System.EventHandler(this.cbAddDescription_OnlyToGoogle_CheckedChanged);
            // 
            // cbAddReminders
            // 
            this.cbAddReminders.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAddReminders.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbAddReminders.Location = new System.Drawing.Point(45, 114);
            this.cbAddReminders.Name = "cbAddReminders";
            this.cbAddReminders.Size = new System.Drawing.Size(80, 17);
            this.cbAddReminders.TabIndex = 32;
            this.cbAddReminders.Text = "Reminders";
            this.cbAddReminders.UseVisualStyleBackColor = true;
            this.cbAddReminders.CheckedChanged += new System.EventHandler(this.cbAddReminders_CheckedChanged);
            // 
            // lAttributes
            // 
            this.lAttributes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAttributes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lAttributes.Location = new System.Drawing.Point(6, 25);
            this.lAttributes.Name = "lAttributes";
            this.lAttributes.Size = new System.Drawing.Size(233, 14);
            this.lAttributes.TabIndex = 33;
            this.lAttributes.Text = "Attributes to include. Affects newly synced items ";
            // 
            // cbAddAttendees
            // 
            this.cbAddAttendees.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAddAttendees.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbAddAttendees.Location = new System.Drawing.Point(45, 78);
            this.cbAddAttendees.Name = "cbAddAttendees";
            this.cbAddAttendees.Size = new System.Drawing.Size(80, 17);
            this.cbAddAttendees.TabIndex = 30;
            this.cbAddAttendees.Text = "Attendees";
            this.cbAddAttendees.UseVisualStyleBackColor = true;
            this.cbAddAttendees.CheckedChanged += new System.EventHandler(this.cbAddAttendees_CheckedChanged);
            // 
            // cbAddDescription
            // 
            this.cbAddDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAddDescription.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbAddDescription.Location = new System.Drawing.Point(45, 60);
            this.cbAddDescription.Name = "cbAddDescription";
            this.cbAddDescription.Size = new System.Drawing.Size(80, 17);
            this.cbAddDescription.TabIndex = 31;
            this.cbAddDescription.Text = "Description";
            this.cbAddDescription.UseVisualStyleBackColor = true;
            this.cbAddDescription.CheckedChanged += new System.EventHandler(this.cbAddDescription_CheckedChanged);
            // 
            // cbReminderDND
            // 
            this.cbReminderDND.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbReminderDND.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbReminderDND.Location = new System.Drawing.Point(126, 130);
            this.cbReminderDND.Name = "cbReminderDND";
            this.cbReminderDND.Size = new System.Drawing.Size(215, 17);
            this.cbReminderDND.TabIndex = 36;
            this.cbReminderDND.Text = "DND between";
            this.cbReminderDND.UseVisualStyleBackColor = true;
            this.cbReminderDND.CheckedChanged += new System.EventHandler(this.cbReminderDND_CheckedChanged);
            // 
            // cbUseGoogleDefaultReminder
            // 
            this.cbUseGoogleDefaultReminder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUseGoogleDefaultReminder.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbUseGoogleDefaultReminder.Location = new System.Drawing.Point(126, 114);
            this.cbUseGoogleDefaultReminder.Name = "cbUseGoogleDefaultReminder";
            this.cbUseGoogleDefaultReminder.Size = new System.Drawing.Size(150, 17);
            this.cbUseGoogleDefaultReminder.TabIndex = 35;
            this.cbUseGoogleDefaultReminder.Text = "Use Google default";
            this.cbUseGoogleDefaultReminder.UseVisualStyleBackColor = true;
            this.cbUseGoogleDefaultReminder.CheckedChanged += new System.EventHandler(this.cbUseGoogleDefaultReminder_CheckedChanged);
            // 
            // lWhatInfo
            // 
            this.lWhatInfo.Font = new System.Drawing.Font("Webdings", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lWhatInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lWhatInfo.Location = new System.Drawing.Point(234, 21);
            this.lWhatInfo.Name = "lWhatInfo";
            this.lWhatInfo.Size = new System.Drawing.Size(23, 23);
            this.lWhatInfo.TabIndex = 42;
            this.lWhatInfo.Text = "i";
            this.lWhatInfo.MouseLeave += new System.EventHandler(this.lWhatInfo_MouseLeave);
            this.lWhatInfo.MouseHover += new System.EventHandler(this.lWhatInfo_MouseHover);
            // 
            // tabAppBehaviour
            // 
            this.tabAppBehaviour.BackColor = System.Drawing.Color.White;
            this.tabAppBehaviour.Controls.Add(this.cbCloudLogging);
            this.tabAppBehaviour.Controls.Add(this.tbStartupDelay);
            this.tabAppBehaviour.Controls.Add(this.cbHideSplash);
            this.tabAppBehaviour.Controls.Add(this.cbMinimiseNotClose);
            this.tabAppBehaviour.Controls.Add(this.cbPortable);
            this.tabAppBehaviour.Controls.Add(this.gbProxy);
            this.tabAppBehaviour.Controls.Add(this.label14);
            this.tabAppBehaviour.Controls.Add(this.btLogLocation);
            this.tabAppBehaviour.Controls.Add(this.label3);
            this.tabAppBehaviour.Controls.Add(this.cbLoggingLevel);
            this.tabAppBehaviour.Controls.Add(this.cbShowBubbleTooltips);
            this.tabAppBehaviour.Controls.Add(this.cbMinimiseToTray);
            this.tabAppBehaviour.Controls.Add(this.cbStartInTray);
            this.tabAppBehaviour.Controls.Add(this.cbCreateFiles);
            this.tabAppBehaviour.Controls.Add(this.cbStartOnStartup);
            this.tabAppBehaviour.Location = new System.Drawing.Point(79, 4);
            this.tabAppBehaviour.Name = "tabAppBehaviour";
            this.tabAppBehaviour.Size = new System.Drawing.Size(392, 462);
            this.tabAppBehaviour.TabIndex = 3;
            this.tabAppBehaviour.Text = "  Application Behaviour";
            // 
            // tbStartupDelay
            // 
            this.tbStartupDelay.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.tbStartupDelay.Location = new System.Drawing.Point(167, 42);
            this.tbStartupDelay.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.tbStartupDelay.Name = "tbStartupDelay";
            this.tbStartupDelay.ReadOnly = true;
            this.tbStartupDelay.Size = new System.Drawing.Size(42, 20);
            this.tbStartupDelay.TabIndex = 41;
            this.tbStartupDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbHideSplash
            // 
            this.cbHideSplash.AutoSize = true;
            this.cbHideSplash.Location = new System.Drawing.Point(16, 62);
            this.cbHideSplash.Name = "cbHideSplash";
            this.cbHideSplash.Size = new System.Drawing.Size(116, 17);
            this.cbHideSplash.TabIndex = 40;
            this.cbHideSplash.Text = "Hide splash screen";
            this.cbHideSplash.UseVisualStyleBackColor = true;
            this.cbHideSplash.CheckedChanged += new System.EventHandler(this.cbHideSplash_CheckedChanged);
            // 
            // cbMinimiseNotClose
            // 
            this.cbMinimiseNotClose.Location = new System.Drawing.Point(16, 116);
            this.cbMinimiseNotClose.Name = "cbMinimiseNotClose";
            this.cbMinimiseNotClose.Size = new System.Drawing.Size(353, 17);
            this.cbMinimiseNotClose.TabIndex = 39;
            this.cbMinimiseNotClose.Text = "Close button [X] minimises window instead of terminating application";
            this.cbMinimiseNotClose.UseVisualStyleBackColor = true;
            this.cbMinimiseNotClose.CheckedChanged += new System.EventHandler(this.cbMinimiseNotCloseCheckedChanged);
            // 
            // cbPortable
            // 
            this.cbPortable.AutoSize = true;
            this.cbPortable.Location = new System.Drawing.Point(16, 153);
            this.cbPortable.Name = "cbPortable";
            this.cbPortable.Size = new System.Drawing.Size(148, 17);
            this.cbPortable.TabIndex = 38;
            this.cbPortable.Text = "Make application portable";
            this.cbPortable.UseVisualStyleBackColor = true;
            this.cbPortable.CheckedChanged += new System.EventHandler(this.cbPortable_CheckedChanged);
            // 
            // gbProxy
            // 
            this.gbProxy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbProxy.Controls.Add(this.rbProxyNone);
            this.gbProxy.Controls.Add(this.rbProxyIE);
            this.gbProxy.Controls.Add(this.rbProxyCustom);
            this.gbProxy.Controls.Add(this.txtProxyPassword);
            this.gbProxy.Controls.Add(this.cbProxyAuthRequired);
            this.gbProxy.Controls.Add(this.txtProxyPort);
            this.gbProxy.Controls.Add(this.txtProxyUser);
            this.gbProxy.Controls.Add(this.txtProxyServer);
            this.gbProxy.Controls.Add(this.label10);
            this.gbProxy.Controls.Add(this.label4);
            this.gbProxy.Controls.Add(this.label9);
            this.gbProxy.Controls.Add(this.label5);
            this.gbProxy.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbProxy.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.gbProxy.Location = new System.Drawing.Point(16, 245);
            this.gbProxy.Name = "gbProxy";
            this.gbProxy.Size = new System.Drawing.Size(364, 200);
            this.gbProxy.TabIndex = 37;
            this.gbProxy.TabStop = false;
            this.gbProxy.Text = "Proxy Setting";
            this.gbProxy.Leave += new System.EventHandler(this.gbProxy_Leave);
            // 
            // rbProxyNone
            // 
            this.rbProxyNone.AutoSize = true;
            this.rbProxyNone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbProxyNone.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbProxyNone.Location = new System.Drawing.Point(20, 22);
            this.rbProxyNone.Name = "rbProxyNone";
            this.rbProxyNone.Size = new System.Drawing.Size(67, 17);
            this.rbProxyNone.TabIndex = 1;
            this.rbProxyNone.Tag = "None";
            this.rbProxyNone.Text = "No proxy";
            this.rbProxyNone.UseVisualStyleBackColor = true;
            this.rbProxyNone.CheckedChanged += new System.EventHandler(this.rbProxyCustom_CheckedChanged);
            // 
            // rbProxyIE
            // 
            this.rbProxyIE.AutoSize = true;
            this.rbProxyIE.Checked = true;
            this.rbProxyIE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbProxyIE.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbProxyIE.Location = new System.Drawing.Point(20, 45);
            this.rbProxyIE.Name = "rbProxyIE";
            this.rbProxyIE.Size = new System.Drawing.Size(157, 17);
            this.rbProxyIE.TabIndex = 2;
            this.rbProxyIE.TabStop = true;
            this.rbProxyIE.Tag = "IE";
            this.rbProxyIE.Text = "Inherit from Internet Explorer";
            this.rbProxyIE.UseVisualStyleBackColor = true;
            this.rbProxyIE.CheckedChanged += new System.EventHandler(this.rbProxyCustom_CheckedChanged);
            // 
            // rbProxyCustom
            // 
            this.rbProxyCustom.AutoSize = true;
            this.rbProxyCustom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbProxyCustom.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbProxyCustom.Location = new System.Drawing.Point(20, 68);
            this.rbProxyCustom.Name = "rbProxyCustom";
            this.rbProxyCustom.Size = new System.Drawing.Size(102, 17);
            this.rbProxyCustom.TabIndex = 3;
            this.rbProxyCustom.Tag = "Custom";
            this.rbProxyCustom.Text = "Custom setttings";
            this.rbProxyCustom.UseVisualStyleBackColor = true;
            this.rbProxyCustom.CheckedChanged += new System.EventHandler(this.rbProxyCustom_CheckedChanged);
            // 
            // txtProxyPassword
            // 
            this.txtProxyPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProxyPassword.Enabled = false;
            this.txtProxyPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProxyPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtProxyPassword.Location = new System.Drawing.Point(94, 167);
            this.txtProxyPassword.Name = "txtProxyPassword";
            this.txtProxyPassword.Size = new System.Drawing.Size(259, 20);
            this.txtProxyPassword.TabIndex = 8;
            this.txtProxyPassword.UseSystemPasswordChar = true;
            // 
            // cbProxyAuthRequired
            // 
            this.cbProxyAuthRequired.AutoSize = true;
            this.cbProxyAuthRequired.Enabled = false;
            this.cbProxyAuthRequired.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProxyAuthRequired.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbProxyAuthRequired.Location = new System.Drawing.Point(38, 120);
            this.cbProxyAuthRequired.Name = "cbProxyAuthRequired";
            this.cbProxyAuthRequired.Size = new System.Drawing.Size(135, 17);
            this.cbProxyAuthRequired.TabIndex = 6;
            this.cbProxyAuthRequired.Text = "Authentication required";
            this.cbProxyAuthRequired.UseVisualStyleBackColor = true;
            this.cbProxyAuthRequired.CheckedChanged += new System.EventHandler(this.cbProxyAuthRequired_CheckedChanged);
            // 
            // txtProxyPort
            // 
            this.txtProxyPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProxyPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProxyPort.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtProxyPort.Location = new System.Drawing.Point(302, 92);
            this.txtProxyPort.Name = "txtProxyPort";
            this.txtProxyPort.Size = new System.Drawing.Size(51, 20);
            this.txtProxyPort.TabIndex = 5;
            // 
            // txtProxyUser
            // 
            this.txtProxyUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProxyUser.Enabled = false;
            this.txtProxyUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProxyUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtProxyUser.Location = new System.Drawing.Point(94, 143);
            this.txtProxyUser.Name = "txtProxyUser";
            this.txtProxyUser.Size = new System.Drawing.Size(259, 20);
            this.txtProxyUser.TabIndex = 7;
            // 
            // txtProxyServer
            // 
            this.txtProxyServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProxyServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProxyServer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtProxyServer.Location = new System.Drawing.Point(94, 92);
            this.txtProxyServer.Name = "txtProxyServer";
            this.txtProxyServer.Size = new System.Drawing.Size(174, 20);
            this.txtProxyServer.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(35, 170);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(35, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Server:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(35, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Username:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(276, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Port:";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label14.Location = new System.Drawing.Point(136, 13);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(139, 15);
            this.label14.TabIndex = 36;
            this.label14.Text = "Application Behaviour";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btLogLocation
            // 
            this.btLogLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btLogLocation.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btLogLocation.Location = new System.Drawing.Point(302, 193);
            this.btLogLocation.Name = "btLogLocation";
            this.btLogLocation.Size = new System.Drawing.Size(80, 23);
            this.btLogLocation.TabIndex = 19;
            this.btLogLocation.Text = "Open Log";
            this.btLogLocation.UseVisualStyleBackColor = true;
            this.btLogLocation.Click += new System.EventHandler(this.btLogLocation_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Logging level";
            // 
            // cbLoggingLevel
            // 
            this.cbLoggingLevel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbLoggingLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoggingLevel.FormattingEnabled = true;
            this.cbLoggingLevel.Items.AddRange(new object[] {
            "Off",
            "Fatal",
            "Error",
            "Fail",
            "Warn",
            "Info",
            "Debug",
            "Fine",
            "Ultra-Fine",
            "All"});
            this.cbLoggingLevel.Location = new System.Drawing.Point(86, 194);
            this.cbLoggingLevel.Name = "cbLoggingLevel";
            this.cbLoggingLevel.Size = new System.Drawing.Size(210, 21);
            this.cbLoggingLevel.TabIndex = 17;
            this.cbLoggingLevel.Tag = "l";
            this.cbLoggingLevel.SelectedIndexChanged += new System.EventHandler(this.cbLoggingLevel_SelectedIndexChanged);
            // 
            // cbShowBubbleTooltips
            // 
            this.cbShowBubbleTooltips.Location = new System.Drawing.Point(16, 134);
            this.cbShowBubbleTooltips.Name = "cbShowBubbleTooltips";
            this.cbShowBubbleTooltips.Size = new System.Drawing.Size(259, 17);
            this.cbShowBubbleTooltips.TabIndex = 14;
            this.cbShowBubbleTooltips.Text = "Show bubble tooltip in tray when syncing";
            this.cbShowBubbleTooltips.UseVisualStyleBackColor = true;
            this.cbShowBubbleTooltips.CheckedChanged += new System.EventHandler(this.cbShowBubbleTooltipsCheckedChanged);
            // 
            // cbMinimiseToTray
            // 
            this.cbMinimiseToTray.Location = new System.Drawing.Point(16, 98);
            this.cbMinimiseToTray.Name = "cbMinimiseToTray";
            this.cbMinimiseToTray.Size = new System.Drawing.Size(206, 17);
            this.cbMinimiseToTray.TabIndex = 12;
            this.cbMinimiseToTray.Text = "Minimise to tray instead of taskbar";
            this.cbMinimiseToTray.UseVisualStyleBackColor = true;
            this.cbMinimiseToTray.CheckedChanged += new System.EventHandler(this.cbMinimiseToTrayCheckedChanged);
            // 
            // cbStartInTray
            // 
            this.cbStartInTray.Location = new System.Drawing.Point(16, 80);
            this.cbStartInTray.Name = "cbStartInTray";
            this.cbStartInTray.Size = new System.Drawing.Size(104, 17);
            this.cbStartInTray.TabIndex = 13;
            this.cbStartInTray.Text = "Start in tray";
            this.cbStartInTray.UseVisualStyleBackColor = true;
            this.cbStartInTray.CheckedChanged += new System.EventHandler(this.cbStartInTrayCheckedChanged);
            // 
            // cbCreateFiles
            // 
            this.cbCreateFiles.Location = new System.Drawing.Point(16, 171);
            this.cbCreateFiles.Name = "cbCreateFiles";
            this.cbCreateFiles.Size = new System.Drawing.Size(235, 17);
            this.cbCreateFiles.TabIndex = 15;
            this.cbCreateFiles.Text = "Create CSV files of calendar entries";
            this.cbCreateFiles.UseVisualStyleBackColor = true;
            this.cbCreateFiles.CheckedChanged += new System.EventHandler(this.cbCreateFiles_CheckedChanged);
            // 
            // cbStartOnStartup
            // 
            this.cbStartOnStartup.AutoSize = true;
            this.cbStartOnStartup.Location = new System.Drawing.Point(16, 43);
            this.cbStartOnStartup.Name = "cbStartOnStartup";
            this.cbStartOnStartup.Size = new System.Drawing.Size(244, 17);
            this.cbStartOnStartup.TabIndex = 16;
            this.cbStartOnStartup.Text = "Start on login, with delay of                 seconds";
            this.cbStartOnStartup.UseVisualStyleBackColor = true;
            this.cbStartOnStartup.CheckedChanged += new System.EventHandler(this.cbStartOnStartup_CheckedChanged);
            // 
            // bSave
            // 
            this.bSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bSave.Location = new System.Drawing.Point(392, 493);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(75, 31);
            this.bSave.TabIndex = 8;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.Save_Click);
            // 
            // tabPage_Help
            // 
            this.tabPage_Help.BackColor = System.Drawing.Color.White;
            this.tabPage_Help.Controls.Add(this.tbTS2);
            this.tabPage_Help.Controls.Add(this.linkTShoot_logfile);
            this.tabPage_Help.Controls.Add(this.tbTS4);
            this.tabPage_Help.Controls.Add(this.linkTShoot_issue);
            this.tabPage_Help.Controls.Add(this.linkTShoot_loglevel);
            this.tabPage_Help.Controls.Add(this.label27);
            this.tabPage_Help.Controls.Add(this.label20);
            this.tabPage_Help.Controls.Add(this.tableLayoutPanel1);
            this.tabPage_Help.Controls.Add(this.label16);
            this.tabPage_Help.Controls.Add(this.tbTS3);
            this.tabPage_Help.Controls.Add(this.tbTS1);
            this.tabPage_Help.Controls.Add(this.tbTS0);
            this.tabPage_Help.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Help.Name = "tabPage_Help";
            this.tabPage_Help.Size = new System.Drawing.Size(487, 542);
            this.tabPage_Help.TabIndex = 3;
            this.tabPage_Help.Text = "Help";
            // 
            // tbTS2
            // 
            this.tbTS2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbTS2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTS2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTS2.Location = new System.Drawing.Point(92, 492);
            this.tbTS2.Name = "tbTS2";
            this.tbTS2.Size = new System.Drawing.Size(297, 13);
            this.tbTS2.TabIndex = 55;
            this.tbTS2.Text = "  - reproduce the problem";
            // 
            // linkTShoot_logfile
            // 
            this.linkTShoot_logfile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.linkTShoot_logfile.AutoSize = true;
            this.linkTShoot_logfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkTShoot_logfile.Location = new System.Drawing.Point(158, 520);
            this.linkTShoot_logfile.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.linkTShoot_logfile.Name = "linkTShoot_logfile";
            this.linkTShoot_logfile.Size = new System.Drawing.Size(92, 13);
            this.linkTShoot_logfile.TabIndex = 50;
            this.linkTShoot_logfile.TabStop = true;
            this.linkTShoot_logfile.Text = "OGcalsync.log file";
            this.linkTShoot_logfile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkTShoot_logfile_LinkClicked);
            // 
            // tbTS4
            // 
            this.tbTS4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbTS4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTS4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTS4.Location = new System.Drawing.Point(92, 520);
            this.tbTS4.Name = "tbTS4";
            this.tbTS4.Size = new System.Drawing.Size(158, 13);
            this.tbTS4.TabIndex = 53;
            this.tbTS4.Text = "  - attach your ";
            // 
            // linkTShoot_issue
            // 
            this.linkTShoot_issue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.linkTShoot_issue.AutoSize = true;
            this.linkTShoot_issue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkTShoot_issue.Location = new System.Drawing.Point(296, 506);
            this.linkTShoot_issue.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.linkTShoot_issue.Name = "linkTShoot_issue";
            this.linkTShoot_issue.Size = new System.Drawing.Size(82, 13);
            this.linkTShoot_issue.TabIndex = 49;
            this.linkTShoot_issue.TabStop = true;
            this.linkTShoot_issue.Text = "issue on GitHub";
            this.linkTShoot_issue.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkTShoot_issue_LinkClicked);
            // 
            // linkTShoot_loglevel
            // 
            this.linkTShoot_loglevel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.linkTShoot_loglevel.AutoSize = true;
            this.linkTShoot_loglevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkTShoot_loglevel.Location = new System.Drawing.Point(138, 478);
            this.linkTShoot_loglevel.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.linkTShoot_loglevel.Name = "linkTShoot_loglevel";
            this.linkTShoot_loglevel.Size = new System.Drawing.Size(66, 13);
            this.linkTShoot_loglevel.TabIndex = 48;
            this.linkTShoot_loglevel.TabStop = true;
            this.linkTShoot_loglevel.Text = "logging level";
            this.linkTShoot_loglevel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkTShoot_loglevel_LinkClicked);
            // 
            // label27
            // 
            this.label27.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label27.Location = new System.Drawing.Point(179, 441);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(104, 15);
            this.label27.TabIndex = 47;
            this.label27.Text = "TroubleShooting";
            this.label27.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(74, 38);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(349, 26);
            this.label20.TabIndex = 40;
            this.label20.Text = "All the configuration is defined on the \"Settings\" tab above.\r\nTry hovering the m" +
    "ouse over individual settings for extra tips, or press F1.";
            this.label20.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.75576F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91.24424F));
            this.tableLayoutPanel1.Controls.Add(this.label24, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label22, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label21, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label19, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label17, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label18, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label23, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label25, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(21, 82);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.58824F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.41176F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(434, 347);
            this.tableLayoutPanel1.TabIndex = 38;
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label24.Location = new System.Drawing.Point(8, 225);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(21, 15);
            this.label24.TabIndex = 44;
            this.label24.Text = "#4";
            this.label24.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label22.Location = new System.Drawing.Point(8, 110);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(21, 15);
            this.label22.TabIndex = 42;
            this.label22.Text = "#3";
            this.label22.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(40, 22);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(389, 78);
            this.label21.TabIndex = 41;
            this.label21.Text = resources.GetString("label21.Text");
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label19.Location = new System.Drawing.Point(8, 22);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(21, 15);
            this.label19.TabIndex = 40;
            this.label19.Text = "#2";
            this.label19.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label17.Location = new System.Drawing.Point(8, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(21, 15);
            this.label17.TabIndex = 38;
            this.label17.Text = "#1";
            this.label17.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(40, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(321, 13);
            this.label18.TabIndex = 39;
            this.label18.Text = "On the \"Outlook\" tab, select the calendar you wish to synchronise.";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(40, 110);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(379, 104);
            this.label23.TabIndex = 43;
            this.label23.Text = resources.GetString("label23.Text");
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(40, 225);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(391, 104);
            this.label25.TabIndex = 45;
            this.label25.Text = resources.GetString("label25.Text");
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label16.Location = new System.Drawing.Point(196, 13);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(87, 15);
            this.label16.TabIndex = 37;
            this.label16.Text = "Configuration";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbTS3
            // 
            this.tbTS3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbTS3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTS3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTS3.Location = new System.Drawing.Point(92, 506);
            this.tbTS3.Name = "tbTS3";
            this.tbTS3.Size = new System.Drawing.Size(297, 13);
            this.tbTS3.TabIndex = 54;
            this.tbTS3.Text = "  - update an existing issue or create a new issue on GitHub";
            // 
            // tbTS1
            // 
            this.tbTS1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbTS1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTS1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTS1.Location = new System.Drawing.Point(92, 478);
            this.tbTS1.Name = "tbTS1";
            this.tbTS1.Size = new System.Drawing.Size(176, 13);
            this.tbTS1.TabIndex = 56;
            this.tbTS1.Text = "  - set the logging level  to \"Debug\"";
            // 
            // tbTS0
            // 
            this.tbTS0.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbTS0.BackColor = System.Drawing.SystemColors.Window;
            this.tbTS0.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTS0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTS0.Location = new System.Drawing.Point(92, 464);
            this.tbTS0.Multiline = true;
            this.tbTS0.Name = "tbTS0";
            this.tbTS0.Size = new System.Drawing.Size(363, 20);
            this.tbTS0.TabIndex = 51;
            this.tbTS0.Text = "If you think you have found a bug, please:-";
            // 
            // tabPage_About
            // 
            this.tabPage_About.BackColor = System.Drawing.Color.White;
            this.tabPage_About.Controls.Add(this.lDonateTip);
            this.tabPage_About.Controls.Add(this.dgAbout);
            this.tabPage_About.Controls.Add(this.cbAlphaReleases);
            this.tabPage_About.Controls.Add(this.btCheckForUpdate);
            this.tabPage_About.Controls.Add(this.label28);
            this.tabPage_About.Controls.Add(this.lAboutURL);
            this.tabPage_About.Controls.Add(this.lAboutMain);
            this.tabPage_About.Controls.Add(this.pbDonate);
            this.tabPage_About.Controls.Add(this.GappBrowser);
            this.tabPage_About.Location = new System.Drawing.Point(4, 22);
            this.tabPage_About.Name = "tabPage_About";
            this.tabPage_About.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_About.Size = new System.Drawing.Size(487, 542);
            this.tabPage_About.TabIndex = 2;
            this.tabPage_About.Text = "About";
            // 
            // lDonateTip
            // 
            this.lDonateTip.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lDonateTip.AutoSize = true;
            this.lDonateTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDonateTip.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lDonateTip.Location = new System.Drawing.Point(154, 406);
            this.lDonateTip.Name = "lDonateTip";
            this.lDonateTip.Size = new System.Drawing.Size(177, 13);
            this.lDonateTip.TabIndex = 46;
            this.lDonateTip.Text = "£10 or more hides the splash screen";
            // 
            // dgAbout
            // 
            this.dgAbout.AllowUserToAddRows = false;
            this.dgAbout.AllowUserToDeleteRows = false;
            this.dgAbout.AllowUserToResizeRows = false;
            this.dgAbout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgAbout.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgAbout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgAbout.ColumnHeadersVisible = false;
            this.dgAbout.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgAbout.Location = new System.Drawing.Point(78, 48);
            this.dgAbout.Name = "dgAbout";
            this.dgAbout.ReadOnly = true;
            this.dgAbout.RowHeadersVisible = false;
            this.dgAbout.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgAbout.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgAbout.Size = new System.Drawing.Size(328, 91);
            this.dgAbout.TabIndex = 44;
            this.dgAbout.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAbout_CellContentDoubleClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 5;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Value";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // cbAlphaReleases
            // 
            this.cbAlphaReleases.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbAlphaReleases.AutoSize = true;
            this.cbAlphaReleases.Location = new System.Drawing.Point(170, 470);
            this.cbAlphaReleases.Name = "cbAlphaReleases";
            this.cbAlphaReleases.Size = new System.Drawing.Size(144, 17);
            this.cbAlphaReleases.TabIndex = 40;
            this.cbAlphaReleases.Text = "Check for Alpha releases";
            this.cbAlphaReleases.UseVisualStyleBackColor = true;
            this.cbAlphaReleases.CheckedChanged += new System.EventHandler(this.cbAlphaReleases_CheckedChanged);
            // 
            // btCheckForUpdate
            // 
            this.btCheckForUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btCheckForUpdate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btCheckForUpdate.Location = new System.Drawing.Point(186, 441);
            this.btCheckForUpdate.Name = "btCheckForUpdate";
            this.btCheckForUpdate.Size = new System.Drawing.Size(113, 23);
            this.btCheckForUpdate.TabIndex = 39;
            this.btCheckForUpdate.Text = "Check for Update";
            this.btCheckForUpdate.UseVisualStyleBackColor = true;
            this.btCheckForUpdate.Click += new System.EventHandler(this.btCheckForUpdate_Click);
            // 
            // label28
            // 
            this.label28.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label28.Location = new System.Drawing.Point(148, 13);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(188, 15);
            this.label28.TabIndex = 37;
            this.label28.Text = "Outlook Google Calendar Sync";
            this.label28.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lAboutURL
            // 
            this.lAboutURL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lAboutURL.Location = new System.Drawing.Point(5, 517);
            this.lAboutURL.Name = "lAboutURL";
            this.lAboutURL.Size = new System.Drawing.Size(475, 23);
            this.lAboutURL.TabIndex = 2;
            this.lAboutURL.TabStop = true;
            this.lAboutURL.Text = "https://phw198.github.io/OutlookGoogleCalendarSync";
            this.lAboutURL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lAboutURL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lAboutURL_LinkClicked);
            // 
            // lAboutMain
            // 
            this.lAboutMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lAboutMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lAboutMain.Location = new System.Drawing.Point(29, 207);
            this.lAboutMain.Name = "lAboutMain";
            this.lAboutMain.Padding = new System.Windows.Forms.Padding(15);
            this.lAboutMain.Size = new System.Drawing.Size(426, 131);
            this.lAboutMain.TabIndex = 1;
            this.lAboutMain.Text = resources.GetString("lAboutMain.Text");
            this.lAboutMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbDonate
            // 
            this.pbDonate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbDonate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbDonate.Image = global::OutlookGoogleCalendarSync.Properties.Resources.paypalDonate;
            this.pbDonate.Location = new System.Drawing.Point(205, 380);
            this.pbDonate.Name = "pbDonate";
            this.pbDonate.Size = new System.Drawing.Size(75, 23);
            this.pbDonate.TabIndex = 3;
            this.pbDonate.TabStop = false;
            this.pbDonate.Click += new System.EventHandler(this.pbDonate_Click);
            // 
            // GappBrowser
            // 
            this.GappBrowser.Location = new System.Drawing.Point(30, 207);
            this.GappBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.GappBrowser.Name = "GappBrowser";
            this.GappBrowser.ScriptErrorsSuppressed = true;
            this.GappBrowser.Size = new System.Drawing.Size(250, 51);
            this.GappBrowser.TabIndex = 45;
            this.GappBrowser.Visible = false;
            // 
            // tabPage_Social
            // 
            this.tabPage_Social.BackColor = System.Drawing.Color.White;
            this.tabPage_Social.Controls.Add(this.pbSocialDonate);
            this.tabPage_Social.Controls.Add(this.tableLayoutPanel2);
            this.tabPage_Social.Controls.Add(this.label2);
            this.tabPage_Social.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Social.Name = "tabPage_Social";
            this.tabPage_Social.Size = new System.Drawing.Size(487, 542);
            this.tabPage_Social.TabIndex = 4;
            this.tabPage_Social.Text = "Socialise";
            // 
            // pbSocialDonate
            // 
            this.pbSocialDonate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbSocialDonate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSocialDonate.Image = global::OutlookGoogleCalendarSync.Properties.Resources.paypalDonate;
            this.pbSocialDonate.Location = new System.Drawing.Point(206, 45);
            this.pbSocialDonate.Name = "pbSocialDonate";
            this.pbSocialDonate.Size = new System.Drawing.Size(75, 23);
            this.pbSocialDonate.TabIndex = 40;
            this.pbSocialDonate.TabStop = false;
            this.pbSocialDonate.Click += new System.EventHandler(this.pbDonate_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.lMilestoneBlurb, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btSocialTweet, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lMilestone, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btSocialGplus, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.btSocialFB, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.btSocialLinkedin, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.btSocialRSSfeed, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.label29, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.label30, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.pbSocialGplusCommunity, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.pbSocialTwitterFollow, 1, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(99, 84);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 9;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(301, 357);
            this.tableLayoutPanel2.TabIndex = 39;
            // 
            // lMilestoneBlurb
            // 
            this.lMilestoneBlurb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lMilestoneBlurb.AutoSize = true;
            this.lMilestoneBlurb.Location = new System.Drawing.Point(103, 5);
            this.lMilestoneBlurb.Name = "lMilestoneBlurb";
            this.lMilestoneBlurb.Size = new System.Drawing.Size(169, 39);
            this.lMilestoneBlurb.TabIndex = 41;
            this.lMilestoneBlurb.Text = "Let others know you\'ve found this appliction by sharing through your favourite so" +
    "cial media site below!";
            // 
            // btSocialTweet
            // 
            this.btSocialTweet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btSocialTweet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSocialTweet.FlatAppearance.BorderSize = 0;
            this.btSocialTweet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btSocialTweet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSocialTweet.Image = global::OutlookGoogleCalendarSync.Properties.Resources.twitter;
            this.btSocialTweet.Location = new System.Drawing.Point(7, 98);
            this.btSocialTweet.Name = "btSocialTweet";
            this.btSocialTweet.Size = new System.Drawing.Size(86, 34);
            this.btSocialTweet.TabIndex = 0;
            this.btSocialTweet.UseVisualStyleBackColor = true;
            this.btSocialTweet.Click += new System.EventHandler(this.btSocialTweet_Click);
            // 
            // lMilestone
            // 
            this.lMilestone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lMilestone.AutoSize = true;
            this.lMilestone.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMilestone.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lMilestone.Location = new System.Drawing.Point(4, 17);
            this.lMilestone.Name = "lMilestone";
            this.lMilestone.Size = new System.Drawing.Size(91, 15);
            this.lMilestone.TabIndex = 40;
            this.lMilestone.Text = "Frequent User";
            this.lMilestone.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btSocialGplus
            // 
            this.btSocialGplus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btSocialGplus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSocialGplus.FlatAppearance.BorderSize = 0;
            this.btSocialGplus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btSocialGplus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSocialGplus.Image = global::OutlookGoogleCalendarSync.Properties.Resources.googleplus;
            this.btSocialGplus.Location = new System.Drawing.Point(7, 148);
            this.btSocialGplus.Name = "btSocialGplus";
            this.btSocialGplus.Size = new System.Drawing.Size(86, 34);
            this.btSocialGplus.TabIndex = 43;
            this.btSocialGplus.UseVisualStyleBackColor = true;
            this.btSocialGplus.Click += new System.EventHandler(this.btSocialGplus_Click);
            // 
            // btSocialFB
            // 
            this.btSocialFB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btSocialFB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSocialFB.FlatAppearance.BorderSize = 0;
            this.btSocialFB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btSocialFB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSocialFB.Image = global::OutlookGoogleCalendarSync.Properties.Resources.facebook;
            this.btSocialFB.Location = new System.Drawing.Point(7, 198);
            this.btSocialFB.Name = "btSocialFB";
            this.btSocialFB.Size = new System.Drawing.Size(86, 34);
            this.btSocialFB.TabIndex = 45;
            this.btSocialFB.UseVisualStyleBackColor = true;
            this.btSocialFB.Click += new System.EventHandler(this.btSocialFB_Click);
            // 
            // btSocialLinkedin
            // 
            this.btSocialLinkedin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btSocialLinkedin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSocialLinkedin.FlatAppearance.BorderSize = 0;
            this.btSocialLinkedin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btSocialLinkedin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSocialLinkedin.Image = global::OutlookGoogleCalendarSync.Properties.Resources.linkedin;
            this.btSocialLinkedin.Location = new System.Drawing.Point(7, 248);
            this.btSocialLinkedin.Name = "btSocialLinkedin";
            this.btSocialLinkedin.Size = new System.Drawing.Size(86, 34);
            this.btSocialLinkedin.TabIndex = 50;
            this.btSocialLinkedin.UseVisualStyleBackColor = true;
            this.btSocialLinkedin.Click += new System.EventHandler(this.btSocialLinkedin_Click);
            // 
            // btSocialRSSfeed
            // 
            this.btSocialRSSfeed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btSocialRSSfeed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSocialRSSfeed.FlatAppearance.BorderSize = 0;
            this.btSocialRSSfeed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btSocialRSSfeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSocialRSSfeed.Image = global::OutlookGoogleCalendarSync.Properties.Resources.rssfeed;
            this.btSocialRSSfeed.Location = new System.Drawing.Point(7, 298);
            this.btSocialRSSfeed.Name = "btSocialRSSfeed";
            this.btSocialRSSfeed.Size = new System.Drawing.Size(86, 34);
            this.btSocialRSSfeed.TabIndex = 46;
            this.btSocialRSSfeed.UseVisualStyleBackColor = true;
            this.btSocialRSSfeed.Click += new System.EventHandler(this.btSocialRSSfeed_Click);
            // 
            // label29
            // 
            this.label29.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(103, 308);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(182, 13);
            this.label29.TabIndex = 49;
            this.label29.Text = "See new versions as they\'re released";
            // 
            // label30
            // 
            this.label30.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label30.Location = new System.Drawing.Point(29, 72);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(41, 15);
            this.label30.TabIndex = 52;
            this.label30.Text = "Share";
            this.label30.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbSocialGplusCommunity
            // 
            this.pbSocialGplusCommunity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pbSocialGplusCommunity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSocialGplusCommunity.Image = global::OutlookGoogleCalendarSync.Properties.Resources.google_community;
            this.pbSocialGplusCommunity.Location = new System.Drawing.Point(103, 150);
            this.pbSocialGplusCommunity.Name = "pbSocialGplusCommunity";
            this.pbSocialGplusCommunity.Size = new System.Drawing.Size(135, 30);
            this.pbSocialGplusCommunity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSocialGplusCommunity.TabIndex = 51;
            this.pbSocialGplusCommunity.TabStop = false;
            this.pbSocialGplusCommunity.Click += new System.EventHandler(this.pbSocialGplusCommunity_Click);
            // 
            // pbSocialTwitterFollow
            // 
            this.pbSocialTwitterFollow.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pbSocialTwitterFollow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSocialTwitterFollow.Image = global::OutlookGoogleCalendarSync.Properties.Resources.twitter_follow;
            this.pbSocialTwitterFollow.Location = new System.Drawing.Point(103, 101);
            this.pbSocialTwitterFollow.Name = "pbSocialTwitterFollow";
            this.pbSocialTwitterFollow.Size = new System.Drawing.Size(135, 27);
            this.pbSocialTwitterFollow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSocialTwitterFollow.TabIndex = 53;
            this.pbSocialTwitterFollow.TabStop = false;
            this.pbSocialTwitterFollow.Click += new System.EventHandler(this.pbSocialTwitterFollow_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(149, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 15);
            this.label2.TabIndex = 38;
            this.label2.Text = "Get Social && Spread The Word!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // trayIcon
            // 
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "Outlook Google Calendar Sync";
            // 
            // cbCloudLogging
            // 
            this.cbCloudLogging.Location = new System.Drawing.Point(16, 221);
            this.cbCloudLogging.Name = "cbCloudLogging";
            this.cbCloudLogging.Size = new System.Drawing.Size(215, 17);
            this.cbCloudLogging.TabIndex = 42;
            this.cbCloudLogging.Text = "Feedback errors to help improve OGCS";
            this.cbCloudLogging.ThreeState = true;
            this.cbCloudLogging.UseVisualStyleBackColor = true;
            this.cbCloudLogging.CheckStateChanged += new System.EventHandler(this.cbCloudLogging_CheckStateChanged);
            // 
            // tbConnectedAcc
            // 
            this.tbConnectedAcc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbConnectedAcc.Location = new System.Drawing.Point(154, 46);
            this.tbConnectedAcc.Name = "tbConnectedAcc";
            this.tbConnectedAcc.ReadOnly = true;
            this.tbConnectedAcc.Size = new System.Drawing.Size(220, 20);
            this.tbConnectedAcc.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Connected Account";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ddCategoryColour
            // 
            this.ddCategoryColour.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ddCategoryColour.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ddCategoryColour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddCategoryColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddCategoryColour.FormattingEnabled = true;
            this.ddCategoryColour.Location = new System.Drawing.Point(178, 58);
            this.ddCategoryColour.Name = "ddCategoryColour";
            this.ddCategoryColour.SelectedItem = null;
            this.ddCategoryColour.Size = new System.Drawing.Size(158, 21);
            this.ddCategoryColour.TabIndex = 43;
            this.ddCategoryColour.SelectedIndexChanged += new System.EventHandler(this.ddCategoryColour_SelectedIndexChanged);
            // 
            // cbLocation
            // 
            this.cbLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLocation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbLocation.Location = new System.Drawing.Point(45, 42);
            this.cbLocation.Name = "cbLocation";
            this.cbLocation.Size = new System.Drawing.Size(80, 17);
            this.cbLocation.TabIndex = 44;
            this.cbLocation.Text = "Location";
            this.cbLocation.UseVisualStyleBackColor = true;
            this.cbLocation.CheckedChanged += new System.EventHandler(this.cbLocation_CheckedChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 592);
            this.Controls.Add(this.tabApp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(535, 630);
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Outlook Google Calendar Sync";
            this.Resize += new System.EventHandler(this.mainFormResize);
            this.tabApp.ResumeLayout(false);
            this.tabPage_Sync.ResumeLayout(false);
            this.tabPage_Sync.PerformLayout();
            this.consolePanel.ResumeLayout(false);
            this.tabPage_Settings.ResumeLayout(false);
            this.tabPage_Settings.PerformLayout();
            this.tabAppSettings.ResumeLayout(false);
            this.tabOutlook.ResumeLayout(false);
            this.tabOutlook.PerformLayout();
            this.msCategories.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabGoogle.ResumeLayout(false);
            this.tabGoogle.PerformLayout();
            this.gbDeveloperOptions.ResumeLayout(false);
            this.gbDeveloperOptions.PerformLayout();
            this.tabSyncOptions.ResumeLayout(false);
            this.tabSyncOptions.PerformLayout();
            this.WhatPostit.ResumeLayout(false);
            this.panelSyncOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbExpandHow)).EndInit();
            this.gbSyncOptions_How.ResumeLayout(false);
            this.howMorePanel.ResumeLayout(false);
            this.howObfuscatePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgObfuscateRegex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExpandWhat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExpandWhen)).EndInit();
            this.gbSyncOptions_When.ResumeLayout(false);
            this.gbSyncOptions_When.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDaysInTheFuture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDaysInThePast)).EndInit();
            this.gbSyncOptions_What.ResumeLayout(false);
            this.gbSyncOptions_What.PerformLayout();
            this.tabAppBehaviour.ResumeLayout(false);
            this.tabAppBehaviour.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbStartupDelay)).EndInit();
            this.gbProxy.ResumeLayout(false);
            this.gbProxy.PerformLayout();
            this.tabPage_Help.ResumeLayout(false);
            this.tabPage_Help.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabPage_About.ResumeLayout(false);
            this.tabPage_About.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAbout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDonate)).EndInit();
            this.tabPage_Social.ResumeLayout(false);
            this.tabPage_Social.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSocialDonate)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSocialGplusCommunity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSocialTwitterFollow)).EndInit();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.LinkLabel lAboutURL;
        private System.Windows.Forms.TabPage tabPage_About;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.Label lAboutMain;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Label lLastSync;
        private System.Windows.Forms.Label lNextSync;
        private System.Windows.Forms.CheckBox cbVerboseOutput;
        public System.Windows.Forms.TabControl tabApp;
        public System.Windows.Forms.TabPage tabPage_Settings;
        private System.Windows.Forms.PictureBox pbDonate;
        public System.Windows.Forms.Button bSyncNow;
        private System.Windows.Forms.TabControl tabAppSettings;
        private System.Windows.Forms.RadioButton rbOutlookSharedCal;
        public System.Windows.Forms.RadioButton rbOutlookDefaultMB;
        private System.Windows.Forms.RadioButton rbOutlookAltMB;
        public System.Windows.Forms.ComboBox ddMailboxName;
        private System.Windows.Forms.TabPage tabGoogle;
        private System.Windows.Forms.Button btResetGCal;
        private System.Windows.Forms.Label lGoogleHelp;
        private System.Windows.Forms.Label lGoogleCalendar;
        private System.Windows.Forms.Button bGetGoogleCalendars;
        private System.Windows.Forms.ComboBox cbGoogleCalendars;
        private System.Windows.Forms.TabPage tabSyncOptions;
        private System.Windows.Forms.TabPage tabAppBehaviour;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btLogLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbLoggingLevel;
        private System.Windows.Forms.CheckBox cbStartOnStartup;
        private System.Windows.Forms.CheckBox cbShowBubbleTooltips;
        private System.Windows.Forms.CheckBox cbMinimiseToTray;
        private System.Windows.Forms.CheckBox cbStartInTray;
        private System.Windows.Forms.CheckBox cbCreateFiles;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox gbProxy;
        private System.Windows.Forms.RadioButton rbProxyIE;
        private System.Windows.Forms.RadioButton rbProxyCustom;
        private System.Windows.Forms.TextBox txtProxyPassword;
        private System.Windows.Forms.CheckBox cbProxyAuthRequired;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtProxyPort;
        private System.Windows.Forms.TextBox txtProxyUser;
        private System.Windows.Forms.TextBox txtProxyServer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbProxyNone;
        private System.Windows.Forms.Label lSettingInfo;
        private System.Windows.Forms.TabPage tabPage_Help;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.CheckBox cbPortable;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.CheckBox cbAlphaReleases;
        public System.Windows.Forms.Button btCheckForUpdate;
        private System.Windows.Forms.TabPage tabPage_Social;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btSocialTweet;
        private System.Windows.Forms.Label lMilestoneBlurb;
        private System.Windows.Forms.Label lMilestone;
        private System.Windows.Forms.Button btSocialGplus;
        private System.Windows.Forms.Button btSocialFB;
        private System.Windows.Forms.Button btSocialRSSfeed;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.PictureBox pbSocialDonate;
        private System.Windows.Forms.Button btSocialLinkedin;
        public System.Windows.Forms.ComboBox cbOutlookCalendars;
        private System.Windows.Forms.PictureBox pbSocialGplusCommunity;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.PictureBox pbSocialTwitterFollow;
        private System.Windows.Forms.Panel WhatPostit;
        private System.Windows.Forms.RichTextBox tbWhatHelp;
        private System.Windows.Forms.GroupBox gbSyncOptions_When;
        private System.Windows.Forms.CheckBox cbOutlookPush;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown tbDaysInTheFuture;
        private System.Windows.Forms.NumericUpDown tbDaysInThePast;
        private System.Windows.Forms.Label lDaysInFuture;
        private System.Windows.Forms.Label lDaysInPast;
        private System.Windows.Forms.Label lDateRange;
        private System.Windows.Forms.GroupBox gbSyncOptions_What;
        private System.Windows.Forms.CheckBox cbAddDescription_OnlyToGoogle;
        private System.Windows.Forms.CheckBox cbAddReminders;
        private System.Windows.Forms.Label lAttributes;
        private System.Windows.Forms.CheckBox cbAddAttendees;
        private System.Windows.Forms.CheckBox cbAddDescription;
        private System.Windows.Forms.GroupBox gbSyncOptions_How;
        private System.Windows.Forms.CheckBox cbOfuscate;
        private System.Windows.Forms.ComboBox syncDirection;
        private System.Windows.Forms.Label lDirection;
        private System.Windows.Forms.CheckBox cbMergeItems;
        private System.Windows.Forms.CheckBox cbDisableDeletion;
        private System.Windows.Forms.CheckBox cbConfirmOnDelete;
        private System.Windows.Forms.Button btObfuscateRules;
        private System.Windows.Forms.CheckBox cbMinimiseNotClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbOutlookDateFormat;
        private System.Windows.Forms.ComboBox cbOutlookDateFormat;
        private System.Windows.Forms.TextBox txtDateFormats;
        private System.Windows.Forms.TextBox tbOutlookDateFormatResult;
        private System.Windows.Forms.Button btTestOutlookFilter;
        private System.Windows.Forms.LinkLabel urlDateFormats;
        private System.Windows.Forms.Label label32;
        public System.Windows.Forms.TabPage tabPage_Sync;
        private System.Windows.Forms.LinkLabel linkTShoot_logfile;
        private System.Windows.Forms.LinkLabel linkTShoot_issue;
        private System.Windows.Forms.LinkLabel linkTShoot_loglevel;
        private System.Windows.Forms.RichTextBox tbSyncNote;
        private System.Windows.Forms.Panel panelSyncNote;
        private System.Windows.Forms.DataGridView dgAbout;
        private System.Windows.Forms.CheckBox cbUseGoogleDefaultReminder;
        private System.Windows.Forms.CheckBox cbReminderDND;
        private System.Windows.Forms.DateTimePicker dtDNDstart;
        private System.Windows.Forms.Label lDNDand;
        private System.Windows.Forms.DateTimePicker dtDNDend;
        private System.Windows.Forms.TextBox tbTS0;
        private System.Windows.Forms.TextBox tbTS4;
        private System.Windows.Forms.TextBox tbTS2;
        private System.Windows.Forms.TextBox tbTS3;
        private System.Windows.Forms.TextBox tbTS1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        public System.Windows.Forms.ComboBox cbIntervalUnit;
        public System.Windows.Forms.NumericUpDown tbInterval;
        public System.Windows.Forms.Label lNextSyncVal;
        private System.Windows.Forms.CheckedListBox clbCategories;
        private System.Windows.Forms.Label lFilterCategories;
        public System.Windows.Forms.ComboBox cbCategoryFilter;
        private System.Windows.Forms.ContextMenuStrip msCategories;
        private System.Windows.Forms.ToolStripMenuItem miCatSelectAll;
        private System.Windows.Forms.ToolStripMenuItem miCatSelectNone;
        private System.Windows.Forms.ToolStripMenuItem miCatRefresh;
        private System.Windows.Forms.GroupBox gbDeveloperOptions;
        private System.Windows.Forms.LinkLabel llAPIConsole;
        private System.Windows.Forms.CheckBox cbShowClientSecret;
        private System.Windows.Forms.TextBox lGoogleAPIInstructions;
        private System.Windows.Forms.TextBox tbClientSecret;
        private System.Windows.Forms.TextBox tbClientID;
        private System.Windows.Forms.Label lClientID;
        private System.Windows.Forms.Label lSecret;
        private System.Windows.Forms.CheckBox cbShowDeveloperOptions;
        public System.Windows.Forms.Label lOutlookCalendar;
        public System.Windows.Forms.TabPage tabOutlook;
        public System.Windows.Forms.CheckBox cbHideSplash;
        private System.Windows.Forms.Panel howObfuscatePanel;
        private System.Windows.Forms.ComboBox cbObfuscateDirection;
        private System.Windows.Forms.Label label31;
        public System.Windows.Forms.DataGridView dgObfuscateRegex;
        private System.Windows.Forms.DataGridViewTextBoxColumn regexFind;
        private System.Windows.Forms.DataGridViewTextBoxColumn regexReplace;
        private System.Windows.Forms.Panel howMorePanel;
        private System.Windows.Forms.DomainUpDown tbTargetCalendar;
        private System.Windows.Forms.CheckBox cbPrivate;
        private System.Windows.Forms.NumericUpDown tbStartupDelay;
        private System.Windows.Forms.CheckBox cbCloakEmail;
        private System.Windows.Forms.Label lWhatInfo;
        private System.Windows.Forms.CheckBox cbAvailable;
        private System.Windows.Forms.Label lTargetSyncCondition;
        private System.Windows.Forms.DomainUpDown tbCreatedItemsOnly;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel consolePanel;
        private System.Windows.Forms.WebBrowser consoleWebBrowser;
        private System.Windows.Forms.CheckBox cbMuteClicks;
        public System.Windows.Forms.WebBrowser GappBrowser;
        public System.Windows.Forms.Label lLastSyncVal;
        private System.Windows.Forms.CheckBox cbOnlyRespondedInvites;
        private System.Windows.Forms.CheckBox cbColour;
        private System.Windows.Forms.Panel panelSyncOptions;
        private System.Windows.Forms.PictureBox pbExpandHow;
        private System.Windows.Forms.PictureBox pbExpandWhat;
        private System.Windows.Forms.PictureBox pbExpandWhen;
        private System.Windows.Forms.Button btCloseRegexRules;
        private System.Windows.Forms.CheckBox cbAddColours;
        public Extensions.ColourPicker ddCategoryColour;
        private System.Windows.Forms.Label lDonateTip;
        private System.Windows.Forms.CheckBox cbLocation;
        public System.Windows.Forms.CheckBox cbCloudLogging;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox tbConnectedAcc;
    }
}
