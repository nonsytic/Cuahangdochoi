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

namespace cuahangdochoi
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(connect.conn);
        SqlCommand cmd;
        SqlDataAdapter adt = new SqlDataAdapter();
        DataTable table = new DataTable();
        private void txttaikhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bntdangnhap_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select *from nhanvien where taikhoan='" + txttaikhoan.Text + "' and matkhau='" + txtmatkhau.Text + "'", con);
            //SqlDataReader dta = cmd.ExecuteReader();
            var reader = cmd.ExecuteReader();
            if (reader.Read() == true)
            {
                string data1 = reader.GetString(1);
                this.Hide();
                main form1 = new main();
                form1.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Nhập lại tài khoản mật khẩu");
                txttaikhoan.Focus();
            }
            con.Close();
        }
    }
}
