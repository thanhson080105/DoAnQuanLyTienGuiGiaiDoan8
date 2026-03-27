namespace DoAnQuanLyTienGui.Form
{
    partial class frmSoTietKiem
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
            groupBox2 = new GroupBox();
            dgvSoTietKiem = new DataGridView();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtLaiSuat = new TextBox();
            txtSoTien = new TextBox();
            txtMaSo = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnLuu = new Button();
            groupBox1 = new GroupBox();
            txtTienLai = new TextBox();
            cboKhachHang = new ComboBox();
            dtpNgayMo = new DateTimePicker();
            txtKyHan = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label5 = new Label();
            btnNhapExcel = new Button();
            btnXuatExcel = new Button();
            btnThoat = new Button();
            helpProvider1 = new HelpProvider();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSoTietKiem).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvSoTietKiem);
            groupBox2.Location = new Point(22, 227);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(876, 294);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách khách hàng mở sổ tiết kiệm ";
            // 
            // dgvSoTietKiem
            // 
            dgvSoTietKiem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSoTietKiem.Location = new Point(-1, 26);
            dgvSoTietKiem.Name = "dgvSoTietKiem";
            dgvSoTietKiem.RowHeadersWidth = 51;
            dgvSoTietKiem.Size = new Size(877, 314);
            dgvSoTietKiem.TabIndex = 2;
            // 
            // btnLamMoi
            // 
            helpProvider1.SetHelpString(btnLamMoi, "web");
            btnLamMoi.Location = new Point(477, 192);
            btnLamMoi.Name = "btnLamMoi";
            helpProvider1.SetShowHelp(btnLamMoi, true);
            btnLamMoi.Size = new Size(90, 29);
            btnLamMoi.TabIndex = 10;
            btnLamMoi.Text = "Làm mới ";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXoa
            // 
            helpProvider1.SetHelpString(btnXoa, "web");
            btnXoa.Location = new Point(249, 192);
            btnXoa.Name = "btnXoa";
            helpProvider1.SetShowHelp(btnXoa, true);
            btnXoa.Size = new Size(90, 29);
            btnXoa.TabIndex = 11;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            helpProvider1.SetHelpString(btnSua, "web");
            btnSua.Location = new Point(135, 192);
            btnSua.Name = "btnSua";
            helpProvider1.SetShowHelp(btnSua, true);
            btnSua.Size = new Size(90, 29);
            btnSua.TabIndex = 12;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            helpProvider1.SetHelpString(btnThem, "web");
            btnThem.Location = new Point(22, 192);
            btnThem.Name = "btnThem";
            helpProvider1.SetShowHelp(btnThem, true);
            btnThem.Size = new Size(90, 29);
            btnThem.TabIndex = 13;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtLaiSuat
            // 
            helpProvider1.SetHelpString(txtLaiSuat, "web");
            txtLaiSuat.Location = new Point(559, 58);
            txtLaiSuat.Name = "txtLaiSuat";
            helpProvider1.SetShowHelp(txtLaiSuat, true);
            txtLaiSuat.Size = new Size(197, 27);
            txtLaiSuat.TabIndex = 1;
            // 
            // txtSoTien
            // 
            helpProvider1.SetHelpString(txtSoTien, "web");
            txtSoTien.Location = new Point(173, 55);
            txtSoTien.Name = "txtSoTien";
            helpProvider1.SetShowHelp(txtSoTien, true);
            txtSoTien.Size = new Size(183, 27);
            txtSoTien.TabIndex = 1;
            txtSoTien.TextChanged += txtSoTien_TextChanged;
            // 
            // txtMaSo
            // 
            helpProvider1.SetHelpString(txtMaSo, "web");
            txtMaSo.Location = new Point(173, 24);
            txtMaSo.Name = "txtMaSo";
            helpProvider1.SetShowHelp(txtMaSo, true);
            txtMaSo.Size = new Size(183, 27);
            txtMaSo.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(476, 65);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 0;
            label4.Text = "Lãi suất ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(476, 29);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 0;
            label3.Text = "Ngày mở";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(102, 58);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 0;
            label2.Text = "Số tiền ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(102, 26);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã sổ";
            // 
            // btnLuu
            // 
            helpProvider1.SetHelpString(btnLuu, "web");
            btnLuu.Location = new Point(364, 192);
            btnLuu.Name = "btnLuu";
            helpProvider1.SetShowHelp(btnLuu, true);
            btnLuu.Size = new Size(90, 29);
            btnLuu.TabIndex = 14;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTienLai);
            groupBox1.Controls.Add(cboKhachHang);
            groupBox1.Controls.Add(dtpNgayMo);
            groupBox1.Controls.Add(txtLaiSuat);
            groupBox1.Controls.Add(txtKyHan);
            groupBox1.Controls.Add(txtSoTien);
            groupBox1.Controls.Add(txtMaSo);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(21, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(877, 161);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sổ tiết kiệm ";
            // 
            // txtTienLai
            // 
            helpProvider1.SetHelpString(txtTienLai, "web");
            txtTienLai.Location = new Point(173, 124);
            txtTienLai.Name = "txtTienLai";
            txtTienLai.ReadOnly = true;
            helpProvider1.SetShowHelp(txtTienLai, true);
            txtTienLai.Size = new Size(183, 27);
            txtTienLai.TabIndex = 4;
            // 
            // cboKhachHang
            // 
            cboKhachHang.FormattingEnabled = true;
            helpProvider1.SetHelpString(cboKhachHang, "web");
            cboKhachHang.Location = new Point(559, 94);
            cboKhachHang.Name = "cboKhachHang";
            helpProvider1.SetShowHelp(cboKhachHang, true);
            cboKhachHang.Size = new Size(197, 28);
            cboKhachHang.TabIndex = 3;
            // 
            // dtpNgayMo
            // 
            dtpNgayMo.Format = DateTimePickerFormat.Short;
            helpProvider1.SetHelpString(dtpNgayMo, "web");
            dtpNgayMo.Location = new Point(559, 25);
            dtpNgayMo.Name = "dtpNgayMo";
            helpProvider1.SetShowHelp(dtpNgayMo, true);
            dtpNgayMo.Size = new Size(197, 27);
            dtpNgayMo.TabIndex = 2;
            dtpNgayMo.Value = new DateTime(2026, 2, 5, 0, 0, 0, 0);
            // 
            // txtKyHan
            // 
            helpProvider1.SetHelpString(txtKyHan, "web");
            txtKyHan.Location = new Point(173, 87);
            txtKyHan.Name = "txtKyHan";
            helpProvider1.SetShowHelp(txtKyHan, true);
            txtKyHan.Size = new Size(183, 27);
            txtKyHan.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(476, 97);
            label6.Name = "label6";
            label6.Size = new Size(56, 20);
            label6.TabIndex = 0;
            label6.Text = "Tên KH";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(102, 127);
            label7.Name = "label7";
            label7.Size = new Size(57, 20);
            label7.TabIndex = 0;
            label7.Text = "Tiền lãi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(102, 94);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 0;
            label5.Text = "Kỳ hạn";
            // 
            // btnNhapExcel
            // 
            helpProvider1.SetHelpString(btnNhapExcel, "web");
            btnNhapExcel.Location = new Point(705, 192);
            btnNhapExcel.Name = "btnNhapExcel";
            helpProvider1.SetShowHelp(btnNhapExcel, true);
            btnNhapExcel.Size = new Size(90, 29);
            btnNhapExcel.TabIndex = 16;
            btnNhapExcel.Text = "Nhập ";
            btnNhapExcel.UseVisualStyleBackColor = true;
            btnNhapExcel.Click += btnNhap_Click;
            // 
            // btnXuatExcel
            // 
            helpProvider1.SetHelpString(btnXuatExcel, "web");
            btnXuatExcel.Location = new Point(801, 192);
            btnXuatExcel.Name = "btnXuatExcel";
            helpProvider1.SetShowHelp(btnXuatExcel, true);
            btnXuatExcel.Size = new Size(97, 29);
            btnXuatExcel.TabIndex = 16;
            btnXuatExcel.Text = "Xuất Excel";
            btnXuatExcel.UseVisualStyleBackColor = true;
            btnXuatExcel.Click += btnXuatExcel_Click;
            // 
            // btnThoat
            // 
            helpProvider1.SetHelpString(btnThoat, "web");
            btnThoat.Location = new Point(592, 192);
            btnThoat.Name = "btnThoat";
            helpProvider1.SetShowHelp(btnThoat, true);
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 17;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // helpProvider1
            // 
            helpProvider1.HelpNamespace = "https://thanhson080105.github.io/HuongDanSuDung_QuanLyTienGui/";
            // 
            // frmSoTietKiem
            // 
            ClientSize = new Size(910, 533);
            Controls.Add(btnThoat);
            Controls.Add(btnXuatExcel);
            Controls.Add(btnNhapExcel);
            Controls.Add(groupBox2);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(btnLuu);
            Controls.Add(groupBox1);
            helpProvider1.SetHelpNavigator(this, HelpNavigator.Topic);
            Name = "frmSoTietKiem";
            helpProvider1.SetShowHelp(this, true);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sổ tiết kiệm ";
            Load += frmSoTietKiem_Load;
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSoTietKiem).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox2;
        private DataGridView dgvSoTietKiem;
        private Button btnLamMoi;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private TextBox txtLaiSuat;
        private TextBox txtSoTien;
        private TextBox txtMaSo;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnLuu;
        private GroupBox groupBox1;
        private DateTimePicker dtpNgayMo;
        private Label label5;
        private TextBox txtKyHan;
        private ComboBox cboKhachHang;
        private Label label6;
        private Button btnNhapExcel;
        private Button btnXuatExcel;
        private Button btnThoat;
        private TextBox txtTienLai;
        private Label label7;
        private HelpProvider helpProvider1;
    }
}