using qlDsSinhVien;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FrmDocGia : Form
    {
        private int selectedIndex = -1;
        private string gioiTinhHienTai = "";

        public FrmDocGia()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "DocGia.csv");
                if (File.Exists(filePath))
                {
                    var lines = File.ReadAllLines(filePath).Skip(1); // bỏ dòng tiêu đề
                    ShareData.DocGiaList.Clear();

                    foreach (var line in lines)
                    {
                        if (string.IsNullOrWhiteSpace(line)) continue;

                        var parts = line.Split(',');
                        if (parts.Length >= 8)
                        {
                            DateTime ngaySinh, ngayLamThe;
                            DateTime.TryParse(parts[3], out ngaySinh);
                            DateTime.TryParse(parts[6], out ngayLamThe);

                            ShareData.DocGiaList.Add(new DocGia
                            {
                                MaDocGia = parts[0],
                                HoTen = parts[1],
                                GioiTinh = parts[2],
                                NgaySinh = ngaySinh,
                                DiaChi = parts[4],
                                SoDienThoai = parts[5],
                                NgayLamThe = ngayLamThe,
                                CMND = parts[7]
                            });
                        }
                    }
                }

                dgvDocGia.DataSource = null;
                dgvDocGia.DataSource = ShareData.DocGiaList.Select(d => new
                {
                    d.MaDocGia,
                    d.HoTen,
                    d.GioiTinh,
                    NgaySinh = d.NgaySinh.ToString("dd/MM/yyyy"),
                    d.DiaChi,
                    SoDienThoai = d.SoDienThoai,
                    NgayLamThe = d.NgayLamThe.ToString("dd/MM/yyyy"),
                    d.CMND
                }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc dữ liệu: " + ex.Message);
            }
        }


        private void SaveData()
        {
            try
            {
                var lines = ShareData.DocGiaList.Select(d =>
                    $"{d.MaDocGia},{d.HoTen},{d.GioiTinh},{d.NgaySinh},{d.DiaChi},{d.SoDienThoai},{d.NgayLamThe},{d.CMND}");
                File.WriteAllLines(GlobalSettingcs.DocGiaFileName, lines);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu dữ liệu: " + ex.Message);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInput()) return;

                if (ShareData.DocGiaList.Any(d => d.MaDocGia == txtMaDocGia.Text.Trim()))
                {
                    MessageBox.Show("Mã độc giả đã tồn tại!");
                    return;
                }

                var docGia = new DocGia
                {
                    MaDocGia = txtMaDocGia.Text.Trim(),
                    HoTen = txtHoTen.Text.Trim(),
                    GioiTinh = gioiTinhHienTai,
                    NgaySinh = dateTimePickerNgaySinh.Value,
                    DiaChi = txtDiaChi.Text.Trim(),
                    SoDienThoai = txtSoDienThoai.Text.Trim(),
                    NgayLamThe = dateTimePickerNgayLamThe.Value,
                    CMND = txtCMND.Text.Trim()
                };

                ShareData.DocGiaList.Add(docGia);
                SaveData();
                LoadData();
                ClearForm();

                MessageBox.Show("Thêm độc giả thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (selectedIndex < 0 || selectedIndex >= ShareData.DocGiaList.Count)
            {
                MessageBox.Show("Vui lòng chọn độc giả cần sửa!");
                return;
            }

            if (!ValidateInput()) return;

            var docGia = ShareData.DocGiaList[selectedIndex];
            docGia.HoTen = txtHoTen.Text.Trim();
            docGia.GioiTinh = gioiTinhHienTai;
            docGia.NgaySinh = dateTimePickerNgaySinh.Value;
            docGia.DiaChi = txtDiaChi.Text.Trim();
            docGia.SoDienThoai = txtSoDienThoai.Text.Trim();
            docGia.NgayLamThe = dateTimePickerNgayLamThe.Value;
            docGia.CMND = txtCMND.Text.Trim();

            SaveData();
            LoadData();
            ClearForm();

            MessageBox.Show("Cập nhật thành công!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (selectedIndex < 0 || selectedIndex >= ShareData.DocGiaList.Count)
            {
                MessageBox.Show("Vui lòng chọn độc giả cần xóa!");
                return;
            }

            var confirm = MessageBox.Show("Bạn có chắc muốn xóa độc giả này không?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                ShareData.DocGiaList.RemoveAt(selectedIndex);
                SaveData();
                LoadData();
                ClearForm();
                MessageBox.Show("Xóa thành công!");
            }
        }

        private void dgvDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= ShareData.DocGiaList.Count)
                return;

            selectedIndex = e.RowIndex;
            var docGia = ShareData.DocGiaList[selectedIndex];

            txtMaDocGia.Text = docGia.MaDocGia;
            txtHoTen.Text = docGia.HoTen;
            txtDiaChi.Text = docGia.DiaChi;
            txtSoDienThoai.Text = docGia.SoDienThoai;
            txtCMND.Text = docGia.CMND;
            dateTimePickerNgaySinh.Value = docGia.NgaySinh;
            dateTimePickerNgayLamThe.Value = docGia.NgayLamThe;

            gioiTinhHienTai = docGia.GioiTinh;
            chkNam.Checked = gioiTinhHienTai == "Nam";
            chkNu.Checked = gioiTinhHienTai == "Nữ";
        }

        private void chkNam_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNam.Checked)
            {
                gioiTinhHienTai = "Nam";
                chkNu.Checked = false;
            }
        }

        private void chkNu_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNu.Checked)
            {
                gioiTinhHienTai = "Nữ";
                chkNam.Checked = false;
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.ToLower().Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                dgvDocGia.DataSource = ShareData.DocGiaList.Select(d => new
                {
                    d.MaDocGia,
                    d.HoTen,
                    d.GioiTinh,
                    NgaySinh = d.NgaySinh.ToString("dd/MM/yyyy"),
                    d.DiaChi,
                    SoDienThoai = d.SoDienThoai,
                    NgayLamThe = d.NgayLamThe.ToString("dd/MM/yyyy"),
                    d.CMND
                }).ToList();
                return;
            }

            // 🔹 Ưu tiên kết quả bắt đầu bằng từ khóa
            var ketQua1 = ShareData.DocGiaList.Where(d =>
                d.MaDocGia.ToLower().StartsWith(keyword)
                || d.HoTen.ToLower().StartsWith(keyword)
                || d.DiaChi.ToLower().StartsWith(keyword)
                || d.SoDienThoai.ToLower().StartsWith(keyword)
                || d.CMND.ToLower().StartsWith(keyword)
            ).ToList();

            // 🔹 Kết quả có chứa từ khóa ở giữa
            var ketQua2 = ShareData.DocGiaList.Where(d =>
                (d.MaDocGia.ToLower().Contains(keyword)
                || d.HoTen.ToLower().Contains(keyword)
                || d.DiaChi.ToLower().Contains(keyword)
                || d.SoDienThoai.ToLower().Contains(keyword)
                || d.CMND.ToLower().Contains(keyword))
                && !ketQua1.Contains(d)
            ).ToList();

            // 🔹 Gộp kết quả (ưu tiên nhóm 1)
            var ketQua = ketQua1.Concat(ketQua2).Select(d => new
            {
                d.MaDocGia,
                d.HoTen,
                d.GioiTinh,
                NgaySinh = d.NgaySinh.ToString("dd/MM/yyyy"),
                d.DiaChi,
                SoDienThoai = d.SoDienThoai,
                NgayLamThe = d.NgayLamThe.ToString("dd/MM/yyyy"),
                d.CMND
            }).ToList();

            dgvDocGia.DataSource = ketQua;
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            if (selectedIndex < 0 || selectedIndex >= ShareData.DocGiaList.Count)
            {
                MessageBox.Show("Vui lòng chọn độc giả cần xem chi tiết!");
                return;
            }

            var docGia = ShareData.DocGiaList[selectedIndex];

            string thongTin = $"📚 Thông tin chi tiết độc giả:\n\n" +
                              $"Mã độc giả: {docGia.MaDocGia}\n" +
                              $"Họ tên: {docGia.HoTen}\n" +
                              $"Giới tính: {docGia.GioiTinh}\n" +
                              $"Ngày sinh: {docGia.NgaySinh:dd/MM/yyyy}\n" +
                              $"Địa chỉ: {docGia.DiaChi}\n" +
                              $"Số điện thoại: {docGia.SoDienThoai}\n" +
                              $"Ngày làm thẻ: {docGia.NgayLamThe:dd/MM/yyyy}\n" +
                              $"CMND: {docGia.CMND}";

            MessageBox.Show(thongTin, "Chi tiết độc giả", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtMaDocGia.Clear();
            txtHoTen.Clear();
            txtDiaChi.Clear();
            txtSoDienThoai.Clear();
            txtCMND.Clear();
            chkNam.Checked = false;
            chkNu.Checked = false;
            gioiTinhHienTai = "";
            dateTimePickerNgaySinh.Value = DateTime.Now.AddYears(-18);
            dateTimePickerNgayLamThe.Value = DateTime.Now;
            selectedIndex = -1;
            txtMaDocGia.Focus();
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Họ tên không được để trống");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSoDienThoai.Text))
            {
                MessageBox.Show("Số điện thoại không được để trống");
                return false;
            }

            // 🔹 Kiểm tra SĐT: phải đủ 10 số, không có ký tự khác
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtSoDienThoai.Text, @"^\d{10}$"))
            {
                MessageBox.Show("Số điện thoại phải gồm đúng 10 chữ số và không có ký tự đặc biệt!");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCMND.Text))
            {
                MessageBox.Show("CMND không được để trống");
                return false;
            }

            // 🔹 Kiểm tra CMND: phải đủ 12 số, không có ký tự khác
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtCMND.Text, @"^\d{12}$"))
            {
                MessageBox.Show("CMND phải gồm đúng 12 chữ số và không có ký tự đặc biệt!");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                MessageBox.Show("Địa chỉ không được để trống");
                return false;
            }

            if (!chkNam.Checked && !chkNu.Checked)
            {
                MessageBox.Show("Vui lòng chọn giới tính");
                return false;
            }

            return true;
        }

    }
}
