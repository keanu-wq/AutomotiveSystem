namespace Automotive
{
    partial class ApprovalsUC
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRemove = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnApprove = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtDetails = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.dgvPending = new System.Windows.Forms.DataGridView();
            this.colLogID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRecordID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateRequested = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPending)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(-11, -8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(863, 76);
            this.panel1.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("SF Pro Display", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label3.Location = new System.Drawing.Point(18, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 41);
            this.label3.TabIndex = 47;
            this.label3.Text = "Approvals";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnRemove);
            this.panel2.Controls.Add(this.btnApprove);
            this.panel2.Location = new System.Drawing.Point(-11, 503);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(863, 98);
            this.panel2.TabIndex = 63;
            // 
            // btnRemove
            // 
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.Location = new System.Drawing.Point(445, 17);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.OverrideDefault.Back.Color1 = System.Drawing.Color.Black;
            this.btnRemove.OverrideDefault.Back.Color2 = System.Drawing.Color.Black;
            this.btnRemove.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnRemove.OverrideDefault.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnRemove.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnRemove.OverrideDefault.Border.Rounding = 20;
            this.btnRemove.OverrideDefault.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.btnRemove.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnRemove.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnRemove.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("SF Pro Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Size = new System.Drawing.Size(123, 48);
            this.btnRemove.StateCommon.Back.Color1 = System.Drawing.Color.Black;
            this.btnRemove.StateCommon.Back.Color2 = System.Drawing.Color.Black;
            this.btnRemove.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.btnRemove.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnRemove.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnRemove.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnRemove.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.btnRemove.StateCommon.Border.Rounding = 20;
            this.btnRemove.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnRemove.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnRemove.StateCommon.Content.ShortText.Font = new System.Drawing.Font("SF Pro Text", 13.75F, System.Drawing.FontStyle.Bold);
            this.btnRemove.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnRemove.TabIndex = 30;
            this.btnRemove.Values.Text = "Reject";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnApprove
            // 
            this.btnApprove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApprove.Location = new System.Drawing.Point(274, 17);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.OverrideDefault.Back.Color1 = System.Drawing.Color.Black;
            this.btnApprove.OverrideDefault.Back.Color2 = System.Drawing.Color.Black;
            this.btnApprove.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnApprove.OverrideDefault.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnApprove.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnApprove.OverrideDefault.Border.Rounding = 20;
            this.btnApprove.OverrideDefault.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.btnApprove.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnApprove.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnApprove.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("SF Pro Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApprove.Size = new System.Drawing.Size(122, 48);
            this.btnApprove.StateCommon.Back.Color1 = System.Drawing.Color.Black;
            this.btnApprove.StateCommon.Back.Color2 = System.Drawing.Color.Black;
            this.btnApprove.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.btnApprove.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnApprove.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnApprove.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnApprove.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.btnApprove.StateCommon.Border.Rounding = 20;
            this.btnApprove.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnApprove.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnApprove.StateCommon.Content.ShortText.Font = new System.Drawing.Font("SF Pro Text", 13.75F, System.Drawing.FontStyle.Bold);
            this.btnApprove.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnApprove.TabIndex = 28;
            this.btnApprove.Values.Text = "Approve";
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // txtDetails
            // 
            this.txtDetails.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDetails.Location = new System.Drawing.Point(238, 460);
            this.txtDetails.Margin = new System.Windows.Forms.Padding(2);
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(357, 38);
            this.txtDetails.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtDetails.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtDetails.StateCommon.Border.Rounding = 16;
            this.txtDetails.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.txtDetails.StateCommon.Content.Font = new System.Drawing.Font("SF Pro Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetails.TabIndex = 64;
            // 
            // dgvPending
            // 
            this.dgvPending.AllowUserToAddRows = false;
            this.dgvPending.AllowUserToDeleteRows = false;
            this.dgvPending.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPending.BackgroundColor = System.Drawing.Color.White;
            this.dgvPending.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPending.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPending.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("SF Pro Display", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPending.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPending.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPending.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLogID,
            this.colTableName,
            this.colActionType,
            this.colRecordID,
            this.colUserID,
            this.colDateRequested});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("SF Pro Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPending.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPending.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPending.GridColor = System.Drawing.Color.White;
            this.dgvPending.Location = new System.Drawing.Point(33, 85);
            this.dgvPending.MultiSelect = false;
            this.dgvPending.Name = "dgvPending";
            this.dgvPending.ReadOnly = true;
            this.dgvPending.RowHeadersVisible = false;
            this.dgvPending.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPending.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPending.Size = new System.Drawing.Size(775, 353);
            this.dgvPending.TabIndex = 65;
            // 
            // colLogID
            // 
            this.colLogID.HeaderText = "Log ID";
            this.colLogID.Name = "colLogID";
            this.colLogID.ReadOnly = true;
            // 
            // colTableName
            // 
            this.colTableName.HeaderText = "Table Name";
            this.colTableName.Name = "colTableName";
            this.colTableName.ReadOnly = true;
            // 
            // colActionType
            // 
            this.colActionType.HeaderText = "Action Type";
            this.colActionType.Name = "colActionType";
            this.colActionType.ReadOnly = true;
            // 
            // colRecordID
            // 
            this.colRecordID.HeaderText = "Record ID";
            this.colRecordID.Name = "colRecordID";
            this.colRecordID.ReadOnly = true;
            // 
            // colUserID
            // 
            this.colUserID.HeaderText = "User ID";
            this.colUserID.Name = "colUserID";
            this.colUserID.ReadOnly = true;
            // 
            // colDateRequested
            // 
            this.colDateRequested.HeaderText = "Date Requested";
            this.colDateRequested.Name = "colDateRequested";
            this.colDateRequested.ReadOnly = true;
            // 
            // ApprovalsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvPending);
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "ApprovalsUC";
            this.Size = new System.Drawing.Size(840, 593);
            this.Load += new System.EventHandler(this.ApprovalsUC_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPending)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnRemove;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnApprove;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtDetails;
        private System.Windows.Forms.DataGridView dgvPending;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLogID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTableName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colActionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecordID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateRequested;
    }
}
