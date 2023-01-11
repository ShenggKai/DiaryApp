using DiaryApp.Source;
using System.Data.SqlClient;
using System.Drawing;

namespace DiaryApp
{
    public partial class MainForm : Form //form 2
    {
        #region MAIN
        public MainForm()
        {
            InitializeComponent();

            instance = this;
            Username = lbUsername1;
            Email = lbEmail;

        }

        #region Main variable
        public static MainForm instance;
        public Label Username;
        public Label Email;

        string txtusername = LoginForm.instance.tbUserName.Text;
        string txtpassword = LoginForm.instance.tbPassword.Text;
        string txtemail = "e";

        #endregion Main variable

        // button dang xuat
        private void btnLogout_Click(object sender, EventArgs e)
        {
            //var result = MessageBox.Show("Are you sure you want to Logout?", "DiaryApp",
            //    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //if (result == DialogResult.Yes)
            //{
            //    new LoginForm().Show();
            //    this.Close();
            //}
            new LoginForm().Show();
            this.Close();
        }

        // when main form load
        private void MainForm_Load(object sender, EventArgs e)
        {
            //demo
            //lbUsername.Text = LoginForm.instance.tbUserName.Text;

            #region load user information
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=KAI\SQLEXPRESS;Initial Catalog=DiaryApp;Integrated Security=True"))
                {
                    conn.Open();

                    string query = "SELECT username, email FROM Account WHERE username = @txtusername OR email = @txtusername";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@txtusername", txtusername);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string tempuser = reader["username"].ToString();
                                string tempemail = reader["email"].ToString();

                                lbUsername.Text = tempuser;
                                txtemail = tempemail;

                                // thong tin tai khoan
                                lbUsername1.Text = tempuser;
                                lbEmail.Text = tempemail;
                            }
                        }
                    }

                    conn.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error!", "DiaryApp", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion load user information
        }
        #endregion MAIN

        #region MENU

        // button trang chu
        private void btnHome_Click(object sender, EventArgs e)
        {
            #region change color
            //change
            btnHome.BackColor = Color.Gainsboro;
            btnHome.ForeColor = Color.FromArgb(90, 130, 95);
            btnHome.Image = global::DiaryApp.Properties.Resources.home_green;

            //back
            btnCalendar.BackColor = Color.FromArgb(90, 130, 95);
            btnCalendar.ForeColor = Color.White;
            btnCalendar.Image = global::DiaryApp.Properties.Resources.calendar;

            btnUser.BackColor = Color.FromArgb(90, 130, 95);
            btnUser.ForeColor = Color.White;
            btnUser.Image = global::DiaryApp.Properties.Resources.user;
            #endregion change color

            pageMain.SelectTab(0);
        }

        // button lich
        private void btnCalendar_Click(object sender, EventArgs e)
        {
            #region change color
            //change
            btnCalendar.BackColor = Color.Gainsboro;
            btnCalendar.ForeColor = Color.FromArgb(90, 130, 95);
            btnCalendar.Image = global::DiaryApp.Properties.Resources.calendar_green;

            //back
            btnHome.BackColor = Color.FromArgb(90, 130, 95);
            btnHome.ForeColor = Color.White;
            btnHome.Image = global::DiaryApp.Properties.Resources.home_full;

            btnUser.BackColor = Color.FromArgb(90, 130, 95);
            btnUser.ForeColor = Color.White;
            btnUser.Image = global::DiaryApp.Properties.Resources.user;
            #endregion change color

            pageMain.SelectTab(1);
        }

        // button tai khoan
        private void btnUser_Click(object sender, EventArgs e)
        {
            #region change color
            //change
            btnUser.BackColor = Color.Gainsboro;
            btnUser.ForeColor = Color.FromArgb(90, 130, 95);
            btnUser.Image = global::DiaryApp.Properties.Resources.user_green1;

            //back
            btnHome.BackColor = Color.FromArgb(90, 130, 95);
            btnHome.ForeColor = Color.White;
            btnHome.Image = global::DiaryApp.Properties.Resources.home_full;

            btnCalendar.BackColor = Color.FromArgb(90, 130, 95);
            btnCalendar.ForeColor = Color.White;
            btnCalendar.Image = global::DiaryApp.Properties.Resources.calendar;
            #endregion change color

            pageMain.SelectTab(2);
        }


        #endregion MENU

        #region ACCOUNT
        private void pEditUser_Click(object sender, EventArgs e)
        {
            changeUsername chUser = new changeUsername();
            chUser.ShowDialog();
        }

        private void pEditEmail_Click(object sender, EventArgs e)
        {
            changeEmail chEmail = new changeEmail();
            chEmail.ShowDialog();
        }

        private void pEditPass_Click(object sender, EventArgs e)
        {
            changePassword chPass = new changePassword();
            chPass.ShowDialog();
        }
        #endregion ACCOUNT
    }
}