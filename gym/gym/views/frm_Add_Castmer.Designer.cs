namespace gym.views
{
    partial class frm_Add_Castmer
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
            this.chbSupscriptionManth = new System.Windows.Forms.CheckBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.cmpSupscriptionManth = new System.Windows.Forms.ComboBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtHeigth = new System.Windows.Forms.TextBox();
            this.txtNameSupscription = new System.Windows.Forms.TextBox();
            this.lblHeigth = new System.Windows.Forms.Label();
            this.lblNameSupscription = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtChronicDisease = new System.Windows.Forms.TextBox();
            this.lblChronicDisease = new System.Windows.Forms.Label();
            this.dtpDateSubscription = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.gbSupscriptionManth = new System.Windows.Forms.GroupBox();
            this.dgvShowSupscription = new System.Windows.Forms.DataGridView();
            this.pnl_title_login.SuspendLayout();
            this.pnl_Operation.SuspendLayout();
            this.gbSupscriptionManth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowSupscription)).BeginInit();
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
            this.pnl_title_login.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::gym.Properties.Resources.shutdown5;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(822, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(63, 48);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // lbl_Titel
            // 
            this.lbl_Titel.AutoSize = true;
            this.lbl_Titel.Font = new System.Drawing.Font("SimSun-ExtB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titel.ForeColor = System.Drawing.Color.White;
            this.lbl_Titel.Location = new System.Drawing.Point(366, 9);
            this.lbl_Titel.Name = "lbl_Titel";
            this.lbl_Titel.Size = new System.Drawing.Size(149, 27);
            this.lbl_Titel.TabIndex = 6;
            this.lbl_Titel.Text = "أضافة مشترك جديد";
            this.lbl_Titel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_Operation
            // 
            this.pnl_Operation.BackColor = System.Drawing.Color.SteelBlue;
            this.pnl_Operation.Controls.Add(this.btn_SaveCustamer);
            this.pnl_Operation.Controls.Add(this.btn_ShowCustamer);
            this.pnl_Operation.Location = new System.Drawing.Point(0, 414);
            this.pnl_Operation.Name = "pnl_Operation";
            this.pnl_Operation.Size = new System.Drawing.Size(880, 44);
            this.pnl_Operation.TabIndex = 12;
            // 
            // btn_SaveCustamer
            // 
            this.btn_SaveCustamer.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_SaveCustamer.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_SaveCustamer.Image = global::gym.Properties.Resources.add;
            this.btn_SaveCustamer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_SaveCustamer.Location = new System.Drawing.Point(499, 4);
            this.btn_SaveCustamer.Name = "btn_SaveCustamer";
            this.btn_SaveCustamer.Size = new System.Drawing.Size(128, 37);
            this.btn_SaveCustamer.TabIndex = 11;
            this.btn_SaveCustamer.Text = "حفظ";
            this.btn_SaveCustamer.UseVisualStyleBackColor = false;
            this.btn_SaveCustamer.Click += new System.EventHandler(this.btn_SaveCustamer_Click);
            // 
            // btn_ShowCustamer
            // 
            this.btn_ShowCustamer.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_ShowCustamer.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_ShowCustamer.Image = global::gym.Properties.Resources.show1;
            this.btn_ShowCustamer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ShowCustamer.Location = new System.Drawing.Point(305, 4);
            this.btn_ShowCustamer.Name = "btn_ShowCustamer";
            this.btn_ShowCustamer.Size = new System.Drawing.Size(128, 37);
            this.btn_ShowCustamer.TabIndex = 12;
            this.btn_ShowCustamer.Text = "عرض";
            this.btn_ShowCustamer.UseVisualStyleBackColor = false;
            this.btn_ShowCustamer.Click += new System.EventHandler(this.btn_ShowCustamer_Click);
            // 
            // chbSupscriptionManth
            // 
            this.chbSupscriptionManth.AutoSize = true;
            this.chbSupscriptionManth.Location = new System.Drawing.Point(201, 53);
            this.chbSupscriptionManth.Name = "chbSupscriptionManth";
            this.chbSupscriptionManth.Size = new System.Drawing.Size(123, 25);
            this.chbSupscriptionManth.TabIndex = 39;
            this.chbSupscriptionManth.Text = "اشتراك الشهري";
            this.chbSupscriptionManth.UseVisualStyleBackColor = true;
            this.chbSupscriptionManth.CheckedChanged += new System.EventHandler(this.chbSupscriptionManth_CheckedChanged);
            // 
            // txtWeight
            // 
            this.txtWeight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWeight.Location = new System.Drawing.Point(649, 81);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(50, 22);
            this.txtWeight.TabIndex = 38;
            this.txtWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmpSupscriptionManth
            // 
            this.cmpSupscriptionManth.Enabled = false;
            this.cmpSupscriptionManth.FormattingEnabled = true;
            this.cmpSupscriptionManth.Items.AddRange(new object[] {
            "12",
            "18",
            "30"});
            this.cmpSupscriptionManth.Location = new System.Drawing.Point(126, 51);
            this.cmpSupscriptionManth.Name = "cmpSupscriptionManth";
            this.cmpSupscriptionManth.Size = new System.Drawing.Size(67, 29);
            this.cmpSupscriptionManth.TabIndex = 30;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(705, 82);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(45, 21);
            this.lblWeight.TabIndex = 37;
            this.lblWeight.Text = "الوزن";
            // 
            // txtHeigth
            // 
            this.txtHeigth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHeigth.Location = new System.Drawing.Point(756, 81);
            this.txtHeigth.Name = "txtHeigth";
            this.txtHeigth.Size = new System.Drawing.Size(50, 22);
            this.txtHeigth.TabIndex = 36;
            this.txtHeigth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNameSupscription
            // 
            this.txtNameSupscription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNameSupscription.Location = new System.Drawing.Point(583, 26);
            this.txtNameSupscription.Name = "txtNameSupscription";
            this.txtNameSupscription.Size = new System.Drawing.Size(185, 22);
            this.txtNameSupscription.TabIndex = 25;
            this.txtNameSupscription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblHeigth
            // 
            this.lblHeigth.AutoSize = true;
            this.lblHeigth.Location = new System.Drawing.Point(812, 82);
            this.lblHeigth.Name = "lblHeigth";
            this.lblHeigth.Size = new System.Drawing.Size(47, 21);
            this.lblHeigth.TabIndex = 35;
            this.lblHeigth.Text = "الطول";
            // 
            // lblNameSupscription
            // 
            this.lblNameSupscription.AutoSize = true;
            this.lblNameSupscription.Location = new System.Drawing.Point(774, 27);
            this.lblNameSupscription.Name = "lblNameSupscription";
            this.lblNameSupscription.Size = new System.Drawing.Size(85, 21);
            this.lblNameSupscription.TabIndex = 24;
            this.lblNameSupscription.Text = "اسم المشترك";
            // 
            // txtPhone
            // 
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhone.Location = new System.Drawing.Point(192, 27);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(131, 22);
            this.txtPhone.TabIndex = 34;
            this.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 21);
            this.label2.TabIndex = 26;
            this.label2.Text = "العمر";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(329, 28);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(49, 21);
            this.lblPhone.TabIndex = 33;
            this.lblPhone.Text = "الهاتف";
            // 
            // txtAge
            // 
            this.txtAge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAge.Location = new System.Drawing.Point(91, 28);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(48, 22);
            this.txtAge.TabIndex = 27;
            this.txtAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddress.Location = new System.Drawing.Point(384, 27);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(131, 22);
            this.txtAddress.TabIndex = 32;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(521, 28);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(52, 21);
            this.lblAddress.TabIndex = 31;
            this.lblAddress.Text = "العنوان";
            // 
            // txtAmount
            // 
            this.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAmount.Enabled = false;
            this.txtAmount.Location = new System.Drawing.Point(2, 54);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(67, 22);
            this.txtAmount.TabIndex = 41;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(75, 55);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(44, 21);
            this.lblAmount.TabIndex = 40;
            this.lblAmount.Text = "السعر";
            // 
            // txtChronicDisease
            // 
            this.txtChronicDisease.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtChronicDisease.Location = new System.Drawing.Point(384, 82);
            this.txtChronicDisease.Name = "txtChronicDisease";
            this.txtChronicDisease.Size = new System.Drawing.Size(173, 22);
            this.txtChronicDisease.TabIndex = 43;
            this.txtChronicDisease.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblChronicDisease
            // 
            this.lblChronicDisease.AutoSize = true;
            this.lblChronicDisease.Location = new System.Drawing.Point(558, 82);
            this.lblChronicDisease.Name = "lblChronicDisease";
            this.lblChronicDisease.Size = new System.Drawing.Size(85, 21);
            this.lblChronicDisease.TabIndex = 42;
            this.lblChronicDisease.Text = "مرض مزمن";
            // 
            // dtpDateSubscription
            // 
            this.dtpDateSubscription.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateSubscription.Location = new System.Drawing.Point(161, 77);
            this.dtpDateSubscription.Name = "dtpDateSubscription";
            this.dtpDateSubscription.Size = new System.Drawing.Size(160, 29);
            this.dtpDateSubscription.TabIndex = 44;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(327, 83);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(51, 21);
            this.lblDate.TabIndex = 45;
            this.lblDate.Text = "التاريخ";
            // 
            // gbSupscriptionManth
            // 
            this.gbSupscriptionManth.Controls.Add(this.dgvShowSupscription);
            this.gbSupscriptionManth.Controls.Add(this.txtPhone);
            this.gbSupscriptionManth.Controls.Add(this.lblDate);
            this.gbSupscriptionManth.Controls.Add(this.lblAddress);
            this.gbSupscriptionManth.Controls.Add(this.dtpDateSubscription);
            this.gbSupscriptionManth.Controls.Add(this.cmpSupscriptionManth);
            this.gbSupscriptionManth.Controls.Add(this.txtAddress);
            this.gbSupscriptionManth.Controls.Add(this.chbSupscriptionManth);
            this.gbSupscriptionManth.Controls.Add(this.txtChronicDisease);
            this.gbSupscriptionManth.Controls.Add(this.lblAmount);
            this.gbSupscriptionManth.Controls.Add(this.txtAge);
            this.gbSupscriptionManth.Controls.Add(this.txtAmount);
            this.gbSupscriptionManth.Controls.Add(this.lblChronicDisease);
            this.gbSupscriptionManth.Controls.Add(this.lblPhone);
            this.gbSupscriptionManth.Controls.Add(this.label2);
            this.gbSupscriptionManth.Controls.Add(this.lblNameSupscription);
            this.gbSupscriptionManth.Controls.Add(this.lblHeigth);
            this.gbSupscriptionManth.Controls.Add(this.txtWeight);
            this.gbSupscriptionManth.Controls.Add(this.txtNameSupscription);
            this.gbSupscriptionManth.Controls.Add(this.txtHeigth);
            this.gbSupscriptionManth.Controls.Add(this.lblWeight);
            this.gbSupscriptionManth.Location = new System.Drawing.Point(10, 57);
            this.gbSupscriptionManth.Name = "gbSupscriptionManth";
            this.gbSupscriptionManth.Size = new System.Drawing.Size(858, 351);
            this.gbSupscriptionManth.TabIndex = 46;
            this.gbSupscriptionManth.TabStop = false;
            this.gbSupscriptionManth.Text = "الاشتراك الشهري:";
            // 
            // dgvShowSupscription
            // 
            this.dgvShowSupscription.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowSupscription.Location = new System.Drawing.Point(-10, 132);
            this.dgvShowSupscription.Name = "dgvShowSupscription";
            this.dgvShowSupscription.Size = new System.Drawing.Size(880, 219);
            this.dgvShowSupscription.TabIndex = 46;
            // 
            // frm_Add_Castmer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(880, 457);
            this.Controls.Add(this.gbSupscriptionManth);
            this.Controls.Add(this.pnl_Operation);
            this.Controls.Add(this.pnl_title_login);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frm_Add_Castmer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm";
            this.Load += new System.EventHandler(this.frm_Add_Castmer_Load);
            this.pnl_title_login.ResumeLayout(false);
            this.pnl_title_login.PerformLayout();
            this.pnl_Operation.ResumeLayout(false);
            this.gbSupscriptionManth.ResumeLayout(false);
            this.gbSupscriptionManth.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowSupscription)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_title_login;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Titel;
        private System.Windows.Forms.Panel pnl_Operation;
        private System.Windows.Forms.Button btn_SaveCustamer;
        private System.Windows.Forms.Button btn_ShowCustamer;
        private System.Windows.Forms.CheckBox chbSupscriptionManth;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.ComboBox cmpSupscriptionManth;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox txtHeigth;
        private System.Windows.Forms.TextBox txtNameSupscription;
        private System.Windows.Forms.Label lblHeigth;
        private System.Windows.Forms.Label lblNameSupscription;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtChronicDisease;
        private System.Windows.Forms.Label lblChronicDisease;
        private System.Windows.Forms.DateTimePicker dtpDateSubscription;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.GroupBox gbSupscriptionManth;
        private System.Windows.Forms.DataGridView dgvShowSupscription;
    }
}