namespace WinFormsApp1
{
    partial class frLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frLogin));
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            btnShowPass = new Button();
            btnLogin = new Button();
            btnHuy = new Button();
            label2 = new Label();
            txtPassword = new TextBox();
            label1 = new Label();
            txtTaiKhoan = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1902, 1033);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(btnShowPass);
            groupBox1.Controls.Add(btnLogin);
            groupBox1.Controls.Add(btnHuy);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtTaiKhoan);
            groupBox1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(768, 323);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(429, 354);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Form đăng nhập";
            // 
            // btnShowPass
            // 
            btnShowPass.Font = new Font("Segoe UI", 9F);
            btnShowPass.Location = new Point(367, 172);
            btnShowPass.Name = "btnShowPass";
            btnShowPass.Size = new Size(56, 34);
            btnShowPass.TabIndex = 6;
            btnShowPass.Text = "Hiện";
            btnShowPass.UseVisualStyleBackColor = true;
            btnShowPass.Click += btnShowPass_Click;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 12F);
            btnLogin.Location = new Point(231, 271);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(130, 36);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnHuy
            // 
            btnHuy.Font = new Font("Segoe UI", 12F);
            btnHuy.Location = new Point(28, 271);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 36);
            btnHuy.TabIndex = 4;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(28, 180);
            label2.Name = "label2";
            label2.Size = new Size(94, 28);
            label2.TabIndex = 3;
            label2.Text = "Mật khẩu";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtPassword.Location = new Point(128, 172);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(233, 34);
            txtPassword.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(28, 116);
            label1.Name = "label1";
            label1.Size = new Size(94, 28);
            label1.TabIndex = 1;
            label1.Text = "Tài khoản";
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtTaiKhoan.Location = new Point(128, 116);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(233, 34);
            txtTaiKhoan.TabIndex = 0;
            // 
            // frLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            ControlBox = false;
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Name = "frLogin";
            Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Button btnLogin;
        private Button btnHuy;
        private Label label2;
        private TextBox txtPassword;
        private Label label1;
        private TextBox txtTaiKhoan;
        private Button btnShowPass;
    }
}