using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiaryApp.Source
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void pClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbNavRes_Click(object sender, EventArgs e)
        {
            pageLogAndReg.SelectTab(1);
        }

        private void lbNavLog_Click(object sender, EventArgs e)
        {
            pageLogAndReg.SelectTab(0);
        }
    }
}
