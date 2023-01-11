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

namespace DiaryApp.Source
{
    public partial class changeUsername : Form
    {
        public changeUsername()
        {
            InitializeComponent();
        }

        string tempEmail = MainForm.instance.Email.Text;
        

        private void btnChangeUsername_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=KAI\SQLEXPRESS;Initial Catalog=DiaryApp;Integrated Security=True"))
            {
                connection.Open();

                string tempUsername = txtUserName.Text;

                string query = "UPDATE Account SET username = @tempUsername WHERE email = @tempEmail";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@tempUsername", tempUsername);
                    command.Parameters.AddWithValue("@tempEmail", tempEmail);
                    int rowsAffected = command.ExecuteNonQuery();
                }
                connection.Close();
            }

            MainForm.instance.Username.Text = txtUserName.Text;

            MessageBox.Show("Đổi username thành công!", "DiaryApp", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtUserName.Clear();
        }
    }
}
