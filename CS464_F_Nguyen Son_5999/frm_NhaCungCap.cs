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
    public partial class frm_NhaCungCap : Form
    {
        LopDungChung lopchung = new LopDungChung();
        public frm_NhaCungCap()
        {
            InitializeComponent();
            LoadNCC();
        }
        public void LoadNCC()
        {
            string sqlLoad = "SELECT * FROM NHACUNGCAP";
            dataGridView1.DataSource = lopchung.LoadData(sqlLoad);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_mancc.Text = dataGridView1.CurrentRow.Cells["ma_nhacc"].Value.ToString();
            txt_tenncc.Text = dataGridView1.CurrentRow.Cells["ten_nhacc"].Value.ToString();
            txt_diachi.Text = dataGridView1.CurrentRow.Cells["dia_chi"].Value.ToString();
            txt_sdt.Text = dataGridView1.CurrentRow.Cells["so_dien_thoai"].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void frm_NhaCungCap_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].HeaderText = "Mã nhà cung cấp";
            dataGridView1.Columns[1].HeaderText = "Tên nhà cung cấp";
            dataGridView1.Columns[2].HeaderText = "Địa chỉ";
            dataGridView1.Columns[3].HeaderText = "Số điện thoại";
        }
    }
}
