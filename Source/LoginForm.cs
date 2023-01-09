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
        private void LoginForm_Load(object sender, EventArgs e)
        {

            btnLogin.BackColor = Color.FromArgb(217, 217, 217);
            btnLogin.ForeColor = Color.FromArgb(70, 70, 70);
            btnLogin.Enabled = false;
        }

        private bool txtuserChanged = false;
        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                txtuserChanged = false;
                btnLogin.BackColor = Color.FromArgb(217, 217, 217);
                btnLogin.ForeColor = Color.FromArgb(70, 70, 70);
                btnLogin.Enabled = false;
            }
            else
            {
                txtuserChanged = true;
                if (txtPassChnaged == true)
                {
                    btnLogin.Enabled = true;
                    btnLogin.BackColor = Color.FromArgb(90, 130, 95);
                    btnLogin.ForeColor = Color.White;
                }
            }
        }

        private bool txtPassChnaged = false;
        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPassChnaged = false;
                btnLogin.BackColor = Color.FromArgb(217, 217, 217);
                btnLogin.ForeColor = Color.FromArgb(70, 70, 70);
                btnLogin.Enabled = false;
            }
            else
            {
                txtPassChnaged = true;
                if (txtuserChanged == true)
                {
                    btnLogin.Enabled = true;
                    btnLogin.BackColor = Color.FromArgb(90, 130, 95);
                    btnLogin.ForeColor = Color.White;
                }
            }
        }

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
            txtUserName.Clear();
            txtPass.Clear();
            pageLogAndReg.SelectTab(1);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String username, user_pass, email;

            username = txtUserName.Text;
            email = txtUserName.Text;
            user_pass = txtPass.Text;

            if (txtUserName.Text == "" || txtPass.Text == "")
            {

            }
            else
            {
                btnLogin.Enabled= true;
                try
                {
                    String querry = "SELECT * FROM Account WHERE (username = '" + txtUserName.Text + "' OR email = '" + txtUserName.Text + "') AND user_pass = '" + txtPass.Text + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                    DataTable dtable = new DataTable();
                    sda.Fill(dtable);

                    if (dtable.Rows.Count > 0)
                    {
                        username = txtUserName.Text;
                        email = txtUserName.Text;
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
        }

        private void lbForget_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPass.Clear();
            pageLogAndReg.SelectTab(2);
        }
        #endregion

        #region Register Form
        private void lbNavLog_Click(object sender, EventArgs e)
        {
            txtUserName1.Clear();
            txtEmail.Clear();
            txtPass1.Clear();
            txtPass2.Clear();
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
            txtUserName1.Clear();
            txtEmail.Clear();
            txtPass1.Clear();
            txtPass2.Clear();
            pageLogAndReg.SelectTab(0);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://www.termsfeed.com/live/789f25f3-0f9e-4416-a657-e302e36ec0f8") { UseShellExecute = true });
        }
        #endregion

        #region OTP Form
        private void btnRepass_Click(object sender, EventArgs e)
        {
            txtEmail2.Clear();
            txtOTP.Clear();
            pageLogAndReg.SelectTab(3);
        }

        private void lbNavLog2_Click(object sender, EventArgs e)
        {
            txtEmail2.Clear();
            txtOTP.Clear();
            pageLogAndReg.SelectTab(0);
        }
        #endregion

        #region Restore password Form
        private bool eyeHide3 = true;
        private void pEye3_Click(object sender, EventArgs e)
        {
            if (eyeHide3 == true)
            {
                pEye3.Image = global::DiaryApp.Properties.Resources.eye;
                txtPass3.UseSystemPasswordChar = false;
                eyeHide3 = false;
            }
            else
            {
                pEye3.Image = global::DiaryApp.Properties.Resources.eye_crossed;
                txtPass3.UseSystemPasswordChar = true;
                eyeHide3 = true;
            }
        }

        private bool eyeHide4 = true;
        private void pEye4_Click(object sender, EventArgs e)
        {
            if (eyeHide4 == true)
            {
                pEye4.Image = global::DiaryApp.Properties.Resources.eye;
                txtPass4.UseSystemPasswordChar = false;
                eyeHide4 = false;
            }
            else
            {
                pEye4.Image = global::DiaryApp.Properties.Resources.eye_crossed;
                txtPass4.UseSystemPasswordChar = true;
                eyeHide4 = true;
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            txtPass3.Clear();
            txtPass4.Clear();
            pageLogAndReg.SelectTab(0);
        }
        #endregion
    }
}
