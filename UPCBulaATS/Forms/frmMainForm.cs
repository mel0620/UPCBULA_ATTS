using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UPCBulaATS
{
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();
        }

        private void btnAtten_Click(object sender, EventArgs e)
        {
            new frmAtten().Show();
        }

        private void btnMemInfo_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            //new frmMembersInfo().Show();
        }

        private void btnViewAtt_Click(object sender, EventArgs e)
        {
            new frmViewAttendance().Show();
        }

        private void btnYouth_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
        }
    }
}
