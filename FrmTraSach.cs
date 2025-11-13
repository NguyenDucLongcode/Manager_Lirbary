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
        List<MuonSach> muonSaches = new List<MuonSach>();
        TraSach CreateTraSach = new TraSach();
        TraSach SelectTraSach = new TraSach();
        int indexSelectTraSach = -1;
        private bool isFilteringTraTre = false;
        private bool isFilteringTraSom = false;
        private bool isFilteringDungHan = false;

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

            // Load dữ liệu mượn sách
            LoadMuonSachData();

            ConfigComboBox();

            dgvTraSach.AutoGenerateColumns = false;
            dgvTraSach.Columns["MaSach"].DataPropertyName = "MaSach";
            dgvTraSach.Columns["MaDocGia"].DataPropertyName = "MaDocGia";
            dgvTraSach.Columns["SoLuong"].DataPropertyName = "SoLuong";
            dgvTraSach.Columns["NgayTraDuKien"].DataPropertyName = "NgayTraDuKien";
            dgvTraSach.Columns["NgayTraThucTe"].DataPropertyName = "NgayTraThucTe";
            dgvTraSach.Columns["TinhTrang"].DataPropertyName = "TinhTrang";

            txtTimKiem.TextChanged += new EventHandler(txtTimKiem_TextChanged);

            // Thêm sự kiện cho combobox
            comboBoxMaSach.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);
            comboBoxMaDocGia.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);

            LoadData();
        }

        private void LoadMuonSachData()
        {
            try
            {
                MuonSach muonSach = new MuonSach();
                muonSaches = muonSach.GetList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu mượn sách: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

                // Cập nhật tình trạng cho từng bản ghi
                foreach (var item in traSaches)
                {
                    item.TinhTrang = GetTinhTrangTraSach(item);

                
                    if (string.IsNullOrEmpty(item.NgayMuon))
                    {
                        var muonSach = muonSaches.FirstOrDefault(m =>
                            m.MaSach == item.MaSach && m.MaDocGia == item.MaDocGia);
                        if (muonSach != null)
                        {
                            item.NgayMuon = muonSach.NgayMuon;
                        }
                    }
                }

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

        private string GetTinhTrangTraSach(TraSach traSach)
        {
            if (DateTime.TryParse(traSach.NgayTraThucTe, out DateTime ngayTraThucTe) &&
                DateTime.TryParse(traSach.NgayTraDuKien, out DateTime ngayTraDuKien))
            {
                if (ngayTraThucTe > ngayTraDuKien)
                    return "Trả trễ";
                else if (ngayTraThucTe < ngayTraDuKien)
                    return "Trả sớm";
                else
                    return "Đúng hạn";
            }
            return "Không xác định";
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateNgayTraDuKien();
        }

        private void UpdateNgayTraDuKien()
        {
            if (comboBoxMaSach.SelectedIndex != -1 && comboBoxMaDocGia.SelectedIndex != -1)
            {
                string maSach = comboBoxMaSach.SelectedValue.ToString();
                string maDocGia = comboBoxMaDocGia.SelectedValue.ToString();

                // Tìm thông tin mượn sách tương ứng
                var muonSach = muonSaches.FirstOrDefault(m =>
                    m.MaSach == maSach && m.MaDocGia == maDocGia);

                if (muonSach != null && DateTime.TryParse(muonSach.NgayMuon, out DateTime ngayMuon))
                {
                    dateTimePickerNgayMuon.Value = ngayMuon;

                    // Tính ngày trả dự kiến (mặc định 14 ngày sau ngày mượn)
                    DateTime ngayTraDuKien = ngayMuon.AddDays(14);
                    dateTimePickerNgayTraDuKien.Value = ngayTraDuKien;
                }
                else
                {
                    // Nếu không tìm thấy, set ngày mượn là ngày hiện tại và ngày trả dự kiến +7 ngày
                    dateTimePickerNgayMuon.Value = DateTime.Now;
                    dateTimePickerNgayTraDuKien.Value = DateTime.Now.AddDays(7);
                }
            }
        }

        private void checkBoxTraTre_CheckedChanged(object sender, EventArgs e)
        {
            isFilteringTraTre = checkBoxTraTre.Checked;
            ApplyFilters();
        }
        private void CheckBoxFilter_CheckedChanged(object sender, EventArgs e)
        {
            isFilteringTraTre = checkBoxTraTre.Checked;
            isFilteringTraSom = checkBoxTraSom.Checked;
            isFilteringDungHan = checkBoxDungHan.Checked;
            ApplyFilters();
        }
        private void ApplyFilters()
        {
            try
            {
                var filtered = traSaches.AsEnumerable();

                // Áp dụng filter tìm kiếm
                string filterText = txtTimKiem.Text.Trim();
                if (!string.IsNullOrEmpty(filterText))
                {
                    filtered = filtered.Where(m =>
                        m.MaSach.IndexOf(filterText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                        m.MaDocGia.IndexOf(filterText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                        (m.HoTen != null && m.HoTen.IndexOf(filterText, StringComparison.OrdinalIgnoreCase) >= 0));
                }

                // Áp dụng filter theo tình trạng
                var activeFilters = new List<Func<TraSach, bool>>();

                if (isFilteringTraTre)
                    activeFilters.Add(m => m.TinhTrang == "Trả trễ");

                if (isFilteringTraSom)
                    activeFilters.Add(m => m.TinhTrang == "Trả sớm");

                if (isFilteringDungHan)
                    activeFilters.Add(m => m.TinhTrang == "Đúng hạn");

                // Nếu có filter active, áp dụng filter (OR logic - hiển thị bản ghi thỏa mãn bất kỳ điều kiện nào)
                if (activeFilters.Any())
                {
                    filtered = filtered.Where(m => activeFilters.Any(filter => filter(m)));
                }

                // SẮP XẾP THEO THỨ TỰ: ĐÚNG HẠN -> TRẢ SỚM -> TRẢ TRỄ
                var sortedData = filtered.OrderBy(m =>
                {
                    switch (m.TinhTrang)
                    {
                        case "Đúng hạn":
                            return 1; // Thứ tự 1 - hiển thị đầu tiên
                        case "Trả sớm":
                            return 2; // Thứ tự 2
                        case "Trả trễ":
                            return 3; // Thứ tự 3 - hiển thị cuối cùng
                        default:
                            return 4; // Các trường hợp khác
                    }
                }).ThenBy(m => m.MaSach); // Sắp xếp phụ theo mã sách nếu cùng tình trạng

                dgvTraSach.DataSource = null;
                dgvTraSach.DataSource = sortedData.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi áp dụng bộ lọc: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
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
                SelectTraSach.TinhTrang = selectedRow.Cells["TinhTrang"].Value?.ToString() ?? "";

                DisplaySelectedData();
            }
        }

        private void DisplaySelectedData()
        {
            comboBoxMaSach.SelectedValue = SelectTraSach.MaSach;
            comboBoxMaDocGia.SelectedValue = SelectTraSach.MaDocGia;
            txtSoLuong.Text = SelectTraSach.SoLuong;

           
            if (DateTime.TryParse(SelectTraSach.NgayMuon, out DateTime ngayMuon))
                dateTimePickerNgayMuon.Value = ngayMuon;
            else
            {
                
                var muonSach = muonSaches.FirstOrDefault(m =>
                    m.MaSach == SelectTraSach.MaSach && m.MaDocGia == SelectTraSach.MaDocGia);
                if (muonSach != null && DateTime.TryParse(muonSach.NgayMuon, out DateTime ngayMuonFromMuonSach))
                    dateTimePickerNgayMuon.Value = ngayMuonFromMuonSach;
                else
                    dateTimePickerNgayMuon.Value = DateTime.Now;
            }

            if (DateTime.TryParse(SelectTraSach.NgayTraDuKien, out DateTime ngayTraDuKien))
                dateTimePickerNgayTraDuKien.Value = ngayTraDuKien;
            else
                dateTimePickerNgayTraDuKien.Value = DateTime.Now.AddDays(7);

            if (DateTime.TryParse(SelectTraSach.NgayTraThucTe, out DateTime ngayTraThucTe))
                dateTimePickerNgayTraThucTe.Value = ngayTraThucTe;
            else
                dateTimePickerNgayTraThucTe.Value = DateTime.Now;
        }

        private void UpdateNgayMuonFromSelected()
        {
            if (!string.IsNullOrEmpty(SelectTraSach.MaSach) && !string.IsNullOrEmpty(SelectTraSach.MaDocGia))
            {
                var muonSach = muonSaches.FirstOrDefault(m =>
                    m.MaSach == SelectTraSach.MaSach && m.MaDocGia == SelectTraSach.MaDocGia);

                if (muonSach != null && DateTime.TryParse(muonSach.NgayMuon, out DateTime ngayMuon))
                {
                    dateTimePickerNgayMuon.Value = ngayMuon;
                }
            }
        }

        private void ClearTraSachForm()
        {
            txtSoLuong.Text = "";
            dateTimePickerNgayMuon.Value = DateTime.Now;
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
                    NgayMuon = dateTimePickerNgayMuon.Value.ToString("dd/MM/yyyy"), 
                    NgayTraDuKien = dateTimePickerNgayTraDuKien.Value.ToString("dd/MM/yyyy"),
                    NgayTraThucTe = dateTimePickerNgayTraThucTe.Value.ToString("dd/MM/yyyy"),
                    TinhTrang = GetTinhTrangTraSach(new TraSach
                    {
                        NgayTraThucTe = dateTimePickerNgayTraThucTe.Value.ToString("dd/MM/yyyy"),
                        NgayTraDuKien = dateTimePickerNgayTraDuKien.Value.ToString("dd/MM/yyyy")
                    })
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
                    SelectTraSach.NgayMuon = dateTimePickerNgayMuon.Value.ToString("dd/MM/yyyy"); 
                    SelectTraSach.NgayTraDuKien = dateTimePickerNgayTraDuKien.Value.ToString("dd/MM/yyyy");
                    SelectTraSach.NgayTraThucTe = dateTimePickerNgayTraThucTe.Value.ToString("dd/MM/yyyy");
                    SelectTraSach.TinhTrang = GetTinhTrangTraSach(SelectTraSach);

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
                           $"Ngày trả thực tế: {SelectTraSach.NgayTraThucTe}\n" +
                           $"Tình trạng: {SelectTraSach.TinhTrang}";

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
                {
                    row.Cells["SttTraSach"].Value = row.Index + 1;

                    // Đảm bảo cột TinhTrang tồn tại và có giá trị
                    if (row.Cells["TinhTrang"] != null && row.Cells["TinhTrang"].Value != null)
                    {
                        string tinhTrang = row.Cells["TinhTrang"].Value.ToString();

                        // Tô màu cho các dòng theo tình trạng
                        if (tinhTrang == "Trả trễ")
                        {
                            row.DefaultCellStyle.BackColor = Color.White;
                            row.DefaultCellStyle.ForeColor = Color.Black; // Màu chữ để dễ đọc
                        }
                        else if (tinhTrang == "Trả sớm")
                        {
                            row.DefaultCellStyle.BackColor = Color.White;
                            row.DefaultCellStyle.ForeColor = Color.Black;
                        }
                        else if (tinhTrang == "Đúng hạn")
                        {
                            row.DefaultCellStyle.BackColor = Color.White;
                            row.DefaultCellStyle.ForeColor = Color.Black;
                        }
                        else
                        {
                            // Màu mặc định cho các trường hợp khác
                            row.DefaultCellStyle.BackColor = Color.White;
                            row.DefaultCellStyle.ForeColor = Color.Black;
                        }
                    }
                    else
                    {
                        // Nếu không có cột TinhTrang, tính toán trực tiếp từ ngày trả
                        if (row.Cells["NgayTraThucTe"] != null && row.Cells["NgayTraThucTe"].Value != null &&
                            row.Cells["NgayTraDuKien"] != null && row.Cells["NgayTraDuKien"].Value != null)
                        {
                            if (DateTime.TryParse(row.Cells["NgayTraThucTe"].Value.ToString(), out DateTime ngayTraThucTe) &&
                                DateTime.TryParse(row.Cells["NgayTraDuKien"].Value.ToString(), out DateTime ngayTraDuKien))
                            {
                                if (ngayTraThucTe > ngayTraDuKien)
                                {
                                    row.DefaultCellStyle.BackColor = Color.White;
                                    row.DefaultCellStyle.ForeColor = Color.Black;
                                }
                                else if (ngayTraThucTe < ngayTraDuKien)
                                {
                                    row.DefaultCellStyle.BackColor = Color.White;
                                    row.DefaultCellStyle.ForeColor = Color.Black;
                                }
                                else
                                {
                                    row.DefaultCellStyle.BackColor = Color.White;
                                    row.DefaultCellStyle.ForeColor = Color.Black;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}