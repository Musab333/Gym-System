using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Linq;
using gym.connction;
using System.Reflection;
using gym.model;
using gym.control;

namespace gym.views
{
    public partial class frm_Add_Castmer : Form
    {
        //Connection SqlServer;
        public SqlConnection conn = new SqlConnection("Server =.\\SQLEXPRESS; database = Gym_System; Integrated Security = true;");
        public SqlCommand cmd;
        

        public frm_Add_Castmer()
        {
            InitializeComponent();
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();  
        }

        private void cmb_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void btn_ShowCustamer_Click(object sender, EventArgs e)
        {
            
            frm_ViewAllCustamer frm_ViewAllCustamer = new frm_ViewAllCustamer();
            frm_ViewAllCustamer.Show();
            this.Hide();
        }

        private void frm_Add_Castmer_Load(object sender, EventArgs e)
        {

        }

        private void grb_Supscription_Enter(object sender, EventArgs e)
        {

        }

        private void chbSupscription_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void chbSupscriptionManth_CheckedChanged(object sender, EventArgs e)
        {
           /* cmpSupscriptionManth.Enabled= false;
               if (chbSupscriptionManth.Checked)
                   {
                      cmpSupscriptionManth.Enabled = true;
                   }else
                      cmpSupscriptionManth.Enabled = false;*/
        }

        private void btn_SaveCustamer_Click(object sender, EventArgs e)
        {
            if(valid())
            {
                try
                {
                    cmd = new SqlCommand("INSERT INTO Gym_Members(Member_Name,Member_Address,Member_Phone,Member_Age,Member_height,Member_weitgh,chronic_disease,Date_Subscription) values ('" + txtNameSupscription.Text + "','" + txtAddress.Text + "','" + txtAge.Text + "','" + txtPhone.Text + "','" + txtHeigth.Text + "','" + txtWeight.Text + "','" + txtChronicDisease.Text + "','" + dtpDateSubscription.Text.ToString() + "')", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("تما أضافة مشترك جديد", "أضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("ُErorr" + ex.Message);
                }
                finally
                {
                    conn.Close();
                }

            }
            else
            {
                MessageBox.Show("الرجاء ملء كل الحقول","تحذير",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            bool valid()
            {
                if (txtNameSupscription.Text == "" || txtAddress.Text == "" || txtAge.Text == "" || txtPhone.Text == "" || txtHeigth.Text == "" || txtWeight.Text == "" || txtChronicDisease.Text == "" || dtpDateSubscription.Text == "")
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

        }



        private void chSupscriptionManth_CheckedChanged(object sender, EventArgs e)
        {
            /*gbSupscriptionDay.Enabled = true;
            gbSupscriptionManth.Enabled = false;

            if (gbSupscriptionManth.Enabled == )
            {
                gbSupscriptionManth.Enabled = true;
                gbSupscriptionDay.Enabled = false;

            } else
               if (gbSupscriptionDay.Enabled == true)
            {
                gbSupscriptionDay.Enabled = true;
                gbSupscriptionManth.Enabled = true;
            }*/
        }

        private void gbSupscriptionDay_Enter(object sender, EventArgs e)
        {

        }

      
    }
}


