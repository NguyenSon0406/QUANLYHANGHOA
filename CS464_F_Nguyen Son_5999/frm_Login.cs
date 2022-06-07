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
    public partial class frm_Login : Form
    {
        LopDungChung lopchung=new LopDungChung();
        string kn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Năm 3\Kì 2\C#\CS464_F_Nguyen Son_5999\CS464_F_Nguyen Son_5999\QLHANGHOA.mdf;Integrated Security=True";
        public frm_Login()
        {
            InitializeComponent();
        }
        int count = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string sqlLogin = "SELECT COUNT(*) from TAIKHOAN where TENDANGNHAP = '" + txt_user.Text + "' and MATKHAU ='" + txt_pass.Text + "'";
            SqlConnection conn = new SqlConnection(kn);
            SqlCommand com = new SqlCommand(sqlLogin, conn);
            conn.Open();
            int kq = (int)com.ExecuteScalar();
            if (kq >= 1)
            {
                frm_Main OpenMain = new frm_Main();
                OpenMain.Show();
                count = 0;
                
                
            }
            else
            {
                count++;
                MessageBox.Show("Sai tài khoản, mật khẩu lần thứ "+count);
                
                if(count==3)
                {
                    MessageBox.Show("Bạn nhập sai quá 3 lần! Chương trình sẽ thoát!");
                    Application.Exit();
                }    
            }
            conn.Close();
        }

       
    }
}
