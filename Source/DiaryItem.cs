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
            
            instance = this;
            TieuDe = lbTitle;
            NoiDung = rtxtContent;
            Image = pImage;
        }

        public static DiaryItem instance;
        public Label TieuDe;
        public RichTextBox NoiDung;
        public PictureBox Image;

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

        public Image Pic
        {
            get { return pImage.Image; }
            set { pImage.Image = value; }
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
            Share chiase = new Share();
            chiase.ShowDialog();
        }

        private void pEit_Click(object sender, EventArgs e)
        {
            EditContent cont = new EditContent();
            cont.ShowDialog();
        }
        #endregion custom event

        private void DiaryItem_Click(object sender, EventArgs e)
        {
            ViewDiary view = new ViewDiary();
            view.ShowDialog();
        }
    }
}
