using qlDsSinhVien;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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
            dgvMuonSach.Columns["SoLuong"].DataPropertyName = "SoLuong";
            dgvMuonSach.Columns["NgayMuon"].DataPropertyName = "NgayMuon";
            dgvMuonSach.Columns["NgayTra"].DataPropertyName = "NgayTra";

            LoadData();
        }

        private void LoadData()
        {
            try
            {
                MuonSach muonSach = new MuonSach();
                muonSaches = muonSach.GetList();
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

        // SỬA: Thay đổi từ CellContentClick sang CellClick - chỉ cần click 1 lần
        private void dgvMuonSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvMuonSach.Rows.Count)
            {
                indexSelectMuonSach = e.RowIndex;

                DataGridViewRow selectedRow = dgvMuonSach.Rows[e.RowIndex];
                SelectMuonSach.MaSach = selectedRow.Cells["MaSach"].Value?.ToString() ?? "";
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
            txtSoLuong.Text = SelectMuonSach.SoLuong;

            if (DateTime.TryParse(SelectMuonSach.NgayMuon, out DateTime ngayMuon))
                dateTimePickerNgayMuon.Value = ngayMuon;
            else
                dateTimePickerNgayMuon.Value = DateTime.Now;

            if (DateTime.TryParse(SelectMuonSach.NgayTra, out DateTime ngayTra))
                dateTimePickerNgayTra.Value = ngayTra;
            else
                dateTimePickerNgayTra.Value = DateTime.Now.AddDays(7);
        }

        private void ClearMuonSachForm()
        {
            txtMaSach.Text = "";
            txtSoLuong.Text = "";
            dateTimePickerNgayMuon.Value = DateTime.Now;
            dateTimePickerNgayTra.Value = DateTime.Now.AddDays(7);
            txtMaSach.ReadOnly = false;
            indexSelectMuonSach = -1;
            SelectMuonSach = new MuonSach();
            txtMaSach.Focus();
        }

        // THÊM MỚI
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
                    SoLuong = txtSoLuong.Text.Trim(),
                    NgayMuon = dateTimePickerNgayMuon.Value.ToString("dd/MM/yyyy"),
                    NgayTra = dateTimePickerNgayTra.Value.ToString("dd/MM/yyyy")
                };

                muonSaches.Insert(0, CreateMuonSach);

                if (CreateMuonSach.SaveList(muonSaches))
                {
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

        // SỬA
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
                    // Cập nhật đối tượng được chọn
                    SelectMuonSach.MaSach = txtMaSach.Text.Trim();
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

        // XÓA
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

        // CHI TIẾT - XÓA phương thức btnChiTiet_Click (vì đã có btnDetail_Click)
        // CHỈ GIỮ LẠI MỘT PHƯƠNG THỨC
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
                           $"Số lượng: {SelectMuonSach.SoLuong}\n" +
                           $"Ngày mượn: {SelectMuonSach.NgayMuon}\n" +
                           $"Ngày trả: {SelectMuonSach.NgayTra}";

            MessageBox.Show(chiTiet, "Chi tiết mượn sách",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // LÀM MỚI/HỦY
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearMuonSachForm();
        }

        // TẢI LẠI DỮ LIỆU
        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            LoadData();
            txtTimKiem.Text = "";
            MessageBox.Show("Đã tải lại dữ liệu!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // TÌM KIẾM
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string filterText = txtTimKiem.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(filterText))
            {
                dgvMuonSach.DataSource = muonSaches;
            }
            else
            {
                var filtered = new MuonSach().SearchByMaSach(muonSaches, filterText);
                dgvMuonSach.DataSource = filtered;
            }
        }

        // KIỂM TRA DỮ LIỆU NHẬP
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtMaSach.Text))
            {
                MessageBox.Show("Mã sách không được để trống!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaSach.Focus();
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

        // THOÁT
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}