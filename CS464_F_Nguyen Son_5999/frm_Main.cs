using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS464_F_Nguyen_Son_5999
{
    public partial class frm_Main : Form
    {
        
        public frm_Main()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_NhaCungCap ncc = new frm_NhaCungCap();
            ncc.MdiParent = this;
            ncc.Show();
        }

        private void danhMụcHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ThongTinMatHang ttmh = new frm_ThongTinMatHang();
            ttmh.MdiParent = this;
            ttmh.Show();
        }
    }
}
