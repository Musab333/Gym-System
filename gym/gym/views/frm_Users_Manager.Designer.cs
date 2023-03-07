namespace gym.views
{
    partial class frm_Users_Manager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_title_login = new System.Windows.Forms.Panel();
            this.pnl_Cansel = new System.Windows.Forms.Panel();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.txt_Comfer_Password = new System.Windows.Forms.TextBox();
            this.lbl_Conferm_password = new System.Windows.Forms.Label();
            this.dgv_Users = new System.Windows.Forms.DataGridView();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gym_SystemDataSet = new gym.Gym_SystemDataSet();
            this.pnl_Operation = new System.Windows.Forms.Panel();
            this.pnl_Expand = new System.Windows.Forms.Panel();
            this.btn_DeleteUser = new System.Windows.Forms.Button();
            this.btn_SaveUser = new System.Windows.Forms.Button();
            this.btn_UpdateUser = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.employeesTableAdapter = new gym.Gym_SystemDataSetTableAdapters.EmployeesTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.empIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_title_login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Users)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gym_SystemDataSet)).BeginInit();
            this.pnl_Operation.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1227, 162);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // pnl_title_login
            // 
            this.pnl_title_login.BackColor = System.Drawing.Color.SteelBlue;
            this.pnl_title_login.Controls.Add(this.pnl_Cansel);
            this.pnl_title_login.Controls.Add(this.lbl_Title);
            this.pnl_title_login.Location = new System.Drawing.Point(0, 0);
            this.pnl_title_login.Name = "pnl_title_login";
            this.pnl_title_login.Size = new System.Drawing.Size(884, 51);
            this.pnl_title_login.TabIndex = 3;
            // 
            // pnl_Cansel
            // 
            this.pnl_Cansel.BackgroundImage = global::gym.Properties.Resources.shutdown5;
            this.pnl_Cansel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnl_Cansel.Location = new System.Drawing.Point(821, 0);
            this.pnl_Cansel.Name = "pnl_Cansel";
            this.pnl_Cansel.Size = new System.Drawing.Size(63, 48);
            this.pnl_Cansel.TabIndex = 8;
            this.pnl_Cansel.Click += new System.EventHandler(this.pnl_Cansel_Click);
            this.pnl_Cansel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnl_Cansel_MouseClick);
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("SimSun-ExtB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.White;
            this.lbl_Title.Location = new System.Drawing.Point(375, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(135, 27);
            this.lbl_Title.TabIndex = 6;
            this.lbl_Title.Text = "أدارة المستخدمين";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Location = new System.Drawing.Point(333, 72);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(87, 21);
            this.lbl_Username.TabIndex = 4;
            this.lbl_Username.Text = "اسم المستخدم";
            this.lbl_Username.Click += new System.EventHandler(this.lbl_Username_Click);
            // 
            // txt_Username
            // 
            this.txt_Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Username.Location = new System.Drawing.Point(165, 73);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(162, 22);
            this.txt_Username.TabIndex = 5;
            this.txt_Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Username.TextChanged += new System.EventHandler(this.txt_Username_TextChanged);
            // 
            // txt_Password
            // 
            this.txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Password.Location = new System.Drawing.Point(604, 124);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(169, 22);
            this.txt_Password.TabIndex = 7;
            this.txt_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(779, 124);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(81, 21);
            this.lbl_Password.TabIndex = 6;
            this.lbl_Password.Text = "كلمة المرور";
            // 
            // txt_Comfer_Password
            // 
            this.txt_Comfer_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Comfer_Password.Location = new System.Drawing.Point(310, 124);
            this.txt_Comfer_Password.Name = "txt_Comfer_Password";
            this.txt_Comfer_Password.PasswordChar = '*';
            this.txt_Comfer_Password.Size = new System.Drawing.Size(169, 22);
            this.txt_Comfer_Password.TabIndex = 9;
            this.txt_Comfer_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_Conferm_password
            // 
            this.lbl_Conferm_password.AutoSize = true;
            this.lbl_Conferm_password.Location = new System.Drawing.Point(485, 124);
            this.lbl_Conferm_password.Name = "lbl_Conferm_password";
            this.lbl_Conferm_password.Size = new System.Drawing.Size(113, 21);
            this.lbl_Conferm_password.TabIndex = 8;
            this.lbl_Conferm_password.Text = "تأكيد كلمة المرور";
            // 
            // dgv_Users
            // 
            this.dgv_Users.AllowUserToAddRows = false;
            this.dgv_Users.AllowUserToDeleteRows = false;
            this.dgv_Users.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Users.AutoGenerateColumns = false;
            this.dgv_Users.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Users.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgv_Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Users.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empIDDataGridViewTextBoxColumn,
            this.empNameDataGridViewTextBoxColumn,
            this.empAddressDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
            this.dgv_Users.DataSource = this.employeesBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Users.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Users.Location = new System.Drawing.Point(0, 215);
            this.dgv_Users.Name = "dgv_Users";
            this.dgv_Users.Size = new System.Drawing.Size(884, 240);
            this.dgv_Users.TabIndex = 10;
            this.dgv_Users.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Users_CellContentClick);
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.gym_SystemDataSet;
            // 
            // gym_SystemDataSet
            // 
            this.gym_SystemDataSet.DataSetName = "Gym_SystemDataSet";
            this.gym_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnl_Operation
            // 
            this.pnl_Operation.BackColor = System.Drawing.Color.SteelBlue;
            this.pnl_Operation.Controls.Add(this.button1);
            this.pnl_Operation.Controls.Add(this.pnl_Expand);
            this.pnl_Operation.Controls.Add(this.btn_DeleteUser);
            this.pnl_Operation.Controls.Add(this.btn_SaveUser);
            this.pnl_Operation.Controls.Add(this.btn_UpdateUser);
            this.pnl_Operation.Location = new System.Drawing.Point(0, 169);
            this.pnl_Operation.Name = "pnl_Operation";
            this.pnl_Operation.Size = new System.Drawing.Size(884, 44);
            this.pnl_Operation.TabIndex = 9;
            // 
            // pnl_Expand
            // 
            this.pnl_Expand.BackColor = System.Drawing.Color.SteelBlue;
            this.pnl_Expand.BackgroundImage = global::gym.Properties.Resources.expand;
            this.pnl_Expand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnl_Expand.Location = new System.Drawing.Point(3, 0);
            this.pnl_Expand.Name = "pnl_Expand";
            this.pnl_Expand.Size = new System.Drawing.Size(66, 44);
            this.pnl_Expand.TabIndex = 14;
            this.pnl_Expand.Click += new System.EventHandler(this.pnl_Expand_Click);
            this.pnl_Expand.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btn_DeleteUser
            // 
            this.btn_DeleteUser.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_DeleteUser.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_DeleteUser.Image = global::gym.Properties.Resources.delete;
            this.btn_DeleteUser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_DeleteUser.Location = new System.Drawing.Point(443, 3);
            this.btn_DeleteUser.Name = "btn_DeleteUser";
            this.btn_DeleteUser.Size = new System.Drawing.Size(113, 37);
            this.btn_DeleteUser.TabIndex = 13;
            this.btn_DeleteUser.Text = "حذف";
            this.btn_DeleteUser.UseVisualStyleBackColor = false;
            this.btn_DeleteUser.Click += new System.EventHandler(this.btn_DeleteUser_Click_1);
            // 
            // btn_SaveUser
            // 
            this.btn_SaveUser.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_SaveUser.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_SaveUser.Image = global::gym.Properties.Resources.add;
            this.btn_SaveUser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_SaveUser.Location = new System.Drawing.Point(755, 3);
            this.btn_SaveUser.Name = "btn_SaveUser";
            this.btn_SaveUser.Size = new System.Drawing.Size(113, 37);
            this.btn_SaveUser.TabIndex = 11;
            this.btn_SaveUser.Text = "حفظ";
            this.btn_SaveUser.UseVisualStyleBackColor = false;
            this.btn_SaveUser.Click += new System.EventHandler(this.btn_SaveUser_Click);
            // 
            // btn_UpdateUser
            // 
            this.btn_UpdateUser.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_UpdateUser.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_UpdateUser.Image = global::gym.Properties.Resources.edit;
            this.btn_UpdateUser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_UpdateUser.Location = new System.Drawing.Point(600, 3);
            this.btn_UpdateUser.Name = "btn_UpdateUser";
            this.btn_UpdateUser.Size = new System.Drawing.Size(113, 37);
            this.btn_UpdateUser.TabIndex = 12;
            this.btn_UpdateUser.Text = "تعديل";
            this.btn_UpdateUser.UseVisualStyleBackColor = false;
            this.btn_UpdateUser.Click += new System.EventHandler(this.btn_UpdateUser_Click);
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Location = new System.Drawing.Point(652, 73);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(162, 22);
            this.txtName.TabIndex = 12;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(820, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "الاسم";
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddress.Location = new System.Drawing.Point(426, 72);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(162, 22);
            this.txtAddress.TabIndex = 14;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(594, 72);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(52, 21);
            this.lblAddress.TabIndex = 13;
            this.lblAddress.Text = "العنوان";
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button1.Image = global::gym.Properties.Resources.delete;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(303, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 37);
            this.button1.TabIndex = 15;
            this.button1.Text = "بحث";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // empIDDataGridViewTextBoxColumn
            // 
            this.empIDDataGridViewTextBoxColumn.DataPropertyName = "Emp_ID";
            this.empIDDataGridViewTextBoxColumn.HeaderText = "رقم المؤظف";
            this.empIDDataGridViewTextBoxColumn.Name = "empIDDataGridViewTextBoxColumn";
            this.empIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empNameDataGridViewTextBoxColumn
            // 
            this.empNameDataGridViewTextBoxColumn.DataPropertyName = "Emp_Name";
            this.empNameDataGridViewTextBoxColumn.HeaderText = "اسم المؤظف";
            this.empNameDataGridViewTextBoxColumn.Name = "empNameDataGridViewTextBoxColumn";
            // 
            // empAddressDataGridViewTextBoxColumn
            // 
            this.empAddressDataGridViewTextBoxColumn.DataPropertyName = "Emp_Address";
            this.empAddressDataGridViewTextBoxColumn.HeaderText = "العنوان";
            this.empAddressDataGridViewTextBoxColumn.Name = "empAddressDataGridViewTextBoxColumn";
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "User_Name";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "اسم المستخدم";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "كلمة المرور";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // frm_Users_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(880, 457);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnl_Operation);
            this.Controls.Add(this.dgv_Users);
            this.Controls.Add(this.txt_Comfer_Password);
            this.Controls.Add(this.lbl_Conferm_password);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.pnl_title_login);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frm_Users_Manager";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Users_Manager";
            this.Load += new System.EventHandler(this.frm_Users_Manager_Load);
            this.pnl_title_login.ResumeLayout(false);
            this.pnl_title_login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Users)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gym_SystemDataSet)).EndInit();
            this.pnl_Operation.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnl_title_login;
        private System.Windows.Forms.Panel pnl_Cansel;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txt_Comfer_Password;
        private System.Windows.Forms.Label lbl_Conferm_password;
        private System.Windows.Forms.DataGridView dgv_Users;
        private System.Windows.Forms.Button btn_SaveUser;
        private System.Windows.Forms.Button btn_UpdateUser;
        private System.Windows.Forms.Button btn_DeleteUser;
        private System.Windows.Forms.Panel pnl_Operation;
        private System.Windows.Forms.Panel pnl_Expand;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private Gym_SystemDataSet gym_SystemDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private Gym_SystemDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn empIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
    }
}