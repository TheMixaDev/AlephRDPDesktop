namespace AlephRDPDesktop.View
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainPalette = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.titleLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.serverStatusLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.serverSettingsButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ipBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.portBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.nameBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.profileActionButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.connectButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.passwordBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pingLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
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
            // titleLabel
            // 
            this.titleLabel.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.titleLabel.Location = new System.Drawing.Point(100, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Palette = this.mainPalette;
            this.titleLabel.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.titleLabel.Size = new System.Drawing.Size(200, 50);
            this.titleLabel.StateCommon.ShortText.Font = new System.Drawing.Font("Play", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Values.Text = "AlephRDP";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(100, 42);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Palette = this.mainPalette;
            this.kryptonLabel1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.kryptonLabel1.Size = new System.Drawing.Size(325, 23);
            this.kryptonLabel1.TabIndex = 2;
            this.kryptonLabel1.Values.Text = "Подключение к удаленному компьютеру";
            // 
            // serverStatusLabel
            // 
            this.serverStatusLabel.AutoSize = false;
            this.serverStatusLabel.Location = new System.Drawing.Point(453, 42);
            this.serverStatusLabel.Name = "serverStatusLabel";
            this.serverStatusLabel.Palette = this.mainPalette;
            this.serverStatusLabel.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.serverStatusLabel.Size = new System.Drawing.Size(194, 23);
            this.serverStatusLabel.StateCommon.ShortText.Color1 = System.Drawing.Color.Red;
            this.serverStatusLabel.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.serverStatusLabel.StateCommon.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.serverStatusLabel.TabIndex = 4;
            this.serverStatusLabel.Values.Text = "Сервер выключен";
            // 
            // serverSettingsButton
            // 
            this.serverSettingsButton.Location = new System.Drawing.Point(453, 0);
            this.serverSettingsButton.Name = "serverSettingsButton";
            this.serverSettingsButton.Palette = this.mainPalette;
            this.serverSettingsButton.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.serverSettingsButton.Size = new System.Drawing.Size(194, 36);
            this.serverSettingsButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Play", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.serverSettingsButton.TabIndex = 5;
            this.serverSettingsButton.Values.Text = "Настройки";
            this.serverSettingsButton.Click += new System.EventHandler(this.serverSettingsButton_Click);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(8, 119);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Palette = this.mainPalette;
            this.kryptonLabel2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.kryptonLabel2.Size = new System.Drawing.Size(34, 26);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Play", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonLabel2.TabIndex = 6;
            this.kryptonLabel2.Values.Text = "IP:";
            // 
            // ipBox
            // 
            this.ipBox.Location = new System.Drawing.Point(48, 117);
            this.ipBox.Name = "ipBox";
            this.ipBox.Size = new System.Drawing.Size(158, 31);
            this.ipBox.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.ipBox.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ipBox.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ipBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ipBox.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.ipBox.StateCommon.Border.Rounding = 10;
            this.ipBox.StateCommon.Border.Width = 1;
            this.ipBox.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.ipBox.StateCommon.Content.Font = new System.Drawing.Font("Play", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ipBox.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 2, 10, 2);
            this.ipBox.TabIndex = 7;
            this.ipBox.Text = "192.168.0.1";
            // 
            // portBox
            // 
            this.portBox.Location = new System.Drawing.Point(281, 117);
            this.portBox.Name = "portBox";
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
            this.portBox.TabIndex = 9;
            this.portBox.Text = "12345";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(213, 121);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Palette = this.mainPalette;
            this.kryptonLabel4.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.kryptonLabel4.Size = new System.Drawing.Size(62, 26);
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Play", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonLabel4.TabIndex = 8;
            this.kryptonLabel4.Values.Text = "Порт:";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(116, 82);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(242, 31);
            this.nameBox.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.nameBox.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.nameBox.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.nameBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.nameBox.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.nameBox.StateCommon.Border.Rounding = 10;
            this.nameBox.StateCommon.Border.Width = 1;
            this.nameBox.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.nameBox.StateCommon.Content.Font = new System.Drawing.Font("Play", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameBox.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 2, 10, 2);
            this.nameBox.TabIndex = 11;
            this.nameBox.Text = "Новое подключение";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(5, 85);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Palette = this.mainPalette;
            this.kryptonLabel5.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.kryptonLabel5.Size = new System.Drawing.Size(105, 26);
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Play", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonLabel5.TabIndex = 10;
            this.kryptonLabel5.Values.Text = "Название:";
            // 
            // profileActionButton
            // 
            this.profileActionButton.Location = new System.Drawing.Point(375, 82);
            this.profileActionButton.Name = "profileActionButton";
            this.profileActionButton.Palette = this.mainPalette;
            this.profileActionButton.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.profileActionButton.Size = new System.Drawing.Size(264, 36);
            this.profileActionButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Play", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.profileActionButton.TabIndex = 12;
            this.profileActionButton.Values.Text = "Импорт профиля";
            this.profileActionButton.Click += new System.EventHandler(this.profileActionButton_Click);
            // 
            // connectButton
            // 
            this.connectButton.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom1;
            this.connectButton.Location = new System.Drawing.Point(375, 123);
            this.connectButton.Name = "connectButton";
            this.connectButton.Palette = this.mainPalette;
            this.connectButton.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.connectButton.Size = new System.Drawing.Size(264, 36);
            this.connectButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Play", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.connectButton.TabIndex = 13;
            this.connectButton.Values.Text = "Подключиться";
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(116, 151);
            this.passwordBox.Name = "passwordBox";
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
            this.passwordBox.TabIndex = 15;
            this.passwordBox.Text = "Пароль";
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(5, 154);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Palette = this.mainPalette;
            this.kryptonLabel6.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.kryptonLabel6.Size = new System.Drawing.Size(83, 26);
            this.kryptonLabel6.StateCommon.ShortText.Font = new System.Drawing.Font("Play", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonLabel6.TabIndex = 14;
            this.kryptonLabel6.Values.Text = "Пароль:";
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "AlephRDP";
            this.notifyIcon.Visible = true;
            this.notifyIcon.Click += new System.EventHandler(this.notifyIcon_Click);
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(389, 162);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 16);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pingLabel
            // 
            this.pingLabel.Location = new System.Drawing.Point(411, 159);
            this.pingLabel.Name = "pingLabel";
            this.pingLabel.Palette = this.mainPalette;
            this.pingLabel.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.pingLabel.Size = new System.Drawing.Size(124, 23);
            this.pingLabel.StateCommon.ShortText.Color1 = System.Drawing.Color.Gray;
            this.pingLabel.TabIndex = 17;
            this.pingLabel.Values.Text = "Нет связи с ПК";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(651, 183);
            this.Controls.Add(this.pingLabel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.kryptonLabel6);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.profileActionButton);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.kryptonLabel5);
            this.Controls.Add(this.portBox);
            this.Controls.Add(this.kryptonLabel4);
            this.Controls.Add(this.ipBox);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.serverSettingsButton);
            this.Controls.Add(this.serverStatusLabel);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.titleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Palette = this.mainPalette;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateCommon.Header.Content.ShortText.Color1 = System.Drawing.Color.Transparent;
            this.StateCommon.Header.Content.ShortText.Color2 = System.Drawing.Color.Transparent;
            this.Text = "AlephRDP";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette mainPalette;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel titleLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel serverStatusLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton serverSettingsButton;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ipBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox portBox;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox nameBox;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonButton profileActionButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton connectButton;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox passwordBox;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.PictureBox pictureBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel pingLabel;
    }
}