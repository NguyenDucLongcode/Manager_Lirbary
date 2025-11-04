using qlDsSinhVien;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FrmMuonSach : Form
    {
        List<MuonSach> muonSaches = new List<MuonSach>();
        MuonSach CreateMuonSach = new MuonSach();
        MuonSach SelectMuonSach = new MuonSach();
        int indexSelectMuonSach = -1;

        public FrmMuonSach()
        {
            InitializeComponent();

            // Cấu hình DataGridView
            dgvMuonSach.AutoGenerateColumns = false;
            dgvMuonSach.Columns["MaSach"].DataPropertyName = "MaSach";
            dgvMuonSach.Columns["MaDocGia"].DataPropertyName = "MaDocGia";
            dgvMuonSach.Columns["HoTen"].DataPropertyName = "HoTen";
            dgvMuonSach.Columns["SoLuong"].DataPropertyName = "SoLuong";
            dgvMuonSach.Columns["NgayMuon"].DataPropertyName = "NgayMuon";
            dgvMuonSach.Columns["NgayTra"].DataPropertyName = "NgayTra";

            // THÊM SỰ KIỆN TÌM KIẾM
            txtTimKiem.TextChanged += new EventHandler(txtTimKiem_TextChanged);

            LoadData();
        }

        private void LoadData()
        {
            try
            {
                MuonSach muonSach = new MuonSach();
                muonSaches = muonSach.GetList();

                // CẬP NHẬT LẠI DATASOURCE
                dgvMuonSach.DataSource = null;
                dgvMuonSach.DataSource = muonSaches;

                ClearMuonSachForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // SỰ KIỆN TÌM KIẾM - SỬA LẠI ĐỂ HOẠT ĐỘNG TỐT HƠN
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string filterText = txtTimKiem.Text.Trim();

                if (string.IsNullOrEmpty(filterText))
                {
                    // Hiển thị toàn bộ dữ liệu khi không có từ khóa tìm kiếm
                    dgvMuonSach.DataSource = null;
                    dgvMuonSach.DataSource = muonSaches;
                }
                else
                {
                    // Tìm kiếm không phân biệt hoa thường trên nhiều trường
                    var filtered = muonSaches.Where(m =>
                        m.MaSach.IndexOf(filterText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                        m.MaDocGia.IndexOf(filterText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                        m.HoTen.IndexOf(filterText, StringComparison.OrdinalIgnoreCase) >= 0)
                        .ToList();

                    dgvMuonSach.DataSource = null;
                    dgvMuonSach.DataSource = filtered;

                    // Hiển thị thông báo nếu không tìm thấy
                    if (filtered.Count == 0)
                    {
                        MessageBox.Show($"Không tìm thấy kết quả cho: {filterText}", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tìm kiếm: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // SỰ KIỆN CLICK VÀO Ô TRONG BẢNG - SỬA LỖI GÁN SAI
        private void dgvMuonSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvMuonSach.Rows.Count)
            {
                indexSelectMuonSach = e.RowIndex;

                DataGridViewRow selectedRow = dgvMuonSach.Rows[e.RowIndex];
                SelectMuonSach.MaSach = selectedRow.Cells["MaSach"].Value?.ToString() ?? "";
                SelectMuonSach.MaDocGia = selectedRow.Cells["MaDocGia"].Value?.ToString() ?? ""; // SỬA LỖI: Gán đúng MaDocGia
                SelectMuonSach.HoTen = selectedRow.Cells["HoTen"].Value?.ToString() ?? ""; // SỬA LỖI: Gán đúng HoTen
                SelectMuonSach.SoLuong = selectedRow.Cells["SoLuong"].Value?.ToString() ?? "";
                SelectMuonSach.NgayMuon = selectedRow.Cells["NgayMuon"].Value?.ToString() ?? "";
                SelectMuonSach.NgayTra = selectedRow.Cells["NgayTra"].Value?.ToString() ?? "";

                DisplaySelectedData();
                txtMaSach.ReadOnly = true;
            }
        }

        private void DisplaySelectedData()
        {
            txtMaSach.Text = SelectMuonSach.MaSach;
            txtMaDocGia.Text = SelectMuonSach.MaDocGia; // THÊM: Hiển thị mã độc giả
            txtHoTen.Text = SelectMuonSach.HoTen; // THÊM: Hiển thị họ tên
            txtSoLuong.Text = SelectMuonSach.SoLuong;

            // Xử lý ngày mượn
            if (DateTime.TryParse(SelectMuonSach.NgayMuon, out DateTime ngayMuon))
                dateTimePickerNgayMuon.Value = ngayMuon;
            else
                dateTimePickerNgayMuon.Value = DateTime.Now;

            // Xử lý ngày trả
            if (DateTime.TryParse(SelectMuonSach.NgayTra, out DateTime ngayTra))
                dateTimePickerNgayTra.Value = ngayTra;
            else
                dateTimePickerNgayTra.Value = DateTime.Now.AddDays(7);
        }

        private void ClearMuonSachForm()
        {
            txtMaSach.Text = "";
            txtMaDocGia.Text = ""; // THÊM: Xóa mã độc giả
            txtHoTen.Text = ""; // THÊM: Xóa họ tên
            txtSoLuong.Text = "";
            dateTimePickerNgayMuon.Value = DateTime.Now;
            dateTimePickerNgayTra.Value = DateTime.Now.AddDays(7);
            txtMaSach.ReadOnly = false;
            indexSelectMuonSach = -1;
            SelectMuonSach = new MuonSach();
            txtMaSach.Focus();
        }

        // NÚT THÊM
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInput())
                    return;

                if (new MuonSach().IsMaSachExists(muonSaches, txtMaSach.Text.Trim()))
                {
                    MessageBox.Show("Mã sách đã tồn tại!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaSach.Focus();
                    return;
                }

                CreateMuonSach = new MuonSach
                {
                    MaSach = txtMaSach.Text.Trim(),
                    MaDocGia = txtMaDocGia.Text.Trim(),
                    HoTen = txtHoTen.Text.Trim(),
                    SoLuong = txtSoLuong.Text.Trim(),
                    NgayMuon = dateTimePickerNgayMuon.Value.ToString("dd/MM/yyyy"),
                    NgayTra = dateTimePickerNgayTra.Value.ToString("dd/MM/yyyy")
                };

                muonSaches.Insert(0, CreateMuonSach);

                if (CreateMuonSach.SaveList(muonSaches))
                {
                    // CẬP NHẬT LẠI DATASOURCE SAU KHI THÊM
                    dgvMuonSach.DataSource = null;
                    dgvMuonSach.DataSource = muonSaches;

                    ClearMuonSachForm();
                    MessageBox.Show("Thêm mượn sách thành công!", "Thành công",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lỗi khi lưu dữ liệu!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // NÚT SỬA
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (indexSelectMuonSach == -1)
                {
                    MessageBox.Show("Vui lòng chọn mượn sách cần sửa!", "Cảnh báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!ValidateInput())
                    return;

                DialogResult confirm = MessageBox.Show("Bạn có chắc muốn cập nhật thông tin mượn sách này không?",
                    "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    SelectMuonSach.MaSach = txtMaSach.Text.Trim();
                    SelectMuonSach.MaDocGia = txtMaDocGia.Text.Trim();
                    SelectMuonSach.HoTen = txtHoTen.Text.Trim();
                    SelectMuonSach.SoLuong = txtSoLuong.Text.Trim();
                    SelectMuonSach.NgayMuon = dateTimePickerNgayMuon.Value.ToString("dd/MM/yyyy");
                    SelectMuonSach.NgayTra = dateTimePickerNgayTra.Value.ToString("dd/MM/yyyy");

                    // Cập nhật trong danh sách
                    if (indexSelectMuonSach >= 0 && indexSelectMuonSach < muonSaches.Count)
                    {
                        muonSaches[indexSelectMuonSach] = SelectMuonSach;
                    }

                    if (SelectMuonSach.SaveList(muonSaches))
                    {
                        // CẬP NHẬT LẠI DATASOURCE SAU KHI SỬA
                        dgvMuonSach.DataSource = null;
                        dgvMuonSach.DataSource = muonSaches;

                        ClearMuonSachForm();
                        MessageBox.Show("Cập nhật thành công!", "Thành công",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi khi lưu dữ liệu!", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi sửa: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // NÚT XÓA
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (indexSelectMuonSach == -1)
                {
                    MessageBox.Show("Vui lòng chọn mượn sách cần xóa!", "Cảnh báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult confirm = MessageBox.Show("Bạn có chắc muốn xóa mượn sách này không?",
                    "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    muonSaches.RemoveAt(indexSelectMuonSach);

                    if (new MuonSach().SaveList(muonSaches))
                    {
                        // CẬP NHẬT LẠI DATASOURCE SAU KHI XÓA
                        dgvMuonSach.DataSource = null;
                        dgvMuonSach.DataSource = muonSaches;

                        ClearMuonSachForm();
                        MessageBox.Show("Xóa thành công!", "Thành công",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi khi lưu dữ liệu!", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // NÚT CHI TIẾT
        private void btnDetail_Click(object sender, EventArgs e)
        {
            if (indexSelectMuonSach == -1)
            {
                MessageBox.Show("Vui lòng chọn mượn sách để xem chi tiết!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string chiTiet = $"THÔNG TIN CHI TIẾT MƯỢN SÁCH\n\n" +
                           $"Mã sách: {SelectMuonSach.MaSach}\n" +
                           $"Mã độc giả: {SelectMuonSach.MaDocGia}\n" +
                           $"Họ tên: {SelectMuonSach.HoTen}\n" +
                           $"Số lượng: {SelectMuonSach.SoLuong}\n" +
                           $"Ngày mượn: {SelectMuonSach.NgayMuon}\n" +
                           $"Ngày trả: {SelectMuonSach.NgayTra}";

            MessageBox.Show(chiTiet, "Chi tiết mượn sách",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // NÚT LÀM MỚI/HỦY
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearMuonSachForm();
        }

        // NÚT TẢI LẠI - THÊM PHƯƠNG THỨC NÀY
        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            LoadData();
            txtTimKiem.Text = ""; // Xóa nội dung tìm kiếm
            MessageBox.Show("Đã tải lại dữ liệu!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // KIỂM TRA DỮ LIỆU NHẬP - THÊM VALIDATION CHO MÃ ĐỘC GIẢ VÀ HỌ TÊN
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtMaSach.Text))
            {
                MessageBox.Show("Mã sách không được để trống!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaSach.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtMaDocGia.Text))
            {
                MessageBox.Show("Mã độc giả không được để trống!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaDocGia.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Họ tên không được để trống!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHoTen.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSoLuong.Text))
            {
                MessageBox.Show("Số lượng không được để trống!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoLuong.Focus();
                return false;
            }

            if (!int.TryParse(txtSoLuong.Text, out int soLuong) || soLuong <= 0)
            {
                MessageBox.Show("Số lượng phải là số nguyên dương!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoLuong.Focus();
                txtSoLuong.SelectAll();
                return false;
            }

            if (dateTimePickerNgayMuon.Value > DateTime.Now)
            {
                MessageBox.Show("Ngày mượn không thể ở tương lai!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateTimePickerNgayMuon.Focus();
                return false;
            }

            if (dateTimePickerNgayTra.Value <= dateTimePickerNgayMuon.Value)
            {
                MessageBox.Show("Ngày trả phải sau ngày mượn!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateTimePickerNgayTra.Focus();
                return false;
            }

            return true;
        }

        // CHỈ CHO NHẬP SỐ
        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // NÚT THOÁT
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}