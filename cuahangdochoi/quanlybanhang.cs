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
    public partial class quanlybanhang : UserControl
    {
        SqlConnection con = new SqlConnection(connect.conn);
        SqlCommand cmd;
        SqlDataAdapter adt = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loaddata()
        {
            SqlCommand com = new SqlCommand("select masp,tensp,mausac,soluong,gia from sanpham", con);
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter(com);
            dt.Fill(ds);
            dgvbanhang.DataSource = ds.Tables[0];

        }
        public quanlybanhang()
        {
            InitializeComponent();
            loaddata();
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandText = "Insert Into sanpham (masp,tensp,mausac,soluong,gia) values('" + tbmasp.Text + "','" + tbtensp.Text + "','" + tbmausac.Text + "','" + tbdv.Text + "','" + tbgia.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không được để trống");
            }
            loaddata();
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            con.Close();
            try
            {
                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandText = "UPDATE sanpham set tensp =  '" + tbtensp.Text + "',mausac='" + tbmausac.Text + "',gia='" + tbgia.Text + "',soluong='" + tbdv.Text + "' where masp = '" + tbmasp.Text + "'";
                cmd.ExecuteNonQuery();
                loaddata();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không được để trống");
            }
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandText = "delete from sanpham where masp = '" + tbmasp.Text + "'";
                cmd.ExecuteNonQuery();
                loaddata();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không được để trống");
            }
        }

        private void btreset_Click(object sender, EventArgs e)
        {
            tbmasp.Text = "";
            tbtensp.Text = "";
            tbmausac.Text = "";
            tbgia.Text = "";
            tbdv.Text = "";

            loaddata();
        }

        private void dgvbanhang_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i;
            i = dgvbanhang.CurrentRow.Index;
            tbmasp.Text = dgvbanhang.Rows[i].Cells[0].Value.ToString();
            tbtensp.Text = dgvbanhang.Rows[i].Cells[1].Value.ToString();
            tbmausac.Text = dgvbanhang.Rows[i].Cells[2].Value.ToString();
            tbdv.Text = dgvbanhang.Rows[i].Cells[3].Value.ToString();
            tbgia.Text = dgvbanhang.Rows[i].Cells[4].Value.ToString();
        }
    }
}
