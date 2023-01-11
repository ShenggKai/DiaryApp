using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DiaryApp.Source
{
    public partial class changeEmail : Form
    {
        public changeEmail()
        {
            InitializeComponent();
        }

        string tempUsername = MainForm.instance.Username.Text;

        bool IsValidEmail(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false;
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }

        private void btnChangeEmail_Click(object sender, EventArgs e)
        {
            if (IsValidEmail(txtEmail.Text) == false)
            {
                MessageBox.Show("Email không hợp lệ!", "DiaryApp", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtEmail.Clear();
            }
            else
            {
                string tempEmail = txtEmail.Text;

                using (SqlConnection connection = new SqlConnection(@"Data Source=KAI\SQLEXPRESS;Initial Catalog=DiaryApp;Integrated Security=True"))
                {
                    connection.Open();

                    string query = "UPDATE Account SET email = @tempEmail WHERE username = @tempUsername";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@tempEmail", tempEmail);
                        command.Parameters.AddWithValue("@tempUsername", tempUsername);
                        int rowsAffected = command.ExecuteNonQuery();
                    }
                    connection.Close();
                }

                MainForm.instance.Email.Text = txtEmail.Text;

                MessageBox.Show("Đổi email thành công!", "DiaryApp", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtEmail.Clear();
            }
        }
    }
}
