using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winforms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            MessageBox.Show(winforms.Properties.Resources.JustOK);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show(winforms.Properties.Resources.JustCancel);
        }

        private void btnOK2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(winforms.Properties.Resources.JustOK2);
        }
    }
}
