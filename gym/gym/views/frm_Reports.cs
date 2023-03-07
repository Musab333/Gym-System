using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace gym.views
{
    public partial class frm_Reports : Form
    {
        public frm_Reports()
        {
            InitializeComponent();
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();   
        }

        private void pnl_Operation_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chShowReportDetails_CheckedChanged(object sender, EventArgs e)
        {
            /*
            dtpMonthNow.Visible= false;
            dtpMonthNow.Visible = false;
            lblTo.Visible= false;
            */
            if(chShowReportDetails.Checked == true)
            {
                dtpMonthNow.Visible = true;
                lblTo.Visible=true;
                dtpMonthNext.Visible = true;
            }
              
            else
                if (chShowReportDetails.Checked == false)
            {
                dtpMonthNow.Visible = false;
                lblTo.Visible = false;
                dtpMonthNext.Visible = false;
            }
                     


        }
    }
}
