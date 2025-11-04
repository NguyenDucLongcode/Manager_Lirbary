using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class frLogin : Form
    {
        private LoginManager loginManager;
        public frLogin()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true; // Ẩn mật khẩu ban đầu
            loginManager = new LoginManager();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtTaiKhoan.Text.Trim();
            string password = txtPassword.Text;
            if (loginManager.Login(username, password))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private void btnShowPass_Click(object sender, EventArgs e)
        {
            // Toggle trạng thái hiện/ẩn mật khẩu
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;

            // Thay đổi text nút
            btnShowPass.Text = txtPassword.UseSystemPasswordChar ? "Hiện" : "Ẩn";
        }



    }
}
