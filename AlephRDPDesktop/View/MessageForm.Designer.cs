namespace AlephRDPDesktop.View
{
    partial class MessageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageForm));
            this.notifyLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.closeButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.mainPallette = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.SuspendLayout();
            // 
            // notifyLabel
            // 
            this.notifyLabel.AutoSize = false;
            this.notifyLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.notifyLabel.Location = new System.Drawing.Point(0, 0);
            this.notifyLabel.Name = "notifyLabel";
            this.notifyLabel.Palette = this.mainPallette;
            this.notifyLabel.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.notifyLabel.Size = new System.Drawing.Size(588, 24);
            this.notifyLabel.StateCommon.LongText.MultiLine = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.notifyLabel.StateCommon.LongText.MultiLineH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.notifyLabel.StateCommon.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.notifyLabel.StateCommon.LongText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.notifyLabel.StateCommon.ShortText.MultiLine = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.notifyLabel.StateCommon.ShortText.MultiLineH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.notifyLabel.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.notifyLabel.StateCommon.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.notifyLabel.StateCommon.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Word;
            this.notifyLabel.TabIndex = 0;
            this.notifyLabel.Values.Text = "Текст";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(196, 30);
            this.closeButton.Name = "closeButton";
            this.closeButton.OverrideDefault.Back.Color1 = System.Drawing.Color.Cyan;
            this.closeButton.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.closeButton.OverrideFocus.Back.Color1 = System.Drawing.Color.Cyan;
            this.closeButton.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.closeButton.Palette = this.mainPallette;
            this.closeButton.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.closeButton.Size = new System.Drawing.Size(194, 36);
            this.closeButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Play", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.StateNormal.Back.Color1 = System.Drawing.Color.Cyan;
            this.closeButton.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.closeButton.StatePressed.Back.Color1 = System.Drawing.Color.Cyan;
            this.closeButton.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.closeButton.StateTracking.Back.Color1 = System.Drawing.Color.Cyan;
            this.closeButton.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.closeButton.TabIndex = 6;
            this.closeButton.Values.Text = "ОК";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // mainPallette
            // 
            this.mainPallette.ButtonSpecs.FormClose.Image = ((System.Drawing.Image)(resources.GetObject("kryptonPalette1.ButtonSpecs.FormClose.Image")));
            this.mainPallette.ButtonSpecs.FormMax.Image = global::AlephRDPDesktop.Properties.Resources.yellow_circle;
            this.mainPallette.ButtonSpecs.FormMin.Image = global::AlephRDPDesktop.Properties.Resources.green_circle;
            this.mainPallette.ButtonStyles.ButtonForm.StateCommon.Back.Color1 = System.Drawing.Color.Black;
            this.mainPallette.ButtonStyles.ButtonForm.StateCommon.Back.Color2 = System.Drawing.Color.Black;
            this.mainPallette.ButtonStyles.ButtonForm.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.mainPallette.ButtonStyles.ButtonForm.StateCommon.Border.Width = 0;
            this.mainPallette.ButtonStyles.ButtonForm.StatePressed.Back.Color1 = System.Drawing.Color.Black;
            this.mainPallette.ButtonStyles.ButtonForm.StatePressed.Back.Color2 = System.Drawing.Color.Black;
            this.mainPallette.ButtonStyles.ButtonForm.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.mainPallette.ButtonStyles.ButtonForm.StatePressed.Border.Width = 0;
            this.mainPallette.ButtonStyles.ButtonForm.StateTracking.Back.Color1 = System.Drawing.Color.Black;
            this.mainPallette.ButtonStyles.ButtonForm.StateTracking.Back.Color2 = System.Drawing.Color.Black;
            this.mainPallette.ButtonStyles.ButtonForm.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.mainPallette.ButtonStyles.ButtonForm.StateTracking.Border.Width = 0;
            this.mainPallette.ButtonStyles.ButtonStandalone.StateCommon.Back.Color1 = System.Drawing.Color.Cyan;
            this.mainPallette.ButtonStyles.ButtonStandalone.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.mainPallette.ButtonStyles.ButtonStandalone.StateCommon.Back.ColorAngle = 45F;
            this.mainPallette.ButtonStyles.ButtonStandalone.StateCommon.Border.Color1 = System.Drawing.Color.Cyan;
            this.mainPallette.ButtonStyles.ButtonStandalone.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.mainPallette.ButtonStyles.ButtonStandalone.StateCommon.Border.ColorAngle = 45F;
            this.mainPallette.ButtonStyles.ButtonStandalone.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.mainPallette.ButtonStyles.ButtonStandalone.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.mainPallette.ButtonStyles.ButtonStandalone.StateCommon.Border.Rounding = 20;
            this.mainPallette.ButtonStyles.ButtonStandalone.StateCommon.Border.Width = 1;
            this.mainPallette.ButtonStyles.ButtonStandalone.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.mainPallette.ButtonStyles.ButtonStandalone.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.mainPallette.ButtonStyles.ButtonStandalone.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Play", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainPallette.ButtonStyles.ButtonStandalone.StateNormal.Back.Color1 = System.Drawing.Color.Cyan;
            this.mainPallette.ButtonStyles.ButtonStandalone.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.mainPallette.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.Black;
            this.mainPallette.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.Black;
            this.mainPallette.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.mainPallette.FormStyles.FormMain.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.mainPallette.FormStyles.FormMain.StateCommon.Border.Rounding = 12;
            this.mainPallette.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.Black;
            this.mainPallette.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.Black;
            this.mainPallette.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            this.mainPallette.HeaderStyles.HeaderForm.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.mainPallette.HeaderStyles.HeaderForm.StateCommon.Content.LongText.Color2 = System.Drawing.Color.White;
            this.mainPallette.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.mainPallette.HeaderStyles.HeaderForm.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.mainPallette.HeaderStyles.HeaderForm.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.mainPallette.LabelStyles.LabelCommon.StateCommon.LongText.Color1 = System.Drawing.Color.White;
            this.mainPallette.LabelStyles.LabelCommon.StateCommon.LongText.Color2 = System.Drawing.Color.White;
            this.mainPallette.LabelStyles.LabelCommon.StateCommon.LongText.Font = new System.Drawing.Font("Play", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainPallette.LabelStyles.LabelCommon.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.mainPallette.LabelStyles.LabelCommon.StateCommon.ShortText.Color2 = System.Drawing.Color.White;
            this.mainPallette.LabelStyles.LabelCommon.StateCommon.ShortText.Font = new System.Drawing.Font("Play", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainPallette.LabelStyles.LabelCommon.StateNormal.LongText.Color1 = System.Drawing.Color.White;
            this.mainPallette.LabelStyles.LabelCommon.StateNormal.LongText.Color2 = System.Drawing.Color.White;
            this.mainPallette.LabelStyles.LabelCommon.StateNormal.ShortText.Color1 = System.Drawing.Color.White;
            this.mainPallette.LabelStyles.LabelCommon.StateNormal.ShortText.Color2 = System.Drawing.Color.White;
            this.mainPallette.LabelStyles.LabelCustom1.StateCommon.LongText.Color1 = System.Drawing.Color.White;
            this.mainPallette.LabelStyles.LabelCustom1.StateCommon.LongText.Color2 = System.Drawing.Color.White;
            this.mainPallette.LabelStyles.LabelCustom1.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.mainPallette.LabelStyles.LabelCustom1.StateCommon.ShortText.Color2 = System.Drawing.Color.White;
            this.mainPallette.LabelStyles.LabelNormalControl.StateCommon.LongText.Color1 = System.Drawing.Color.White;
            this.mainPallette.LabelStyles.LabelNormalControl.StateCommon.LongText.Color2 = System.Drawing.Color.White;
            this.mainPallette.LabelStyles.LabelNormalControl.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.mainPallette.LabelStyles.LabelNormalControl.StateCommon.ShortText.Color2 = System.Drawing.Color.White;
            this.mainPallette.LabelStyles.LabelNormalControl.StateDisabled.LongText.Color1 = System.Drawing.Color.White;
            this.mainPallette.LabelStyles.LabelNormalControl.StateDisabled.LongText.Color2 = System.Drawing.Color.White;
            this.mainPallette.LabelStyles.LabelNormalControl.StateDisabled.ShortText.Color1 = System.Drawing.Color.White;
            this.mainPallette.LabelStyles.LabelNormalControl.StateDisabled.ShortText.Color2 = System.Drawing.Color.White;
            this.mainPallette.LabelStyles.LabelNormalControl.StateNormal.LongText.Color1 = System.Drawing.Color.White;
            this.mainPallette.LabelStyles.LabelNormalControl.StateNormal.LongText.Color2 = System.Drawing.Color.White;
            this.mainPallette.LabelStyles.LabelNormalControl.StateNormal.ShortText.Color1 = System.Drawing.Color.White;
            this.mainPallette.LabelStyles.LabelNormalControl.StateNormal.ShortText.Color2 = System.Drawing.Color.White;
            this.mainPallette.LabelStyles.LabelTitleControl.StateCommon.LongText.Color1 = System.Drawing.Color.White;
            this.mainPallette.LabelStyles.LabelTitleControl.StateCommon.LongText.Color2 = System.Drawing.Color.White;
            this.mainPallette.LabelStyles.LabelTitleControl.StateCommon.LongText.Font = new System.Drawing.Font("Play", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainPallette.LabelStyles.LabelTitleControl.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.mainPallette.LabelStyles.LabelTitleControl.StateCommon.ShortText.Color2 = System.Drawing.Color.White;
            this.mainPallette.LabelStyles.LabelTitleControl.StateCommon.ShortText.Font = new System.Drawing.Font("Play", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // MessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(588, 73);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.notifyLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MessageForm";
            this.Palette = this.mainPallette;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Уведомление";
            this.Load += new System.EventHandler(this.MessageForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonLabel notifyLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton closeButton;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette mainPallette;
    }
}