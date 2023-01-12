using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiaryApp.Source
{
    public partial class EditDiary : Form
    {
        public EditDiary()
        {
            InitializeComponent();
        }

        #region button click
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            DiaryItem diaryItem = new DiaryItem();
            diaryItem.Title = txtTitle.Text;
            diaryItem.Content = rtEditConent.Text;

            MainForm.instance.pnItem.Controls.Add(diaryItem);
            this.Close();
        }
        #endregion button click
    }
}
