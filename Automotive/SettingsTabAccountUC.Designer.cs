namespace Automotive
{
    partial class SettingsTabAccountUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.txtOldPass = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnShowOldPass = new System.Windows.Forms.PictureBox();
            this.btnShowNewPass = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNewPass = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblInvalid = new System.Windows.Forms.Label();
            this.btnConfirm = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblStrength = new System.Windows.Forms.Label();
            this.barStrong = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.barMedium = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.barWeak = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.label4 = new System.Windows.Forms.Label();
            this.lblGuide5 = new System.Windows.Forms.Label();
            this.lblGuide4 = new System.Windows.Forms.Label();
            this.lblGuide3 = new System.Windows.Forms.Label();
            this.lblGuide2 = new System.Windows.Forms.Label();
            this.lblGuide1 = new System.Windows.Forms.Label();
            this.kryptonBorderEdge1 = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowOldPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowNewPass)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("SF Pro Text", 15.25F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.label2.Location = new System.Drawing.Point(45, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "Old Password";
            // 
            // txtOldPass
            // 
            this.txtOldPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOldPass.Location = new System.Drawing.Point(36, 78);
            this.txtOldPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.PasswordChar = '*';
            this.txtOldPass.Size = new System.Drawing.Size(394, 45);
            this.txtOldPass.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtOldPass.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtOldPass.StateCommon.Border.Rounding = 16;
            this.txtOldPass.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.txtOldPass.StateCommon.Content.Font = new System.Drawing.Font("SF Pro Text", 15.25F);
            this.txtOldPass.TabIndex = 11;
            this.txtOldPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOldPass_KeyDown);
            this.txtOldPass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtOldPass_MouseDown);
            // 
            // btnShowOldPass
            // 
            this.btnShowOldPass.BackColor = System.Drawing.Color.Transparent;
            this.btnShowOldPass.BackgroundImage = global::Automotive.Properties.Resources.show;
            this.btnShowOldPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowOldPass.Image = global::Automotive.Properties.Resources.show;
            this.btnShowOldPass.Location = new System.Drawing.Point(394, 84);
            this.btnShowOldPass.Name = "btnShowOldPass";
            this.btnShowOldPass.Size = new System.Drawing.Size(27, 29);
            this.btnShowOldPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnShowOldPass.TabIndex = 13;
            this.btnShowOldPass.TabStop = false;
            this.btnShowOldPass.Click += new System.EventHandler(this.btnShowOldPass_Click);
            // 
            // btnShowNewPass
            // 
            this.btnShowNewPass.BackColor = System.Drawing.Color.Transparent;
            this.btnShowNewPass.BackgroundImage = global::Automotive.Properties.Resources.show;
            this.btnShowNewPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowNewPass.Image = global::Automotive.Properties.Resources.show;
            this.btnShowNewPass.Location = new System.Drawing.Point(394, 211);
            this.btnShowNewPass.Name = "btnShowNewPass";
            this.btnShowNewPass.Size = new System.Drawing.Size(27, 29);
            this.btnShowNewPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnShowNewPass.TabIndex = 16;
            this.btnShowNewPass.TabStop = false;
            this.btnShowNewPass.Click += new System.EventHandler(this.btnShowNewPass_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("SF Pro Text", 15.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.label1.Location = new System.Drawing.Point(45, 156);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "New Password";
            // 
            // txtNewPass
            // 
            this.txtNewPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewPass.Location = new System.Drawing.Point(36, 205);
            this.txtNewPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '*';
            this.txtNewPass.Size = new System.Drawing.Size(394, 45);
            this.txtNewPass.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtNewPass.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtNewPass.StateCommon.Border.Rounding = 16;
            this.txtNewPass.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.txtNewPass.StateCommon.Content.Font = new System.Drawing.Font("SF Pro Text", 15.25F);
            this.txtNewPass.TabIndex = 14;
            this.txtNewPass.TextChanged += new System.EventHandler(this.txtNewPass_TextChanged);
            this.txtNewPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNewPass_KeyDown);
            this.txtNewPass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtNewPass_MouseDown);
            // 
            // lblInvalid
            // 
            this.lblInvalid.BackColor = System.Drawing.Color.Transparent;
            this.lblInvalid.Font = new System.Drawing.Font("SF Pro Text", 15.25F);
            this.lblInvalid.ForeColor = System.Drawing.Color.Brown;
            this.lblInvalid.Location = new System.Drawing.Point(27, 322);
            this.lblInvalid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInvalid.Name = "lblInvalid";
            this.lblInvalid.Size = new System.Drawing.Size(792, 29);
            this.lblInvalid.TabIndex = 53;
            this.lblInvalid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.Location = new System.Drawing.Point(342, 361);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.OverrideDefault.Back.Color1 = System.Drawing.Color.CornflowerBlue;
            this.btnConfirm.OverrideDefault.Back.Color2 = System.Drawing.Color.CornflowerBlue;
            this.btnConfirm.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnConfirm.OverrideDefault.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btnConfirm.Size = new System.Drawing.Size(162, 68);
            this.btnConfirm.StateCommon.Back.Color1 = System.Drawing.Color.CornflowerBlue;
            this.btnConfirm.StateCommon.Back.Color2 = System.Drawing.Color.CornflowerBlue;
            this.btnConfirm.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnConfirm.StateCommon.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btnConfirm.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnConfirm.StateCommon.Border.Rounding = 25;
            this.btnConfirm.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnConfirm.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnConfirm.StateCommon.Content.ShortText.Font = new System.Drawing.Font("SF Pro Text", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnConfirm.StateDisabled.Back.Color1 = System.Drawing.Color.CornflowerBlue;
            this.btnConfirm.StateDisabled.Back.Color2 = System.Drawing.Color.CornflowerBlue;
            this.btnConfirm.StateDisabled.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnConfirm.StateDisabled.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btnConfirm.StateNormal.Back.Color1 = System.Drawing.Color.CornflowerBlue;
            this.btnConfirm.StateNormal.Back.Color2 = System.Drawing.Color.CornflowerBlue;
            this.btnConfirm.StateNormal.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnConfirm.StateNormal.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btnConfirm.StatePressed.Back.Color1 = System.Drawing.Color.RoyalBlue;
            this.btnConfirm.StatePressed.Back.Color2 = System.Drawing.Color.RoyalBlue;
            this.btnConfirm.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnConfirm.StatePressed.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btnConfirm.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnConfirm.StatePressed.Border.Rounding = 25;
            this.btnConfirm.StateTracking.Back.Color1 = System.Drawing.Color.CornflowerBlue;
            this.btnConfirm.StateTracking.Back.Color2 = System.Drawing.Color.CornflowerBlue;
            this.btnConfirm.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnConfirm.StateTracking.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btnConfirm.TabIndex = 52;
            this.btnConfirm.Values.Text = "CONFIRM";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblStrength
            // 
            this.lblStrength.BackColor = System.Drawing.Color.Transparent;
            this.lblStrength.Font = new System.Drawing.Font("SF Pro Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStrength.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.lblStrength.Location = new System.Drawing.Point(298, 262);
            this.lblStrength.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStrength.Name = "lblStrength";
            this.lblStrength.Size = new System.Drawing.Size(113, 20);
            this.lblStrength.TabIndex = 68;
            this.lblStrength.Text = "None";
            this.lblStrength.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // barStrong
            // 
            this.barStrong.Location = new System.Drawing.Point(249, 272);
            this.barStrong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.barStrong.Name = "barStrong";
            this.barStrong.Size = new System.Drawing.Size(38, 5);
            this.barStrong.StateCommon.Color1 = System.Drawing.Color.Silver;
            this.barStrong.StateCommon.Width = 5;
            this.barStrong.Text = "kryptonBorderEdge1";
            // 
            // barMedium
            // 
            this.barMedium.Location = new System.Drawing.Point(204, 272);
            this.barMedium.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.barMedium.Name = "barMedium";
            this.barMedium.Size = new System.Drawing.Size(38, 5);
            this.barMedium.StateCommon.Color1 = System.Drawing.Color.Silver;
            this.barMedium.StateCommon.Width = 5;
            this.barMedium.Text = "kryptonBorderEdge1";
            // 
            // barWeak
            // 
            this.barWeak.Location = new System.Drawing.Point(159, 272);
            this.barWeak.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.barWeak.Name = "barWeak";
            this.barWeak.Size = new System.Drawing.Size(38, 5);
            this.barWeak.StateCommon.Color1 = System.Drawing.Color.Silver;
            this.barWeak.StateCommon.Width = 5;
            this.barWeak.Text = "kryptonBorderEdge1";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("SF Pro Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.label4.Location = new System.Drawing.Point(44, 262);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 67;
            this.label4.Text = "Password strength:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGuide5
            // 
            this.lblGuide5.BackColor = System.Drawing.Color.Transparent;
            this.lblGuide5.Font = new System.Drawing.Font("SF Pro Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuide5.ForeColor = System.Drawing.Color.Brown;
            this.lblGuide5.Location = new System.Drawing.Point(440, 285);
            this.lblGuide5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGuide5.Name = "lblGuide5";
            this.lblGuide5.Size = new System.Drawing.Size(372, 20);
            this.lblGuide5.TabIndex = 66;
            this.lblGuide5.Text = "- Minimum of 8 characters";
            this.lblGuide5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGuide4
            // 
            this.lblGuide4.BackColor = System.Drawing.Color.Transparent;
            this.lblGuide4.Font = new System.Drawing.Font("SF Pro Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuide4.ForeColor = System.Drawing.Color.Brown;
            this.lblGuide4.Location = new System.Drawing.Point(440, 265);
            this.lblGuide4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGuide4.Name = "lblGuide4";
            this.lblGuide4.Size = new System.Drawing.Size(372, 20);
            this.lblGuide4.TabIndex = 65;
            this.lblGuide4.Text = "- Must not contain White Spaces";
            this.lblGuide4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGuide3
            // 
            this.lblGuide3.BackColor = System.Drawing.Color.Transparent;
            this.lblGuide3.Font = new System.Drawing.Font("SF Pro Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuide3.ForeColor = System.Drawing.Color.Brown;
            this.lblGuide3.Location = new System.Drawing.Point(440, 245);
            this.lblGuide3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGuide3.Name = "lblGuide3";
            this.lblGuide3.Size = new System.Drawing.Size(372, 20);
            this.lblGuide3.TabIndex = 64;
            this.lblGuide3.Text = "- Must include at least 1 special character(@/!$*+=-,.)";
            this.lblGuide3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGuide2
            // 
            this.lblGuide2.BackColor = System.Drawing.Color.Transparent;
            this.lblGuide2.Font = new System.Drawing.Font("SF Pro Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuide2.ForeColor = System.Drawing.Color.Brown;
            this.lblGuide2.Location = new System.Drawing.Point(440, 225);
            this.lblGuide2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGuide2.Name = "lblGuide2";
            this.lblGuide2.Size = new System.Drawing.Size(372, 20);
            this.lblGuide2.TabIndex = 63;
            this.lblGuide2.Text = "- Must include at least 1 number";
            this.lblGuide2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGuide1
            // 
            this.lblGuide1.BackColor = System.Drawing.Color.Transparent;
            this.lblGuide1.Font = new System.Drawing.Font("SF Pro Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuide1.ForeColor = System.Drawing.Color.Brown;
            this.lblGuide1.Location = new System.Drawing.Point(440, 206);
            this.lblGuide1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGuide1.Name = "lblGuide1";
            this.lblGuide1.Size = new System.Drawing.Size(372, 20);
            this.lblGuide1.TabIndex = 62;
            this.lblGuide1.Text = "- Must contain a mix of uppercase and lowercase letters";
            this.lblGuide1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // kryptonBorderEdge1
            // 
            this.kryptonBorderEdge1.Location = new System.Drawing.Point(28, 136);
            this.kryptonBorderEdge1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kryptonBorderEdge1.Name = "kryptonBorderEdge1";
            this.kryptonBorderEdge1.Size = new System.Drawing.Size(764, 3);
            this.kryptonBorderEdge1.StateCommon.Color1 = System.Drawing.Color.DarkGray;
            this.kryptonBorderEdge1.StateCommon.Width = 3;
            this.kryptonBorderEdge1.Text = "kryptonBorderEdge1";
            // 
            // SettingsTabAccountUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.kryptonBorderEdge1);
            this.Controls.Add(this.lblStrength);
            this.Controls.Add(this.barStrong);
            this.Controls.Add(this.barMedium);
            this.Controls.Add(this.barWeak);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblGuide5);
            this.Controls.Add(this.lblGuide4);
            this.Controls.Add(this.lblGuide3);
            this.Controls.Add(this.lblGuide2);
            this.Controls.Add(this.lblGuide1);
            this.Controls.Add(this.lblInvalid);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnShowNewPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.btnShowOldPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOldPass);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SettingsTabAccountUC";
            this.Size = new System.Drawing.Size(840, 452);
            ((System.ComponentModel.ISupportInitialize)(this.btnShowOldPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowNewPass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnShowOldPass;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtOldPass;
        private System.Windows.Forms.PictureBox btnShowNewPass;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtNewPass;
        private System.Windows.Forms.Label lblInvalid;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnConfirm;
        private System.Windows.Forms.Label lblStrength;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge barStrong;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge barMedium;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge barWeak;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblGuide5;
        private System.Windows.Forms.Label lblGuide4;
        private System.Windows.Forms.Label lblGuide3;
        private System.Windows.Forms.Label lblGuide2;
        private System.Windows.Forms.Label lblGuide1;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge1;
    }
}
