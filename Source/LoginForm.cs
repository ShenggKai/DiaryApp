using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.VisualBasic;

namespace DiaryApp.Source
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=KAI\SQLEXPRESS;Initial Catalog=DiaryApp;Integrated Security=True");

        private void pClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region Login Form
        private bool eyeHide1 = true;
        private void pEye1_Click(object sender, EventArgs e)
        {
            if (eyeHide1 == true)
            {
                pEye1.Image = global::DiaryApp.Properties.Resources.eye;
                txtPass.UseSystemPasswordChar= false;
                eyeHide1 = false;
            }
            else
            {
                pEye1.Image = global::DiaryApp.Properties.Resources.eye_crossed;
                txtPass.UseSystemPasswordChar= true;
                eyeHide1 = true;
            }
        }

        private void lbNavRes_Click(object sender, EventArgs e)
        {
            pageLogAndReg.SelectTab(1);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String username, user_pass;

            username = txtUserName.Text;
            user_pass = txtPass.Text;

            try
            {
                String querry = "SELECT * FROM Account WHERE username = '"+txtUserName.Text+"' AND user_pass = '"+txtPass.Text+"'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    username = txtUserName.Text;
                    user_pass = txtPass.Text;

                    //form that need to be load next
                    new MainForm().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu! Vui lòng kiểm tra lại", "DiaryApp", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtUserName.Clear();
                    txtPass.Clear();

                    txtUserName.Focus();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }
            
            
        }
        #endregion

        #region Register Form
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
                txtPass1.UseSystemPasswordChar = false;
                eyeHide = false;
            }
            else
            {
                pEye.Image = global::DiaryApp.Properties.Resources.eye_crossed;
                txtPass1.UseSystemPasswordChar = true;
                eyeHide = true;
            }
        }

        private bool eyeHide2 = true;
        private void pEye2_Click(object sender, EventArgs e)
        {
            if (eyeHide2 == true)
            {
                pEye2.Image = global::DiaryApp.Properties.Resources.eye;
                txtPass2.UseSystemPasswordChar = false;
                eyeHide2 = false;
            }
            else
            {
                pEye2.Image = global::DiaryApp.Properties.Resources.eye_crossed;
                txtPass2.UseSystemPasswordChar = true;
                eyeHide2 = true;
            }
        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            pageLogAndReg.SelectTab(0);
        }
        #endregion

        private void label1_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://www.termsfeed.com/live/789f25f3-0f9e-4416-a657-e302e36ec0f8") { UseShellExecute = true });
        }
    }
}
