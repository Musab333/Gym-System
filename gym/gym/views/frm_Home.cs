using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gym.views
{
    public partial class frm_Home : Form
    {
        public frm_Home()
        {
            InitializeComponent();
        }

        private void pnl_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
               
        }

        private void pnl_Exit_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();  
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Click(object sender, EventArgs e)
        {
            frm_Add_Castmer fac= new frm_Add_Castmer();           
            fac.Show();
            this.Hide();
        }

        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {
            frm_Add_Castmer fac = new frm_Add_Castmer();            
            fac.Show();
            this.Hide();
        }

        private void panel8_MouseClick(object sender, MouseEventArgs e)
        {
            frm_Add_Castmer fac = new frm_Add_Castmer(); 
            fac.Show();
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            frm_Add_Castmer fac = new frm_Add_Castmer();
            fac.Show();
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
         
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_MouseClick(object sender, MouseEventArgs e)
        {
            frm_Users_Manager frm_Users_Manager= new frm_Users_Manager();
            frm_Users_Manager.Show();
        }

        private void panel9_Click(object sender, EventArgs e)
        {
            frm_Users_Manager frm_Users_Manager = new frm_Users_Manager();
            frm_Users_Manager.Show();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            frm_Users_Manager frm_Users_Manager = new frm_Users_Manager();
            frm_Users_Manager.Show();
        }

        private void pnl_Exit_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void timerHome_Tick(object sender, EventArgs e)
        {
            lbl_timer.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void lbl_timer_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_MouseClick(object sender, MouseEventArgs e)
        {
            frm_Reports frm_reports= new frm_Reports();
            frm_reports.Show();
        }

        private void panel6_MouseClick(object sender, MouseEventArgs e)
        {
            frm_Reports frm_reports = new frm_Reports();
            frm_reports.Show();
        }

        private void pnlMaingment_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlReportsImg_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
