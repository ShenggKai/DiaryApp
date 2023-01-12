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

        private void lbDate_Click(object sender, EventArgs e)
        {

        }
    }
}
