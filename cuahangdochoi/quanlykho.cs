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
    public partial class quanlykho : UserControl
    {
        SqlConnection con = new SqlConnection(connect.conn);
        SqlCommand cmd;
        SqlDataAdapter adt = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loaddata()
        {
            SqlCommand com = new SqlCommand("select makho,masp,soluong from kho", con);
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter(com);
            dt.Fill(ds);
            dgvkho.DataSource = ds.Tables[0];

        }
        public quanlykho()
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
                cmd.CommandText = "Insert Into kho values('" + tbmk.Text + "','" + tbmasp.Text + "','" + tbsoluong.Text + "')";
                cmd.ExecuteNonQuery();
                loaddata();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không được để trống");
            }
        }

        private void quanlykho_Load(object sender, EventArgs e)
        {
         
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandText = "UPDATE kho set soluong=  '" + tbsoluong.Text + "',masp= '" + tbmasp.Text + "' where makho = '" + tbmk.Text + "'";
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
                cmd.CommandText = "delete from kho where makho = '" + tbmk.Text + "'";
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
            tbmk.Text = "";
            tbmasp.Text = "";
            tbsoluong.Text = "";
        }

        private void bttimkiem_Click(object sender, EventArgs e)
        {

            SqlCommand com = new SqlCommand("select makho,masp,soluong from kho where makho like '" + tbtimkiem.Text + "%'", con);
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter(com);
            dt.Fill(ds);
            dgvkho.DataSource = ds.Tables[0];
        }

        private void dgvkho_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i;
            i = dgvkho.CurrentRow.Index;
            tbmk.Text = dgvkho.Rows[i].Cells[0].Value.ToString();
            tbmasp.Text = dgvkho.Rows[i].Cells[1].Value.ToString();
            tbsoluong.Text = dgvkho.Rows[i].Cells[2].Value.ToString();
        }
    }
}
