namespace AlephRDPDesktop.View
{
    partial class ClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            this.screenButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.consoleButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.itemsPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.uploadFileButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.mainPalette = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.itemsPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // screenButton
            // 
            this.screenButton.Location = new System.Drawing.Point(817, 3);
            this.screenButton.Name = "screenButton";
            this.screenButton.Palette = this.mainPalette;
            this.screenButton.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.screenButton.Size = new System.Drawing.Size(194, 36);
            this.screenButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Play", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.screenButton.TabIndex = 6;
            this.screenButton.Values.Text = "Экран";
            this.screenButton.Click += new System.EventHandler(this.screenButton_Click);
            // 
            // consoleButton
            // 
            this.consoleButton.Location = new System.Drawing.Point(11, 3);
            this.consoleButton.Name = "consoleButton";
            this.consoleButton.Palette = this.mainPalette;
            this.consoleButton.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.consoleButton.Size = new System.Drawing.Size(194, 36);
            this.consoleButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Play", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.consoleButton.TabIndex = 7;
            this.consoleButton.Values.Text = "Консоль";
            this.consoleButton.Click += new System.EventHandler(this.consoleButton_Click);
            // 
            // itemsPanel
            // 
            this.itemsPanel.Location = new System.Drawing.Point(11, 45);
            this.itemsPanel.Name = "itemsPanel";
            this.itemsPanel.Palette = this.mainPalette;
            this.itemsPanel.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.itemsPanel.Size = new System.Drawing.Size(1000, 562);
            this.itemsPanel.StateCommon.Color1 = System.Drawing.Color.Transparent;
            this.itemsPanel.StateCommon.Color2 = System.Drawing.Color.Transparent;
            this.itemsPanel.TabIndex = 8;
            // 
            // uploadFileButton
            // 
            this.uploadFileButton.Location = new System.Drawing.Point(211, 3);
            this.uploadFileButton.Name = "uploadFileButton";
            this.uploadFileButton.Palette = this.mainPalette;
            this.uploadFileButton.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.uploadFileButton.Size = new System.Drawing.Size(194, 36);
            this.uploadFileButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Play", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.uploadFileButton.TabIndex = 9;
            this.uploadFileButton.Values.Text = "Загрузить файл";
            this.uploadFileButton.Click += new System.EventHandler(this.uploadFileButton_Click);
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
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1024, 615);
            this.ControlBox = false;
            this.Controls.Add(this.uploadFileButton);
            this.Controls.Add(this.itemsPanel);
            this.Controls.Add(this.consoleButton);
            this.Controls.Add(this.screenButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClientForm";
            this.Palette = this.mainPalette;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.Text = "Связь с ПК";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemsPanel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonButton screenButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton consoleButton;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel itemsPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton uploadFileButton;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette mainPalette;
    }
}