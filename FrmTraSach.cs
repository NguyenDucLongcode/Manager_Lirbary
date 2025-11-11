using qlDsSinhVien;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FrmTraSach : Form
    {
        List<TraSach> traSaches = new List<TraSach>();
        TraSach CreateTraSach = new TraSach();
        TraSach SelectTraSach = new TraSach();
        int indexSelectTraSach = -1;

        public FrmTraSach()
        {
            InitializeComponent();

            if (ShareData.DocGiaList.Count == 0)
            {
                DocGia docGia = new DocGia();
                ShareData.DocGiaList = docGia.GetList();
            }

            if (ShareData.bookList.Count == 0)
            {
                ListBook book = new ListBook();
                ShareData.bookList = book.GetList();
            }

            ConfigComboBox();

            dgvTraSach.AutoGenerateColumns = false;
            dgvTraSach.Columns["MaSach"].DataPropertyName = "MaSach";
            dgvTraSach.Columns["MaDocGia"].DataPropertyName = "MaDocGia";
            dgvTraSach.Columns["SoLuong"].DataPropertyName = "SoLuong";
            dgvTraSach.Columns["NgayTraDuKien"].DataPropertyName = "NgayTraDuKien";
            dgvTraSach.Columns["NgayTraThucTe"].DataPropertyName = "NgayTraThucTe";

            txtTimKiem.TextChanged += new EventHandler(txtTimKiem_TextChanged);

            LoadData();
        }

        private void ConfigComboBox()
        {
            var displayList = ShareData.DocGiaList.Select(dg => new
            {
                MaDocGia = dg.MaDocGia,
                DisplayText = $"{dg.HoTen} - {dg.CMND}",
                OriginalItem = dg
            }).ToList();

            comboBoxMaDocGia.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxMaDocGia.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxMaDocGia.DisplayMember = "DisplayText";
            comboBoxMaDocGia.ValueMember = "MaDocGia";
            comboBoxMaDocGia.DataSource = displayList;
            comboBoxMaDocGia.SelectedIndex = -1;
            comboBoxMaDocGia.Text = "Chọn độc giả...";

            comboBoxMaSach.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxMaSach.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxMaSach.DisplayMember = "TenSach";
            comboBoxMaSach.ValueMember = "MaSach";
            comboBoxMaSach.DataSource = ShareData.bookList;
            comboBoxMaSach.SelectedIndex = -1;
            comboBoxMaSach.Text = "Chọn sách...";
        }

        private void LoadData()
        {
            try
            {
                TraSach traSach = new TraSach();
                traSaches = traSach.GetList();

                dgvTraSach.DataSource = null;
                dgvTraSach.DataSource = traSaches;

                ClearTraSachForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string filterText = txtTimKiem.Text.Trim();

                if (string.IsNullOrEmpty(filterText))
                {
                    dgvTraSach.DataSource = null;
                    dgvTraSach.DataSource = traSaches;
                }
                else
                {
                    var filtered = traSaches.Where(m =>
                        m.MaSach.IndexOf(filterText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                        m.MaDocGia.IndexOf(filterText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                        m.HoTen.IndexOf(filterText, StringComparison.OrdinalIgnoreCase) >= 0)
                        .ToList();

                    dgvTraSach.DataSource = null;
                    dgvTraSach.DataSource = filtered;

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

        private void dgvTraSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvTraSach.Rows.Count)
            {
                indexSelectTraSach = e.RowIndex;

                DataGridViewRow selectedRow = dgvTraSach.Rows[e.RowIndex];
                SelectTraSach.MaSach = selectedRow.Cells["MaSach"].Value?.ToString() ?? "";
                SelectTraSach.MaDocGia = selectedRow.Cells["MaDocGia"].Value?.ToString() ?? "";
                SelectTraSach.SoLuong = selectedRow.Cells["SoLuong"].Value?.ToString() ?? "";
                SelectTraSach.NgayTraDuKien = selectedRow.Cells["NgayTraDuKien"].Value?.ToString() ?? "";
                SelectTraSach.NgayTraThucTe = selectedRow.Cells["NgayTraThucTe"].Value?.ToString() ?? "";

                DisplaySelectedData();
            }
        }

        private void DisplaySelectedData()
        {
            comboBoxMaSach.SelectedValue = SelectTraSach.MaSach;
            comboBoxMaDocGia.SelectedValue = SelectTraSach.MaDocGia;
            txtSoLuong.Text = SelectTraSach.SoLuong;

            if (DateTime.TryParse(SelectTraSach.NgayTraDuKien, out DateTime ngayTraDuKien))
                dateTimePickerNgayTraDuKien.Value = ngayTraDuKien;
            else
                dateTimePickerNgayTraDuKien.Value = DateTime.Now.AddDays(7);

            if (DateTime.TryParse(SelectTraSach.NgayTraThucTe, out DateTime ngayTraThucTe))
                dateTimePickerNgayTraThucTe.Value = ngayTraThucTe;
            else
                dateTimePickerNgayTraThucTe.Value = DateTime.Now;
        }

        private void ClearTraSachForm()
        {
            txtSoLuong.Text = "";
            dateTimePickerNgayTraDuKien.Value = DateTime.Now.AddDays(7);
            dateTimePickerNgayTraThucTe.Value = DateTime.Now;
            comboBoxMaSach.SelectedIndex = -1;
            comboBoxMaDocGia.SelectedIndex = -1;
            indexSelectTraSach = -1;
            SelectTraSach = new TraSach();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInput())
                    return;

                CreateTraSach = new TraSach
                {
                    MaSach = comboBoxMaSach.SelectedValue.ToString(),
                    MaDocGia = comboBoxMaDocGia.SelectedValue.ToString(),
                    SoLuong = txtSoLuong.Text.Trim(),
                    NgayTraDuKien = dateTimePickerNgayTraDuKien.Value.ToString("dd/MM/yyyy"),
                    NgayTraThucTe = dateTimePickerNgayTraThucTe.Value.ToString("dd/MM/yyyy")
                };

                traSaches.Insert(0, CreateTraSach);

                if (CreateTraSach.SaveList(traSaches))
                {
                    dgvTraSach.DataSource = null;
                    dgvTraSach.DataSource = traSaches;

                    ClearTraSachForm();
                    MessageBox.Show("Thêm trả sách thành công!", "Thành công",
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (indexSelectTraSach == -1)
                {
                    MessageBox.Show("Vui lòng chọn trả sách cần sửa!", "Cảnh báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!ValidateInput())
                    return;

                DialogResult confirm = MessageBox.Show("Bạn có chắc muốn cập nhật thông tin trả sách này không?",
                    "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    SelectTraSach.MaSach = comboBoxMaSach.SelectedValue.ToString();
                    SelectTraSach.MaDocGia = comboBoxMaDocGia.SelectedValue.ToString();
                    SelectTraSach.SoLuong = txtSoLuong.Text.Trim();
                    SelectTraSach.NgayTraDuKien = dateTimePickerNgayTraDuKien.Value.ToString("dd/MM/yyyy");
                    SelectTraSach.NgayTraThucTe = dateTimePickerNgayTraThucTe.Value.ToString("dd/MM/yyyy");

                    if (indexSelectTraSach >= 0 && indexSelectTraSach < traSaches.Count)
                    {
                        traSaches[indexSelectTraSach] = SelectTraSach;
                    }

                    if (SelectTraSach.SaveList(traSaches))
                    {
                        dgvTraSach.DataSource = null;
                        dgvTraSach.DataSource = traSaches;

                        ClearTraSachForm();
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (indexSelectTraSach == -1)
                {
                    MessageBox.Show("Vui lòng chọn trả sách cần xóa!", "Cảnh báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult confirm = MessageBox.Show("Bạn có chắc muốn xóa trả sách này không?",
                    "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    traSaches.RemoveAt(indexSelectTraSach);

                    if (new TraSach().SaveList(traSaches))
                    {
                        dgvTraSach.DataSource = null;
                        dgvTraSach.DataSource = traSaches;

                        ClearTraSachForm();
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

        private void btnDetail_Click(object sender, EventArgs e)
        {
            if (indexSelectTraSach == -1)
            {
                MessageBox.Show("Vui lòng chọn trả sách để xem chi tiết!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string Tensach = ShareData.bookList
                .FirstOrDefault(b => b.MaSach == SelectTraSach.MaSach)?.TenSach ?? "N/A";

            string TenDocGia = ShareData.DocGiaList.FirstOrDefault(b => b.MaDocGia == SelectTraSach.MaDocGia)?.HoTen ?? "N/A";

            string chiTiet = $"THÔNG TIN CHI TIẾT TRẢ SÁCH\n\n" +
                           $"Tên sách: {Tensach}\n" +
                           $"Tên độc giả: {TenDocGia}\n" +
                           $"Số lượng: {SelectTraSach.SoLuong}\n" +
                           $"Ngày trả dự kiến: {SelectTraSach.NgayTraDuKien}\n" +
                           $"Ngày trả thực tế: {SelectTraSach.NgayTraThucTe}";

            MessageBox.Show(chiTiet, "Chi tiết trả sách",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ClearTraSachForm();
        }

        private bool ValidateInput()
        {
            if (comboBoxMaDocGia.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn độc giả!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxMaDocGia.Focus();
                return false;
            }

            if (comboBoxMaSach.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn sách!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxMaDocGia.Focus();
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

            if (dateTimePickerNgayTraThucTe.Value < dateTimePickerNgayTraDuKien.Value.AddDays(-30))
            {
                MessageBox.Show("Ngày trả thực tế không hợp lệ!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateTimePickerNgayTraThucTe.Focus();
                return false;
            }

            return true;
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void FrmTraSach_Load(object sender, EventArgs e)
        {
            // Load additional data if needed
        }

        private void dgvTraSach_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvTraSach.Rows)
            {
                if (!row.IsNewRow)
                    row.Cells["SttTraSach"].Value = row.Index + 1;
            }
        }
    }
}