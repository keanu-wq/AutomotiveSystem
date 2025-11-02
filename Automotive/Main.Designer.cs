namespace Automotive
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
            this.FormDesign = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.lblName = new System.Windows.Forms.Label();
            this.kryptonBorderEdge1 = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picReports = new System.Windows.Forms.PictureBox();
            this.btnReports = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.picTransaction = new System.Windows.Forms.PictureBox();
            this.btnTransactionLogs = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.picLogout = new System.Windows.Forms.PictureBox();
            this.btnLogout = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.picSettings = new System.Windows.Forms.PictureBox();
            this.btnSettings = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonBorderEdge3 = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.picCustomers = new System.Windows.Forms.PictureBox();
            this.picHome = new System.Windows.Forms.PictureBox();
            this.btnClients = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.picStorage = new System.Windows.Forms.PictureBox();
            this.btnStorage = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnDashboard = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonBorderEdge2 = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.UCHolder = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTransaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.White;
            this.lblName.Font = new System.Drawing.Font("SF Pro Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblName.Location = new System.Drawing.Point(70, 41);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(134, 72);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "JOHN DOE M. MARASIGAN";
            // 
            // kryptonBorderEdge1
            // 
            this.kryptonBorderEdge1.Location = new System.Drawing.Point(18, 90);
            this.kryptonBorderEdge1.Name = "kryptonBorderEdge1";
            this.kryptonBorderEdge1.Size = new System.Drawing.Size(184, 2);
            this.kryptonBorderEdge1.StateCommon.Color1 = System.Drawing.Color.DarkGray;
            this.kryptonBorderEdge1.StateCommon.Width = 2;
            this.kryptonBorderEdge1.Text = "kryptonBorderEdge1";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.picReports);
            this.panel1.Controls.Add(this.btnReports);
            this.panel1.Controls.Add(this.picTransaction);
            this.panel1.Controls.Add(this.btnTransactionLogs);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.picLogout);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.picSettings);
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Controls.Add(this.kryptonBorderEdge3);
            this.panel1.Controls.Add(this.picCustomers);
            this.panel1.Controls.Add(this.picHome);
            this.panel1.Controls.Add(this.btnClients);
            this.panel1.Controls.Add(this.picStorage);
            this.panel1.Controls.Add(this.btnStorage);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Location = new System.Drawing.Point(-2, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 615);
            this.panel1.TabIndex = 23;
            // 
            // picReports
            // 
            this.picReports.BackColor = System.Drawing.Color.Transparent;
            this.picReports.Image = global::Automotive.Properties.Resources.report;
            this.picReports.Location = new System.Drawing.Point(18, 383);
            this.picReports.Name = "picReports";
            this.picReports.Size = new System.Drawing.Size(25, 25);
            this.picReports.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picReports.TabIndex = 34;
            this.picReports.TabStop = false;
            // 
            // btnReports
            // 
            this.btnReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReports.Location = new System.Drawing.Point(12, 374);
            this.btnReports.Name = "btnReports";
            this.btnReports.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.btnReports.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.btnReports.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnReports.OverrideDefault.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnReports.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnReports.OverrideDefault.Border.Rounding = 15;
            this.btnReports.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.btnReports.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.btnReports.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("SF Pro Text", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnReports.Size = new System.Drawing.Size(190, 48);
            this.btnReports.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnReports.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnReports.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.btnReports.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnReports.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnReports.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnReports.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.btnReports.StateCommon.Border.Rounding = 15;
            this.btnReports.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.btnReports.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.btnReports.StateCommon.Content.ShortText.Font = new System.Drawing.Font("SF Pro Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnReports.TabIndex = 35;
            this.btnReports.Values.Text = "        REPORTS";
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            this.btnReports.MouseEnter += new System.EventHandler(this.btnReports_MouseEnter);
            this.btnReports.MouseLeave += new System.EventHandler(this.btnReports_MouseLeave);
            // 
            // picTransaction
            // 
            this.picTransaction.BackColor = System.Drawing.Color.Transparent;
            this.picTransaction.Image = global::Automotive.Properties.Resources.transactionlog;
            this.picTransaction.Location = new System.Drawing.Point(18, 318);
            this.picTransaction.Name = "picTransaction";
            this.picTransaction.Size = new System.Drawing.Size(25, 25);
            this.picTransaction.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTransaction.TabIndex = 32;
            this.picTransaction.TabStop = false;
            // 
            // btnTransactionLogs
            // 
            this.btnTransactionLogs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTransactionLogs.Location = new System.Drawing.Point(12, 309);
            this.btnTransactionLogs.Name = "btnTransactionLogs";
            this.btnTransactionLogs.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.btnTransactionLogs.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.btnTransactionLogs.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnTransactionLogs.OverrideDefault.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnTransactionLogs.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnTransactionLogs.OverrideDefault.Border.Rounding = 15;
            this.btnTransactionLogs.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.btnTransactionLogs.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.btnTransactionLogs.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("SF Pro Text", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnTransactionLogs.Size = new System.Drawing.Size(190, 48);
            this.btnTransactionLogs.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnTransactionLogs.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnTransactionLogs.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.btnTransactionLogs.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnTransactionLogs.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnTransactionLogs.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnTransactionLogs.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.btnTransactionLogs.StateCommon.Border.Rounding = 15;
            this.btnTransactionLogs.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.btnTransactionLogs.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.btnTransactionLogs.StateCommon.Content.ShortText.Font = new System.Drawing.Font("SF Pro Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransactionLogs.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnTransactionLogs.TabIndex = 33;
            this.btnTransactionLogs.Values.Text = "        TRANSACTION LOGS";
            this.btnTransactionLogs.Click += new System.EventHandler(this.btnTransactionLogs_Click);
            this.btnTransactionLogs.MouseEnter += new System.EventHandler(this.btnTransactionLogs_MouseEnter);
            this.btnTransactionLogs.MouseLeave += new System.EventHandler(this.btnTransactionLogs_MouseLeave);
            // 
            // picLogout
            // 
            this.picLogout.BackColor = System.Drawing.Color.Transparent;
            this.picLogout.Image = global::Automotive.Properties.Resources.power;
            this.picLogout.Location = new System.Drawing.Point(18, 536);
            this.picLogout.Name = "picLogout";
            this.picLogout.Size = new System.Drawing.Size(25, 25);
            this.picLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogout.TabIndex = 29;
            this.picLogout.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Location = new System.Drawing.Point(12, 527);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.btnLogout.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.btnLogout.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnLogout.OverrideDefault.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnLogout.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnLogout.OverrideDefault.Border.Rounding = 15;
            this.btnLogout.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.btnLogout.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.btnLogout.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("SF Pro Text", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnLogout.Size = new System.Drawing.Size(190, 48);
            this.btnLogout.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnLogout.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnLogout.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.btnLogout.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnLogout.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnLogout.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnLogout.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.btnLogout.StateCommon.Border.Rounding = 15;
            this.btnLogout.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.btnLogout.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.btnLogout.StateCommon.Content.ShortText.Font = new System.Drawing.Font("SF Pro Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnLogout.TabIndex = 30;
            this.btnLogout.Values.Text = "        LOG OUT";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            this.btnLogout.MouseEnter += new System.EventHandler(this.btnLogout_MouseEnter);
            this.btnLogout.MouseLeave += new System.EventHandler(this.btnLogout_MouseLeave);
            // 
            // picSettings
            // 
            this.picSettings.BackColor = System.Drawing.Color.Transparent;
            this.picSettings.Image = global::Automotive.Properties.Resources.settings;
            this.picSettings.Location = new System.Drawing.Point(18, 475);
            this.picSettings.Name = "picSettings";
            this.picSettings.Size = new System.Drawing.Size(25, 25);
            this.picSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSettings.TabIndex = 27;
            this.picSettings.TabStop = false;
            // 
            // btnSettings
            // 
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.Location = new System.Drawing.Point(12, 466);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.btnSettings.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.btnSettings.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnSettings.OverrideDefault.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnSettings.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSettings.OverrideDefault.Border.Rounding = 15;
            this.btnSettings.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.btnSettings.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.btnSettings.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("SF Pro Text", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSettings.Size = new System.Drawing.Size(190, 48);
            this.btnSettings.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnSettings.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnSettings.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.btnSettings.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnSettings.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnSettings.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSettings.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.btnSettings.StateCommon.Border.Rounding = 15;
            this.btnSettings.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.btnSettings.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.btnSettings.StateCommon.Content.ShortText.Font = new System.Drawing.Font("SF Pro Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnSettings.TabIndex = 28;
            this.btnSettings.Values.Text = "        SETTINGS";
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            this.btnSettings.MouseEnter += new System.EventHandler(this.btnSettings_MouseEnter);
            this.btnSettings.MouseLeave += new System.EventHandler(this.btnSettings_MouseLeave);
            // 
            // kryptonBorderEdge3
            // 
            this.kryptonBorderEdge3.Location = new System.Drawing.Point(18, 444);
            this.kryptonBorderEdge3.Name = "kryptonBorderEdge3";
            this.kryptonBorderEdge3.Size = new System.Drawing.Size(184, 2);
            this.kryptonBorderEdge3.StateCommon.Color1 = System.Drawing.Color.DarkGray;
            this.kryptonBorderEdge3.StateCommon.Width = 2;
            this.kryptonBorderEdge3.Text = "kryptonBorderEdge3";
            // 
            // picCustomers
            // 
            this.picCustomers.BackColor = System.Drawing.Color.Transparent;
            this.picCustomers.Image = global::Automotive.Properties.Resources.people;
            this.picCustomers.Location = new System.Drawing.Point(18, 255);
            this.picCustomers.Name = "picCustomers";
            this.picCustomers.Size = new System.Drawing.Size(25, 25);
            this.picCustomers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCustomers.TabIndex = 25;
            this.picCustomers.TabStop = false;
            // 
            // picHome
            // 
            this.picHome.BackColor = System.Drawing.Color.Transparent;
            this.picHome.Image = global::Automotive.Properties.Resources.home;
            this.picHome.Location = new System.Drawing.Point(18, 125);
            this.picHome.Name = "picHome";
            this.picHome.Size = new System.Drawing.Size(25, 25);
            this.picHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHome.TabIndex = 19;
            this.picHome.TabStop = false;
            // 
            // btnClients
            // 
            this.btnClients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClients.Location = new System.Drawing.Point(12, 246);
            this.btnClients.Name = "btnClients";
            this.btnClients.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.btnClients.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.btnClients.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnClients.OverrideDefault.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnClients.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnClients.OverrideDefault.Border.Rounding = 15;
            this.btnClients.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.btnClients.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.btnClients.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("SF Pro Text", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnClients.Size = new System.Drawing.Size(190, 48);
            this.btnClients.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnClients.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnClients.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.btnClients.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnClients.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnClients.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnClients.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.btnClients.StateCommon.Border.Rounding = 15;
            this.btnClients.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.btnClients.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.btnClients.StateCommon.Content.ShortText.Font = new System.Drawing.Font("SF Pro Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClients.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnClients.TabIndex = 26;
            this.btnClients.Values.Text = "        CLIENTS";
            this.btnClients.Click += new System.EventHandler(this.btnCustomers_Click);
            this.btnClients.MouseEnter += new System.EventHandler(this.btnCustomers_MouseEnter);
            this.btnClients.MouseLeave += new System.EventHandler(this.btnCustomers_MouseLeave);
            // 
            // picStorage
            // 
            this.picStorage.BackColor = System.Drawing.Color.Transparent;
            this.picStorage.Image = global::Automotive.Properties.Resources.storage_box;
            this.picStorage.Location = new System.Drawing.Point(18, 190);
            this.picStorage.Name = "picStorage";
            this.picStorage.Size = new System.Drawing.Size(25, 25);
            this.picStorage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStorage.TabIndex = 23;
            this.picStorage.TabStop = false;
            // 
            // btnStorage
            // 
            this.btnStorage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStorage.Location = new System.Drawing.Point(12, 181);
            this.btnStorage.Name = "btnStorage";
            this.btnStorage.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.btnStorage.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.btnStorage.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnStorage.OverrideDefault.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnStorage.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnStorage.OverrideDefault.Border.Rounding = 15;
            this.btnStorage.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.btnStorage.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.btnStorage.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("SF Pro Text", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnStorage.Size = new System.Drawing.Size(190, 48);
            this.btnStorage.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnStorage.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnStorage.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.btnStorage.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnStorage.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnStorage.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnStorage.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.btnStorage.StateCommon.Border.Rounding = 15;
            this.btnStorage.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.btnStorage.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.btnStorage.StateCommon.Content.ShortText.Font = new System.Drawing.Font("SF Pro Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStorage.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnStorage.TabIndex = 24;
            this.btnStorage.Values.Text = "         STORAGE";
            this.btnStorage.Click += new System.EventHandler(this.btnStorage_Click);
            this.btnStorage.MouseEnter += new System.EventHandler(this.btnStorage_MouseEnter);
            this.btnStorage.MouseLeave += new System.EventHandler(this.btnStorage_MouseLeave);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.Location = new System.Drawing.Point(12, 116);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.btnDashboard.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.btnDashboard.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnDashboard.OverrideDefault.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnDashboard.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDashboard.OverrideDefault.Border.Rounding = 15;
            this.btnDashboard.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.btnDashboard.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.btnDashboard.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("SF Pro Text", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDashboard.Size = new System.Drawing.Size(190, 48);
            this.btnDashboard.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnDashboard.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnDashboard.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.btnDashboard.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnDashboard.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnDashboard.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDashboard.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.btnDashboard.StateCommon.Border.Rounding = 15;
            this.btnDashboard.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.btnDashboard.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.btnDashboard.StateCommon.Content.ShortText.Font = new System.Drawing.Font("SF Pro Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnDashboard.TabIndex = 22;
            this.btnDashboard.Values.Text = "         DASHBOARD";
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            this.btnDashboard.MouseEnter += new System.EventHandler(this.btnHome_MouseEnter);
            this.btnDashboard.MouseLeave += new System.EventHandler(this.btnHome_MouseLeave_1);
            // 
            // kryptonBorderEdge2
            // 
            this.kryptonBorderEdge2.Location = new System.Drawing.Point(220, -3);
            this.kryptonBorderEdge2.Name = "kryptonBorderEdge2";
            this.kryptonBorderEdge2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.kryptonBorderEdge2.Size = new System.Drawing.Size(2, 600);
            this.kryptonBorderEdge2.StateCommon.Color1 = System.Drawing.Color.DarkGray;
            this.kryptonBorderEdge2.StateCommon.Width = 2;
            this.kryptonBorderEdge2.Text = "kryptonBorderEdge2";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(218, -2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 0);
            this.panel2.TabIndex = 24;
            // 
            // UCHolder
            // 
            this.UCHolder.BackColor = System.Drawing.SystemColors.Control;
            this.UCHolder.Location = new System.Drawing.Point(220, -3);
            this.UCHolder.Margin = new System.Windows.Forms.Padding(2);
            this.UCHolder.Name = "UCHolder";
            this.UCHolder.Size = new System.Drawing.Size(835, 602);
            this.UCHolder.TabIndex = 30;
            this.UCHolder.Paint += new System.Windows.Forms.PaintEventHandler(this.UCHolder_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox1.Image = global::Automotive.Properties.Resources.user_gear;
            this.pictureBox1.Location = new System.Drawing.Point(23, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1066, 601);
            this.Controls.Add(this.UCHolder);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.kryptonBorderEdge2);
            this.Controls.Add(this.kryptonBorderEdge1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Palette = this.FormDesign;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Representative Tab";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTransaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette FormDesign;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblName;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge1;
        private System.Windows.Forms.PictureBox picHome;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDashboard;
        private System.Windows.Forms.PictureBox picStorage;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnStorage;
        private System.Windows.Forms.PictureBox picCustomers;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnClients;
        private System.Windows.Forms.PictureBox picSettings;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSettings;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge3;
        private System.Windows.Forms.PictureBox picLogout;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnLogout;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel UCHolder;
        private System.Windows.Forms.PictureBox picReports;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnReports;
        private System.Windows.Forms.PictureBox picTransaction;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnTransactionLogs;
    }
}