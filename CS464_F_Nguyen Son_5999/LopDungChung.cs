using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace CS464_F_Nguyen_Son_5999
{
    class LopDungChung
    {
        string kn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Năm 3\Kì 2\C#\CS464_F_Nguyen Son_5999\CS464_F_Nguyen Son_5999\QLHANGHOA.mdf;Integrated Security=True";
        SqlConnection conn;
        public LopDungChung()
        {
            conn = new SqlConnection(kn);
        }
        public DataTable LoadData(string sqlData)
        {
            SqlDataAdapter daData = new SqlDataAdapter(sqlData, conn);
            DataTable dtData = new DataTable();
            daData.Fill(dtData);
            return dtData;
        }
        public void NonQuery(string sqlNonquery, int code)
        {
            SqlCommand com = new SqlCommand(sqlNonquery, conn);
            conn.Open();
            if(code ==1 )
            {
                try
                {
                    int kq = com.ExecuteNonQuery();

                    if (kq >= 1)
                        MessageBox.Show("Thêm thành công");
                    else
                        MessageBox.Show("Thêm Thất bại");
                }
                catch
                {
                    MessageBox.Show("Thêm cái đã có mời nhập lại!");
                }
                finally
                {
                    conn.Close();
                }
            }
            else if(code ==2)
            {
                try
                {
                    int kq = com.ExecuteNonQuery();

                    if (kq >= 1)
                        MessageBox.Show("Xóa thành công");
                    else
                        MessageBox.Show("Xóa cái chưa có mời chọn cái đã có!");
                }
                catch
                {
                    MessageBox.Show("Lỗi chương trình!");
                }
                finally
                {
                    conn.Close();
                }
            }
            else if(code == 3)
            {
                try
                {
                    int kq = com.ExecuteNonQuery();

                    if (kq >= 1)
                        MessageBox.Show("Sửa thành công");
                    else
                        MessageBox.Show("Sửa cái không có trong hàng hóa, mời nhập lại!");
                }
                catch
                {
                    MessageBox.Show("Lỗi chương trình");
                }
                finally
                {
                    conn.Close();
                }
            }
            


        }
        public int ExecuteScalar(string sql)
        {
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            int kq = (int)comm.ExecuteScalar();
            conn.Close();
            return kq;
        }
    }
}
