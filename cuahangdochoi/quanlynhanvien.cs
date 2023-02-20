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
    public partial class quanlynhanvien : UserControl
    {
        SqlConnection con = new SqlConnection(connect.conn);
        SqlCommand cmd;
        SqlDataAdapter adt = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loaddata()
        {
            SqlCommand com = new SqlCommand("select manv,tennv,diachi,sdt from nhanvien", con);
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter(com);
            dt.Fill(ds);
            DTVnv.DataSource = ds.Tables[0];

        }
        public quanlynhanvien()
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
                cmd.CommandText = "Insert Into nhanvien(manv,tennv,diachi,sdt) values('" + idnv.Text + "',N'" + tbhoten.Text + "',N'" + tbdc.Text + "','" + tbsdt.Text + "')";
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
                cmd.CommandText = "UPDATE nhanvien set tennv=  N'" + tbhoten.Text + "',diachi = N'" + tbdc.Text + "',sdt = '" + tbsdt.Text + "' where manv = '" + idnv.Text + "'";
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
                cmd.CommandText = "delete from nhanvien where manv = '" + idnv.Text + "'";
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
            idnv.Text = "";
            tbhoten.Text = "";
            tbsdt.Text = "";
            tbdc.Text = "";

            loaddata();
        }

        private void bttk_Click(object sender, EventArgs e)
        {

                SqlCommand com = new SqlCommand("select manv,tennv,diachi,sdt from nhanvien where manv like '" + tbtimkiem.Text + "%'", con);
                DataSet ds = new DataSet();
                SqlDataAdapter dt = new SqlDataAdapter(com);
                dt.Fill(ds);
                DTVnv.DataSource = ds.Tables[0];
 
        }

        private void DTVnv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i;
            i = DTVnv.CurrentRow.Index;
            idnv.Text = DTVnv.Rows[i].Cells[0].Value.ToString();
            tbhoten.Text = DTVnv.Rows[i].Cells[1].Value.ToString();
            tbdc.Text = DTVnv.Rows[i].Cells[2].Value.ToString();
            tbsdt.Text = DTVnv.Rows[i].Cells[3].Value.ToString();
        }
    }
}
