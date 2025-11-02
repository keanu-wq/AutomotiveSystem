namespace Automotive
{
    partial class TransactionLogADMINUC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearchDetailsAdmin = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.dgvTransactionLogAdmin = new System.Windows.Forms.DataGridView();
            this.btnViewInfoAdmin = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnAdminSearch = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactionLogAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 80;
            this.label3.Text = "Search by:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(-14, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(912, 76);
            this.panel1.TabIndex = 76;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("SF Pro Display", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label4.Location = new System.Drawing.Point(18, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(272, 54);
            this.label4.TabIndex = 48;
            this.label4.Text = "Transaction Log";
            // 
            // txtSearchDetailsAdmin
            // 
            this.txtSearchDetailsAdmin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchDetailsAdmin.Location = new System.Drawing.Point(171, 122);
            this.txtSearchDetailsAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchDetailsAdmin.Name = "txtSearchDetailsAdmin";
            this.txtSearchDetailsAdmin.Size = new System.Drawing.Size(457, 34);
            this.txtSearchDetailsAdmin.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtSearchDetailsAdmin.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSearchDetailsAdmin.StateCommon.Border.Rounding = 16;
            this.txtSearchDetailsAdmin.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.txtSearchDetailsAdmin.StateCommon.Content.Font = new System.Drawing.Font("SF Pro Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchDetailsAdmin.TabIndex = 77;
            // 
            // dgvTransactionLogAdmin
            // 
            this.dgvTransactionLogAdmin.AllowUserToAddRows = false;
            this.dgvTransactionLogAdmin.AllowUserToDeleteRows = false;
            this.dgvTransactionLogAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTransactionLogAdmin.BackgroundColor = System.Drawing.Color.White;
            this.dgvTransactionLogAdmin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTransactionLogAdmin.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvTransactionLogAdmin.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("SF Pro Display", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransactionLogAdmin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvTransactionLogAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("SF Pro Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTransactionLogAdmin.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvTransactionLogAdmin.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTransactionLogAdmin.GridColor = System.Drawing.Color.White;
            this.dgvTransactionLogAdmin.Location = new System.Drawing.Point(70, 174);
            this.dgvTransactionLogAdmin.MultiSelect = false;
            this.dgvTransactionLogAdmin.Name = "dgvTransactionLogAdmin";
            this.dgvTransactionLogAdmin.ReadOnly = true;
            this.dgvTransactionLogAdmin.RowHeadersVisible = false;
            this.dgvTransactionLogAdmin.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTransactionLogAdmin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransactionLogAdmin.Size = new System.Drawing.Size(741, 314);
            this.dgvTransactionLogAdmin.TabIndex = 78;
            // 
            // btnViewInfoAdmin
            // 
            this.btnViewInfoAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewInfoAdmin.Location = new System.Drawing.Point(660, 494);
            this.btnViewInfoAdmin.Name = "btnViewInfoAdmin";
            this.btnViewInfoAdmin.OverrideDefault.Back.Color1 = System.Drawing.Color.Black;
            this.btnViewInfoAdmin.OverrideDefault.Back.Color2 = System.Drawing.Color.Black;
            this.btnViewInfoAdmin.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnViewInfoAdmin.OverrideDefault.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnViewInfoAdmin.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnViewInfoAdmin.OverrideDefault.Border.Rounding = 20;
            this.btnViewInfoAdmin.OverrideDefault.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.btnViewInfoAdmin.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnViewInfoAdmin.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnViewInfoAdmin.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("SF Pro Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewInfoAdmin.Size = new System.Drawing.Size(151, 36);
            this.btnViewInfoAdmin.StateCommon.Back.Color1 = System.Drawing.Color.Black;
            this.btnViewInfoAdmin.StateCommon.Back.Color2 = System.Drawing.Color.Black;
            this.btnViewInfoAdmin.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.btnViewInfoAdmin.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnViewInfoAdmin.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnViewInfoAdmin.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnViewInfoAdmin.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.btnViewInfoAdmin.StateCommon.Border.Rounding = 20;
            this.btnViewInfoAdmin.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnViewInfoAdmin.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnViewInfoAdmin.StateCommon.Content.ShortText.Font = new System.Drawing.Font("SF Pro Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewInfoAdmin.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnViewInfoAdmin.TabIndex = 81;
            this.btnViewInfoAdmin.Values.Text = "View Information";
            this.btnViewInfoAdmin.Click += new System.EventHandler(this.btnViewInfoAdmin_Click);
            // 
            // btnAdminSearch
            // 
            this.btnAdminSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdminSearch.Location = new System.Drawing.Point(736, 122);
            this.btnAdminSearch.Name = "btnAdminSearch";
            this.btnAdminSearch.OverrideDefault.Back.Color1 = System.Drawing.Color.Black;
            this.btnAdminSearch.OverrideDefault.Back.Color2 = System.Drawing.Color.Black;
            this.btnAdminSearch.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnAdminSearch.OverrideDefault.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnAdminSearch.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAdminSearch.OverrideDefault.Border.Rounding = 20;
            this.btnAdminSearch.OverrideDefault.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.btnAdminSearch.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAdminSearch.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnAdminSearch.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("SF Pro Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminSearch.Size = new System.Drawing.Size(75, 37);
            this.btnAdminSearch.StateCommon.Back.Color1 = System.Drawing.Color.Black;
            this.btnAdminSearch.StateCommon.Back.Color2 = System.Drawing.Color.Black;
            this.btnAdminSearch.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.btnAdminSearch.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnAdminSearch.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnAdminSearch.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAdminSearch.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.btnAdminSearch.StateCommon.Border.Rounding = 20;
            this.btnAdminSearch.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAdminSearch.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnAdminSearch.StateCommon.Content.ShortText.Font = new System.Drawing.Font("SF Pro Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminSearch.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnAdminSearch.TabIndex = 82;
            this.btnAdminSearch.Values.Text = "Search";
            this.btnAdminSearch.Click += new System.EventHandler(this.btnAdminSearch_Click);
            // 
            // TransactionLogADMINUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAdminSearch);
            this.Controls.Add(this.btnViewInfoAdmin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtSearchDetailsAdmin);
            this.Controls.Add(this.dgvTransactionLogAdmin);
            this.Name = "TransactionLogADMINUC";
            this.Size = new System.Drawing.Size(875, 550);
            this.Load += new System.EventHandler(this.TransactionLogADMINUC_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactionLogAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtSearchDetailsAdmin;
        private System.Windows.Forms.DataGridView dgvTransactionLogAdmin;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnViewInfoAdmin;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAdminSearch;
    }
}
