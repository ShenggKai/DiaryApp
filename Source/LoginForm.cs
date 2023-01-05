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

        private bool eyeHide = true;
        private void pEye_Click(object sender, EventArgs e)
        {
            if (eyeHide == true)
            {
                pEye.Image = global::DiaryApp.Properties.Resources.eye;
                eyeHide = false;
            }
            else
            {
                pEye.Image = global::DiaryApp.Properties.Resources.eye_crossed;
                eyeHide = true;
            }
        }

        private bool eyeHide2 = true;
        private void pEye2_Click(object sender, EventArgs e)
        {
            if (eyeHide2 == true)
            {
                pEye2.Image = global::DiaryApp.Properties.Resources.eye;
                eyeHide2 = false;
            }
            else
            {
                pEye2.Image = global::DiaryApp.Properties.Resources.eye_crossed;
                eyeHide2 = true;
            }
        }
    }
}
