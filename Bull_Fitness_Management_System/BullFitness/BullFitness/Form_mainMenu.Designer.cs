namespace BullFitness
{
    partial class Form_mainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_mainMenu));
            this.pnl_headder = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPayment = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnStatistict = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnViewMember = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnAddmember = new Bunifu.Framework.UI.BunifuThinButton2();
            this.userControl_viewMembers = new BullFitness.UserControl_viewMembers();
            this.userControl_statistic = new BullFitness.UserControl_statistic();
            this.userControl_payments = new BullFitness.UserControl_payments();
            this.userControl_addMembers = new BullFitness.UserControl_addMembers();
            this.pnl_headder.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_headder
            // 
            this.pnl_headder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_headder.BackgroundImage")));
            this.pnl_headder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_headder.Controls.Add(this.btnMinimize);
            this.pnl_headder.Controls.Add(this.btnMaximize);
            this.pnl_headder.Controls.Add(this.btnClose);
            this.pnl_headder.Controls.Add(this.btnPayment);
            this.pnl_headder.Controls.Add(this.btnStatistict);
            this.pnl_headder.Controls.Add(this.btnViewMember);
            this.pnl_headder.Controls.Add(this.btnAddmember);
            this.pnl_headder.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_headder.GradientBottomLeft = System.Drawing.Color.Black;
            this.pnl_headder.GradientBottomRight = System.Drawing.Color.Black;
            this.pnl_headder.GradientTopLeft = System.Drawing.Color.Black;
            this.pnl_headder.GradientTopRight = System.Drawing.Color.Black;
            this.pnl_headder.Location = new System.Drawing.Point(0, 0);
            this.pnl_headder.Name = "pnl_headder";
            this.pnl_headder.Quality = 10;
            this.pnl_headder.Size = new System.Drawing.Size(813, 49);
            this.pnl_headder.TabIndex = 0;
            this.pnl_headder.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pnl_headder_MouseDoubleClick);
            this.pnl_headder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_mainMenu_MouseDown);
            this.pnl_headder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_mainMenu_MouseMove);
            this.pnl_headder.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_mainMenu_MouseUp);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimize.BackgroundImage")));
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Location = new System.Drawing.Point(711, 11);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(23, 21);
            this.btnMinimize.TabIndex = 12;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMaximize.BackgroundImage")));
            this.btnMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Location = new System.Drawing.Point(749, 13);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(23, 21);
            this.btnMaximize.TabIndex = 11;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(783, 13);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(23, 21);
            this.btnClose.TabIndex = 5;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.ActiveBorderThickness = 1;
            this.btnPayment.ActiveCornerRadius = 20;
            this.btnPayment.ActiveFillColor = System.Drawing.Color.Red;
            this.btnPayment.ActiveForecolor = System.Drawing.Color.White;
            this.btnPayment.ActiveLineColor = System.Drawing.Color.Red;
            this.btnPayment.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPayment.BackColor = System.Drawing.Color.Black;
            this.btnPayment.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPayment.BackgroundImage")));
            this.btnPayment.ButtonText = "Payments";
            this.btnPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPayment.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.ForeColor = System.Drawing.Color.White;
            this.btnPayment.IdleBorderThickness = 1;
            this.btnPayment.IdleCornerRadius = 20;
            this.btnPayment.IdleFillColor = System.Drawing.Color.Black;
            this.btnPayment.IdleForecolor = System.Drawing.Color.White;
            this.btnPayment.IdleLineColor = System.Drawing.Color.Black;
            this.btnPayment.Location = new System.Drawing.Point(271, 5);
            this.btnPayment.Margin = new System.Windows.Forms.Padding(5);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(129, 41);
            this.btnPayment.TabIndex = 10;
            this.btnPayment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnStatistict
            // 
            this.btnStatistict.ActiveBorderThickness = 1;
            this.btnStatistict.ActiveCornerRadius = 20;
            this.btnStatistict.ActiveFillColor = System.Drawing.Color.Red;
            this.btnStatistict.ActiveForecolor = System.Drawing.Color.White;
            this.btnStatistict.ActiveLineColor = System.Drawing.Color.Red;
            this.btnStatistict.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnStatistict.BackColor = System.Drawing.Color.Black;
            this.btnStatistict.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStatistict.BackgroundImage")));
            this.btnStatistict.ButtonText = "Statistic";
            this.btnStatistict.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStatistict.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistict.ForeColor = System.Drawing.Color.White;
            this.btnStatistict.IdleBorderThickness = 1;
            this.btnStatistict.IdleCornerRadius = 20;
            this.btnStatistict.IdleFillColor = System.Drawing.Color.Black;
            this.btnStatistict.IdleForecolor = System.Drawing.Color.White;
            this.btnStatistict.IdleLineColor = System.Drawing.Color.Black;
            this.btnStatistict.Location = new System.Drawing.Point(404, 5);
            this.btnStatistict.Margin = new System.Windows.Forms.Padding(5);
            this.btnStatistict.Name = "btnStatistict";
            this.btnStatistict.Size = new System.Drawing.Size(129, 41);
            this.btnStatistict.TabIndex = 9;
            this.btnStatistict.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnStatistict.Click += new System.EventHandler(this.btnStatistict_Click);
            // 
            // btnViewMember
            // 
            this.btnViewMember.ActiveBorderThickness = 1;
            this.btnViewMember.ActiveCornerRadius = 20;
            this.btnViewMember.ActiveFillColor = System.Drawing.Color.Red;
            this.btnViewMember.ActiveForecolor = System.Drawing.Color.White;
            this.btnViewMember.ActiveLineColor = System.Drawing.Color.Red;
            this.btnViewMember.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnViewMember.BackColor = System.Drawing.Color.Black;
            this.btnViewMember.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnViewMember.BackgroundImage")));
            this.btnViewMember.ButtonText = "View ";
            this.btnViewMember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewMember.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewMember.ForeColor = System.Drawing.Color.White;
            this.btnViewMember.IdleBorderThickness = 1;
            this.btnViewMember.IdleCornerRadius = 20;
            this.btnViewMember.IdleFillColor = System.Drawing.Color.Black;
            this.btnViewMember.IdleForecolor = System.Drawing.Color.White;
            this.btnViewMember.IdleLineColor = System.Drawing.Color.Black;
            this.btnViewMember.Location = new System.Drawing.Point(138, 5);
            this.btnViewMember.Margin = new System.Windows.Forms.Padding(5);
            this.btnViewMember.Name = "btnViewMember";
            this.btnViewMember.Size = new System.Drawing.Size(129, 41);
            this.btnViewMember.TabIndex = 8;
            this.btnViewMember.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnViewMember.Click += new System.EventHandler(this.btnViewMember_Click);
            // 
            // btnAddmember
            // 
            this.btnAddmember.ActiveBorderThickness = 1;
            this.btnAddmember.ActiveCornerRadius = 20;
            this.btnAddmember.ActiveFillColor = System.Drawing.Color.Red;
            this.btnAddmember.ActiveForecolor = System.Drawing.Color.White;
            this.btnAddmember.ActiveLineColor = System.Drawing.Color.Red;
            this.btnAddmember.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddmember.BackColor = System.Drawing.Color.Black;
            this.btnAddmember.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddmember.BackgroundImage")));
            this.btnAddmember.ButtonText = "Add ";
            this.btnAddmember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddmember.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddmember.ForeColor = System.Drawing.Color.White;
            this.btnAddmember.IdleBorderThickness = 1;
            this.btnAddmember.IdleCornerRadius = 20;
            this.btnAddmember.IdleFillColor = System.Drawing.Color.Black;
            this.btnAddmember.IdleForecolor = System.Drawing.Color.White;
            this.btnAddmember.IdleLineColor = System.Drawing.Color.Black;
            this.btnAddmember.Location = new System.Drawing.Point(5, 5);
            this.btnAddmember.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddmember.Name = "btnAddmember";
            this.btnAddmember.Size = new System.Drawing.Size(129, 41);
            this.btnAddmember.TabIndex = 7;
            this.btnAddmember.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddmember.Click += new System.EventHandler(this.btnAddmember_Click);
            // 
            // userControl_viewMembers
            // 
            this.userControl_viewMembers.BackColor = System.Drawing.Color.Black;
            this.userControl_viewMembers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_viewMembers.Location = new System.Drawing.Point(0, 49);
            this.userControl_viewMembers.Name = "userControl_viewMembers";
            this.userControl_viewMembers.Size = new System.Drawing.Size(813, 437);
            this.userControl_viewMembers.TabIndex = 4;
            this.userControl_viewMembers.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_mainMenu_MouseDown);
            this.userControl_viewMembers.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_mainMenu_MouseMove);
            this.userControl_viewMembers.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_mainMenu_MouseUp);
            // 
            // userControl_statistic
            // 
            this.userControl_statistic.BackColor = System.Drawing.Color.Black;
            this.userControl_statistic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_statistic.Location = new System.Drawing.Point(0, 49);
            this.userControl_statistic.Name = "userControl_statistic";
            this.userControl_statistic.Size = new System.Drawing.Size(813, 437);
            this.userControl_statistic.TabIndex = 3;
            // 
            // userControl_payments
            // 
            this.userControl_payments.BackColor = System.Drawing.Color.Black;
            this.userControl_payments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_payments.Location = new System.Drawing.Point(0, 49);
            this.userControl_payments.Name = "userControl_payments";
            this.userControl_payments.Size = new System.Drawing.Size(813, 437);
            this.userControl_payments.TabIndex = 2;
            // 
            // userControl_addMembers
            // 
            this.userControl_addMembers.BackColor = System.Drawing.Color.Black;
            this.userControl_addMembers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_addMembers.Location = new System.Drawing.Point(0, 49);
            this.userControl_addMembers.Name = "userControl_addMembers";
            this.userControl_addMembers.Size = new System.Drawing.Size(813, 437);
            this.userControl_addMembers.TabIndex = 1;
            // 
            // Form_mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(813, 486);
            this.Controls.Add(this.userControl_viewMembers);
            this.Controls.Add(this.userControl_statistic);
            this.Controls.Add(this.userControl_payments);
            this.Controls.Add(this.userControl_addMembers);
            this.Controls.Add(this.pnl_headder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_mainMenu";
            this.Text = "Form_mainMenu";
            this.Load += new System.EventHandler(this.Form_mainMenu_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_mainMenu_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_mainMenu_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_mainMenu_MouseUp);
            this.pnl_headder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel pnl_headder;
        private Bunifu.Framework.UI.BunifuThinButton2 btnPayment;
        private Bunifu.Framework.UI.BunifuThinButton2 btnStatistict;
        private Bunifu.Framework.UI.BunifuThinButton2 btnViewMember;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAddmember;
        private UserControl_addMembers userControl_addMembers;
        private UserControl_payments userControl_payments;
        private UserControl_statistic userControl_statistic;
        private UserControl_viewMembers userControl_viewMembers;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnMinimize;
    }
}