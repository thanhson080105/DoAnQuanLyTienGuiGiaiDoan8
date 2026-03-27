namespace DoAnQuanLyTienGui.Form
{
    partial class frmNhanVien
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
            dgvNhanVien = new DataGridView();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            groupBox1 = new GroupBox();
            txtChucVu = new TextBox();
            txtSDT = new TextBox();
            txtTenNV = new TextBox();
            txtMaNV = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnLuu = new Button();
            helpProvider1 = new HelpProvider();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Location = new Point(-1, 26);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.RowHeadersWidth = 51;
            dgvNhanVien.Size = new Size(881, 331);
            dgvNhanVien.TabIndex = 8;
            // 
            // btnLamMoi
            // 
            helpProvider1.SetHelpString(btnLamMoi, "web");
            btnLamMoi.Location = new Point(633, 134);
            btnLamMoi.Name = "btnLamMoi";
            helpProvider1.SetShowHelp(btnLamMoi, true);
            btnLamMoi.Size = new Size(94, 29);
            btnLamMoi.TabIndex = 11;
            btnLamMoi.Text = "Làm mới ";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXoa
            // 
            helpProvider1.SetHelpString(btnXoa, "web");
            btnXoa.Location = new Point(403, 134);
            btnXoa.Name = "btnXoa";
            helpProvider1.SetShowHelp(btnXoa, true);
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            helpProvider1.SetHelpString(btnSua, "web");
            btnSua.Location = new Point(273, 134);
            btnSua.Name = "btnSua";
            helpProvider1.SetShowHelp(btnSua, true);
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 13;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            helpProvider1.SetHelpString(btnThem, "web");
            btnThem.Location = new Point(138, 134);
            btnThem.Name = "btnThem";
            helpProvider1.SetShowHelp(btnThem, true);
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 14;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtChucVu);
            groupBox1.Controls.Add(txtSDT);
            groupBox1.Controls.Add(txtTenNV);
            groupBox1.Controls.Add(txtMaNV);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(18, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(880, 112);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhân viên ";
            // 
            // txtChucVu
            // 
            helpProvider1.SetHelpString(txtChucVu, "web");
            txtChucVu.Location = new Point(585, 72);
            txtChucVu.Name = "txtChucVu";
            helpProvider1.SetShowHelp(txtChucVu, true);
            txtChucVu.Size = new Size(183, 27);
            txtChucVu.TabIndex = 1;
            // 
            // txtSDT
            // 
            helpProvider1.SetHelpString(txtSDT, "web");
            txtSDT.Location = new Point(585, 23);
            txtSDT.Name = "txtSDT";
            helpProvider1.SetShowHelp(txtSDT, true);
            txtSDT.Size = new Size(183, 27);
            txtSDT.TabIndex = 1;
            // 
            // txtTenNV
            // 
            helpProvider1.SetHelpString(txtTenNV, "web");
            txtTenNV.Location = new Point(176, 72);
            txtTenNV.Name = "txtTenNV";
            helpProvider1.SetShowHelp(txtTenNV, true);
            txtTenNV.Size = new Size(183, 27);
            txtTenNV.TabIndex = 1;
            // 
            // txtMaNV
            // 
            helpProvider1.SetHelpString(txtMaNV, "web");
            txtMaNV.Location = new Point(176, 23);
            txtMaNV.Name = "txtMaNV";
            helpProvider1.SetShowHelp(txtMaNV, true);
            txtMaNV.Size = new Size(183, 27);
            txtMaNV.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(520, 79);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 0;
            label4.Text = "Chức vụ ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(530, 30);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 0;
            label3.Text = "SĐT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(105, 79);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 0;
            label2.Text = "Tên NV";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 30);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã NV";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvNhanVien);
            groupBox2.Location = new Point(18, 183);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(880, 363);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách nhân viên";
            // 
            // btnLuu
            // 
            helpProvider1.SetHelpString(btnLuu, "web");
            btnLuu.Location = new Point(519, 134);
            btnLuu.Name = "btnLuu";
            helpProvider1.SetShowHelp(btnLuu, true);
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 16;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // helpProvider1
            // 
            helpProvider1.HelpNamespace = "https://thanhson080105.github.io/HuongDanSuDung_QuanLyTienGui/";
            // 
            // frmNhanVien
            // 
            ClientSize = new Size(906, 545);
            Controls.Add(btnLuu);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            helpProvider1.SetHelpNavigator(this, HelpNavigator.Topic);
            Name = "frmNhanVien";
            helpProvider1.SetShowHelp(this, true);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nhân viên ";
            Load += frmNhanVien_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvNhanVien;
        private Button btnLamMoi;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private GroupBox groupBox1;
        private TextBox txtChucVu;
        private TextBox txtSDT;
        private TextBox txtTenNV;
        private TextBox txtMaNV;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Button btnLuu;
        private HelpProvider helpProvider1;
    }
}