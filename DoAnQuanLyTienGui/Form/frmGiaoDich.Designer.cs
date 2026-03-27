namespace DoAnQuanLyTienGui.Form
{
    partial class frmGiaoDich
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cboNhanVien = new ComboBox();
            dtpNgayGD = new DateTimePicker();
            txtMaSo = new TextBox();
            label4 = new Label();
            btnLuu = new Button();
            groupBox1 = new GroupBox();
            txtTienLai = new TextBox();
            label9 = new Label();
            txtLaiSuat = new TextBox();
            txtKyHan = new TextBox();
            label8 = new Label();
            label7 = new Label();
            cboLoaiGD = new ComboBox();
            txtSoTien = new TextBox();
            txtMaGD = new TextBox();
            label6 = new Label();
            label3 = new Label();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dgvGiaoDich = new DataGridView();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            btnXuatExcel = new Button();
            btnNhapExcel = new Button();
            btnInGD = new Button();
            btnThoat = new Button();
            helpProvider1 = new HelpProvider();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGiaoDich).BeginInit();
            SuspendLayout();
            // 
            // cboNhanVien
            // 
            cboNhanVien.FormattingEnabled = true;
            helpProvider1.SetHelpString(cboNhanVien, "web hỗ trợ ");
            cboNhanVien.Location = new Point(635, 99);
            cboNhanVien.Name = "cboNhanVien";
            helpProvider1.SetShowHelp(cboNhanVien, true);
            cboNhanVien.Size = new Size(197, 28);
            cboNhanVien.TabIndex = 3;
            // 
            // dtpNgayGD
            // 
            dtpNgayGD.Format = DateTimePickerFormat.Short;
            helpProvider1.SetHelpString(dtpNgayGD, "web hỗ trợ ");
            dtpNgayGD.Location = new Point(635, 30);
            dtpNgayGD.Name = "dtpNgayGD";
            helpProvider1.SetShowHelp(dtpNgayGD, true);
            dtpNgayGD.Size = new Size(197, 27);
            dtpNgayGD.TabIndex = 2;
            dtpNgayGD.Value = new DateTime(2026, 2, 5, 0, 0, 0, 0);
            // 
            // txtMaSo
            // 
            helpProvider1.SetHelpString(txtMaSo, "");
            txtMaSo.Location = new Point(249, 96);
            txtMaSo.Name = "txtMaSo";
            helpProvider1.SetShowHelp(txtMaSo, true);
            txtMaSo.Size = new Size(183, 27);
            txtMaSo.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(552, 70);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 0;
            label4.Text = "Loại GD";
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.White;
            btnLuu.ForeColor = Color.Blue;
            helpProvider1.SetHelpKeyword(btnLuu, "web hỗ trợ ");
            btnLuu.Location = new Point(347, 227);
            btnLuu.Name = "btnLuu";
            helpProvider1.SetShowHelp(btnLuu, true);
            btnLuu.Size = new Size(95, 29);
            btnLuu.TabIndex = 21;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTienLai);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtLaiSuat);
            groupBox1.Controls.Add(txtKyHan);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(cboLoaiGD);
            groupBox1.Controls.Add(cboNhanVien);
            groupBox1.Controls.Add(dtpNgayGD);
            groupBox1.Controls.Add(txtMaSo);
            groupBox1.Controls.Add(txtSoTien);
            groupBox1.Controls.Add(txtMaGD);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = Color.FromArgb(44, 62, 80);
            groupBox1.Location = new Point(16, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(982, 199);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sổ tiết kiệm ";
            // 
            // txtTienLai
            // 
            helpProvider1.SetHelpString(txtTienLai, "web hỗ trợ ");
            txtTienLai.Location = new Point(635, 165);
            txtTienLai.Name = "txtTienLai";
            txtTienLai.ReadOnly = true;
            helpProvider1.SetShowHelp(txtTienLai, true);
            txtTienLai.Size = new Size(197, 27);
            txtTienLai.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(554, 168);
            label9.Name = "label9";
            label9.Size = new Size(57, 20);
            label9.TabIndex = 10;
            label9.Text = "Tiền lãi";
            // 
            // txtLaiSuat
            // 
            helpProvider1.SetHelpString(txtLaiSuat, "web hỗ trợ ");
            txtLaiSuat.Location = new Point(635, 133);
            txtLaiSuat.Name = "txtLaiSuat";
            helpProvider1.SetShowHelp(txtLaiSuat, true);
            txtLaiSuat.Size = new Size(197, 27);
            txtLaiSuat.TabIndex = 9;
            // 
            // txtKyHan
            // 
            helpProvider1.SetHelpString(txtKyHan, "web hỗ trợ ");
            txtKyHan.Location = new Point(249, 133);
            txtKyHan.Name = "txtKyHan";
            helpProvider1.SetShowHelp(txtKyHan, true);
            txtKyHan.Size = new Size(183, 27);
            txtKyHan.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(552, 136);
            label8.Name = "label8";
            label8.Size = new Size(59, 20);
            label8.TabIndex = 6;
            label8.Text = "Lãi suất";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(178, 136);
            label7.Name = "label7";
            label7.Size = new Size(52, 20);
            label7.TabIndex = 7;
            label7.Text = "Kỳ hạn";
            // 
            // cboLoaiGD
            // 
            cboLoaiGD.FormattingEnabled = true;
            helpProvider1.SetHelpString(cboLoaiGD, "web hỗ trợ ");
            cboLoaiGD.Items.AddRange(new object[] { "Gửi tiền ", "Rút tiền " });
            cboLoaiGD.Location = new Point(635, 65);
            cboLoaiGD.Name = "cboLoaiGD";
            helpProvider1.SetShowHelp(cboLoaiGD, true);
            cboLoaiGD.Size = new Size(197, 28);
            cboLoaiGD.TabIndex = 3;
            // 
            // txtSoTien
            // 
            helpProvider1.SetHelpString(txtSoTien, "");
            txtSoTien.Location = new Point(249, 60);
            txtSoTien.Name = "txtSoTien";
            helpProvider1.SetShowHelp(txtSoTien, true);
            txtSoTien.Size = new Size(183, 27);
            txtSoTien.TabIndex = 1;
            txtSoTien.TextChanged += txtSoTien_TextChanged;
            // 
            // txtMaGD
            // 
            helpProvider1.SetHelpString(txtMaGD, "");
            txtMaGD.Location = new Point(249, 29);
            txtMaGD.Name = "txtMaGD";
            helpProvider1.SetShowHelp(txtMaGD, true);
            txtMaGD.Size = new Size(183, 27);
            txtMaGD.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(552, 102);
            label6.Name = "label6";
            label6.Size = new Size(56, 20);
            label6.TabIndex = 0;
            label6.Text = "Tên NV";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(552, 34);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 0;
            label3.Text = "Ngày GD";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(178, 99);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 0;
            label5.Text = "Mã sổ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(178, 63);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 0;
            label2.Text = "Số tiền ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(178, 31);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã GD";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvGiaoDich);
            groupBox2.ForeColor = Color.FromArgb(44, 62, 80);
            groupBox2.Location = new Point(10, 262);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(988, 300);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách khách hàng mở sổ tiết kiệm ";
            // 
            // dgvGiaoDich
            // 
            dgvGiaoDich.BackgroundColor = Color.White;
            dgvGiaoDich.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dgvGiaoDich.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGiaoDich.Location = new Point(6, 26);
            dgvGiaoDich.Name = "dgvGiaoDich";
            dgvGiaoDich.RowHeadersWidth = 51;
            dgvGiaoDich.Size = new Size(975, 279);
            dgvGiaoDich.TabIndex = 2;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.White;
            helpProvider1.SetHelpKeyword(btnLamMoi, "web hỗ trợ ");
            btnLamMoi.Location = new Point(459, 227);
            btnLamMoi.Name = "btnLamMoi";
            helpProvider1.SetShowHelp(btnLamMoi, true);
            btnLamMoi.Size = new Size(95, 29);
            btnLamMoi.TabIndex = 17;
            btnLamMoi.Text = "Làm mới ";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.White;
            btnXoa.ForeColor = Color.Red;
            helpProvider1.SetHelpKeyword(btnXoa, "web hỗ trợ ");
            btnXoa.Location = new Point(235, 227);
            btnXoa.Name = "btnXoa";
            helpProvider1.SetShowHelp(btnXoa, true);
            btnXoa.Size = new Size(95, 29);
            btnXoa.TabIndex = 18;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.White;
            helpProvider1.SetHelpKeyword(btnSua, "web hỗ trợ ");
            btnSua.Location = new Point(123, 227);
            btnSua.Name = "btnSua";
            helpProvider1.SetShowHelp(btnSua, true);
            btnSua.Size = new Size(95, 29);
            btnSua.TabIndex = 19;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.White;
            helpProvider1.SetHelpKeyword(btnThem, "web hỗ trợ ");
            btnThem.Location = new Point(10, 227);
            btnThem.Name = "btnThem";
            helpProvider1.SetShowHelp(btnThem, true);
            btnThem.Size = new Size(95, 29);
            btnThem.TabIndex = 20;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnXuatExcel
            // 
            btnXuatExcel.BackColor = Color.White;
            btnXuatExcel.ForeColor = Color.FromArgb(0, 192, 0);
            helpProvider1.SetHelpKeyword(btnXuatExcel, "web hỗ trợ  ");
            btnXuatExcel.Location = new Point(903, 227);
            btnXuatExcel.Name = "btnXuatExcel";
            helpProvider1.SetShowHelp(btnXuatExcel, true);
            btnXuatExcel.Size = new Size(95, 29);
            btnXuatExcel.TabIndex = 23;
            btnXuatExcel.Text = "Xuất Excel";
            btnXuatExcel.UseVisualStyleBackColor = false;
            btnXuatExcel.Click += btnXuatExcel_Click;
            // 
            // btnNhapExcel
            // 
            btnNhapExcel.BackColor = Color.White;
            helpProvider1.SetHelpKeyword(btnNhapExcel, "web hỗ trợ ");
            btnNhapExcel.Location = new Point(790, 227);
            btnNhapExcel.Name = "btnNhapExcel";
            helpProvider1.SetShowHelp(btnNhapExcel, true);
            btnNhapExcel.Size = new Size(95, 29);
            btnNhapExcel.TabIndex = 24;
            btnNhapExcel.Text = "Nhập ";
            btnNhapExcel.UseVisualStyleBackColor = false;
            btnNhapExcel.Click += btnNhapExcel_Click;
            // 
            // btnInGD
            // 
            btnInGD.BackColor = Color.White;
            btnInGD.ForeColor = Color.Black;
            helpProvider1.SetHelpKeyword(btnInGD, "web hỗ trợ ");
            btnInGD.Location = new Point(680, 227);
            btnInGD.Name = "btnInGD";
            helpProvider1.SetShowHelp(btnInGD, true);
            btnInGD.Size = new Size(94, 29);
            btnInGD.TabIndex = 25;
            btnInGD.Text = "In GD";
            btnInGD.UseVisualStyleBackColor = false;
            btnInGD.Click += btnInGD_Click;
            // 
            // btnThoat
            // 
            helpProvider1.SetHelpKeyword(btnThoat, "web hỗ trợ ");
            btnThoat.Location = new Point(568, 227);
            btnThoat.Name = "btnThoat";
            helpProvider1.SetShowHelp(btnThoat, true);
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 26;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // helpProvider1
            // 
            helpProvider1.HelpNamespace = "https://thanhson080105.github.io/HuongDanSuDung_QuanLyTienGui/";
            // 
            // frmGiaoDich
            // 
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1010, 565);
            Controls.Add(btnThoat);
            Controls.Add(btnInGD);
            Controls.Add(btnXuatExcel);
            Controls.Add(btnNhapExcel);
            Controls.Add(btnLuu);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            helpProvider1.SetHelpNavigator(this, HelpNavigator.Topic);
            Name = "frmGiaoDich";
            helpProvider1.SetShowHelp(this, true);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giao dịch ";
            Load += frmGiaoDich_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGiaoDich).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cboNhanVien;
        private DateTimePicker dtpNgayGD;
        private TextBox txtMaSo;
        private Label label4;
        private Button btnLuu;
        private GroupBox groupBox1;
        private TextBox txtSoTien;
        private TextBox txtMaGD;
        private Label label6;
        private Label label3;
        private Label label5;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private DataGridView dgvGiaoDich;
        private Button btnLamMoi;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private ComboBox cboLoaiGD;
        private Button btnXuatExcel;
        private Button btnNhapExcel;
        private Button btnInGD;
        private TextBox txtLaiSuat;
        private TextBox txtKyHan;
        private Label label8;
        private Label label7;
        private TextBox txtTienLai;
        private Label label9;
        private Button btnThoat;
        private HelpProvider helpProvider1;
    }
}