namespace cuahangdochoi
{
    partial class quanlybanhang
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvbanhang = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbmausac = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbgia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbtensp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbmasp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbtimkiem = new System.Windows.Forms.TextBox();
            this.bttk = new System.Windows.Forms.Button();
            this.btthem = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btreset = new System.Windows.Forms.Button();
            this.masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mausac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbdv = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbanhang)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvbanhang
            // 
            this.dgvbanhang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvbanhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbanhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masp,
            this.tensp,
            this.gia,
            this.soluong,
            this.mausac});
            this.dgvbanhang.Location = new System.Drawing.Point(12, 210);
            this.dgvbanhang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvbanhang.Name = "dgvbanhang";
            this.dgvbanhang.RowHeadersVisible = false;
            this.dgvbanhang.RowHeadersWidth = 51;
            this.dgvbanhang.RowTemplate.Height = 24;
            this.dgvbanhang.Size = new System.Drawing.Size(1097, 455);
            this.dgvbanhang.TabIndex = 16;
            this.dgvbanhang.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvbanhang_CellMouseClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel2.Controls.Add(this.tbdv);
            this.panel2.Controls.Add(this.tbmausac);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.tbgia);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.tbtensp);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.tbmasp);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(226, 63);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(883, 140);
            this.panel2.TabIndex = 15;
            // 
            // tbmausac
            // 
            this.tbmausac.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbmausac.Location = new System.Drawing.Point(748, 34);
            this.tbmausac.Margin = new System.Windows.Forms.Padding(4);
            this.tbmausac.Name = "tbmausac";
            this.tbmausac.Size = new System.Drawing.Size(106, 30);
            this.tbmausac.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(662, 36);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Màu sắc:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(376, 92);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Đơn vị:";
            // 
            // tbgia
            // 
            this.tbgia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbgia.Location = new System.Drawing.Point(466, 28);
            this.tbgia.Margin = new System.Windows.Forms.Padding(4);
            this.tbgia.Name = "tbgia";
            this.tbgia.Size = new System.Drawing.Size(188, 30);
            this.tbgia.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(376, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Đơn giá:";
            // 
            // tbtensp
            // 
            this.tbtensp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtensp.Location = new System.Drawing.Point(157, 85);
            this.tbtensp.Margin = new System.Windows.Forms.Padding(4);
            this.tbtensp.Name = "tbtensp";
            this.tbtensp.Size = new System.Drawing.Size(188, 30);
            this.tbtensp.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(17, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên sản phẩm:";
            // 
            // tbmasp
            // 
            this.tbmasp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbmasp.Location = new System.Drawing.Point(157, 26);
            this.tbmasp.Margin = new System.Windows.Forms.Padding(4);
            this.tbmasp.Name = "tbmasp";
            this.tbmasp.Size = new System.Drawing.Size(188, 30);
            this.tbmasp.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sản phẩm:";
            // 
            // tbtimkiem
            // 
            this.tbtimkiem.Location = new System.Drawing.Point(426, 14);
            this.tbtimkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbtimkiem.Multiline = true;
            this.tbtimkiem.Name = "tbtimkiem";
            this.tbtimkiem.Size = new System.Drawing.Size(684, 43);
            this.tbtimkiem.TabIndex = 14;
            // 
            // bttk
            // 
            this.bttk.Location = new System.Drawing.Point(226, 14);
            this.bttk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttk.Name = "bttk";
            this.bttk.Size = new System.Drawing.Size(193, 43);
            this.bttk.TabIndex = 13;
            this.bttk.Text = "Tìm Kiếm";
            this.bttk.UseVisualStyleBackColor = true;
            // 
            // btthem
            // 
            this.btthem.Location = new System.Drawing.Point(12, 14);
            this.btthem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(193, 43);
            this.btthem.TabIndex = 12;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // btsua
            // 
            this.btsua.Location = new System.Drawing.Point(12, 62);
            this.btsua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(193, 43);
            this.btsua.TabIndex = 11;
            this.btsua.Text = "Sửa";
            this.btsua.UseVisualStyleBackColor = true;
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // btxoa
            // 
            this.btxoa.Location = new System.Drawing.Point(12, 111);
            this.btxoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(193, 43);
            this.btxoa.TabIndex = 10;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btreset
            // 
            this.btreset.Location = new System.Drawing.Point(12, 160);
            this.btreset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btreset.Name = "btreset";
            this.btreset.Size = new System.Drawing.Size(193, 43);
            this.btreset.TabIndex = 9;
            this.btreset.Text = "Làm Mới";
            this.btreset.UseVisualStyleBackColor = true;
            this.btreset.Click += new System.EventHandler(this.btreset_Click);
            // 
            // masp
            // 
            this.masp.DataPropertyName = "masp";
            this.masp.HeaderText = "Mã Sản Phẩm";
            this.masp.MinimumWidth = 6;
            this.masp.Name = "masp";
            // 
            // tensp
            // 
            this.tensp.DataPropertyName = "tensp";
            this.tensp.HeaderText = "Tên Sản phẩm";
            this.tensp.MinimumWidth = 6;
            this.tensp.Name = "tensp";
            // 
            // gia
            // 
            this.gia.DataPropertyName = "gia";
            this.gia.HeaderText = "Giá";
            this.gia.MinimumWidth = 6;
            this.gia.Name = "gia";
            // 
            // soluong
            // 
            this.soluong.DataPropertyName = "soluong";
            this.soluong.HeaderText = "Đơn Vị";
            this.soluong.MinimumWidth = 6;
            this.soluong.Name = "soluong";
            // 
            // mausac
            // 
            this.mausac.DataPropertyName = "mausac";
            this.mausac.HeaderText = "Màu Sắc";
            this.mausac.MinimumWidth = 6;
            this.mausac.Name = "mausac";
            // 
            // tbdv
            // 
            this.tbdv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbdv.Location = new System.Drawing.Point(466, 90);
            this.tbdv.Margin = new System.Windows.Forms.Padding(4);
            this.tbdv.Name = "tbdv";
            this.tbdv.Size = new System.Drawing.Size(188, 30);
            this.tbdv.TabIndex = 10;
            // 
            // quanlybanhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvbanhang);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tbtimkiem);
            this.Controls.Add(this.bttk);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.btsua);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.btreset);
            this.Name = "quanlybanhang";
            this.Size = new System.Drawing.Size(1123, 679);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbanhang)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvbanhang;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbmausac;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbgia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbtensp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbmasp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbtimkiem;
        private System.Windows.Forms.Button bttk;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btreset;
        private System.Windows.Forms.DataGridViewTextBoxColumn masp;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensp;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn mausac;
        private System.Windows.Forms.TextBox tbdv;
    }
}
