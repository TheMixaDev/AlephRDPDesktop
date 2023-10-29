namespace AlephRDPDesktop.View
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.launchOnStartupBox = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.hideOnCloseBox = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.serverOnLaunchBox = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.portBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.notifyBox = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.periodicCheckBox = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.checkIntervalBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.intervalLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.intervalCLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.passwordBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.port2Box = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.serverButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.closeButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.hideDefaultBox = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.mainPalette = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.SuspendLayout();
            // 
            // launchOnStartupBox
            // 
            this.launchOnStartupBox.Checked = true;
            this.launchOnStartupBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.launchOnStartupBox.Images.CheckedDisabled = global::AlephRDPDesktop.Properties.Resources.checkbox_true;
            this.launchOnStartupBox.Images.CheckedNormal = ((System.Drawing.Image)(resources.GetObject("launchOnStartupBox.Images.CheckedNormal")));
            this.launchOnStartupBox.Images.CheckedPressed = global::AlephRDPDesktop.Properties.Resources.checkbox_true;
            this.launchOnStartupBox.Images.CheckedTracking = global::AlephRDPDesktop.Properties.Resources.checkbox_true;
            this.launchOnStartupBox.Images.UncheckedDisabled = global::AlephRDPDesktop.Properties.Resources.checkbox_false;
            this.launchOnStartupBox.Images.UncheckedNormal = ((System.Drawing.Image)(resources.GetObject("launchOnStartupBox.Images.UncheckedNormal")));
            this.launchOnStartupBox.Images.UncheckedPressed = global::AlephRDPDesktop.Properties.Resources.checkbox_false;
            this.launchOnStartupBox.Images.UncheckedTracking = global::AlephRDPDesktop.Properties.Resources.checkbox_false;
            this.launchOnStartupBox.Location = new System.Drawing.Point(12, 12);
            this.launchOnStartupBox.Name = "launchOnStartupBox";
            this.launchOnStartupBox.Palette = this.mainPalette;
            this.launchOnStartupBox.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.launchOnStartupBox.Size = new System.Drawing.Size(295, 32);
            this.launchOnStartupBox.StateNormal.ShortText.Font = new System.Drawing.Font("Play", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.launchOnStartupBox.TabIndex = 0;
            this.launchOnStartupBox.Values.Text = "Запускать AlephRDP при включении ПК";
            this.launchOnStartupBox.CheckedChanged += new System.EventHandler(this.launchOnStartupBox_CheckedChanged);
            // 
            // hideOnCloseBox
            // 
            this.hideOnCloseBox.Checked = true;
            this.hideOnCloseBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hideOnCloseBox.Images.CheckedDisabled = global::AlephRDPDesktop.Properties.Resources.checkbox_true;
            this.hideOnCloseBox.Images.CheckedNormal = ((System.Drawing.Image)(resources.GetObject("hideOnCloseBox.Images.CheckedNormal")));
            this.hideOnCloseBox.Images.CheckedPressed = global::AlephRDPDesktop.Properties.Resources.checkbox_true;
            this.hideOnCloseBox.Images.CheckedTracking = global::AlephRDPDesktop.Properties.Resources.checkbox_true;
            this.hideOnCloseBox.Images.UncheckedDisabled = global::AlephRDPDesktop.Properties.Resources.checkbox_false;
            this.hideOnCloseBox.Images.UncheckedNormal = ((System.Drawing.Image)(resources.GetObject("hideOnCloseBox.Images.UncheckedNormal")));
            this.hideOnCloseBox.Images.UncheckedPressed = global::AlephRDPDesktop.Properties.Resources.checkbox_false;
            this.hideOnCloseBox.Images.UncheckedTracking = global::AlephRDPDesktop.Properties.Resources.checkbox_false;
            this.hideOnCloseBox.Location = new System.Drawing.Point(12, 88);
            this.hideOnCloseBox.Name = "hideOnCloseBox";
            this.hideOnCloseBox.Palette = this.mainPalette;
            this.hideOnCloseBox.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.hideOnCloseBox.Size = new System.Drawing.Size(294, 32);
            this.hideOnCloseBox.StateNormal.ShortText.Font = new System.Drawing.Font("Play", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hideOnCloseBox.TabIndex = 1;
            this.hideOnCloseBox.Values.Text = "Скрывать в панель задач при закрытии";
            this.hideOnCloseBox.CheckedChanged += new System.EventHandler(this.hideOnCloseBox_CheckedChanged);
            // 
            // serverOnLaunchBox
            // 
            this.serverOnLaunchBox.Images.CheckedDisabled = global::AlephRDPDesktop.Properties.Resources.checkbox_true;
            this.serverOnLaunchBox.Images.CheckedNormal = ((System.Drawing.Image)(resources.GetObject("serverOnLaunchBox.Images.CheckedNormal")));
            this.serverOnLaunchBox.Images.CheckedPressed = global::AlephRDPDesktop.Properties.Resources.checkbox_true;
            this.serverOnLaunchBox.Images.CheckedTracking = global::AlephRDPDesktop.Properties.Resources.checkbox_true;
            this.serverOnLaunchBox.Images.UncheckedDisabled = global::AlephRDPDesktop.Properties.Resources.checkbox_false;
            this.serverOnLaunchBox.Images.UncheckedNormal = ((System.Drawing.Image)(resources.GetObject("serverOnLaunchBox.Images.UncheckedNormal")));
            this.serverOnLaunchBox.Images.UncheckedPressed = global::AlephRDPDesktop.Properties.Resources.checkbox_false;
            this.serverOnLaunchBox.Images.UncheckedTracking = global::AlephRDPDesktop.Properties.Resources.checkbox_false;
            this.serverOnLaunchBox.Location = new System.Drawing.Point(12, 126);
            this.serverOnLaunchBox.Name = "serverOnLaunchBox";
            this.serverOnLaunchBox.Palette = this.mainPalette;
            this.serverOnLaunchBox.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.serverOnLaunchBox.Size = new System.Drawing.Size(251, 32);
            this.serverOnLaunchBox.StateNormal.ShortText.Font = new System.Drawing.Font("Play", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.serverOnLaunchBox.TabIndex = 2;
            this.serverOnLaunchBox.Values.Text = "Автоматический запуск сервера";
            this.serverOnLaunchBox.CheckedChanged += new System.EventHandler(this.serverOnLaunchBox_CheckedChanged);
            // 
            // portBox
            // 
            this.portBox.Location = new System.Drawing.Point(85, 303);
            this.portBox.Name = "portBox";
            this.portBox.Palette = this.mainPalette;
            this.portBox.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.portBox.Size = new System.Drawing.Size(77, 31);
            this.portBox.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.portBox.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.portBox.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.portBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.portBox.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.portBox.StateCommon.Border.Rounding = 10;
            this.portBox.StateCommon.Border.Width = 1;
            this.portBox.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.portBox.StateCommon.Content.Font = new System.Drawing.Font("Play", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.portBox.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 2, 10, 2);
            this.portBox.TabIndex = 11;
            this.portBox.Text = "727";
            this.portBox.TextChanged += new System.EventHandler(this.portBox_TextChanged);
            // 
            // notifyBox
            // 
            this.notifyBox.Checked = true;
            this.notifyBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.notifyBox.Images.CheckedDisabled = global::AlephRDPDesktop.Properties.Resources.checkbox_true;
            this.notifyBox.Images.CheckedNormal = ((System.Drawing.Image)(resources.GetObject("notifyBox.Images.CheckedNormal")));
            this.notifyBox.Images.CheckedPressed = global::AlephRDPDesktop.Properties.Resources.checkbox_true;
            this.notifyBox.Images.CheckedTracking = global::AlephRDPDesktop.Properties.Resources.checkbox_true;
            this.notifyBox.Images.UncheckedDisabled = global::AlephRDPDesktop.Properties.Resources.checkbox_false;
            this.notifyBox.Images.UncheckedNormal = ((System.Drawing.Image)(resources.GetObject("notifyBox.Images.UncheckedNormal")));
            this.notifyBox.Images.UncheckedPressed = global::AlephRDPDesktop.Properties.Resources.checkbox_false;
            this.notifyBox.Images.UncheckedTracking = global::AlephRDPDesktop.Properties.Resources.checkbox_false;
            this.notifyBox.Location = new System.Drawing.Point(12, 164);
            this.notifyBox.Name = "notifyBox";
            this.notifyBox.Palette = this.mainPalette;
            this.notifyBox.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.notifyBox.Size = new System.Drawing.Size(272, 32);
            this.notifyBox.StateNormal.ShortText.Font = new System.Drawing.Font("Play", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.notifyBox.TabIndex = 12;
            this.notifyBox.Values.Text = "Уведомлять о новых подключениях";
            this.notifyBox.CheckedChanged += new System.EventHandler(this.notifyBox_CheckedChanged);
            // 
            // periodicCheckBox
            // 
            this.periodicCheckBox.Checked = true;
            this.periodicCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.periodicCheckBox.Images.CheckedDisabled = global::AlephRDPDesktop.Properties.Resources.checkbox_true;
            this.periodicCheckBox.Images.CheckedNormal = ((System.Drawing.Image)(resources.GetObject("periodicCheckBox.Images.CheckedNormal")));
            this.periodicCheckBox.Images.CheckedPressed = global::AlephRDPDesktop.Properties.Resources.checkbox_true;
            this.periodicCheckBox.Images.CheckedTracking = global::AlephRDPDesktop.Properties.Resources.checkbox_true;
            this.periodicCheckBox.Images.UncheckedDisabled = global::AlephRDPDesktop.Properties.Resources.checkbox_false;
            this.periodicCheckBox.Images.UncheckedNormal = ((System.Drawing.Image)(resources.GetObject("periodicCheckBox.Images.UncheckedNormal")));
            this.periodicCheckBox.Images.UncheckedPressed = global::AlephRDPDesktop.Properties.Resources.checkbox_false;
            this.periodicCheckBox.Images.UncheckedTracking = global::AlephRDPDesktop.Properties.Resources.checkbox_false;
            this.periodicCheckBox.Location = new System.Drawing.Point(12, 202);
            this.periodicCheckBox.Name = "periodicCheckBox";
            this.periodicCheckBox.Palette = this.mainPalette;
            this.periodicCheckBox.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.periodicCheckBox.Size = new System.Drawing.Size(309, 32);
            this.periodicCheckBox.StateNormal.ShortText.Font = new System.Drawing.Font("Play", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.periodicCheckBox.TabIndex = 13;
            this.periodicCheckBox.Values.Text = "Периодически проверять доступность ПК";
            this.periodicCheckBox.CheckedChanged += new System.EventHandler(this.periodicCheckBox_CheckedChanged);
            // 
            // checkIntervalBox
            // 
            this.checkIntervalBox.Location = new System.Drawing.Point(173, 239);
            this.checkIntervalBox.Name = "checkIntervalBox";
            this.checkIntervalBox.Palette = this.mainPalette;
            this.checkIntervalBox.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.checkIntervalBox.Size = new System.Drawing.Size(76, 31);
            this.checkIntervalBox.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.checkIntervalBox.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.checkIntervalBox.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.checkIntervalBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.checkIntervalBox.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.checkIntervalBox.StateCommon.Border.Rounding = 10;
            this.checkIntervalBox.StateCommon.Border.Width = 1;
            this.checkIntervalBox.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.checkIntervalBox.StateCommon.Content.Font = new System.Drawing.Font("Play", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkIntervalBox.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 2, 10, 2);
            this.checkIntervalBox.TabIndex = 15;
            this.checkIntervalBox.Text = "120";
            this.checkIntervalBox.TextChanged += new System.EventHandler(this.checkIntervalBox_TextChanged);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(76, 276);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Palette = this.mainPalette;
            this.kryptonLabel2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.kryptonLabel2.Size = new System.Drawing.Size(187, 26);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Play", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonLabel2.TabIndex = 14;
            this.kryptonLabel2.Values.Text = "Настройки сервера";
            // 
            // intervalLabel
            // 
            this.intervalLabel.Location = new System.Drawing.Point(12, 244);
            this.intervalLabel.Name = "intervalLabel";
            this.intervalLabel.Palette = this.mainPalette;
            this.intervalLabel.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.intervalLabel.Size = new System.Drawing.Size(169, 23);
            this.intervalLabel.TabIndex = 3;
            this.intervalLabel.Values.Text = "Интервал проверки:";
            // 
            // intervalCLabel
            // 
            this.intervalCLabel.Location = new System.Drawing.Point(255, 244);
            this.intervalCLabel.Name = "intervalCLabel";
            this.intervalCLabel.Palette = this.mainPalette;
            this.intervalCLabel.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.intervalCLabel.Size = new System.Drawing.Size(24, 23);
            this.intervalCLabel.TabIndex = 16;
            this.intervalCLabel.Values.Text = "с.";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(12, 308);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Palette = this.mainPalette;
            this.kryptonLabel4.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.kryptonLabel4.Size = new System.Drawing.Size(54, 23);
            this.kryptonLabel4.TabIndex = 17;
            this.kryptonLabel4.Values.Text = "Порт:";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(12, 346);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Palette = this.mainPalette;
            this.kryptonLabel5.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.kryptonLabel5.Size = new System.Drawing.Size(72, 23);
            this.kryptonLabel5.TabIndex = 18;
            this.kryptonLabel5.Values.Text = "Пароль:";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(85, 340);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Palette = this.mainPalette;
            this.passwordBox.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(242, 31);
            this.passwordBox.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.passwordBox.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.passwordBox.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.passwordBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.passwordBox.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.passwordBox.StateCommon.Border.Rounding = 10;
            this.passwordBox.StateCommon.Border.Width = 1;
            this.passwordBox.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.passwordBox.StateCommon.Content.Font = new System.Drawing.Font("Play", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordBox.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 2, 10, 2);
            this.passwordBox.TabIndex = 19;
            this.passwordBox.Text = "password";
            this.passwordBox.TextChanged += new System.EventHandler(this.passwordBox_TextChanged);
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(173, 308);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Palette = this.mainPalette;
            this.kryptonLabel6.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.kryptonLabel6.Size = new System.Drawing.Size(68, 23);
            this.kryptonLabel6.TabIndex = 20;
            this.kryptonLabel6.Values.Text = "Порт 2:";
            // 
            // port2Box
            // 
            this.port2Box.Enabled = false;
            this.port2Box.Location = new System.Drawing.Point(250, 303);
            this.port2Box.Name = "port2Box";
            this.port2Box.Palette = this.mainPalette;
            this.port2Box.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.port2Box.Size = new System.Drawing.Size(77, 31);
            this.port2Box.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.port2Box.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.port2Box.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.port2Box.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.port2Box.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.port2Box.StateCommon.Border.Rounding = 10;
            this.port2Box.StateCommon.Border.Width = 1;
            this.port2Box.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.port2Box.StateCommon.Content.Font = new System.Drawing.Font("Play", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.port2Box.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 2, 10, 2);
            this.port2Box.TabIndex = 21;
            this.port2Box.Text = "728";
            // 
            // serverButton
            // 
            this.serverButton.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom1;
            this.serverButton.Location = new System.Drawing.Point(42, 377);
            this.serverButton.Name = "serverButton";
            this.serverButton.Palette = this.mainPalette;
            this.serverButton.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.serverButton.Size = new System.Drawing.Size(264, 36);
            this.serverButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Play", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.serverButton.TabIndex = 22;
            this.serverButton.Values.Text = "Запустить сервер";
            this.serverButton.Click += new System.EventHandler(this.serverButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom2;
            this.closeButton.Location = new System.Drawing.Point(43, 419);
            this.closeButton.Name = "closeButton";
            this.closeButton.Palette = this.mainPalette;
            this.closeButton.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.closeButton.Size = new System.Drawing.Size(264, 36);
            this.closeButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Play", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.TabIndex = 23;
            this.closeButton.Values.Text = "Выход";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // hideDefaultBox
            // 
            this.hideDefaultBox.Checked = true;
            this.hideDefaultBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hideDefaultBox.Images.CheckedDisabled = ((System.Drawing.Image)(resources.GetObject("hideDefaultBox.Images.CheckedDisabled")));
            this.hideDefaultBox.Images.CheckedNormal = ((System.Drawing.Image)(resources.GetObject("hideDefaultBox.Images.CheckedNormal")));
            this.hideDefaultBox.Images.CheckedPressed = ((System.Drawing.Image)(resources.GetObject("hideDefaultBox.Images.CheckedPressed")));
            this.hideDefaultBox.Images.CheckedTracking = ((System.Drawing.Image)(resources.GetObject("hideDefaultBox.Images.CheckedTracking")));
            this.hideDefaultBox.Images.UncheckedDisabled = ((System.Drawing.Image)(resources.GetObject("hideDefaultBox.Images.UncheckedDisabled")));
            this.hideDefaultBox.Images.UncheckedNormal = ((System.Drawing.Image)(resources.GetObject("hideDefaultBox.Images.UncheckedNormal")));
            this.hideDefaultBox.Images.UncheckedPressed = ((System.Drawing.Image)(resources.GetObject("hideDefaultBox.Images.UncheckedPressed")));
            this.hideDefaultBox.Images.UncheckedTracking = ((System.Drawing.Image)(resources.GetObject("hideDefaultBox.Images.UncheckedTracking")));
            this.hideDefaultBox.Location = new System.Drawing.Point(12, 50);
            this.hideDefaultBox.Name = "hideDefaultBox";
            this.hideDefaultBox.Palette = this.mainPalette;
            this.hideDefaultBox.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.hideDefaultBox.Size = new System.Drawing.Size(244, 32);
            this.hideDefaultBox.StateNormal.ShortText.Font = new System.Drawing.Font("Play", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hideDefaultBox.TabIndex = 24;
            this.hideDefaultBox.Values.Text = "Запускать в свернутом режиме";
            this.hideDefaultBox.CheckedChanged += new System.EventHandler(this.hideDefaultBox_CheckedChanged);
            // 
            // mainPalette
            // 
            this.mainPalette.ButtonSpecs.FormClose.Image = ((System.Drawing.Image)(resources.GetObject("mainPalette.ButtonSpecs.FormClose.Image")));
            this.mainPalette.ButtonSpecs.FormMax.Image = global::AlephRDPDesktop.Properties.Resources.yellow_circle;
            this.mainPalette.ButtonSpecs.FormMin.Image = global::AlephRDPDesktop.Properties.Resources.green_circle;
            this.mainPalette.ButtonStyles.ButtonCustom1.OverrideDefault.Back.Color1 = System.Drawing.Color.Green;
            this.mainPalette.ButtonStyles.ButtonCustom1.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.mainPalette.ButtonStyles.ButtonCustom1.OverrideDefault.Back.ColorAngle = 45F;
            this.mainPalette.ButtonStyles.ButtonCustom1.OverrideDefault.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.mainPalette.ButtonStyles.ButtonCustom1.OverrideDefault.Border.Color1 = System.Drawing.Color.Green;
            this.mainPalette.ButtonStyles.ButtonCustom1.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.mainPalette.ButtonStyles.ButtonCustom1.OverrideDefault.Border.ColorAngle = 45F;
            this.mainPalette.ButtonStyles.ButtonCustom1.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.mainPalette.ButtonStyles.ButtonCustom1.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.mainPalette.ButtonStyles.ButtonCustom1.OverrideDefault.Border.Rounding = 20;
            this.mainPalette.ButtonStyles.ButtonCustom1.OverrideDefault.Border.Width = 1;
            this.mainPalette.ButtonStyles.ButtonCustom1.OverrideFocus.Back.Color1 = System.Drawing.Color.Lime;
            this.mainPalette.ButtonStyles.ButtonCustom1.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.mainPalette.ButtonStyles.ButtonCustom1.OverrideFocus.Back.ColorAngle = 45F;
            this.mainPalette.ButtonStyles.ButtonCustom1.OverrideFocus.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.mainPalette.ButtonStyles.ButtonCustom1.OverrideFocus.Border.Color1 = System.Drawing.Color.Lime;
            this.mainPalette.ButtonStyles.ButtonCustom1.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.mainPalette.ButtonStyles.ButtonCustom1.OverrideFocus.Border.ColorAngle = 45F;
            this.mainPalette.ButtonStyles.ButtonCustom1.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.mainPalette.ButtonStyles.ButtonCustom1.OverrideFocus.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.mainPalette.ButtonStyles.ButtonCustom1.OverrideFocus.Border.Rounding = 20;
            this.mainPalette.ButtonStyles.ButtonCustom1.OverrideFocus.Border.Width = 1;
            this.mainPalette.ButtonStyles.ButtonCustom1.StateCommon.Back.Color1 = System.Drawing.Color.Green;
            this.mainPalette.ButtonStyles.ButtonCustom1.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.mainPalette.ButtonStyles.ButtonCustom1.StateCommon.Back.ColorAngle = 45F;
            this.mainPalette.ButtonStyles.ButtonCustom1.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.mainPalette.ButtonStyles.ButtonCustom1.StateCommon.Border.Color1 = System.Drawing.Color.Green;
            this.mainPalette.ButtonStyles.ButtonCustom1.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.mainPalette.ButtonStyles.ButtonCustom1.StateCommon.Border.ColorAngle = 45F;
            this.mainPalette.ButtonStyles.ButtonCustom1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.mainPalette.ButtonStyles.ButtonCustom1.StateCommon.Border.Rounding = 20;
            this.mainPalette.ButtonStyles.ButtonCustom1.StateCommon.Border.Width = 1;
            this.mainPalette.ButtonStyles.ButtonCustom1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.mainPalette.ButtonStyles.ButtonCustom1.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.mainPalette.ButtonStyles.ButtonCustom2.OverrideDefault.Back.Color1 = System.Drawing.Color.Maroon;
            this.mainPalette.ButtonStyles.ButtonCustom2.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mainPalette.ButtonStyles.ButtonCustom2.OverrideDefault.Back.ColorAngle = 45F;
            this.mainPalette.ButtonStyles.ButtonCustom2.OverrideDefault.Border.Color1 = System.Drawing.Color.Maroon;
            this.mainPalette.ButtonStyles.ButtonCustom2.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mainPalette.ButtonStyles.ButtonCustom2.OverrideDefault.Border.ColorAngle = 45F;
            this.mainPalette.ButtonStyles.ButtonCustom2.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.mainPalette.ButtonStyles.ButtonCustom2.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.mainPalette.ButtonStyles.ButtonCustom2.OverrideDefault.Border.Rounding = 20;
            this.mainPalette.ButtonStyles.ButtonCustom2.OverrideDefault.Border.Width = 1;
            this.mainPalette.ButtonStyles.ButtonCustom2.OverrideFocus.Back.Color1 = System.Drawing.Color.Maroon;
            this.mainPalette.ButtonStyles.ButtonCustom2.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mainPalette.ButtonStyles.ButtonCustom2.OverrideFocus.Back.ColorAngle = 45F;
            this.mainPalette.ButtonStyles.ButtonCustom2.OverrideFocus.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.mainPalette.ButtonStyles.ButtonCustom2.OverrideFocus.Border.Color1 = System.Drawing.Color.Maroon;
            this.mainPalette.ButtonStyles.ButtonCustom2.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mainPalette.ButtonStyles.ButtonCustom2.OverrideFocus.Border.ColorAngle = 45F;
            this.mainPalette.ButtonStyles.ButtonCustom2.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.mainPalette.ButtonStyles.ButtonCustom2.OverrideFocus.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.mainPalette.ButtonStyles.ButtonCustom2.OverrideFocus.Border.Rounding = 20;
            this.mainPalette.ButtonStyles.ButtonCustom2.OverrideFocus.Border.Width = 1;
            this.mainPalette.ButtonStyles.ButtonCustom2.StateCommon.Back.Color1 = System.Drawing.Color.Maroon;
            this.mainPalette.ButtonStyles.ButtonCustom2.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mainPalette.ButtonStyles.ButtonCustom2.StateCommon.Back.ColorAngle = 45F;
            this.mainPalette.ButtonStyles.ButtonCustom2.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.mainPalette.ButtonStyles.ButtonCustom2.StateCommon.Border.Color1 = System.Drawing.Color.Maroon;
            this.mainPalette.ButtonStyles.ButtonCustom2.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mainPalette.ButtonStyles.ButtonCustom2.StateCommon.Border.ColorAngle = 45F;
            this.mainPalette.ButtonStyles.ButtonCustom2.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.mainPalette.ButtonStyles.ButtonCustom2.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.mainPalette.ButtonStyles.ButtonCustom2.StateCommon.Border.Rounding = 20;
            this.mainPalette.ButtonStyles.ButtonCustom2.StateCommon.Border.Width = 1;
            this.mainPalette.ButtonStyles.ButtonCustom2.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.mainPalette.ButtonStyles.ButtonCustom2.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.mainPalette.ButtonStyles.ButtonForm.StateCommon.Back.Color1 = System.Drawing.Color.Black;
            this.mainPalette.ButtonStyles.ButtonForm.StateCommon.Back.Color2 = System.Drawing.Color.Black;
            this.mainPalette.ButtonStyles.ButtonForm.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.mainPalette.ButtonStyles.ButtonForm.StateCommon.Border.Width = 0;
            this.mainPalette.ButtonStyles.ButtonForm.StatePressed.Back.Color1 = System.Drawing.Color.Black;
            this.mainPalette.ButtonStyles.ButtonForm.StatePressed.Back.Color2 = System.Drawing.Color.Black;
            this.mainPalette.ButtonStyles.ButtonForm.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.mainPalette.ButtonStyles.ButtonForm.StatePressed.Border.Width = 0;
            this.mainPalette.ButtonStyles.ButtonForm.StateTracking.Back.Color1 = System.Drawing.Color.Black;
            this.mainPalette.ButtonStyles.ButtonForm.StateTracking.Back.Color2 = System.Drawing.Color.Black;
            this.mainPalette.ButtonStyles.ButtonForm.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.mainPalette.ButtonStyles.ButtonForm.StateTracking.Border.Width = 0;
            this.mainPalette.ButtonStyles.ButtonStandalone.OverrideDefault.Back.Color1 = System.Drawing.Color.Teal;
            this.mainPalette.ButtonStyles.ButtonStandalone.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mainPalette.ButtonStyles.ButtonStandalone.OverrideDefault.Back.ColorAngle = 45F;
            this.mainPalette.ButtonStyles.ButtonStandalone.OverrideDefault.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.mainPalette.ButtonStyles.ButtonStandalone.OverrideDefault.Border.Color1 = System.Drawing.Color.Teal;
            this.mainPalette.ButtonStyles.ButtonStandalone.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mainPalette.ButtonStyles.ButtonStandalone.OverrideDefault.Border.ColorAngle = 45F;
            this.mainPalette.ButtonStyles.ButtonStandalone.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.mainPalette.ButtonStyles.ButtonStandalone.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.mainPalette.ButtonStyles.ButtonStandalone.OverrideDefault.Border.Rounding = 20;
            this.mainPalette.ButtonStyles.ButtonStandalone.OverrideDefault.Border.Width = 1;
            this.mainPalette.ButtonStyles.ButtonStandalone.OverrideFocus.Back.Color1 = System.Drawing.Color.Teal;
            this.mainPalette.ButtonStyles.ButtonStandalone.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mainPalette.ButtonStyles.ButtonStandalone.OverrideFocus.Back.ColorAngle = 45F;
            this.mainPalette.ButtonStyles.ButtonStandalone.OverrideFocus.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.mainPalette.ButtonStyles.ButtonStandalone.OverrideFocus.Border.Color1 = System.Drawing.Color.Aqua;
            this.mainPalette.ButtonStyles.ButtonStandalone.OverrideFocus.Border.Color2 = System.Drawing.Color.Teal;
            this.mainPalette.ButtonStyles.ButtonStandalone.OverrideFocus.Border.ColorAngle = 45F;
            this.mainPalette.ButtonStyles.ButtonStandalone.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.mainPalette.ButtonStyles.ButtonStandalone.OverrideFocus.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.mainPalette.ButtonStyles.ButtonStandalone.OverrideFocus.Border.Rounding = 20;
            this.mainPalette.ButtonStyles.ButtonStandalone.OverrideFocus.Border.Width = 1;
            this.mainPalette.ButtonStyles.ButtonStandalone.StateCommon.Back.Color1 = System.Drawing.Color.Teal;
            this.mainPalette.ButtonStyles.ButtonStandalone.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mainPalette.ButtonStyles.ButtonStandalone.StateCommon.Back.ColorAngle = 45F;
            this.mainPalette.ButtonStyles.ButtonStandalone.StateCommon.Border.Color1 = System.Drawing.Color.Teal;
            this.mainPalette.ButtonStyles.ButtonStandalone.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mainPalette.ButtonStyles.ButtonStandalone.StateCommon.Border.ColorAngle = 45F;
            this.mainPalette.ButtonStyles.ButtonStandalone.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.mainPalette.ButtonStyles.ButtonStandalone.StateCommon.Border.Rounding = 20;
            this.mainPalette.ButtonStyles.ButtonStandalone.StateCommon.Border.Width = 1;
            this.mainPalette.ButtonStyles.ButtonStandalone.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.mainPalette.ButtonStyles.ButtonStandalone.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.mainPalette.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.Black;
            this.mainPalette.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.Black;
            this.mainPalette.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.mainPalette.FormStyles.FormMain.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.mainPalette.FormStyles.FormMain.StateCommon.Border.Rounding = 12;
            this.mainPalette.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.Black;
            this.mainPalette.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.Black;
            this.mainPalette.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            this.mainPalette.HeaderStyles.HeaderForm.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.mainPalette.HeaderStyles.HeaderForm.StateCommon.Content.LongText.Color2 = System.Drawing.Color.White;
            this.mainPalette.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.mainPalette.HeaderStyles.HeaderForm.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.mainPalette.HeaderStyles.HeaderForm.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.mainPalette.LabelStyles.LabelCommon.StateCommon.LongText.Color1 = System.Drawing.Color.White;
            this.mainPalette.LabelStyles.LabelCommon.StateCommon.LongText.Color2 = System.Drawing.Color.White;
            this.mainPalette.LabelStyles.LabelCommon.StateCommon.LongText.Font = new System.Drawing.Font("Play", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainPalette.LabelStyles.LabelCommon.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.mainPalette.LabelStyles.LabelCommon.StateCommon.ShortText.Color2 = System.Drawing.Color.White;
            this.mainPalette.LabelStyles.LabelCommon.StateCommon.ShortText.Font = new System.Drawing.Font("Play", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainPalette.LabelStyles.LabelCommon.StateNormal.LongText.Color1 = System.Drawing.Color.White;
            this.mainPalette.LabelStyles.LabelCommon.StateNormal.LongText.Color2 = System.Drawing.Color.White;
            this.mainPalette.LabelStyles.LabelCommon.StateNormal.ShortText.Color1 = System.Drawing.Color.White;
            this.mainPalette.LabelStyles.LabelCommon.StateNormal.ShortText.Color2 = System.Drawing.Color.White;
            this.mainPalette.LabelStyles.LabelCustom1.StateCommon.LongText.Color1 = System.Drawing.Color.White;
            this.mainPalette.LabelStyles.LabelCustom1.StateCommon.LongText.Color2 = System.Drawing.Color.White;
            this.mainPalette.LabelStyles.LabelCustom1.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.mainPalette.LabelStyles.LabelCustom1.StateCommon.ShortText.Color2 = System.Drawing.Color.White;
            this.mainPalette.LabelStyles.LabelNormalControl.StateCommon.LongText.Color1 = System.Drawing.Color.White;
            this.mainPalette.LabelStyles.LabelNormalControl.StateCommon.LongText.Color2 = System.Drawing.Color.White;
            this.mainPalette.LabelStyles.LabelNormalControl.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.mainPalette.LabelStyles.LabelNormalControl.StateCommon.ShortText.Color2 = System.Drawing.Color.White;
            this.mainPalette.LabelStyles.LabelNormalControl.StateDisabled.LongText.Color1 = System.Drawing.Color.White;
            this.mainPalette.LabelStyles.LabelNormalControl.StateDisabled.LongText.Color2 = System.Drawing.Color.White;
            this.mainPalette.LabelStyles.LabelNormalControl.StateDisabled.ShortText.Color1 = System.Drawing.Color.White;
            this.mainPalette.LabelStyles.LabelNormalControl.StateDisabled.ShortText.Color2 = System.Drawing.Color.White;
            this.mainPalette.LabelStyles.LabelNormalControl.StateNormal.LongText.Color1 = System.Drawing.Color.White;
            this.mainPalette.LabelStyles.LabelNormalControl.StateNormal.LongText.Color2 = System.Drawing.Color.White;
            this.mainPalette.LabelStyles.LabelNormalControl.StateNormal.ShortText.Color1 = System.Drawing.Color.White;
            this.mainPalette.LabelStyles.LabelNormalControl.StateNormal.ShortText.Color2 = System.Drawing.Color.White;
            this.mainPalette.LabelStyles.LabelTitleControl.StateCommon.LongText.Color1 = System.Drawing.Color.White;
            this.mainPalette.LabelStyles.LabelTitleControl.StateCommon.LongText.Color2 = System.Drawing.Color.White;
            this.mainPalette.LabelStyles.LabelTitleControl.StateCommon.LongText.Font = new System.Drawing.Font("Play", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainPalette.LabelStyles.LabelTitleControl.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.mainPalette.LabelStyles.LabelTitleControl.StateCommon.ShortText.Color2 = System.Drawing.Color.White;
            this.mainPalette.LabelStyles.LabelTitleControl.StateCommon.ShortText.Font = new System.Drawing.Font("Play", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(340, 459);
            this.Controls.Add(this.hideDefaultBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.serverButton);
            this.Controls.Add(this.port2Box);
            this.Controls.Add(this.kryptonLabel6);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.kryptonLabel5);
            this.Controls.Add(this.kryptonLabel4);
            this.Controls.Add(this.intervalCLabel);
            this.Controls.Add(this.checkIntervalBox);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.periodicCheckBox);
            this.Controls.Add(this.notifyBox);
            this.Controls.Add(this.portBox);
            this.Controls.Add(this.intervalLabel);
            this.Controls.Add(this.serverOnLaunchBox);
            this.Controls.Add(this.hideOnCloseBox);
            this.Controls.Add(this.launchOnStartupBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.Palette = this.mainPalette;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Настройки";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SettingsForm_FormClosed);
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox launchOnStartupBox;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox hideOnCloseBox;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox serverOnLaunchBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox portBox;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox notifyBox;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox periodicCheckBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox checkIntervalBox;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel intervalLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel intervalCLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox passwordBox;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox port2Box;
        private ComponentFactory.Krypton.Toolkit.KryptonButton serverButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton closeButton;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox hideDefaultBox;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette mainPalette;
    }
}