namespace DoAnQuanLyTienGui.Form
{
    partial class frmDangNhap
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
            label3 = new Label();
            txtTenDangNhap = new TextBox();
            txtMatKhau = new TextBox();
            ckbGhiNho = new CheckBox();
            btnDangNhap = new Button();
            btnHuyBo = new Button();
            helpProvider1 = new HelpProvider();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(205, 24);
            label1.Name = "label1";
            label1.Size = new Size(169, 38);
            label1.TabIndex = 0;
            label1.Text = "Đăng nhập ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 113);
            label2.Name = "label2";
            label2.Size = new Size(130, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên đăng nhập (*):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 171);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 1;
            label3.Text = "Mật khẩu (*):";
            // 
            // txtTenDangNhap
            // 
            helpProvider1.SetHelpNavigator(txtTenDangNhap, HelpNavigator.Topic);
            helpProvider1.SetHelpString(txtTenDangNhap, "");
            txtTenDangNhap.Location = new Point(170, 110);
            txtTenDangNhap.Name = "txtTenDangNhap";
            helpProvider1.SetShowHelp(txtTenDangNhap, true);
            txtTenDangNhap.Size = new Size(267, 27);
            txtTenDangNhap.TabIndex = 2;
            // 
            // txtMatKhau
            // 
            helpProvider1.SetHelpNavigator(txtMatKhau, HelpNavigator.Topic);
            helpProvider1.SetHelpString(txtMatKhau, "");
            txtMatKhau.Location = new Point(170, 168);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            helpProvider1.SetShowHelp(txtMatKhau, true);
            txtMatKhau.Size = new Size(267, 27);
            txtMatKhau.TabIndex = 2;
            txtMatKhau.KeyDown += txtMatKhau_KeyDown;
            // 
            // ckbGhiNho
            // 
            ckbGhiNho.AutoSize = true;
            ckbGhiNho.Location = new Point(170, 221);
            ckbGhiNho.Name = "ckbGhiNho";
            ckbGhiNho.Size = new Size(147, 24);
            ckbGhiNho.TabIndex = 3;
            ckbGhiNho.Text = "Ghi nhớ mật khẩu";
            ckbGhiNho.UseVisualStyleBackColor = true;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.White;
            helpProvider1.SetHelpNavigator(btnDangNhap, HelpNavigator.Topic);
            helpProvider1.SetHelpString(btnDangNhap, "");
            btnDangNhap.Location = new Point(108, 275);
            btnDangNhap.Name = "btnDangNhap";
            helpProvider1.SetShowHelp(btnDangNhap, true);
            btnDangNhap.Size = new Size(138, 43);
            btnDangNhap.TabIndex = 4;
            btnDangNhap.Text = "Đăng nhập ";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // btnHuyBo
            // 
            helpProvider1.SetHelpNavigator(btnHuyBo, HelpNavigator.Topic);
            helpProvider1.SetHelpString(btnHuyBo, "");
            btnHuyBo.Location = new Point(310, 275);
            btnHuyBo.Name = "btnHuyBo";
            helpProvider1.SetShowHelp(btnHuyBo, true);
            btnHuyBo.Size = new Size(127, 43);
            btnHuyBo.TabIndex = 4;
            btnHuyBo.Text = "Hủy bỏ ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // helpProvider1
            // 
            helpProvider1.HelpNamespace = "https://thanhson080105.github.io/HuongDanSuDung_QuanLyTienGui/";
            // 
            // frmDangNhap
            // 
            AcceptButton = btnDangNhap;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(565, 401);
            Controls.Add(btnHuyBo);
            Controls.Add(btnDangNhap);
            Controls.Add(ckbGhiNho);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTenDangNhap);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            helpProvider1.SetHelpNavigator(this, HelpNavigator.Topic);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmDangNhap";
            helpProvider1.SetShowHelp(this, true);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label label1;
        private Label label2;
        private Label label3;
        private CheckBox ckbGhiNho;
        private Button btnDangNhap;
        private Button btnHuyBo;
        public TextBox txtTenDangNhap;
        public TextBox txtMatKhau;
        private HelpProvider helpProvider1;
    }
}