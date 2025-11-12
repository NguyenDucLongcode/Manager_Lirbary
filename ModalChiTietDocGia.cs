using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class ModalChiTietDocGia : Form
    {
        private DocGia docGia;

        public ModalChiTietDocGia(DocGia docGia)
        {
            InitializeComponent();
            this.docGia = docGia;
            HienThiThongTin();
        }

        private void HienThiThongTin()
        {
            if (docGia != null)
            {
                txtMaDocGia.Text = docGia.MaDocGia.ToUpper();
                txtHoTen.Text = VietHoaChuCaiDau(docGia.HoTen);
                txtGioiTinh.Text = docGia.GioiTinh;
                txtNgaySinh.Text = docGia.NgaySinh.ToString("dd/MM/yyyy");
                txtDiaChi.Text = VietHoaChuCaiDau(docGia.DiaChi);
                txtDienThoai.Text = docGia.SoDienThoai;
                txtCMND.Text = docGia.CMND;
            }
        }

        private string VietHoaChuCaiDau(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return input;

            string result = System.Text.RegularExpressions.Regex.Replace(
                input.ToLower().Trim(),
                @"\s+",
                " "
            );

            return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(result);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
