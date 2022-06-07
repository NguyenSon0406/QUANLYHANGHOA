using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CS464_F_Nguyen_Son_5999
{
    public partial class frm_ThongTinMatHang : Form
    {
        LopDungChung lopchung = new LopDungChung();

        public frm_ThongTinMatHang()
        {
            InitializeComponent();
            LoadHH();
        }
        
        private void btn_add_Click(object sender, EventArgs e)
        {
            string id = txt_mahang.Text.ToString();
            string tenhang = txt_tenhang.Text.ToString();
            if(id != "" && tenhang != "")
            {
                string sqlAdd = "INSERT INTO DANHMUCHHANG values ('" + txt_mahang.Text + "',N'" + txt_tenhang.Text
               + "','" + cb_ncc.SelectedValue + "',N'" + cb_donvitinh.SelectedItem + "')";
                lopchung.NonQuery(sqlAdd, 1);
            }
            else
                MessageBox.Show("Phải nhập mã và tên hàng! ");
            LoadHH();
        }
        public void LoadHH()
        {
            string sqlLoad = "SELECT * FROM DANHMUCHHANG";
            dataGridView1.DataSource = lopchung.LoadData(sqlLoad);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            txt_mahang.Text = dataGridView1.CurrentRow.Cells["ma_hang"].Value.ToString();
            txt_tenhang.Text = dataGridView1.CurrentRow.Cells["ten_hang"].Value.ToString();
            cb_ncc.SelectedValue = dataGridView1.CurrentRow.Cells["ma_nhacc"].Value.ToString();
            cb_donvitinh.SelectedItem = dataGridView1.CurrentRow.Cells["don_vi_tinh"].Value.ToString();
        }

        private void frm_ThongTinMatHang_Load(object sender, EventArgs e)
        {

            dataGridView1.Columns[0].HeaderText = "Mã hàng";
            dataGridView1.Columns[1].HeaderText = "Tên hàng";
            dataGridView1.Columns[2].HeaderText = "Mã nhà cung cấp";
            dataGridView1.Columns[3].HeaderText = "Đơn vị tính";
            LoadHH();
            LoadCombo();
        }
        public void LoadCombo()
        {
            string sqlNCC = "SELECT * FROM NHACUNGCAP";
            cb_ncc.DataSource = lopchung.LoadData(sqlNCC);
            cb_ncc.DisplayMember = "ten_nhacc";
            cb_ncc.ValueMember = "ma_nhacc";

            //string sqldvt = "SELECT don_vi_tinh FROM DANHMUCHHANG GROUP BY don_vi_tinh";
            //cb_donvitinh.DataSource = lopchung.LoadData(sqldvt);
            //cb_donvitinh.DisplayMember = "don_vi_tinh";
            //cb_donvitinh.ValueMember = "don_vi_tinh";
        }

        private void cb_ncc_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if(choice ==0 )
            //{
            //    string text = cb_ncc.SelectedValue.ToString();
            //    string sqlcb = "SELECT * FROM DANHMUCHHANG WHERE ma_nhacc = '" + text + "'";
            //    dataGridView1.DataSource = lopchung.LoadData(sqlcb);
            //}
            //choice = 0;
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            string sqlDel = "DELETE FROM DANHMUCHHANG WHERE ma_hang = '" + txt_mahang.Text + "'";
            lopchung.NonQuery(sqlDel,2);
            LoadHH();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            string sqlUpdate = "UPDATE DANHMUCHHANG  SET ten_hang = N'" + txt_tenhang.Text 
               + "',ma_nhacc =N'" + cb_ncc.SelectedValue + "', don_vi_tinh =N'" + cb_donvitinh.SelectedItem + "' where ma_hang = '"+ txt_mahang.Text+"'";
            lopchung.NonQuery(sqlUpdate, 3);
            LoadHH();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
