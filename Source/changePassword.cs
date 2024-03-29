﻿using System;
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
    public partial class changePassword : Form
    {
        public changePassword()
        {
            InitializeComponent();
            instance = this;
        }

        #region main variable
        public static changePassword instance;

        string Username = MainForm.instance.Username.Text;
        string Email = MainForm.instance.Email.Text;

        // SQL server connection
        //SqlConnection conn = new SqlConnection(@"Data Source=KAI\SQLEXPRESS;Initial Catalog=DiaryApp;Integrated Security=True");
        #endregion main variable

        #region eye click
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
        #endregion eye click

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            if (txtPass1.Text != txtPass2.Text)
            {
                MessageBox.Show("Mật khẩu không khớp!", "DiaryApp", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtPass1.Clear();
                txtPass2.Clear();
            }
            else
            {
                string temPass = txtPass1.Text;
                using (SqlConnection connection = new SqlConnection(@"Data Source=KAI\SQLEXPRESS;Initial Catalog=DiaryApp;Integrated Security=True"))
                {
                    connection.Open();

                    string query = "UPDATE Account SET user_pass = @temPass WHERE email = @Email";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", Email);
                        command.Parameters.AddWithValue("@temPass", temPass);
                        int rowsAffected = command.ExecuteNonQuery();
                    }
                    connection.Close();
                }

                MessageBox.Show("Đổi mật khẩu thành công!", "DiaryApp", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //txtPass1.Clear();
                //txtPass2.Clear();
            }
        }
    }
}
