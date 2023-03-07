namespace gym.views
{
    partial class frm_Reports
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
            this.pnl_title_login = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Titel = new System.Windows.Forms.Label();
            this.pnl_Operation = new System.Windows.Forms.Panel();
            this.btn_SaveCustamer = new System.Windows.Forms.Button();
            this.btn_ShowCustamer = new System.Windows.Forms.Button();
            this.cmb_Type_Report = new System.Windows.Forms.ComboBox();
            this.dgv_Custamers = new System.Windows.Forms.DataGridView();
            this.chShowReportDetails = new System.Windows.Forms.CheckBox();
            this.dtpMonthNow = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtpMonthNext = new System.Windows.Forms.DateTimePicker();
            this.pnl_title_login.SuspendLayout();
            this.pnl_Operation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Custamers)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_title_login
            // 
            this.pnl_title_login.BackColor = System.Drawing.Color.SteelBlue;
            this.pnl_title_login.Controls.Add(this.panel1);
            this.pnl_title_login.Controls.Add(this.lbl_Titel);
            this.pnl_title_login.Location = new System.Drawing.Point(0, 0);
            this.pnl_title_login.Name = "pnl_title_login";
            this.pnl_title_login.Size = new System.Drawing.Size(880, 51);
            this.pnl_title_login.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::gym.Properties.Resources.shutdown5;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(822, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(63, 48);
            this.panel1.TabIndex = 8;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // lbl_Titel
            // 
            this.lbl_Titel.AutoSize = true;
            this.lbl_Titel.Font = new System.Drawing.Font("SimSun-ExtB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titel.ForeColor = System.Drawing.Color.White;
            this.lbl_Titel.Location = new System.Drawing.Point(397, 9);
            this.lbl_Titel.Name = "lbl_Titel";
            this.lbl_Titel.Size = new System.Drawing.Size(119, 27);
            this.lbl_Titel.TabIndex = 6;
            this.lbl_Titel.Text = "عرض التقارير\r\n";
            this.lbl_Titel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_Operation
            // 
            this.pnl_Operation.BackColor = System.Drawing.Color.SteelBlue;
            this.pnl_Operation.Controls.Add(this.btn_SaveCustamer);
            this.pnl_Operation.Controls.Add(this.btn_ShowCustamer);
            this.pnl_Operation.Location = new System.Drawing.Point(0, 413);
            this.pnl_Operation.Name = "pnl_Operation";
            this.pnl_Operation.Size = new System.Drawing.Size(880, 44);
            this.pnl_Operation.TabIndex = 13;
            this.pnl_Operation.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Operation_Paint);
            // 
            // btn_SaveCustamer
            // 
            this.btn_SaveCustamer.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_SaveCustamer.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_SaveCustamer.Image = global::gym.Properties.Resources.statistics;
            this.btn_SaveCustamer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_SaveCustamer.Location = new System.Drawing.Point(499, 4);
            this.btn_SaveCustamer.Name = "btn_SaveCustamer";
            this.btn_SaveCustamer.Size = new System.Drawing.Size(128, 37);
            this.btn_SaveCustamer.TabIndex = 11;
            this.btn_SaveCustamer.Text = "عرض";
            this.btn_SaveCustamer.UseVisualStyleBackColor = false;
            // 
            // btn_ShowCustamer
            // 
            this.btn_ShowCustamer.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_ShowCustamer.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_ShowCustamer.Image = global::gym.Properties.Resources.Printer;
            this.btn_ShowCustamer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ShowCustamer.Location = new System.Drawing.Point(305, 4);
            this.btn_ShowCustamer.Name = "btn_ShowCustamer";
            this.btn_ShowCustamer.Size = new System.Drawing.Size(128, 37);
            this.btn_ShowCustamer.TabIndex = 12;
            this.btn_ShowCustamer.Text = "طباعة";
            this.btn_ShowCustamer.UseVisualStyleBackColor = false;
            // 
            // cmb_Type_Report
            // 
            this.cmb_Type_Report.FormattingEnabled = true;
            this.cmb_Type_Report.Items.AddRange(new object[] {
            "تقارير يومية",
            "تقارير شهرية"});
            this.cmb_Type_Report.Location = new System.Drawing.Point(499, 68);
            this.cmb_Type_Report.Name = "cmb_Type_Report";
            this.cmb_Type_Report.Size = new System.Drawing.Size(321, 29);
            this.cmb_Type_Report.TabIndex = 14;
            this.cmb_Type_Report.Text = "أختيار نوع التقارير";
            // 
            // dgv_Custamers
            // 
            this.dgv_Custamers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Custamers.Location = new System.Drawing.Point(-1, 114);
            this.dgv_Custamers.Name = "dgv_Custamers";
            this.dgv_Custamers.Size = new System.Drawing.Size(881, 293);
            this.dgv_Custamers.TabIndex = 15;
            // 
            // chShowReportDetails
            // 
            this.chShowReportDetails.AutoSize = true;
            this.chShowReportDetails.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chShowReportDetails.Location = new System.Drawing.Point(267, 72);
            this.chShowReportDetails.Name = "chShowReportDetails";
            this.chShowReportDetails.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chShowReportDetails.Size = new System.Drawing.Size(128, 21);
            this.chShowReportDetails.TabIndex = 16;
            this.chShowReportDetails.Text = "عرض تقرير تفصيلي";
            this.chShowReportDetails.UseVisualStyleBackColor = true;
            this.chShowReportDetails.CheckedChanged += new System.EventHandler(this.chShowReportDetails_CheckedChanged);
            // 
            // dtpMonthNow
            // 
            this.dtpMonthNow.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMonthNow.Location = new System.Drawing.Point(157, 68);
            this.dtpMonthNow.Name = "dtpMonthNow";
            this.dtpMonthNow.Size = new System.Drawing.Size(104, 29);
            this.dtpMonthNow.TabIndex = 17;
            this.dtpMonthNow.Visible = false;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(122, 72);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(29, 21);
            this.lblTo.TabIndex = 18;
            this.lblTo.Text = "الي";
            this.lblTo.Visible = false;
            // 
            // dtpMonthNext
            // 
            this.dtpMonthNext.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMonthNext.Location = new System.Drawing.Point(12, 68);
            this.dtpMonthNext.Name = "dtpMonthNext";
            this.dtpMonthNext.Size = new System.Drawing.Size(104, 29);
            this.dtpMonthNext.TabIndex = 19;
            this.dtpMonthNext.Visible = false;
            // 
            // frm_Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(880, 457);
            this.Controls.Add(this.dtpMonthNext);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.dtpMonthNow);
            this.Controls.Add(this.chShowReportDetails);
            this.Controls.Add(this.dgv_Custamers);
            this.Controls.Add(this.cmb_Type_Report);
            this.Controls.Add(this.pnl_Operation);
            this.Controls.Add(this.pnl_title_login);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frm_Reports";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Reports";
            this.pnl_title_login.ResumeLayout(false);
            this.pnl_title_login.PerformLayout();
            this.pnl_Operation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Custamers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_title_login;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Titel;
        private System.Windows.Forms.Panel pnl_Operation;
        private System.Windows.Forms.Button btn_SaveCustamer;
        private System.Windows.Forms.Button btn_ShowCustamer;
        private System.Windows.Forms.ComboBox cmb_Type_Report;
        private System.Windows.Forms.DataGridView dgv_Custamers;
        private System.Windows.Forms.CheckBox chShowReportDetails;
        private System.Windows.Forms.DateTimePicker dtpMonthNow;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dtpMonthNext;
    }
}