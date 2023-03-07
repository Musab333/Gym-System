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

namespace gym.views
{
    public partial class frm_Users_Manager : Form
    {
        SqlConnection conn = new SqlConnection("Server =.\\SQLEXPRESS; database = Gym_System; Integrated Security = true;");
        SqlCommand cmd;
        SqlDataReader dr;


        public frm_Users_Manager()
        {
            InitializeComponent();
        }

        private void lbl_Username_Click(object sender, EventArgs e)
        {

        }

        private void pnl_Cansel_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
        }

        private void pnl_Cansel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frm_Users_Manager_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gym_SystemDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.gym_SystemDataSet.Employees);

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_SaveUser_Click(object sender, EventArgs e)
        {


            if (valid() && confirmPassword())
            {
                try
                {                   
                    cmd = new SqlCommand("INSERT INTO Employees(Emp_Name,Emp_Address,User_Name,Password) values ('" + txtName.Text + "','" + txtAddress.Text + "','" + txt_Username.Text + "','" + txt_Password.Text + "')", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("تما أضافة مؤظف جديد", "أضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("الرجاء ملء كل الحقول", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void dgv_Users_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_UpdateUser_Click(object sender, EventArgs e)
        {
            //updateViewData();
            if (txtName.Text == "" || txtAddress.Text == "" || txt_Username.Text == "" || txt_Password.Text == "")
            {
                selectViewData();
                if (txtName.Text != string.Empty || txtAddress.Text != string.Empty || txt_Username.Text != string.Empty || txt_Password.Text != string.Empty || txt_Comfer_Password.Text != string.Empty)
                {
                    updateViewData();
                }
            }
            else
            {
                MessageBox.Show("الرجاء أدخال الاسم المؤظف فقط", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

      // Button Upadte 
        // Select in Data
        void selectViewData()
        {

            if (validTextBoxName())
            {
                try
                {
                    cmd = new SqlCommand("SELECT Emp_Name,Emp_Address,User_Name,Password from Employees where Emp_Name='" + txtName.Text + "' or User_Name='" + txt_Username.Text + "'", conn);
                    conn.Open();
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    txtName.Text = dr["Emp_Name"].ToString();
                    txtAddress.Text = dr["Emp_Address"].ToString();
                    txt_Username.Text = dr["User_Name"].ToString();
                    txt_Password.Text = dr["Password"].ToString();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("ُErorr" + ex.Message);
                }
                finally
                {
                    dr.Close();
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("الرجاء أدخال الاسم المؤظف للتعديل", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Update in Data
        void updateViewData()
        {

            if (valid() || confirmPassword())
            {
                try
                {
                    cmd = new SqlCommand("UPDATE Employees SET Emp_Name='" + txtName+ "', Emp_Address='" + txtAddress.Text+"', User_Name='"+txt_Username.Text+"', Password='"+txt_Password.Text+"' where Emp_Name='"+txtName.Text+"'", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("تما تعديل بيانات مؤظف ", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("الرجاء ملء كل الحقول", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_DeleteUser_Click_1(object sender, EventArgs e)
        {
            if (validTextBoxName() && confirmPassword())
            {
                try
                {
                    cmd = new SqlCommand("DELETE FROM Employees WHERE Emp_Name= '" + txtName.Text + "'", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    if (DialogResult == MessageBox.Show("هل تريد حذف المؤظف ؟ ", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == true) ;
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
                MessageBox.Show("الرجاء أدخال الاسم المؤظف للحذف", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        // Is valid TextBox
        bool valid()
        {
            if (txtName.Text == "" || txtAddress.Text == "" || txt_Username.Text == "" || txt_Password.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        // Is valid TextBox Name
        bool validTextBoxName()
        {
            if (txtName.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        // confirmPassword TextBox
        bool confirmPassword()
        {
            string passwod = txt_Password.Text;
            string confPassword = txt_Comfer_Password.Text;

            if (!passwod.Equals(confPassword))
            {
                MessageBox.Show("كلمة السر غير متوافقة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectViewData();
        }

        private void pnl_Expand_Click(object sender, EventArgs e)
        {
            this.Size = new Size(this.Width, Size.Height);  
        }
    }
}
