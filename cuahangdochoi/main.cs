using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cuahangdochoi
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void btnqlykho_Click(object sender, EventArgs e)
        {
            quanlykho1.BringToFront();
        }

        private void btnqlybanhang_Click(object sender, EventArgs e)
        {
            quanlybanhang1.BringToFront();
        }

        private void btnqlykhachhang_Click(object sender, EventArgs e)
        {
            quanlykhachhang1.BringToFront();
        }

        private void btnqlynhanvien_Click(object sender, EventArgs e)
        {
            quanlynhanvien1.BringToFront();
        }

        private void btnthongke_Click(object sender, EventArgs e)
        {
            thongke1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
