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
        }

        #region Main variable
        public static MainForm instance;

        // SQL server connection
        SqlConnection conn = new SqlConnection(@"Data Source=KAI\SQLEXPRESS;Initial Catalog=DiaryApp;Integrated Security=True");
        #endregion Main variable

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to Logout?", "DiaryApp",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                new LoginForm().Show();
                this.Close();
            }
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

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}