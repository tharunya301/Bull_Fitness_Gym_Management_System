namespace BullFitness
{
    partial class UserControl_statistic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_statistic));
            this.pnl_headder = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnPendingPayment = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnOutsanding = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pnlOutsanding = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnReset = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnSearchPayments = new Bunifu.Framework.UI.BunifuThinButton2();
            this.datePicker2 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label8 = new System.Windows.Forms.Label();
            this.datePicker1 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.labelIndicator = new System.Windows.Forms.Label();
            this.labelIncome = new System.Windows.Forms.Label();
            this.labelIncomeValue = new System.Windows.Forms.Label();
            this.labelDeficit = new System.Windows.Forms.Label();
            this.labelDeficitValue = new System.Windows.Forms.Label();
            this.dataGridView_Outsanding = new System.Windows.Forms.DataGridView();
            this.txtMemberID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlPendingPayment = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnSearchDateBetween = new Bunifu.Framework.UI.BunifuThinButton2();
            this.datePickerPendingDate2 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dropDownDate = new Bunifu.Framework.UI.BunifuDropdown();
            this.datePickerPendingDate1 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.dataGridViewPendingPayments = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnl_headder.SuspendLayout();
            this.pnlOutsanding.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Outsanding)).BeginInit();
            this.pnlPendingPayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPendingPayments)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_headder
            // 
            this.pnl_headder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_headder.BackgroundImage")));
            this.pnl_headder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_headder.Controls.Add(this.btnPendingPayment);
            this.pnl_headder.Controls.Add(this.btnOutsanding);
            this.pnl_headder.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_headder.GradientBottomLeft = System.Drawing.Color.Black;
            this.pnl_headder.GradientBottomRight = System.Drawing.Color.Black;
            this.pnl_headder.GradientTopLeft = System.Drawing.Color.Black;
            this.pnl_headder.GradientTopRight = System.Drawing.Color.Black;
            this.pnl_headder.Location = new System.Drawing.Point(0, 0);
            this.pnl_headder.Name = "pnl_headder";
            this.pnl_headder.Quality = 10;
            this.pnl_headder.Size = new System.Drawing.Size(813, 44);
            this.pnl_headder.TabIndex = 17;
            // 
            // btnPendingPayment
            // 
            this.btnPendingPayment.ActiveBorderThickness = 1;
            this.btnPendingPayment.ActiveCornerRadius = 20;
            this.btnPendingPayment.ActiveFillColor = System.Drawing.Color.Red;
            this.btnPendingPayment.ActiveForecolor = System.Drawing.Color.White;
            this.btnPendingPayment.ActiveLineColor = System.Drawing.Color.Red;
            this.btnPendingPayment.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPendingPayment.BackColor = System.Drawing.Color.Black;
            this.btnPendingPayment.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPendingPayment.BackgroundImage")));
            this.btnPendingPayment.ButtonText = "Pending Payments";
            this.btnPendingPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPendingPayment.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPendingPayment.ForeColor = System.Drawing.Color.White;
            this.btnPendingPayment.IdleBorderThickness = 1;
            this.btnPendingPayment.IdleCornerRadius = 20;
            this.btnPendingPayment.IdleFillColor = System.Drawing.Color.Black;
            this.btnPendingPayment.IdleForecolor = System.Drawing.Color.Red;
            this.btnPendingPayment.IdleLineColor = System.Drawing.Color.Black;
            this.btnPendingPayment.Location = new System.Drawing.Point(461, 4);
            this.btnPendingPayment.Margin = new System.Windows.Forms.Padding(5);
            this.btnPendingPayment.Name = "btnPendingPayment";
            this.btnPendingPayment.Size = new System.Drawing.Size(193, 37);
            this.btnPendingPayment.TabIndex = 10;
            this.btnPendingPayment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPendingPayment.Click += new System.EventHandler(this.btnPendingPayment_Click);
            // 
            // btnOutsanding
            // 
            this.btnOutsanding.ActiveBorderThickness = 1;
            this.btnOutsanding.ActiveCornerRadius = 20;
            this.btnOutsanding.ActiveFillColor = System.Drawing.Color.Red;
            this.btnOutsanding.ActiveForecolor = System.Drawing.Color.White;
            this.btnOutsanding.ActiveLineColor = System.Drawing.Color.Red;
            this.btnOutsanding.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnOutsanding.BackColor = System.Drawing.Color.Black;
            this.btnOutsanding.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOutsanding.BackgroundImage")));
            this.btnOutsanding.ButtonText = "Payments";
            this.btnOutsanding.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOutsanding.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOutsanding.ForeColor = System.Drawing.Color.White;
            this.btnOutsanding.IdleBorderThickness = 1;
            this.btnOutsanding.IdleCornerRadius = 20;
            this.btnOutsanding.IdleFillColor = System.Drawing.Color.Black;
            this.btnOutsanding.IdleForecolor = System.Drawing.Color.Red;
            this.btnOutsanding.IdleLineColor = System.Drawing.Color.Black;
            this.btnOutsanding.Location = new System.Drawing.Point(228, 4);
            this.btnOutsanding.Margin = new System.Windows.Forms.Padding(5);
            this.btnOutsanding.Name = "btnOutsanding";
            this.btnOutsanding.Size = new System.Drawing.Size(188, 37);
            this.btnOutsanding.TabIndex = 7;
            this.btnOutsanding.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOutsanding.Click += new System.EventHandler(this.btnOutsanding_Click);
            // 
            // pnlOutsanding
            // 
            this.pnlOutsanding.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlOutsanding.BackgroundImage")));
            this.pnlOutsanding.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlOutsanding.Controls.Add(this.btnReset);
            this.pnlOutsanding.Controls.Add(this.btnSearchPayments);
            this.pnlOutsanding.Controls.Add(this.datePicker2);
            this.pnlOutsanding.Controls.Add(this.label8);
            this.pnlOutsanding.Controls.Add(this.datePicker1);
            this.pnlOutsanding.Controls.Add(this.labelIndicator);
            this.pnlOutsanding.Controls.Add(this.labelIncome);
            this.pnlOutsanding.Controls.Add(this.labelIncomeValue);
            this.pnlOutsanding.Controls.Add(this.labelDeficit);
            this.pnlOutsanding.Controls.Add(this.labelDeficitValue);
            this.pnlOutsanding.Controls.Add(this.dataGridView_Outsanding);
            this.pnlOutsanding.Controls.Add(this.txtMemberID);
            this.pnlOutsanding.Controls.Add(this.txtName);
            this.pnlOutsanding.Controls.Add(this.label1);
            this.pnlOutsanding.Controls.Add(this.label2);
            this.pnlOutsanding.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOutsanding.GradientBottomLeft = System.Drawing.Color.Black;
            this.pnlOutsanding.GradientBottomRight = System.Drawing.Color.Black;
            this.pnlOutsanding.GradientTopLeft = System.Drawing.Color.Black;
            this.pnlOutsanding.GradientTopRight = System.Drawing.Color.Black;
            this.pnlOutsanding.Location = new System.Drawing.Point(0, 44);
            this.pnlOutsanding.Name = "pnlOutsanding";
            this.pnlOutsanding.Quality = 10;
            this.pnlOutsanding.Size = new System.Drawing.Size(813, 349);
            this.pnlOutsanding.TabIndex = 14;
            // 
            // btnReset
            // 
            this.btnReset.ActiveBorderThickness = 1;
            this.btnReset.ActiveCornerRadius = 20;
            this.btnReset.ActiveFillColor = System.Drawing.Color.Red;
            this.btnReset.ActiveForecolor = System.Drawing.Color.White;
            this.btnReset.ActiveLineColor = System.Drawing.Color.Red;
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.BackColor = System.Drawing.Color.Black;
            this.btnReset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReset.BackgroundImage")));
            this.btnReset.ButtonText = "Reset";
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.IdleBorderThickness = 1;
            this.btnReset.IdleCornerRadius = 20;
            this.btnReset.IdleFillColor = System.Drawing.Color.Black;
            this.btnReset.IdleForecolor = System.Drawing.Color.White;
            this.btnReset.IdleLineColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(708, 311);
            this.btnReset.Margin = new System.Windows.Forms.Padding(5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(102, 33);
            this.btnReset.TabIndex = 65;
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSearchPayments
            // 
            this.btnSearchPayments.ActiveBorderThickness = 1;
            this.btnSearchPayments.ActiveCornerRadius = 20;
            this.btnSearchPayments.ActiveFillColor = System.Drawing.Color.Red;
            this.btnSearchPayments.ActiveForecolor = System.Drawing.Color.White;
            this.btnSearchPayments.ActiveLineColor = System.Drawing.Color.Red;
            this.btnSearchPayments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchPayments.BackColor = System.Drawing.Color.Black;
            this.btnSearchPayments.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearchPayments.BackgroundImage")));
            this.btnSearchPayments.ButtonText = "Search";
            this.btnSearchPayments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchPayments.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnSearchPayments.ForeColor = System.Drawing.Color.White;
            this.btnSearchPayments.IdleBorderThickness = 1;
            this.btnSearchPayments.IdleCornerRadius = 20;
            this.btnSearchPayments.IdleFillColor = System.Drawing.Color.Black;
            this.btnSearchPayments.IdleForecolor = System.Drawing.Color.White;
            this.btnSearchPayments.IdleLineColor = System.Drawing.Color.White;
            this.btnSearchPayments.Location = new System.Drawing.Point(606, 311);
            this.btnSearchPayments.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearchPayments.Name = "btnSearchPayments";
            this.btnSearchPayments.Size = new System.Drawing.Size(98, 33);
            this.btnSearchPayments.TabIndex = 64;
            this.btnSearchPayments.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearchPayments.Click += new System.EventHandler(this.btnSearchPayments_Click);
            // 
            // datePicker2
            // 
            this.datePicker2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.datePicker2.BackColor = System.Drawing.Color.Black;
            this.datePicker2.BorderRadius = 0;
            this.datePicker2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.datePicker2.ForeColor = System.Drawing.Color.White;
            this.datePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.datePicker2.FormatCustom = null;
            this.datePicker2.Location = new System.Drawing.Point(634, 0);
            this.datePicker2.Name = "datePicker2";
            this.datePicker2.Size = new System.Drawing.Size(176, 35);
            this.datePicker2.TabIndex = 63;
            this.datePicker2.Value = new System.DateTime(2021, 3, 22, 12, 22, 49, 307);
            this.datePicker2.onValueChanged += new System.EventHandler(this.datePicker2_onValueChanged);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(619, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 16);
            this.label8.TabIndex = 62;
            this.label8.Text = "-";
            // 
            // datePicker1
            // 
            this.datePicker1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.datePicker1.BackColor = System.Drawing.Color.Black;
            this.datePicker1.BorderRadius = 0;
            this.datePicker1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.datePicker1.ForeColor = System.Drawing.Color.White;
            this.datePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.datePicker1.FormatCustom = null;
            this.datePicker1.Location = new System.Drawing.Point(455, 0);
            this.datePicker1.Name = "datePicker1";
            this.datePicker1.Size = new System.Drawing.Size(161, 35);
            this.datePicker1.TabIndex = 61;
            this.datePicker1.Value = new System.DateTime(2021, 3, 22, 12, 22, 49, 307);
            // 
            // labelIndicator
            // 
            this.labelIndicator.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelIndicator.AutoSize = true;
            this.labelIndicator.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIndicator.ForeColor = System.Drawing.Color.Red;
            this.labelIndicator.Location = new System.Drawing.Point(562, 313);
            this.labelIndicator.Name = "labelIndicator";
            this.labelIndicator.Size = new System.Drawing.Size(26, 32);
            this.labelIndicator.TabIndex = 60;
            this.labelIndicator.Text = "-";
            this.labelIndicator.Visible = false;
            // 
            // labelIncome
            // 
            this.labelIncome.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelIncome.AutoSize = true;
            this.labelIncome.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIncome.ForeColor = System.Drawing.Color.White;
            this.labelIncome.Location = new System.Drawing.Point(224, 318);
            this.labelIncome.Name = "labelIncome";
            this.labelIncome.Size = new System.Drawing.Size(92, 23);
            this.labelIncome.TabIndex = 59;
            this.labelIncome.Text = "Income:";
            this.labelIncome.Visible = false;
            // 
            // labelIncomeValue
            // 
            this.labelIncomeValue.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelIncomeValue.AutoSize = true;
            this.labelIncomeValue.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIncomeValue.ForeColor = System.Drawing.Color.White;
            this.labelIncomeValue.Location = new System.Drawing.Point(321, 318);
            this.labelIncomeValue.Name = "labelIncomeValue";
            this.labelIncomeValue.Size = new System.Drawing.Size(21, 23);
            this.labelIncomeValue.TabIndex = 58;
            this.labelIncomeValue.Text = "0";
            this.labelIncomeValue.Visible = false;
            // 
            // labelDeficit
            // 
            this.labelDeficit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelDeficit.AutoSize = true;
            this.labelDeficit.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeficit.ForeColor = System.Drawing.Color.White;
            this.labelDeficit.Location = new System.Drawing.Point(396, 318);
            this.labelDeficit.Name = "labelDeficit";
            this.labelDeficit.Size = new System.Drawing.Size(78, 23);
            this.labelDeficit.TabIndex = 57;
            this.labelDeficit.Text = "Deficit:";
            this.labelDeficit.Visible = false;
            // 
            // labelDeficitValue
            // 
            this.labelDeficitValue.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelDeficitValue.AutoSize = true;
            this.labelDeficitValue.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeficitValue.ForeColor = System.Drawing.Color.White;
            this.labelDeficitValue.Location = new System.Drawing.Point(483, 318);
            this.labelDeficitValue.Name = "labelDeficitValue";
            this.labelDeficitValue.Size = new System.Drawing.Size(21, 23);
            this.labelDeficitValue.TabIndex = 56;
            this.labelDeficitValue.Text = "0";
            this.labelDeficitValue.Visible = false;
            // 
            // dataGridView_Outsanding
            // 
            this.dataGridView_Outsanding.AllowUserToAddRows = false;
            this.dataGridView_Outsanding.AllowUserToDeleteRows = false;
            this.dataGridView_Outsanding.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Outsanding.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Outsanding.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Outsanding.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Outsanding.Location = new System.Drawing.Point(1, 36);
            this.dataGridView_Outsanding.Name = "dataGridView_Outsanding";
            this.dataGridView_Outsanding.ReadOnly = true;
            this.dataGridView_Outsanding.Size = new System.Drawing.Size(810, 275);
            this.dataGridView_Outsanding.TabIndex = 44;
            // 
            // txtMemberID
            // 
            this.txtMemberID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMemberID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMemberID.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtMemberID.ForeColor = System.Drawing.Color.White;
            this.txtMemberID.HintForeColor = System.Drawing.Color.White;
            this.txtMemberID.HintText = "Member ID";
            this.txtMemberID.isPassword = false;
            this.txtMemberID.LineFocusedColor = System.Drawing.Color.White;
            this.txtMemberID.LineIdleColor = System.Drawing.Color.White;
            this.txtMemberID.LineMouseHoverColor = System.Drawing.Color.White;
            this.txtMemberID.LineThickness = 1;
            this.txtMemberID.Location = new System.Drawing.Point(10, 4);
            this.txtMemberID.Margin = new System.Windows.Forms.Padding(4);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(208, 25);
            this.txtMemberID.TabIndex = 43;
            this.txtMemberID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMemberID.OnValueChanged += new System.EventHandler(this.txtMemberID_OnValueChanged);
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.HintForeColor = System.Drawing.Color.White;
            this.txtName.HintText = "Name";
            this.txtName.isPassword = false;
            this.txtName.LineFocusedColor = System.Drawing.Color.White;
            this.txtName.LineIdleColor = System.Drawing.Color.White;
            this.txtName.LineMouseHoverColor = System.Drawing.Color.White;
            this.txtName.LineThickness = 1;
            this.txtName.Location = new System.Drawing.Point(239, 4);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(208, 25);
            this.txtName.TabIndex = 42;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtName.OnValueChanged += new System.EventHandler(this.txtName_OnValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(77, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 32);
            this.label1.TabIndex = 20;
            this.label1.Text = "FITNESS";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(8, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 32);
            this.label2.TabIndex = 19;
            this.label2.Text = "BULL";
            // 
            // pnlPendingPayment
            // 
            this.pnlPendingPayment.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlPendingPayment.BackgroundImage")));
            this.pnlPendingPayment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlPendingPayment.Controls.Add(this.btnSearchDateBetween);
            this.pnlPendingPayment.Controls.Add(this.datePickerPendingDate2);
            this.pnlPendingPayment.Controls.Add(this.label5);
            this.pnlPendingPayment.Controls.Add(this.label9);
            this.pnlPendingPayment.Controls.Add(this.dropDownDate);
            this.pnlPendingPayment.Controls.Add(this.datePickerPendingDate1);
            this.pnlPendingPayment.Controls.Add(this.dataGridViewPendingPayments);
            this.pnlPendingPayment.Controls.Add(this.label3);
            this.pnlPendingPayment.Controls.Add(this.label4);
            this.pnlPendingPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPendingPayment.GradientBottomLeft = System.Drawing.Color.Black;
            this.pnlPendingPayment.GradientBottomRight = System.Drawing.Color.Black;
            this.pnlPendingPayment.GradientTopLeft = System.Drawing.Color.Black;
            this.pnlPendingPayment.GradientTopRight = System.Drawing.Color.Black;
            this.pnlPendingPayment.Location = new System.Drawing.Point(0, 44);
            this.pnlPendingPayment.Name = "pnlPendingPayment";
            this.pnlPendingPayment.Quality = 10;
            this.pnlPendingPayment.Size = new System.Drawing.Size(813, 349);
            this.pnlPendingPayment.TabIndex = 18;
            // 
            // btnSearchDateBetween
            // 
            this.btnSearchDateBetween.ActiveBorderThickness = 1;
            this.btnSearchDateBetween.ActiveCornerRadius = 20;
            this.btnSearchDateBetween.ActiveFillColor = System.Drawing.Color.Red;
            this.btnSearchDateBetween.ActiveForecolor = System.Drawing.Color.White;
            this.btnSearchDateBetween.ActiveLineColor = System.Drawing.Color.Red;
            this.btnSearchDateBetween.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearchDateBetween.BackColor = System.Drawing.Color.Black;
            this.btnSearchDateBetween.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearchDateBetween.BackgroundImage")));
            this.btnSearchDateBetween.ButtonText = "Search";
            this.btnSearchDateBetween.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchDateBetween.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchDateBetween.ForeColor = System.Drawing.Color.White;
            this.btnSearchDateBetween.IdleBorderThickness = 1;
            this.btnSearchDateBetween.IdleCornerRadius = 20;
            this.btnSearchDateBetween.IdleFillColor = System.Drawing.Color.Black;
            this.btnSearchDateBetween.IdleForecolor = System.Drawing.Color.White;
            this.btnSearchDateBetween.IdleLineColor = System.Drawing.Color.White;
            this.btnSearchDateBetween.Location = new System.Drawing.Point(696, 5);
            this.btnSearchDateBetween.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchDateBetween.Name = "btnSearchDateBetween";
            this.btnSearchDateBetween.Size = new System.Drawing.Size(110, 35);
            this.btnSearchDateBetween.TabIndex = 50;
            this.btnSearchDateBetween.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearchDateBetween.Click += new System.EventHandler(this.btnSearchDateBetween_Click);
            // 
            // datePickerPendingDate2
            // 
            this.datePickerPendingDate2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.datePickerPendingDate2.BackColor = System.Drawing.Color.Black;
            this.datePickerPendingDate2.BorderRadius = 0;
            this.datePickerPendingDate2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.datePickerPendingDate2.ForeColor = System.Drawing.Color.White;
            this.datePickerPendingDate2.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.datePickerPendingDate2.FormatCustom = null;
            this.datePickerPendingDate2.Location = new System.Drawing.Point(466, 5);
            this.datePickerPendingDate2.Name = "datePickerPendingDate2";
            this.datePickerPendingDate2.Size = new System.Drawing.Size(205, 35);
            this.datePickerPendingDate2.TabIndex = 49;
            this.datePickerPendingDate2.Value = new System.DateTime(2021, 3, 22, 12, 22, 49, 307);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(399, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 48;
            this.label5.Text = "Between";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(9, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 17);
            this.label9.TabIndex = 47;
            this.label9.Text = "Date:";
            // 
            // dropDownDate
            // 
            this.dropDownDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dropDownDate.BackColor = System.Drawing.Color.Transparent;
            this.dropDownDate.BorderRadius = 3;
            this.dropDownDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dropDownDate.ForeColor = System.Drawing.Color.White;
            this.dropDownDate.Items = new string[0];
            this.dropDownDate.Location = new System.Drawing.Point(6, 5);
            this.dropDownDate.Name = "dropDownDate";
            this.dropDownDate.NomalColor = System.Drawing.Color.Black;
            this.dropDownDate.onHoverColor = System.Drawing.Color.Red;
            this.dropDownDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dropDownDate.selectedIndex = -1;
            this.dropDownDate.Size = new System.Drawing.Size(176, 35);
            this.dropDownDate.TabIndex = 46;
            this.dropDownDate.onItemSelected += new System.EventHandler(this.dropDownDate_onItemSelected);
            // 
            // datePickerPendingDate1
            // 
            this.datePickerPendingDate1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.datePickerPendingDate1.BackColor = System.Drawing.Color.Black;
            this.datePickerPendingDate1.BorderRadius = 0;
            this.datePickerPendingDate1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.datePickerPendingDate1.ForeColor = System.Drawing.Color.White;
            this.datePickerPendingDate1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.datePickerPendingDate1.FormatCustom = null;
            this.datePickerPendingDate1.Location = new System.Drawing.Point(188, 5);
            this.datePickerPendingDate1.Name = "datePickerPendingDate1";
            this.datePickerPendingDate1.Size = new System.Drawing.Size(205, 35);
            this.datePickerPendingDate1.TabIndex = 45;
            this.datePickerPendingDate1.Value = new System.DateTime(2021, 3, 22, 12, 22, 49, 307);
            // 
            // dataGridViewPendingPayments
            // 
            this.dataGridViewPendingPayments.AllowUserToAddRows = false;
            this.dataGridViewPendingPayments.AllowUserToDeleteRows = false;
            this.dataGridViewPendingPayments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPendingPayments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPendingPayments.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewPendingPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPendingPayments.Location = new System.Drawing.Point(1, 45);
            this.dataGridViewPendingPayments.Name = "dataGridViewPendingPayments";
            this.dataGridViewPendingPayments.ReadOnly = true;
            this.dataGridViewPendingPayments.Size = new System.Drawing.Size(810, 266);
            this.dataGridViewPendingPayments.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(73, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 32);
            this.label3.TabIndex = 20;
            this.label3.Text = "FITNESS";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(4, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 32);
            this.label4.TabIndex = 19;
            this.label4.Text = "BULL";
            // 
            // UserControl_statistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.pnlOutsanding);
            this.Controls.Add(this.pnlPendingPayment);
            this.Controls.Add(this.pnl_headder);
            this.Name = "UserControl_statistic";
            this.Size = new System.Drawing.Size(813, 393);
            this.Load += new System.EventHandler(this.UserControl_statistic_Load);
            this.pnl_headder.ResumeLayout(false);
            this.pnlOutsanding.ResumeLayout(false);
            this.pnlOutsanding.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Outsanding)).EndInit();
            this.pnlPendingPayment.ResumeLayout(false);
            this.pnlPendingPayment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPendingPayments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuGradientPanel pnl_headder;
        private Bunifu.Framework.UI.BunifuThinButton2 btnPendingPayment;
        private Bunifu.Framework.UI.BunifuThinButton2 btnOutsanding;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlOutsanding;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtMemberID;
        private System.Windows.Forms.DataGridView dataGridView_Outsanding;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlPendingPayment;
        private System.Windows.Forms.DataGridView dataGridViewPendingPayments;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuDatepicker datePickerPendingDate1;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuDropdown dropDownDate;
        private Bunifu.Framework.UI.BunifuDatepicker datePickerPendingDate2;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSearchDateBetween;
        private System.Windows.Forms.Label labelIndicator;
        private System.Windows.Forms.Label labelIncome;
        private System.Windows.Forms.Label labelIncomeValue;
        private System.Windows.Forms.Label labelDeficit;
        private System.Windows.Forms.Label labelDeficitValue;
        private Bunifu.Framework.UI.BunifuDatepicker datePicker2;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuDatepicker datePicker1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnReset;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSearchPayments;
    }
}
