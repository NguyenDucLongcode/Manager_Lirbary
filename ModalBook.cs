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
    public partial class ModalBook : Form
    {
        private ListBook _book;

        public ModalBook(ListBook book)
        {
            InitializeComponent();
            _book = book;
            LoadBookData();
        }

        private void LoadBookData()
        {
            // Hiển thị thông tin sách lên controls và set cho nó ko đc thay đổi giá trị
            txtGiaTien.Text = _book.GiaTien;
            txtGiaTien.ReadOnly = true;

            txtTacGia.Text = _book.MaTacGia;
            txtTacGia.ReadOnly = true;

            txtGiaTien.Text = _book.GiaTien;
            txtGiaTien.ReadOnly = true;

            txtTheLoai.Text = _book.TheLoai;
            txtTheLoai.ReadOnly = true;

            txtTenSach.Text = _book.TenSach;
            txtTenSach.ReadOnly = true;

            txtTacGia.Text = _book.MaTacGia;
            txtTacGia.ReadOnly = true;

            txtNgayXB.Text = _book.NgayXB;
            txtNgayXB.ReadOnly = true;

            txtMaSach.Text = _book.MaSach;
            txtMaSach.ReadOnly = true;

        }

        private void ModalBook_Load(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
