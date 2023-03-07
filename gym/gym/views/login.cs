using gym.views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gym
{
    public partial class frm_Login : Form
    {
        
        SqlConnection conn = new SqlConnection("Server =.\\SQLEXPRESS; database = Gym_System; Integrated Security = true;");
        SqlCommand cmd;
        SqlDataReader dr;

        public frm_Login()
        {
            InitializeComponent();
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Username.Text != string.Empty || txt_Password.Text != string.Empty)
                {
                    cmd = new SqlCommand("SELECT User_Name,Password from Employees where User_Name='" + txt_Username.Text + "' and Password='" + txt_Password.Text + "'", conn);
                    conn.Open();
                    dr = cmd.ExecuteReader();
                   
                    if (dr.Read())
                    {
                        dr.Close();
                        this.Hide();
                        frm_Home frm = new frm_Home();
                        frm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("عفوآ, الرجاء التأكد من اسم المستخدم وكلمة المرور", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dr.Close();
                    }

                }
                else
                {
                    MessageBox.Show("الرجاء ملء كل الحقول", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error"+ex.Message, "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally 
            {
                dr.Close();
                conn.Close();    
            }
           
        }

        void validectionUser()
        {
            var username = txt_Username.Text;
            var password = txt_Password.Text;

            if(!(username == "Moh" && password == "12345"))
            {
               /* pnlMaingment.Visible = true;
                pnlReports.Visible = true;*/
            }
        }


    private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
