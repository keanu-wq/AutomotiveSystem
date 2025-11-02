namespace Automotive
{
    partial class ReportsAdminUC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbFilterByAdmin = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvReportsTableAdmin = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dteDateToAdmin = new System.Windows.Forms.DateTimePicker();
            this.dteDateFromAdmin = new System.Windows.Forms.DateTimePicker();
            this.btnGenerateAdmin = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnViewInformationAdmin = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbReportTypeAdmin = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTotalSales = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportsTableAdmin)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.cbFilterByAdmin);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.dgvReportsTableAdmin);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(62, 189);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(670, 256);
            this.panel2.TabIndex = 70;
            // 
            // cbFilterByAdmin
            // 
            this.cbFilterByAdmin.FormattingEnabled = true;
            this.cbFilterByAdmin.Location = new System.Drawing.Point(526, 12);
            this.cbFilterByAdmin.Name = "cbFilterByAdmin";
            this.cbFilterByAdmin.Size = new System.Drawing.Size(118, 21);
            this.cbFilterByAdmin.TabIndex = 74;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label6.Location = new System.Drawing.Point(466, 12);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 23);
            this.label6.TabIndex = 74;
            this.label6.Text = "Filter:";
            // 
            // dgvReportsTableAdmin
            // 
            this.dgvReportsTableAdmin.AllowUserToAddRows = false;
            this.dgvReportsTableAdmin.AllowUserToDeleteRows = false;
            this.dgvReportsTableAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReportsTableAdmin.BackgroundColor = System.Drawing.Color.White;
            this.dgvReportsTableAdmin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvReportsTableAdmin.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvReportsTableAdmin.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("SF Pro Display", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReportsTableAdmin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReportsTableAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("SF Pro Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReportsTableAdmin.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvReportsTableAdmin.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvReportsTableAdmin.GridColor = System.Drawing.Color.White;
            this.dgvReportsTableAdmin.Location = new System.Drawing.Point(26, 45);
            this.dgvReportsTableAdmin.MultiSelect = false;
            this.dgvReportsTableAdmin.Name = "dgvReportsTableAdmin";
            this.dgvReportsTableAdmin.ReadOnly = true;
            this.dgvReportsTableAdmin.RowHeadersVisible = false;
            this.dgvReportsTableAdmin.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvReportsTableAdmin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReportsTableAdmin.Size = new System.Drawing.Size(618, 191);
            this.dgvReportsTableAdmin.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("SF Pro Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 23);
            this.label1.TabIndex = 48;
            this.label1.Text = "Sales Report Table";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(-5, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(937, 76);
            this.panel1.TabIndex = 69;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("SF Pro Display", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label4.Location = new System.Drawing.Point(25, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(272, 54);
            this.label4.TabIndex = 48;
            this.label4.Text = "Reports";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.dteDateToAdmin);
            this.panel3.Controls.Add(this.dteDateFromAdmin);
            this.panel3.Controls.Add(this.btnGenerateAdmin);
            this.panel3.Controls.Add(this.btnViewInformationAdmin);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.cbReportTypeAdmin);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(3, 92);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(817, 78);
            this.panel3.TabIndex = 75;
            // 
            // dteDateToAdmin
            // 
            this.dteDateToAdmin.Location = new System.Drawing.Point(545, 7);
            this.dteDateToAdmin.Name = "dteDateToAdmin";
            this.dteDateToAdmin.Size = new System.Drawing.Size(185, 20);
            this.dteDateToAdmin.TabIndex = 75;
            // 
            // dteDateFromAdmin
            // 
            this.dteDateFromAdmin.Location = new System.Drawing.Point(369, 8);
            this.dteDateFromAdmin.Name = "dteDateFromAdmin";
            this.dteDateFromAdmin.Size = new System.Drawing.Size(137, 20);
            this.dteDateFromAdmin.TabIndex = 74;
            // 
            // btnGenerateAdmin
            // 
            this.btnGenerateAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerateAdmin.Location = new System.Drawing.Point(637, 33);
            this.btnGenerateAdmin.Name = "btnGenerateAdmin";
            this.btnGenerateAdmin.OverrideDefault.Back.Color1 = System.Drawing.Color.CornflowerBlue;
            this.btnGenerateAdmin.OverrideDefault.Back.Color2 = System.Drawing.Color.CornflowerBlue;
            this.btnGenerateAdmin.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnGenerateAdmin.OverrideDefault.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnGenerateAdmin.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnGenerateAdmin.OverrideDefault.Border.Rounding = 20;
            this.btnGenerateAdmin.OverrideDefault.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.btnGenerateAdmin.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnGenerateAdmin.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnGenerateAdmin.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("SF Pro Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateAdmin.Size = new System.Drawing.Size(93, 36);
            this.btnGenerateAdmin.StateCommon.Back.Color1 = System.Drawing.Color.Black;
            this.btnGenerateAdmin.StateCommon.Back.Color2 = System.Drawing.Color.Black;
            this.btnGenerateAdmin.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.btnGenerateAdmin.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnGenerateAdmin.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnGenerateAdmin.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnGenerateAdmin.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.btnGenerateAdmin.StateCommon.Border.Rounding = 20;
            this.btnGenerateAdmin.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.btnGenerateAdmin.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnGenerateAdmin.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnGenerateAdmin.StateCommon.Content.ShortText.Font = new System.Drawing.Font("SF Pro Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateAdmin.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnGenerateAdmin.TabIndex = 73;
            this.btnGenerateAdmin.Values.Text = "Generate";
            // 
            // btnViewInformationAdmin
            // 
            this.btnViewInformationAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewInformationAdmin.Location = new System.Drawing.Point(503, 35);
            this.btnViewInformationAdmin.Name = "btnViewInformationAdmin";
            this.btnViewInformationAdmin.OverrideDefault.Back.Color1 = System.Drawing.Color.CornflowerBlue;
            this.btnViewInformationAdmin.OverrideDefault.Back.Color2 = System.Drawing.Color.CornflowerBlue;
            this.btnViewInformationAdmin.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnViewInformationAdmin.OverrideDefault.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnViewInformationAdmin.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnViewInformationAdmin.OverrideDefault.Border.Rounding = 20;
            this.btnViewInformationAdmin.OverrideDefault.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.btnViewInformationAdmin.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnViewInformationAdmin.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnViewInformationAdmin.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("SF Pro Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewInformationAdmin.Size = new System.Drawing.Size(126, 34);
            this.btnViewInformationAdmin.StateCommon.Back.Color1 = System.Drawing.Color.Black;
            this.btnViewInformationAdmin.StateCommon.Back.Color2 = System.Drawing.Color.Black;
            this.btnViewInformationAdmin.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.btnViewInformationAdmin.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnViewInformationAdmin.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnViewInformationAdmin.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnViewInformationAdmin.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.btnViewInformationAdmin.StateCommon.Border.Rounding = 20;
            this.btnViewInformationAdmin.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.btnViewInformationAdmin.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnViewInformationAdmin.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnViewInformationAdmin.StateCommon.Content.ShortText.Font = new System.Drawing.Font("SF Pro Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewInformationAdmin.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnViewInformationAdmin.TabIndex = 72;
            this.btnViewInformationAdmin.Values.Text = "View Information";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label5.Location = new System.Drawing.Point(514, 7);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 23);
            this.label5.TabIndex = 51;
            this.label5.Text = "To:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label3.Location = new System.Drawing.Point(270, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 23);
            this.label3.TabIndex = 50;
            this.label3.Text = "Date From:";
            // 
            // cbReportTypeAdmin
            // 
            this.cbReportTypeAdmin.FormattingEnabled = true;
            this.cbReportTypeAdmin.Location = new System.Drawing.Point(159, 7);
            this.cbReportTypeAdmin.Name = "cbReportTypeAdmin";
            this.cbReportTypeAdmin.Size = new System.Drawing.Size(100, 21);
            this.cbReportTypeAdmin.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label2.Location = new System.Drawing.Point(2, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 23);
            this.label2.TabIndex = 48;
            this.label2.Text = "Select Report Type:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.lblTotalSales);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(29, 471);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(767, 56);
            this.panel4.TabIndex = 76;
            // 
            // lblTotalSales
            // 
            this.lblTotalSales.BackColor = System.Drawing.Color.White;
            this.lblTotalSales.Font = new System.Drawing.Font("SF Pro Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSales.ForeColor = System.Drawing.Color.Black;
            this.lblTotalSales.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblTotalSales.Location = new System.Drawing.Point(123, 9);
            this.lblTotalSales.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalSales.Name = "lblTotalSales";
            this.lblTotalSales.Size = new System.Drawing.Size(60, 23);
            this.lblTotalSales.TabIndex = 49;
            this.lblTotalSales.Text = "Value";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("SF Pro Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label8.Location = new System.Drawing.Point(6, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 23);
            this.label8.TabIndex = 48;
            this.label8.Text = "Total Sales:";
            // 
            // ReportsAdminUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ReportsAdminUC";
            this.Size = new System.Drawing.Size(817, 590);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportsTableAdmin)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbFilterByAdmin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvReportsTableAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dteDateToAdmin;
        private System.Windows.Forms.DateTimePicker dteDateFromAdmin;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnGenerateAdmin;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnViewInformationAdmin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbReportTypeAdmin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTotalSales;
        private System.Windows.Forms.Label label8;
    }
}
