namespace Automotive
{
    partial class ReportsUC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvReportsTable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dteDateTo = new System.Windows.Forms.DateTimePicker();
            this.dteDateFrom = new System.Windows.Forms.DateTimePicker();
            this.btnGenerate = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnViewInformation = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbReportType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTotalSales = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportsTable)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("SF Pro Display", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label4.Location = new System.Drawing.Point(25, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(272, 54);
            this.label4.TabIndex = 48;
            this.label4.Text = "Reports";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(-25, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(937, 76);
            this.panel1.TabIndex = 67;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.cbFilterBy);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.dgvReportsTable);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(97, 190);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(670, 256);
            this.panel2.TabIndex = 68;
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Location = new System.Drawing.Point(526, 12);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(118, 21);
            this.cbFilterBy.TabIndex = 74;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label6.Location = new System.Drawing.Point(466, 12);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 23);
            this.label6.TabIndex = 74;
            this.label6.Text = "Filter:";
            // 
            // dgvReportsTable
            // 
            this.dgvReportsTable.AllowUserToAddRows = false;
            this.dgvReportsTable.AllowUserToDeleteRows = false;
            this.dgvReportsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReportsTable.BackgroundColor = System.Drawing.Color.White;
            this.dgvReportsTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvReportsTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvReportsTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("SF Pro Display", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReportsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvReportsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("SF Pro Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReportsTable.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvReportsTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvReportsTable.GridColor = System.Drawing.Color.White;
            this.dgvReportsTable.Location = new System.Drawing.Point(26, 45);
            this.dgvReportsTable.MultiSelect = false;
            this.dgvReportsTable.Name = "dgvReportsTable";
            this.dgvReportsTable.ReadOnly = true;
            this.dgvReportsTable.RowHeadersVisible = false;
            this.dgvReportsTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvReportsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReportsTable.Size = new System.Drawing.Size(618, 191);
            this.dgvReportsTable.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("SF Pro Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 23);
            this.label1.TabIndex = 48;
            this.label1.Text = "Sales Report Table";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.dteDateTo);
            this.panel3.Controls.Add(this.dteDateFrom);
            this.panel3.Controls.Add(this.btnGenerate);
            this.panel3.Controls.Add(this.btnViewInformation);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.cbReportType);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(19, 82);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(893, 78);
            this.panel3.TabIndex = 71;
            // 
            // dteDateTo
            // 
            this.dteDateTo.Location = new System.Drawing.Point(604, 7);
            this.dteDateTo.Name = "dteDateTo";
            this.dteDateTo.Size = new System.Drawing.Size(192, 20);
            this.dteDateTo.TabIndex = 75;
            // 
            // dteDateFrom
            // 
            this.dteDateFrom.Location = new System.Drawing.Point(369, 8);
            this.dteDateFrom.Name = "dteDateFrom";
            this.dteDateFrom.Size = new System.Drawing.Size(173, 20);
            this.dteDateFrom.TabIndex = 74;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerate.Location = new System.Drawing.Point(703, 33);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.OverrideDefault.Back.Color1 = System.Drawing.Color.CornflowerBlue;
            this.btnGenerate.OverrideDefault.Back.Color2 = System.Drawing.Color.CornflowerBlue;
            this.btnGenerate.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnGenerate.OverrideDefault.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnGenerate.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnGenerate.OverrideDefault.Border.Rounding = 20;
            this.btnGenerate.OverrideDefault.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.btnGenerate.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnGenerate.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnGenerate.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("SF Pro Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Size = new System.Drawing.Size(93, 36);
            this.btnGenerate.StateCommon.Back.Color1 = System.Drawing.Color.CornflowerBlue;
            this.btnGenerate.StateCommon.Back.Color2 = System.Drawing.Color.CornflowerBlue;
            this.btnGenerate.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.btnGenerate.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnGenerate.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnGenerate.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnGenerate.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.btnGenerate.StateCommon.Border.Rounding = 20;
            this.btnGenerate.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.btnGenerate.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnGenerate.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnGenerate.StateCommon.Content.ShortText.Font = new System.Drawing.Font("SF Pro Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnGenerate.TabIndex = 73;
            this.btnGenerate.Values.Text = "Generate";
            // 
            // btnViewInformation
            // 
            this.btnViewInformation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewInformation.Location = new System.Drawing.Point(569, 35);
            this.btnViewInformation.Name = "btnViewInformation";
            this.btnViewInformation.OverrideDefault.Back.Color1 = System.Drawing.Color.CornflowerBlue;
            this.btnViewInformation.OverrideDefault.Back.Color2 = System.Drawing.Color.CornflowerBlue;
            this.btnViewInformation.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnViewInformation.OverrideDefault.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnViewInformation.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnViewInformation.OverrideDefault.Border.Rounding = 20;
            this.btnViewInformation.OverrideDefault.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.btnViewInformation.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnViewInformation.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnViewInformation.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("SF Pro Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewInformation.Size = new System.Drawing.Size(126, 34);
            this.btnViewInformation.StateCommon.Back.Color1 = System.Drawing.Color.CornflowerBlue;
            this.btnViewInformation.StateCommon.Back.Color2 = System.Drawing.Color.CornflowerBlue;
            this.btnViewInformation.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.btnViewInformation.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnViewInformation.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnViewInformation.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnViewInformation.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.btnViewInformation.StateCommon.Border.Rounding = 20;
            this.btnViewInformation.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.btnViewInformation.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnViewInformation.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnViewInformation.StateCommon.Content.ShortText.Font = new System.Drawing.Font("SF Pro Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewInformation.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnViewInformation.TabIndex = 72;
            this.btnViewInformation.Values.Text = "View Information";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label5.Location = new System.Drawing.Point(573, 7);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 23);
            this.label5.TabIndex = 51;
            this.label5.Text = "To:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label3.Location = new System.Drawing.Point(270, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 23);
            this.label3.TabIndex = 50;
            this.label3.Text = "Date From:";
            // 
            // cbReportType
            // 
            this.cbReportType.FormattingEnabled = true;
            this.cbReportType.Location = new System.Drawing.Point(159, 7);
            this.cbReportType.Name = "cbReportType";
            this.cbReportType.Size = new System.Drawing.Size(100, 21);
            this.cbReportType.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
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
            this.panel4.Location = new System.Drawing.Point(97, 469);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(670, 56);
            this.panel4.TabIndex = 75;
            // 
            // lblTotalSales
            // 
            this.lblTotalSales.BackColor = System.Drawing.Color.White;
            this.lblTotalSales.Font = new System.Drawing.Font("SF Pro Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSales.ForeColor = System.Drawing.Color.CornflowerBlue;
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
            this.label8.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label8.Location = new System.Drawing.Point(6, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 23);
            this.label8.TabIndex = 48;
            this.label8.Text = "Total Sales:";
            // 
            // ReportsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ReportsUC";
            this.Size = new System.Drawing.Size(853, 560);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportsTable)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvReportsTable;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbReportType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Label label6;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnGenerate;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnViewInformation;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTotalSales;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dteDateTo;
        private System.Windows.Forms.DateTimePicker dteDateFrom;
    }
}
