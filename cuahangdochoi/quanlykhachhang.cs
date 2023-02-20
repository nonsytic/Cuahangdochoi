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
    public partial class quanlykhachhang : UserControl
    {
        SqlConnection con = new SqlConnection(connect.conn);
        SqlCommand cmd;
        SqlDataAdapter adt = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loaddata()
        {
            SqlCommand com = new SqlCommand("select makh,hoten,sdt,diachi from khachhang", con);
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter(com);
            dt.Fill(ds);
            DTVkh.DataSource = ds.Tables[0];
        }
        public quanlykhachhang()
        {
            InitializeComponent();
            loaddata();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btthem_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandText = "Insert Into khachhang values('" + tbidkh.Text + "',N'" + tbtenkh.Text + "',N'" + tbsdt.Text + "','"+ tbdiachi.Text + "')";
                cmd.ExecuteNonQuery();
                loaddata();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không được để trống");
            }
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            con.Close();
            try
            {
                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandText = "UPDATE khachhang set hoten=  N'" + tbtenkh.Text + "',diachi = N'" + tbdiachi.Text + "',sdt = '" + tbsdt.Text + "' where makh = '" + tbidkh.Text + "'";
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
                cmd.CommandText = "delete from khachhang where makh = '" + tbidkh.Text + "'";
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
            tbidkh.Text = "";
            tbtenkh.Text = "";
            tbsdt.Text = "";
            tbdiachi.Text = "";

            loaddata();
        }

        private void DTVkh_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i;
            i = DTVkh.CurrentRow.Index;
            tbidkh.Text = DTVkh.Rows[i].Cells[0].Value.ToString();
            tbtenkh.Text = DTVkh.Rows[i].Cells[1].Value.ToString();
            tbsdt.Text = DTVkh.Rows[i].Cells[2].Value.ToString();
            tbdiachi.Text = DTVkh.Rows[i].Cells[3].Value.ToString();
        }
    }
}
