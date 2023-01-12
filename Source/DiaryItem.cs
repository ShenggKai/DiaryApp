using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiaryApp.Source
{
    public partial class DiaryItem : UserControl
    {
        public DiaryItem()
        {
            InitializeComponent();
        }

        private void DiaryItem_Load(object sender, EventArgs e)
        {
            string temp = DateTime.Now.ToString("D");
            lbDate.Text = DateTime.Now.ToString("dddd") + ", " + temp;

            lbTime.Text = DateTime.Now.ToString("t");
        }

        #region editable string
        public string Title
        { 
            get { return lbTitle.Text; }
            set { lbTitle.Text = value; }
        }

        public string Content
        {
            get { return rtxtContent.Text; }
            set { rtxtContent.Text = value;}
        }

        #endregion editable string

        #region custom event
        protected void pDel_Click(object sender, EventArgs e)
        {
            const string message = "Xác nhận xóa nhật ký ?";
            const string caption = "DiaryApp";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                this.Controls.Clear();
                this.Dispose();
            }
        }

        protected void pShare_Click(object sender, EventArgs e)
        {

        }

        private void pEit_Click(object sender, EventArgs e)
        {

        }
        #endregion custom event
    }
}
