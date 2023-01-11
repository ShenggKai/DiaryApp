using DiaryApp.Source;
using System.Drawing;

namespace DiaryApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

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

        #region MENU

        // button trang chu
        private void btnHome_Click(object sender, EventArgs e)
        {
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
        }

        // button lich
        private void btnCalendar_Click(object sender, EventArgs e)
        {
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

        }

        // button tai khoan
        private void btnUser_Click(object sender, EventArgs e)
        {
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
        }

        #endregion MENU


    }
}