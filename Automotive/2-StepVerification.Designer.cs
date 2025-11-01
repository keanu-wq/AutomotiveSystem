namespace Automotive
{
    partial class _2_StepVerification
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
            this.FormDesign = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblInvalid = new System.Windows.Forms.Label();
            this.btnResend = new System.Windows.Forms.LinkLabel();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblResend = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShowPass = new System.Windows.Forms.PictureBox();
            this.btnEnter = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCode = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.removeVerifyCB = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowPass)).BeginInit();
            this.SuspendLayout();
            // 
            // FormDesign
            // 
            this.FormDesign.BasePaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            this.FormDesign.BaseRenderMode = ComponentFactory.Krypton.Toolkit.RendererMode.Professional;
            this.FormDesign.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormDesign.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormDesign.FormStyles.FormMain.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormDesign.FormStyles.FormMain.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormDesign.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.FormDesign.FormStyles.FormMain.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.FormDesign.FormStyles.FormMain.StateCommon.Border.Rounding = 20;
            this.FormDesign.FormStyles.FormMain.StateInactive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.FormDesign.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormDesign.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormDesign.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 16;
            this.FormDesign.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(16, -1, -1, -1);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblInvalid
            // 
            this.lblInvalid.BackColor = System.Drawing.Color.Transparent;
            this.lblInvalid.Font = new System.Drawing.Font("SF Pro Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalid.ForeColor = System.Drawing.Color.Brown;
            this.lblInvalid.Location = new System.Drawing.Point(24, 279);
            this.lblInvalid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInvalid.Name = "lblInvalid";
            this.lblInvalid.Size = new System.Drawing.Size(345, 20);
            this.lblInvalid.TabIndex = 46;
            this.lblInvalid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnResend
            // 
            this.btnResend.AutoSize = true;
            this.btnResend.BackColor = System.Drawing.Color.Transparent;
            this.btnResend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResend.DisabledLinkColor = System.Drawing.Color.Silver;
            this.btnResend.Enabled = false;
            this.btnResend.Font = new System.Drawing.Font("SF Pro Text", 11.25F);
            this.btnResend.ForeColor = System.Drawing.Color.Silver;
            this.btnResend.Location = new System.Drawing.Point(138, 217);
            this.btnResend.Name = "btnResend";
            this.btnResend.Size = new System.Drawing.Size(105, 20);
            this.btnResend.TabIndex = 45;
            this.btnResend.TabStop = true;
            this.btnResend.Text = "Resend Code";
            this.btnResend.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnResend_LinkClicked);
            // 
            // lblTimer
            // 
            this.lblTimer.BackColor = System.Drawing.Color.Transparent;
            this.lblTimer.Font = new System.Drawing.Font("SF Pro Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.lblTimer.Location = new System.Drawing.Point(206, 193);
            this.lblTimer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(85, 24);
            this.lblTimer.TabIndex = 44;
            this.lblTimer.Text = "00s";
            // 
            // lblResend
            // 
            this.lblResend.BackColor = System.Drawing.Color.Transparent;
            this.lblResend.Font = new System.Drawing.Font("SF Pro Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.lblResend.Location = new System.Drawing.Point(122, 193);
            this.lblResend.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResend.Name = "lblResend";
            this.lblResend.Size = new System.Drawing.Size(85, 24);
            this.lblResend.TabIndex = 43;
            this.lblResend.Text = "Resend in:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("SF Pro Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.label1.Location = new System.Drawing.Point(48, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 41);
            this.label1.TabIndex = 42;
            this.label1.Text = "Check your E-Mail for Verification Code";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnShowPass
            // 
            this.btnShowPass.BackColor = System.Drawing.Color.Transparent;
            this.btnShowPass.BackgroundImage = global::Automotive.Properties.Resources.show;
            this.btnShowPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowPass.Image = global::Automotive.Properties.Resources.show;
            this.btnShowPass.Location = new System.Drawing.Point(259, 162);
            this.btnShowPass.Name = "btnShowPass";
            this.btnShowPass.Size = new System.Drawing.Size(22, 19);
            this.btnShowPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnShowPass.TabIndex = 41;
            this.btnShowPass.TabStop = false;
            this.btnShowPass.Click += new System.EventHandler(this.btnShowPass_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnter.Location = new System.Drawing.Point(112, 302);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.OverrideDefault.Back.Color1 = System.Drawing.Color.CornflowerBlue;
            this.btnEnter.OverrideDefault.Back.Color2 = System.Drawing.Color.CornflowerBlue;
            this.btnEnter.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnEnter.OverrideDefault.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btnEnter.Size = new System.Drawing.Size(153, 52);
            this.btnEnter.StateCommon.Back.Color1 = System.Drawing.Color.CornflowerBlue;
            this.btnEnter.StateCommon.Back.Color2 = System.Drawing.Color.CornflowerBlue;
            this.btnEnter.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnEnter.StateCommon.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btnEnter.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnEnter.StateCommon.Border.Rounding = 25;
            this.btnEnter.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnEnter.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnEnter.StateCommon.Content.ShortText.Font = new System.Drawing.Font("SF Pro Text", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.StateDisabled.Back.Color1 = System.Drawing.Color.CornflowerBlue;
            this.btnEnter.StateDisabled.Back.Color2 = System.Drawing.Color.CornflowerBlue;
            this.btnEnter.StateDisabled.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnEnter.StateDisabled.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btnEnter.StateNormal.Back.Color1 = System.Drawing.Color.CornflowerBlue;
            this.btnEnter.StateNormal.Back.Color2 = System.Drawing.Color.CornflowerBlue;
            this.btnEnter.StateNormal.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnEnter.StateNormal.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btnEnter.StatePressed.Back.Color1 = System.Drawing.Color.DeepSkyBlue;
            this.btnEnter.StatePressed.Back.Color2 = System.Drawing.Color.DeepSkyBlue;
            this.btnEnter.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnEnter.StatePressed.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btnEnter.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnEnter.StatePressed.Border.Rounding = 25;
            this.btnEnter.StateTracking.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnEnter.StateTracking.Back.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnEnter.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnEnter.StateTracking.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btnEnter.TabIndex = 40;
            this.btnEnter.Values.Text = "ENTER";
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("SF Pro Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.label3.Location = new System.Drawing.Point(2, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(376, 38);
            this.label3.TabIndex = 39;
            this.label3.Text = "2-Step Verification";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("SF Pro Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.label2.Location = new System.Drawing.Point(98, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "Code";
            // 
            // txtCode
            // 
            this.txtCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCode.Location = new System.Drawing.Point(101, 153);
            this.txtCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtCode.Name = "txtCode";
            this.txtCode.PasswordChar = '*';
            this.txtCode.Size = new System.Drawing.Size(190, 38);
            this.txtCode.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtCode.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCode.StateCommon.Border.Rounding = 16;
            this.txtCode.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.txtCode.StateCommon.Content.Font = new System.Drawing.Font("SF Pro Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.TabIndex = 37;
            // 
            // removeVerifyCB
            // 
            this.removeVerifyCB.AutoSize = true;
            this.removeVerifyCB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeVerifyCB.Font = new System.Drawing.Font("SF Pro Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeVerifyCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.removeVerifyCB.Location = new System.Drawing.Point(86, 257);
            this.removeVerifyCB.Name = "removeVerifyCB";
            this.removeVerifyCB.Size = new System.Drawing.Size(205, 19);
            this.removeVerifyCB.TabIndex = 47;
            this.removeVerifyCB.Text = "Remove Verification for 30 Days";
            this.removeVerifyCB.UseVisualStyleBackColor = true;
            this.removeVerifyCB.CheckedChanged += new System.EventHandler(this.removeVerifyCB_CheckedChanged);
            // 
            // _2_StepVerification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(380, 366);
            this.Controls.Add(this.removeVerifyCB);
            this.Controls.Add(this.lblInvalid);
            this.Controls.Add(this.btnResend);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblResend);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShowPass);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "_2_StepVerification";
            this.Palette = this.FormDesign;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2-Step Verification";
            this.Load += new System.EventHandler(this._2_StepVerification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnShowPass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette FormDesign;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblInvalid;
        private System.Windows.Forms.LinkLabel btnResend;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblResend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnShowPass;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnEnter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtCode;
        private System.Windows.Forms.CheckBox removeVerifyCB;
    }
}