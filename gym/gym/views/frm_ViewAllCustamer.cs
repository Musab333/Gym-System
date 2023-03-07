using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gym.views
{
    public partial class frm_ViewAllCustamer : Form
    {
        public frm_ViewAllCustamer()
        {
            InitializeComponent();
        }

        private void pnl_Cansel_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}
