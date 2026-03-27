namespace DoAnQuanLyTienGui.Form
{
    partial class frmRutTien
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
            label1 = new Label();
            label2 = new Label();
            btnRutTien = new Button();
            txtMaSo = new TextBox();
            groupBox1 = new GroupBox();
            cboNhanVien = new ComboBox();
            label8 = new Label();
            dtpNgayGD = new DateTimePicker();
            label6 = new Label();
            txtSoTienRut = new TextBox();
            txtSoDu = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtKyHan = new TextBox();
            label7 = new Label();
            txtLaiSuat = new TextBox();
            label5 = new Label();
            btnTimKiem = new Button();
            btnThoat = new Button();
            btnLamMoi = new Button();
            helpProvider1 = new HelpProvider();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(190, 9);
            label1.Name = "label1";
            label1.Size = new Size(274, 38);
            label1.TabIndex = 0;
            label1.Text = "Rút tiền sổ tiết kiệm ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 72);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 1;
            label2.Text = "Mã sổ :";
            // 
            // btnRutTien
            // 
            helpProvider1.SetHelpString(btnRutTien, "web");
            btnRutTien.Location = new Point(137, 319);
            btnRutTien.Name = "btnRutTien";
            helpProvider1.SetShowHelp(btnRutTien, true);
            btnRutTien.Size = new Size(94, 29);
            btnRutTien.TabIndex = 2;
            btnRutTien.Text = "Rút tiền";
            btnRutTien.UseVisualStyleBackColor = true;
            btnRutTien.Click += btnRutTien_Click;
            // 
            // txtMaSo
            // 
            helpProvider1.SetHelpString(txtMaSo, "web");
            txtMaSo.Location = new Point(121, 69);
            txtMaSo.Name = "txtMaSo";
            helpProvider1.SetShowHelp(txtMaSo, true);
            txtMaSo.Size = new Size(239, 27);
            txtMaSo.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboNhanVien);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(dtpNgayGD);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtSoTienRut);
            groupBox1.Controls.Add(txtSoDu);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtKyHan);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtLaiSuat);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(25, 116);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(684, 181);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin rút tiền ";
            // 
            // cboNhanVien
            // 
            cboNhanVien.FormattingEnabled = true;
            helpProvider1.SetHelpString(cboNhanVien, "web");
            cboNhanVien.Location = new Point(465, 86);
            cboNhanVien.Name = "cboNhanVien";
            helpProvider1.SetShowHelp(cboNhanVien, true);
            cboNhanVien.Size = new Size(197, 28);
            cboNhanVien.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(372, 90);
            label8.Name = "label8";
            label8.Size = new Size(56, 20);
            label8.TabIndex = 14;
            label8.Text = "Tên NV";
            // 
            // dtpNgayGD
            // 
            dtpNgayGD.Format = DateTimePickerFormat.Short;
            helpProvider1.SetHelpString(dtpNgayGD, "web");
            dtpNgayGD.Location = new Point(96, 132);
            dtpNgayGD.Name = "dtpNgayGD";
            helpProvider1.SetShowHelp(dtpNgayGD, true);
            dtpNgayGD.Size = new Size(183, 27);
            dtpNgayGD.TabIndex = 13;
            dtpNgayGD.Value = new DateTime(2026, 2, 5, 0, 0, 0, 0);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 137);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 12;
            label6.Text = "Ngày rút ";
            // 
            // txtSoTienRut
            // 
            helpProvider1.SetHelpString(txtSoTienRut, "web");
            txtSoTienRut.Location = new Point(465, 130);
            txtSoTienRut.Name = "txtSoTienRut";
            helpProvider1.SetShowHelp(txtSoTienRut, true);
            txtSoTienRut.Size = new Size(197, 27);
            txtSoTienRut.TabIndex = 11;
            // 
            // txtSoDu
            // 
            helpProvider1.SetHelpString(txtSoDu, "web");
            txtSoDu.Location = new Point(465, 41);
            txtSoDu.Name = "txtSoDu";
            helpProvider1.SetShowHelp(txtSoDu, true);
            txtSoDu.Size = new Size(197, 27);
            txtSoDu.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(362, 134);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 10;
            label3.Text = "Số tiền rút";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(372, 45);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 10;
            label4.Text = "Số dư ";
            // 
            // txtKyHan
            // 
            helpProvider1.SetHelpString(txtKyHan, "web");
            txtKyHan.Location = new Point(96, 83);
            txtKyHan.Name = "txtKyHan";
            helpProvider1.SetShowHelp(txtKyHan, true);
            txtKyHan.Size = new Size(183, 27);
            txtKyHan.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 86);
            label7.Name = "label7";
            label7.Size = new Size(52, 20);
            label7.TabIndex = 8;
            label7.Text = "Kỳ hạn";
            // 
            // txtLaiSuat
            // 
            helpProvider1.SetHelpString(txtLaiSuat, "web");
            txtLaiSuat.Location = new Point(96, 38);
            txtLaiSuat.Name = "txtLaiSuat";
            helpProvider1.SetShowHelp(txtLaiSuat, true);
            txtLaiSuat.Size = new Size(183, 27);
            txtLaiSuat.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 41);
            label5.Name = "label5";
            label5.Size = new Size(59, 20);
            label5.TabIndex = 6;
            label5.Text = "Lãi suất";
            // 
            // btnTimKiem
            // 
            helpProvider1.SetHelpString(btnTimKiem, "web");
            btnTimKiem.Location = new Point(397, 69);
            btnTimKiem.Name = "btnTimKiem";
            helpProvider1.SetShowHelp(btnTimKiem, true);
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 2;
            btnTimKiem.Text = "Tìm Kiếm ";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnThoat
            // 
            helpProvider1.SetHelpKeyword(btnThoat, "");
            helpProvider1.SetHelpString(btnThoat, "web");
            btnThoat.Location = new Point(469, 319);
            btnThoat.Name = "btnThoat";
            helpProvider1.SetShowHelp(btnThoat, true);
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 2;
            btnThoat.Text = "Thoát ";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnLamMoi
            // 
            helpProvider1.SetHelpString(btnLamMoi, "web");
            btnLamMoi.Location = new Point(307, 319);
            btnLamMoi.Name = "btnLamMoi";
            helpProvider1.SetShowHelp(btnLamMoi, true);
            btnLamMoi.Size = new Size(94, 29);
            btnLamMoi.TabIndex = 2;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // helpProvider1
            // 
            helpProvider1.HelpNamespace = "https://thanhson080105.github.io/HuongDanSuDung_QuanLyTienGui/";
            // 
            // frmRutTien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 384);
            Controls.Add(groupBox1);
            Controls.Add(txtMaSo);
            Controls.Add(btnTimKiem);
            Controls.Add(btnLamMoi);
            Controls.Add(btnThoat);
            Controls.Add(btnRutTien);
            Controls.Add(label2);
            Controls.Add(label1);
            HelpButton = true;
            helpProvider1.SetHelpNavigator(this, HelpNavigator.Topic);
            Name = "frmRutTien";
            helpProvider1.SetShowHelp(this, true);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rút tiền ";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnRutTien;
        private TextBox txtMaSo;
        private GroupBox groupBox1;
        private TextBox txtKyHan;
        private Label label7;
        private TextBox txtLaiSuat;
        private Label label5;
        private TextBox txtSoDu;
        private Label label3;
        private Label label4;
        private TextBox txtSoTienRut;
        private DateTimePicker dtpNgayGD;
        private Label label6;
        private ComboBox cboNhanVien;
        private Label label8;
        private Button btnTimKiem;
        private Button btnThoat;
        private Button btnLamMoi;
        private HelpProvider helpProvider1;
    }
}