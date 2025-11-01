namespace Automotive
{
    partial class EditClientEditHistory
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
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lblInvalid2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEditConfirm = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpDate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIssue = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbWarranty = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.txtRepairedBy = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtWarranty = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtAmount = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblRepairedBy = new System.Windows.Forms.Label();
            this.lblIssue = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblWarranty = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbWarranty)).BeginInit();
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
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("SF Pro Display", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label12.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label12.Location = new System.Drawing.Point(79, 18);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(407, 36);
            this.label12.TabIndex = 77;
            this.label12.Text = "Edit Client\'s History";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.lblWarranty);
            this.panel1.Controls.Add(this.lblAmount);
            this.panel1.Controls.Add(this.lblRepairedBy);
            this.panel1.Controls.Add(this.lblIssue);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lblInvalid2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnEditConfirm);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.dtpDate);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtIssue);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.cbWarranty);
            this.panel1.Controls.Add(this.txtRepairedBy);
            this.panel1.Controls.Add(this.txtWarranty);
            this.panel1.Controls.Add(this.txtAmount);
            this.panel1.Location = new System.Drawing.Point(16, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(553, 320);
            this.panel1.TabIndex = 78;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("SF Pro Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.label7.Location = new System.Drawing.Point(19, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 18);
            this.label7.TabIndex = 74;
            this.label7.Text = "Date:";
            // 
            // lblInvalid2
            // 
            this.lblInvalid2.BackColor = System.Drawing.Color.Transparent;
            this.lblInvalid2.Font = new System.Drawing.Font("SF Pro Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalid2.ForeColor = System.Drawing.Color.Brown;
            this.lblInvalid2.Location = new System.Drawing.Point(16, 235);
            this.lblInvalid2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInvalid2.Name = "lblInvalid2";
            this.lblInvalid2.Size = new System.Drawing.Size(335, 28);
            this.lblInvalid2.TabIndex = 84;
            this.lblInvalid2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("SF Pro Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.label6.Location = new System.Drawing.Point(17, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 18);
            this.label6.TabIndex = 71;
            this.label6.Text = "Warranty:";
            // 
            // btnEditConfirm
            // 
            this.btnEditConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditConfirm.Location = new System.Drawing.Point(218, 266);
            this.btnEditConfirm.Name = "btnEditConfirm";
            this.btnEditConfirm.OverrideDefault.Back.Color1 = System.Drawing.Color.CornflowerBlue;
            this.btnEditConfirm.OverrideDefault.Back.Color2 = System.Drawing.Color.CornflowerBlue;
            this.btnEditConfirm.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnEditConfirm.OverrideDefault.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btnEditConfirm.Size = new System.Drawing.Size(118, 41);
            this.btnEditConfirm.StateCommon.Back.Color1 = System.Drawing.Color.CornflowerBlue;
            this.btnEditConfirm.StateCommon.Back.Color2 = System.Drawing.Color.CornflowerBlue;
            this.btnEditConfirm.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnEditConfirm.StateCommon.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btnEditConfirm.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnEditConfirm.StateCommon.Border.Rounding = 25;
            this.btnEditConfirm.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnEditConfirm.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnEditConfirm.StateCommon.Content.ShortText.Font = new System.Drawing.Font("SF Pro Text", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnEditConfirm.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnEditConfirm.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnEditConfirm.StateDisabled.Back.Color1 = System.Drawing.Color.CornflowerBlue;
            this.btnEditConfirm.StateDisabled.Back.Color2 = System.Drawing.Color.CornflowerBlue;
            this.btnEditConfirm.StateDisabled.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnEditConfirm.StateDisabled.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btnEditConfirm.StateNormal.Back.Color1 = System.Drawing.Color.CornflowerBlue;
            this.btnEditConfirm.StateNormal.Back.Color2 = System.Drawing.Color.CornflowerBlue;
            this.btnEditConfirm.StateNormal.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnEditConfirm.StateNormal.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btnEditConfirm.StatePressed.Back.Color1 = System.Drawing.Color.DeepSkyBlue;
            this.btnEditConfirm.StatePressed.Back.Color2 = System.Drawing.Color.DeepSkyBlue;
            this.btnEditConfirm.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnEditConfirm.StatePressed.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btnEditConfirm.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnEditConfirm.StatePressed.Border.Rounding = 25;
            this.btnEditConfirm.StateTracking.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnEditConfirm.StateTracking.Back.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnEditConfirm.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnEditConfirm.StateTracking.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btnEditConfirm.TabIndex = 83;
            this.btnEditConfirm.Values.Text = "Confirm";
            this.btnEditConfirm.Click += new System.EventHandler(this.btnEditConfirm_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("SF Pro Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.label8.Location = new System.Drawing.Point(17, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 18);
            this.label8.TabIndex = 67;
            this.label8.Text = "Amount:";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(311, 193);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(219, 39);
            this.dtpDate.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dtpDate.StateCommon.Border.Rounding = 25;
            this.dtpDate.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.dtpDate.StateCommon.Content.Font = new System.Drawing.Font("SF Pro Text", 9.25F);
            this.dtpDate.TabIndex = 82;
            this.dtpDate.ValueNullable = new System.DateTime(2025, 11, 1, 14, 59, 9, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("SF Pro Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.label9.Location = new System.Drawing.Point(17, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 18);
            this.label9.TabIndex = 66;
            this.label9.Text = "Repaired By:";
            // 
            // txtIssue
            // 
            this.txtIssue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIssue.Location = new System.Drawing.Point(311, 22);
            this.txtIssue.Margin = new System.Windows.Forms.Padding(2);
            this.txtIssue.Name = "txtIssue";
            this.txtIssue.Size = new System.Drawing.Size(219, 38);
            this.txtIssue.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtIssue.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtIssue.StateCommon.Border.Rounding = 16;
            this.txtIssue.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.txtIssue.StateCommon.Content.Font = new System.Drawing.Font("SF Pro Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIssue.TabIndex = 77;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("SF Pro Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.label10.Location = new System.Drawing.Point(17, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 18);
            this.label10.TabIndex = 65;
            this.label10.Text = "Issue:";
            // 
            // cbWarranty
            // 
            this.cbWarranty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbWarranty.DropDownWidth = 127;
            this.cbWarranty.Items.AddRange(new object[] {
            "Day(s)",
            "Month(s)",
            "Year(s)"});
            this.cbWarranty.Location = new System.Drawing.Point(385, 150);
            this.cbWarranty.Name = "cbWarranty";
            this.cbWarranty.Size = new System.Drawing.Size(143, 38);
            this.cbWarranty.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbWarranty.StateCommon.ComboBox.Border.Rounding = 25;
            this.cbWarranty.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.cbWarranty.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("SF Pro Text", 9.25F);
            this.cbWarranty.TabIndex = 81;
            // 
            // txtRepairedBy
            // 
            this.txtRepairedBy.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRepairedBy.Location = new System.Drawing.Point(311, 64);
            this.txtRepairedBy.Margin = new System.Windows.Forms.Padding(2);
            this.txtRepairedBy.Name = "txtRepairedBy";
            this.txtRepairedBy.Size = new System.Drawing.Size(219, 38);
            this.txtRepairedBy.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtRepairedBy.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtRepairedBy.StateCommon.Border.Rounding = 16;
            this.txtRepairedBy.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.txtRepairedBy.StateCommon.Content.Font = new System.Drawing.Font("SF Pro Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepairedBy.TabIndex = 78;
            // 
            // txtWarranty
            // 
            this.txtWarranty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtWarranty.Location = new System.Drawing.Point(311, 150);
            this.txtWarranty.Margin = new System.Windows.Forms.Padding(2);
            this.txtWarranty.Name = "txtWarranty";
            this.txtWarranty.Size = new System.Drawing.Size(69, 38);
            this.txtWarranty.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtWarranty.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtWarranty.StateCommon.Border.Rounding = 16;
            this.txtWarranty.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.txtWarranty.StateCommon.Content.Font = new System.Drawing.Font("SF Pro Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWarranty.TabIndex = 80;
            // 
            // txtAmount
            // 
            this.txtAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAmount.Location = new System.Drawing.Point(311, 106);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(2);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(219, 38);
            this.txtAmount.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtAmount.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtAmount.StateCommon.Border.Rounding = 16;
            this.txtAmount.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.txtAmount.StateCommon.Content.Font = new System.Drawing.Font("SF Pro Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.TabIndex = 79;
            // 
            // lblAmount
            // 
            this.lblAmount.Font = new System.Drawing.Font("SF Pro Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.lblAmount.Location = new System.Drawing.Point(130, 117);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(176, 18);
            this.lblAmount.TabIndex = 87;
            this.lblAmount.Text = "Null";
            this.lblAmount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblRepairedBy
            // 
            this.lblRepairedBy.Font = new System.Drawing.Font("SF Pro Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepairedBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.lblRepairedBy.Location = new System.Drawing.Point(130, 75);
            this.lblRepairedBy.Name = "lblRepairedBy";
            this.lblRepairedBy.Size = new System.Drawing.Size(176, 18);
            this.lblRepairedBy.TabIndex = 86;
            this.lblRepairedBy.Text = "Null";
            this.lblRepairedBy.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblIssue
            // 
            this.lblIssue.Font = new System.Drawing.Font("SF Pro Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.lblIssue.Location = new System.Drawing.Point(130, 30);
            this.lblIssue.Name = "lblIssue";
            this.lblIssue.Size = new System.Drawing.Size(176, 18);
            this.lblIssue.TabIndex = 85;
            this.lblIssue.Text = "Null";
            this.lblIssue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("SF Pro Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.lblDate.Location = new System.Drawing.Point(130, 204);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(176, 18);
            this.lblDate.TabIndex = 89;
            this.lblDate.Text = "Null";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblWarranty
            // 
            this.lblWarranty.Font = new System.Drawing.Font("SF Pro Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarranty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.lblWarranty.Location = new System.Drawing.Point(130, 159);
            this.lblWarranty.Name = "lblWarranty";
            this.lblWarranty.Size = new System.Drawing.Size(176, 18);
            this.lblWarranty.TabIndex = 88;
            this.lblWarranty.Text = "Null";
            this.lblWarranty.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(-3, -3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(591, 86);
            this.panel3.TabIndex = 79;
            // 
            // EditClientEditHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 433);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EditClientEditHistory";
            this.Palette = this.FormDesign;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditClientEditHistory";
            this.Load += new System.EventHandler(this.EditClientEditHistory_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbWarranty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette FormDesign;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblInvalid2;
        private System.Windows.Forms.Label label6;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnEditConfirm;
        private System.Windows.Forms.Label label8;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpDate;
        private System.Windows.Forms.Label label9;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtIssue;
        private System.Windows.Forms.Label label10;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbWarranty;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtRepairedBy;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtWarranty;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtAmount;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblWarranty;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblRepairedBy;
        private System.Windows.Forms.Label lblIssue;
        private System.Windows.Forms.Panel panel3;
    }
}