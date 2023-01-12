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

        public event EventHandler Delete;
        public event EventHandler Share;
        public event EventHandler Edit;

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
            if (this.Delete != null)
            {
                Delete.Invoke(this, e);
            }
        }

        protected void pShare_Click(object sender, EventArgs e)
        {
            if (this.Share != null)
            {
                Share.Invoke(this, e);
            }
        }

        private void pEit_Click(object sender, EventArgs e)
        {
            if (this.Edit != null)
            {
                Edit.Invoke(this, e);
            }
        }
        #endregion custom event
    }
}
