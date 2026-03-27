namespace DoAnQuanLyTienGui.Form
{
    partial class frmKhachHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox2 = new GroupBox();
            dgvKhachHang = new DataGridView();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtDiaChi = new TextBox();
            txtSDT = new TextBox();
            txtTenKH = new TextBox();
            txtMaKH = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnLuu = new Button();
            helpProvider1 = new HelpProvider();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvKhachHang);
            groupBox2.Location = new Point(22, 178);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(787, 321);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách khách hàng";
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhachHang.Location = new Point(-1, 26);
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.RowHeadersWidth = 51;
            dgvKhachHang.Size = new Size(788, 286);
            dgvKhachHang.TabIndex = 2;
            // 
            // btnLamMoi
            // 
            helpProvider1.SetHelpString(btnLamMoi, "web");
            btnLamMoi.Location = new Point(627, 136);
            btnLamMoi.Name = "btnLamMoi";
            helpProvider1.SetShowHelp(btnLamMoi, true);
            btnLamMoi.Size = new Size(94, 29);
            btnLamMoi.TabIndex = 4;
            btnLamMoi.Text = "Làm mới ";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXoa
            // 
            helpProvider1.SetHelpString(btnXoa, "web");
            btnXoa.Location = new Point(390, 136);
            btnXoa.Name = "btnXoa";
            helpProvider1.SetShowHelp(btnXoa, true);
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            helpProvider1.SetHelpString(btnSua, "web");
            btnSua.Location = new Point(262, 136);
            btnSua.Name = "btnSua";
            helpProvider1.SetShowHelp(btnSua, true);
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 6;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            helpProvider1.SetHelpString(btnThem, "web");
            btnThem.Location = new Point(132, 136);
            btnThem.Name = "btnThem";
            helpProvider1.SetShowHelp(btnThem, true);
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 7;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click_1;
            // 
            // txtDiaChi
            // 
            helpProvider1.SetHelpString(txtDiaChi, "web");
            txtDiaChi.Location = new Point(496, 73);
            txtDiaChi.Name = "txtDiaChi";
            helpProvider1.SetShowHelp(txtDiaChi, true);
            txtDiaChi.Size = new Size(183, 27);
            txtDiaChi.TabIndex = 1;
            // 
            // txtSDT
            // 
            helpProvider1.SetHelpString(txtSDT, "web");
            txtSDT.Location = new Point(496, 24);
            txtSDT.Name = "txtSDT";
            helpProvider1.SetShowHelp(txtSDT, true);
            txtSDT.Size = new Size(183, 27);
            txtSDT.TabIndex = 1;
            // 
            // txtTenKH
            // 
            helpProvider1.SetHelpString(txtTenKH, "web");
            txtTenKH.Location = new Point(142, 77);
            txtTenKH.Name = "txtTenKH";
            helpProvider1.SetShowHelp(txtTenKH, true);
            txtTenKH.Size = new Size(183, 27);
            txtTenKH.TabIndex = 1;
            // 
            // txtMaKH
            // 
            helpProvider1.SetHelpString(txtMaKH, "web");
            txtMaKH.Location = new Point(142, 28);
            txtMaKH.Name = "txtMaKH";
            helpProvider1.SetShowHelp(txtMaKH, true);
            txtMaKH.Size = new Size(183, 27);
            txtMaKH.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(431, 80);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 0;
            label4.Text = "Địa chỉ ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(441, 31);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 0;
            label3.Text = "SĐT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(86, 80);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 0;
            label2.Text = "Tên KH";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 31);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã KH";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(txtSDT);
            groupBox1.Controls.Add(txtTenKH);
            groupBox1.Controls.Add(txtMaKH);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(21, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(788, 112);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin khách hàng";
            // 
            // btnLuu
            // 
            helpProvider1.SetHelpString(btnLuu, "web");
            btnLuu.Location = new Point(506, 136);
            btnLuu.Name = "btnLuu";
            helpProvider1.SetShowHelp(btnLuu, true);
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 7;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // helpProvider1
            // 
            helpProvider1.HelpNamespace = "https://thanhson080105.github.io/HuongDanSuDung_QuanLyTienGui/";
            // 
            // frmKhachHang
            // 
            ClientSize = new Size(831, 481);
            Controls.Add(groupBox2);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnLuu);
            Controls.Add(btnThem);
            Controls.Add(groupBox1);
            helpProvider1.SetHelpNavigator(this, HelpNavigator.Topic);
            Name = "frmKhachHang";
            helpProvider1.SetShowHelp(this, true);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Khách hàng";
            Load += frmKhachHang_Load;
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private DataGridView dgvKhachHang;
        private Button btnLamMoi;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private TextBox txtDiaChi;
        private TextBox txtSDT;
        private TextBox txtTenKH;
        private TextBox txtMaKH;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox1;
        private Button btnLuu;
        private HelpProvider helpProvider1;
    }
}