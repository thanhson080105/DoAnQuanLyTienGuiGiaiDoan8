namespace DoAnQuanLyTienGui.Form
{
    partial class frmGuiTien
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
            groupBox1 = new GroupBox();
            txtKyHan = new TextBox();
            label7 = new Label();
            cboNhanVien = new ComboBox();
            dtpNgayGD = new DateTimePicker();
            txtLaiSuat = new TextBox();
            txtSoDu = new TextBox();
            txtSoTienGui = new TextBox();
            txtMaSo = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnLamMoi = new Button();
            btnThoat = new Button();
            btnThem = new Button();
            label8 = new Label();
            helpProvider1 = new HelpProvider();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtKyHan);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(cboNhanVien);
            groupBox1.Controls.Add(dtpNgayGD);
            groupBox1.Controls.Add(txtLaiSuat);
            groupBox1.Controls.Add(txtSoDu);
            groupBox1.Controls.Add(txtSoTienGui);
            groupBox1.Controls.Add(txtMaSo);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(29, 64);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(688, 221);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin gửi tiền ";
            // 
            // txtKyHan
            // 
            helpProvider1.SetHelpString(txtKyHan, "web");
            txtKyHan.Location = new Point(108, 169);
            txtKyHan.Name = "txtKyHan";
            helpProvider1.SetShowHelp(txtKyHan, true);
            txtKyHan.Size = new Size(183, 27);
            txtKyHan.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(37, 172);
            label7.Name = "label7";
            label7.Size = new Size(52, 20);
            label7.TabIndex = 4;
            label7.Text = "Kỳ hạn";
            // 
            // cboNhanVien
            // 
            cboNhanVien.FormattingEnabled = true;
            helpProvider1.SetHelpString(cboNhanVien, "web");
            cboNhanVien.Location = new Point(466, 125);
            cboNhanVien.Name = "cboNhanVien";
            helpProvider1.SetShowHelp(cboNhanVien, true);
            cboNhanVien.Size = new Size(197, 28);
            cboNhanVien.TabIndex = 3;
            // 
            // dtpNgayGD
            // 
            dtpNgayGD.Format = DateTimePickerFormat.Short;
            helpProvider1.SetHelpString(dtpNgayGD, "web");
            dtpNgayGD.Location = new Point(466, 34);
            dtpNgayGD.Name = "dtpNgayGD";
            helpProvider1.SetShowHelp(dtpNgayGD, true);
            dtpNgayGD.Size = new Size(197, 27);
            dtpNgayGD.TabIndex = 2;
            dtpNgayGD.Value = new DateTime(2026, 2, 5, 0, 0, 0, 0);
            // 
            // txtLaiSuat
            // 
            helpProvider1.SetHelpString(txtLaiSuat, "web");
            txtLaiSuat.Location = new Point(108, 126);
            txtLaiSuat.Name = "txtLaiSuat";
            helpProvider1.SetShowHelp(txtLaiSuat, true);
            txtLaiSuat.Size = new Size(183, 27);
            txtLaiSuat.TabIndex = 1;
            // 
            // txtSoDu
            // 
            helpProvider1.SetHelpString(txtSoDu, "web");
            txtSoDu.Location = new Point(466, 79);
            txtSoDu.Name = "txtSoDu";
            helpProvider1.SetShowHelp(txtSoDu, true);
            txtSoDu.Size = new Size(197, 27);
            txtSoDu.TabIndex = 1;
            txtSoDu.TextChanged += txtMaSo_Leave;
            // 
            // txtSoTienGui
            // 
            helpProvider1.SetHelpString(txtSoTienGui, "web");
            txtSoTienGui.Location = new Point(108, 82);
            txtSoTienGui.Name = "txtSoTienGui";
            helpProvider1.SetShowHelp(txtSoTienGui, true);
            txtSoTienGui.Size = new Size(183, 27);
            txtSoTienGui.TabIndex = 1;
            txtSoTienGui.TextChanged += txtSoTienGui_TextChanged;
            // 
            // txtMaSo
            // 
            helpProvider1.SetHelpString(txtMaSo, "web");
            txtMaSo.Location = new Point(108, 36);
            txtMaSo.Name = "txtMaSo";
            helpProvider1.SetShowHelp(txtMaSo, true);
            txtMaSo.Size = new Size(183, 27);
            txtMaSo.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(383, 129);
            label6.Name = "label6";
            label6.Size = new Size(56, 20);
            label6.TabIndex = 0;
            label6.Text = "Tên NV";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(383, 86);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 0;
            label4.Text = "Số dư ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(369, 39);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 0;
            label3.Text = "Ngày gửi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 129);
            label5.Name = "label5";
            label5.Size = new Size(59, 20);
            label5.TabIndex = 0;
            label5.Text = "Lãi suất";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 89);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 0;
            label2.Text = "Số tiền gửi";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 43);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã sổ ";
            // 
            // btnLamMoi
            // 
            helpProvider1.SetHelpString(btnLamMoi, "web");
            btnLamMoi.Location = new Point(318, 315);
            btnLamMoi.Name = "btnLamMoi";
            helpProvider1.SetShowHelp(btnLamMoi, true);
            btnLamMoi.Size = new Size(94, 29);
            btnLamMoi.TabIndex = 23;
            btnLamMoi.Text = "Làm mới ";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnThoat
            // 
            helpProvider1.SetHelpKeyword(btnThoat, "web");
            btnThoat.Location = new Point(498, 315);
            btnThoat.Name = "btnThoat";
            helpProvider1.SetShowHelp(btnThoat, true);
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 24;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnThem
            // 
            helpProvider1.SetHelpString(btnThem, "web");
            btnThem.Location = new Point(138, 315);
            btnThem.Name = "btnThem";
            helpProvider1.SetShowHelp(btnThem, true);
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 26;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(218, 9);
            label8.Name = "label8";
            label8.Size = new Size(274, 38);
            label8.TabIndex = 27;
            label8.Text = "Gửi tiền sổ tiết kiệm ";
            label8.Click += label8_Click;
            // 
            // helpProvider1
            // 
            helpProvider1.HelpNamespace = "https://thanhson080105.github.io/HuongDanSuDung_QuanLyTienGui/";
            // 
            // frmGuiTien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 384);
            Controls.Add(label8);
            Controls.Add(groupBox1);
            Controls.Add(btnLamMoi);
            Controls.Add(btnThoat);
            Controls.Add(btnThem);
            helpProvider1.SetHelpNavigator(this, HelpNavigator.Topic);
            Name = "frmGuiTien";
            helpProvider1.SetShowHelp(this, true);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gửi tiền";
            Load += frmGuiTien_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private ComboBox cboNhanVien;
        private DateTimePicker dtpNgayGD;
        private TextBox txtLaiSuat;
        private TextBox txtSoTienGui;
        private TextBox txtMaSo;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label2;
        private Label label1;
        private Button btnLamMoi;
        private Button btnThoat;
        private Button btnThem;
        private TextBox txtSoDu;
        private TextBox txtKyHan;
        private Label label7;
        private Label label8;
        private HelpProvider helpProvider1;
    }
}