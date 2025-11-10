using qlDsSinhVien;
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
    public partial class ModalTacGia : Form
    {
        private Author _author;
        public ModalTacGia(Author author)
        {
            InitializeComponent();
            _author = author;
            LoadAuthorData();
        }

        private void LoadAuthorData()
        {
            // Hiển thị thông tin sách lên controls và set cho nó ko đc thay đổi giá trị
            txtAuthorId.Text = _author.AuthorID;
            txtAuthorId.ReadOnly = true;

            txtAddress.Text = _author.Address;
            txtAddress.ReadOnly = true;

            txtCMND.Text = _author.CMND;
            txtCMND.ReadOnly = true;

            txtGender.Text = _author.Gender;
            txtGender.ReadOnly = true;

            txtName.Text = _author.FullName;
            txtName.ReadOnly = true;

            txtNgaySinh.Text = _author.BirthDate;
            txtNgaySinh.ReadOnly = true;

            txtPenName.Text = _author.PenName;
            txtPenName.ReadOnly = true;

            txtPhone.Text = _author.PhoneNumber;
            txtPhone.ReadOnly = true;

        }

        private void ModalTacGia_Load(object sender, EventArgs e)
        {

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
