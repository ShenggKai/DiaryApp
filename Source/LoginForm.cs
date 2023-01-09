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
        #region Main
        public LoginForm()
        {
            InitializeComponent();
        }

        // SQL server connection
        SqlConnection conn = new SqlConnection(@"Data Source=KAI\SQLEXPRESS;Initial Catalog=DiaryApp;Integrated Security=True");

        // Close button
        private void pClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // button login
            btnLogin.BackColor = Color.FromArgb(217, 217, 217);
            btnLogin.ForeColor = Color.FromArgb(70, 70, 70);
            btnLogin.Enabled = false;

            // button resister
            btnRes.BackColor = Color.FromArgb(217, 217, 217);
            btnRes.ForeColor = Color.FromArgb(70, 70, 70);
            btnRes.Enabled = false;

            // button OTP send
            btnOTP.BackColor = Color.FromArgb(217, 217, 217);
            btnOTP.ForeColor = Color.FromArgb(70, 70, 70);
            btnOTP.Enabled = false;

            // button dat lai mat khau
            btnRepass.BackColor = Color.FromArgb(217, 217, 217);
            btnRepass.ForeColor = Color.FromArgb(70, 70, 70);
            btnRepass.Enabled = false;

            // button khoi phuc
            btnRestore.BackColor = Color.FromArgb(217, 217, 217);
            btnRestore.ForeColor = Color.FromArgb(70, 70, 70);
            btnRestore.Enabled = false;
        }

        // Enable button function
        private void btnEnable(Button btn, bool txt1, bool txt2, bool txt3, bool txt4)
        {
            if (txt1 == true && txt2 == true && txt3 == true && txt4 == true)
            {
                btn.Enabled = true;
                btn.BackColor = Color.FromArgb(90, 130, 95);
                btn.ForeColor = Color.White;
            }
        }

        // Unable button function
        private void btnUnable(Button btn)
        {
            btn.BackColor = Color.FromArgb(217, 217, 217);
            btn.ForeColor = Color.FromArgb(70, 70, 70);
            btn.Enabled = false;
        }
        #endregion

        #region Login Form

        #region Enable or unable button dang nhap
        private bool txtuserChanged = false;
        private bool txtPassChnaged = false;

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                txtuserChanged = false;
                btnUnable(btnLogin);
            }
            else
            {
                txtuserChanged = true;
                if (txtPassChnaged == true)
                {
                    btnEnable(btnLogin, txtuserChanged, txtPassChnaged, true, true);
                }
            }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPassChnaged = false;
                btnUnable(btnLogin);
            }
            else
            {
                txtPassChnaged = true;
                if (txtuserChanged == true)
                {
                    btnEnable(btnLogin, txtuserChanged, txtPassChnaged, true, true);
                }
            }
        }
        #endregion

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

        private void lbForget_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPass.Clear();
            pageLogAndReg.SelectTab(2);
        }
        #endregion

        #region Register Form

        #region Enable or Unable button dang ky

        private bool txtUserName1Changed = false;
        private bool txtEmailChanged = false;
        private bool txtPass1Changed = false;
        private bool txtPass2Changed = false;

        private void txtUserName1_TextChanged(object sender, EventArgs e)
        {
            if (txtUserName1.Text == "")
            {
                txtUserName1Changed = false;
                btnUnable(btnRes);
            }
            else
            {
                txtUserName1Changed = true;
                if (cbAgree.Checked)
                {
                    btnEnable(btnRes, txtUserName1Changed, txtEmailChanged, txtPass1Changed, txtPass2Changed);
                }
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmailChanged = false;
                btnUnable(btnRes);
            }
            else
            {
                txtEmailChanged = true;
                if (cbAgree.Checked)
                {
                    btnEnable(btnRes, txtUserName1Changed, txtEmailChanged, txtPass1Changed, txtPass2Changed);
                }
            }
        }

        private void txtPass1_TextChanged(object sender, EventArgs e)
        {
            if (txtPass1.Text == "")
            {
                txtPass1Changed = false;
                btnUnable(btnRes);
            }
            else
            {
                txtPass1Changed = true;
                if (cbAgree.Checked)
                {
                    btnEnable(btnRes, txtUserName1Changed, txtEmailChanged, txtPass1Changed, txtPass2Changed);
                }
            }
        }

        private void txtPass2_TextChanged(object sender, EventArgs e)
        {
            if (txtPass2.Text == "")
            {
                txtPass2Changed = false;
                btnUnable(btnRes);
            }
            else
            {
                txtPass2Changed = true;
                if (cbAgree.Checked)
                {
                    btnEnable(btnRes, txtUserName1Changed, txtEmailChanged, txtPass1Changed, txtPass2Changed);
                }
            }
        }

        //check box dong y dieu khoan
        private void cbAgree_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAgree.Checked)
            {
                btnEnable(btnRes, txtUserName1Changed, txtEmailChanged, txtPass1Changed, txtPass2Changed);
            }
            else
            {
                btnUnable(btnRes);
            }
        }
        #endregion

        private void lbNavLog_Click(object sender, EventArgs e)
        {
            txtUserName1.Clear();
            txtEmail.Clear();
            txtPass1.Clear();
            txtPass2.Clear();
            cbAgree.Checked = false;

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
            cbAgree.Checked= false;

            pageLogAndReg.SelectTab(0);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://www.termsfeed.com/live/789f25f3-0f9e-4416-a657-e302e36ec0f8") { UseShellExecute = true });
        }
        #endregion

        #region OTP Form
        #region button click event
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

        #region Enable or unable button in OTP form
        private void txtEmail2_TextChanged(object sender, EventArgs e)
        {
            if (txtEmail2.Text == "")
            {
                btnUnable(btnOTP);
            }
            else
            {
                btnEnable(btnOTP, true, true, true, true);
            }
        }

        private void txtOTP_TextChanged(object sender, EventArgs e)
        {
            if (txtOTP.Text == "")
            {
                btnUnable(btnRepass);
            }
            else
            {
                btnEnable(btnRepass, true, true, true, true);
            }
        }
        #endregion

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
