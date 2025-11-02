namespace Automotive
{
    partial class TransactionLogsUC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnViewInformation = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvTransactionLog = new System.Windows.Forms.DataGridView();
            this.txtSearchDetails = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnSearch = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactionLog)).BeginInit();
            this.SuspendLayout();
            // 
            // btnViewInformation
            // 
            this.btnViewInformation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewInformation.Location = new System.Drawing.Point(644, 495);
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
            this.btnViewInformation.Size = new System.Drawing.Size(169, 41);
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
            this.btnViewInformation.StateCommon.Content.ShortText.Font = new System.Drawing.Font("SF Pro Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewInformation.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnViewInformation.TabIndex = 26;
            this.btnViewInformation.Values.Text = "View Information";
            this.btnViewInformation.Click += new System.EventHandler(this.btnViewInformation_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(-12, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(912, 76);
            this.panel1.TabIndex = 66;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("SF Pro Display", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label4.Location = new System.Drawing.Point(18, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(272, 54);
            this.label4.TabIndex = 48;
            this.label4.Text = "Transaction Log";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dgvTransactionLog
            // 
            this.dgvTransactionLog.AllowUserToAddRows = false;
            this.dgvTransactionLog.AllowUserToDeleteRows = false;
            this.dgvTransactionLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTransactionLog.BackgroundColor = System.Drawing.Color.White;
            this.dgvTransactionLog.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTransactionLog.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvTransactionLog.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("SF Pro Display", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransactionLog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTransactionLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("SF Pro Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTransactionLog.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTransactionLog.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTransactionLog.GridColor = System.Drawing.Color.White;
            this.dgvTransactionLog.Location = new System.Drawing.Point(72, 175);
            this.dgvTransactionLog.MultiSelect = false;
            this.dgvTransactionLog.Name = "dgvTransactionLog";
            this.dgvTransactionLog.ReadOnly = true;
            this.dgvTransactionLog.RowHeadersVisible = false;
            this.dgvTransactionLog.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTransactionLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransactionLog.Size = new System.Drawing.Size(741, 314);
            this.dgvTransactionLog.TabIndex = 69;
            this.dgvTransactionLog.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransactionLog_CellContentClick);
            // 
            // txtSearchDetails
            // 
            this.txtSearchDetails.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchDetails.Location = new System.Drawing.Point(173, 123);
            this.txtSearchDetails.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchDetails.Name = "txtSearchDetails";
            this.txtSearchDetails.Size = new System.Drawing.Size(457, 34);
            this.txtSearchDetails.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtSearchDetails.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSearchDetails.StateCommon.Border.Rounding = 16;
            this.txtSearchDetails.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.txtSearchDetails.StateCommon.Content.Font = new System.Drawing.Font("SF Pro Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchDetails.TabIndex = 68;
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Location = new System.Drawing.Point(734, 123);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.OverrideDefault.Back.Color1 = System.Drawing.Color.CornflowerBlue;
            this.btnSearch.OverrideDefault.Back.Color2 = System.Drawing.Color.CornflowerBlue;
            this.btnSearch.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnSearch.OverrideDefault.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnSearch.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSearch.OverrideDefault.Border.Rounding = 20;
            this.btnSearch.OverrideDefault.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.btnSearch.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSearch.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnSearch.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("SF Pro Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Size = new System.Drawing.Size(79, 40);
            this.btnSearch.StateCommon.Back.Color1 = System.Drawing.Color.CornflowerBlue;
            this.btnSearch.StateCommon.Back.Color2 = System.Drawing.Color.CornflowerBlue;
            this.btnSearch.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.btnSearch.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnSearch.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnSearch.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSearch.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.btnSearch.StateCommon.Border.Rounding = 20;
            this.btnSearch.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.btnSearch.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSearch.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnSearch.StateCommon.Content.ShortText.Font = new System.Drawing.Font("SF Pro Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnSearch.TabIndex = 73;
            this.btnSearch.Values.Text = "search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 74;
            this.label3.Text = "Search by:";
            // 
            // TransactionLogsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtSearchDetails);
            this.Controls.Add(this.btnViewInformation);
            this.Controls.Add(this.dgvTransactionLog);
            this.Name = "TransactionLogsUC";
            this.Size = new System.Drawing.Size(885, 568);
            this.Load += new System.EventHandler(this.TransactionLogsUC_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactionLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton btnViewInformation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvTransactionLog;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtSearchDetails;
        private System.Windows.Forms.Label label4;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSearch;
        private System.Windows.Forms.Label label3;
    }
}
