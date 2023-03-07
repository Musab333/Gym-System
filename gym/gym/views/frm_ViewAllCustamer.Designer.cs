namespace gym.views
{
    partial class frm_ViewAllCustamer
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
            this.pnl_title = new System.Windows.Forms.Panel();
            this.pnl_Cansel = new System.Windows.Forms.Panel();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.pnl_Operation = new System.Windows.Forms.Panel();
            this.pnl_Expand = new System.Windows.Forms.Panel();
            this.btn_DeleteCustamer = new System.Windows.Forms.Button();
            this.btn_SaveCustamer = new System.Windows.Forms.Button();
            this.btn_UpdateCustamer = new System.Windows.Forms.Button();
            this.dgv_Custamers = new System.Windows.Forms.DataGridView();
            this.pnl_title.SuspendLayout();
            this.pnl_Operation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Custamers)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_title
            // 
            this.pnl_title.BackColor = System.Drawing.Color.SteelBlue;
            this.pnl_title.Controls.Add(this.pnl_Cansel);
            this.pnl_title.Controls.Add(this.lbl_Title);
            this.pnl_title.Location = new System.Drawing.Point(0, 0);
            this.pnl_title.Name = "pnl_title";
            this.pnl_title.Size = new System.Drawing.Size(881, 51);
            this.pnl_title.TabIndex = 4;
            // 
            // pnl_Cansel
            // 
            this.pnl_Cansel.BackgroundImage = global::gym.Properties.Resources.shutdown5;
            this.pnl_Cansel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnl_Cansel.Location = new System.Drawing.Point(821, 0);
            this.pnl_Cansel.Name = "pnl_Cansel";
            this.pnl_Cansel.Size = new System.Drawing.Size(63, 48);
            this.pnl_Cansel.TabIndex = 8;
            this.pnl_Cansel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnl_Cansel_MouseClick);
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("SimSun-ExtB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.White;
            this.lbl_Title.Location = new System.Drawing.Point(397, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(91, 27);
            this.lbl_Title.TabIndex = 6;
            this.lbl_Title.Text = "المشتركيين\r\n";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_Operation
            // 
            this.pnl_Operation.BackColor = System.Drawing.Color.SteelBlue;
            this.pnl_Operation.Controls.Add(this.pnl_Expand);
            this.pnl_Operation.Controls.Add(this.btn_DeleteCustamer);
            this.pnl_Operation.Controls.Add(this.btn_SaveCustamer);
            this.pnl_Operation.Controls.Add(this.btn_UpdateCustamer);
            this.pnl_Operation.Location = new System.Drawing.Point(-2, 73);
            this.pnl_Operation.Name = "pnl_Operation";
            this.pnl_Operation.Size = new System.Drawing.Size(884, 44);
            this.pnl_Operation.TabIndex = 10;
            // 
            // pnl_Expand
            // 
            this.pnl_Expand.BackColor = System.Drawing.Color.SteelBlue;
            this.pnl_Expand.BackgroundImage = global::gym.Properties.Resources.expand;
            this.pnl_Expand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnl_Expand.Location = new System.Drawing.Point(12, 0);
            this.pnl_Expand.Name = "pnl_Expand";
            this.pnl_Expand.Size = new System.Drawing.Size(66, 44);
            this.pnl_Expand.TabIndex = 14;
            // 
            // btn_DeleteCustamer
            // 
            this.btn_DeleteCustamer.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_DeleteCustamer.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_DeleteCustamer.Image = global::gym.Properties.Resources.delete;
            this.btn_DeleteCustamer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_DeleteCustamer.Location = new System.Drawing.Point(443, 3);
            this.btn_DeleteCustamer.Name = "btn_DeleteCustamer";
            this.btn_DeleteCustamer.Size = new System.Drawing.Size(113, 37);
            this.btn_DeleteCustamer.TabIndex = 13;
            this.btn_DeleteCustamer.Text = "حذف";
            this.btn_DeleteCustamer.UseVisualStyleBackColor = false;
            // 
            // btn_SaveCustamer
            // 
            this.btn_SaveCustamer.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_SaveCustamer.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_SaveCustamer.Image = global::gym.Properties.Resources.add;
            this.btn_SaveCustamer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_SaveCustamer.Location = new System.Drawing.Point(755, 3);
            this.btn_SaveCustamer.Name = "btn_SaveCustamer";
            this.btn_SaveCustamer.Size = new System.Drawing.Size(113, 37);
            this.btn_SaveCustamer.TabIndex = 11;
            this.btn_SaveCustamer.Text = "حفظ";
            this.btn_SaveCustamer.UseVisualStyleBackColor = false;
            // 
            // btn_UpdateCustamer
            // 
            this.btn_UpdateCustamer.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_UpdateCustamer.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_UpdateCustamer.Image = global::gym.Properties.Resources.edit;
            this.btn_UpdateCustamer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_UpdateCustamer.Location = new System.Drawing.Point(600, 3);
            this.btn_UpdateCustamer.Name = "btn_UpdateCustamer";
            this.btn_UpdateCustamer.Size = new System.Drawing.Size(113, 37);
            this.btn_UpdateCustamer.TabIndex = 12;
            this.btn_UpdateCustamer.Text = "تعديل";
            this.btn_UpdateCustamer.UseVisualStyleBackColor = false;
            // 
            // dgv_Custamers
            // 
            this.dgv_Custamers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Custamers.Location = new System.Drawing.Point(0, 123);
            this.dgv_Custamers.Name = "dgv_Custamers";
            this.dgv_Custamers.Size = new System.Drawing.Size(881, 332);
            this.dgv_Custamers.TabIndex = 11;
            // 
            // frm_ViewAllCustamer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(880, 457);
            this.Controls.Add(this.dgv_Custamers);
            this.Controls.Add(this.pnl_Operation);
            this.Controls.Add(this.pnl_title);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frm_ViewAllCustamer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_ViewAllCustamer";
            this.pnl_title.ResumeLayout(false);
            this.pnl_title.PerformLayout();
            this.pnl_Operation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Custamers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_title;
        private System.Windows.Forms.Panel pnl_Cansel;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Panel pnl_Operation;
        private System.Windows.Forms.Panel pnl_Expand;
        private System.Windows.Forms.Button btn_DeleteCustamer;
        private System.Windows.Forms.Button btn_SaveCustamer;
        private System.Windows.Forms.Button btn_UpdateCustamer;
        private System.Windows.Forms.DataGridView dgv_Custamers;
    }
}