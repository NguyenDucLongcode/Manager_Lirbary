using qlDsSinhVien;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
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
            SetupDataGridView();
            LoadData();
        }

        private void SetupDataGridView()
        {
            dgvDocGia.Columns.Clear();

            // Thêm cột STT
            dgvDocGia.Columns.Add("Stt", "STT");
            dgvDocGia.Columns.Add("MaDocGia", "Mã Độc Giả");
            dgvDocGia.Columns.Add("HoTen", "Họ Tên");
            dgvDocGia.Columns.Add("GioiTinh", "Giới Tính");
            dgvDocGia.Columns.Add("NgaySinh", "Ngày Sinh");
            dgvDocGia.Columns.Add("DiaChi", "Địa Chỉ");
            dgvDocGia.Columns.Add("SoDienThoai", "Số Điện Thoại");
            dgvDocGia.Columns.Add("NgayLamThe", "Ngày Làm Thẻ");
            dgvDocGia.Columns.Add("CMND", "CMND");

            dgvDocGia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDocGia.MultiSelect = false;

            // Cấu hình auto-size giống FrmListBook
            dgvDocGia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDocGia.Columns["Stt"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDocGia.Columns["MaDocGia"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDocGia.Columns["GioiTinh"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDocGia.Columns["SoDienThoai"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDocGia.Columns["CMND"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dgvDocGia.Columns["Stt"].MinimumWidth = 50;
            dgvDocGia.Columns["MaDocGia"].MinimumWidth = 100;
            dgvDocGia.Columns["HoTen"].MinimumWidth = 200;

            dgvDocGia.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvDocGia.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dgvDocGia.Columns["Stt"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void LoadData()
        {
            try
            {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "DocGia.csv");
                if (File.Exists(filePath))
                {
                    var lines = File.ReadAllLines(filePath, Encoding.UTF8).Skip(1);
                    ShareData.DocGiaList.Clear();

                    foreach (var line in lines)
                    {
                        if (string.IsNullOrWhiteSpace(line)) continue;

                        var parts = line.Split(',');
                        if (parts.Length >= 8)
                        {
                            DateTime ngaySinh = ParseDateVietNam(parts[3]);
                            DateTime ngayLamThe = ParseDateVietNam(parts[6]);

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

                RefreshDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc dữ liệu: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshDataGrid()
        {
            dgvDocGia.Rows.Clear();

            for (int i = 0; i < ShareData.DocGiaList.Count; i++)
            {
                var docGia = ShareData.DocGiaList[i];
                dgvDocGia.Rows.Add(
                    i + 1,
                    docGia.MaDocGia.ToUpper(),
                    VietHoaChuCaiDau(docGia.HoTen),
                    docGia.GioiTinh,
                    docGia.NgaySinh.ToString("dd/MM/yyyy"),
                    VietHoaChuCaiDau(docGia.DiaChi),
                    docGia.SoDienThoai,
                    docGia.NgayLamThe.ToString("dd/MM/yyyy"),
                    docGia.CMND
                );
            }
            dgvDocGia.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
        }

        private DateTime ParseDateVietNam(string dateString)
        {
            try
            {
                if (DateTime.TryParseExact(dateString,
                    new[] { "dd/M/yyyy", "d/M/yyyy", "dd/MM/yyyy", "d/MM/yyyy" },
                    System.Globalization.CultureInfo.InvariantCulture,
                    System.Globalization.DateTimeStyles.None,
                    out DateTime result))
                {
                    return result;
                }

                if (DateTime.TryParse(dateString, out result))
                    return result;

                return DateTime.Now.AddYears(-18);
            }
            catch
            {
                return DateTime.Now.AddYears(-18);
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

        private void SaveData()
        {
            try
            {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "DocGia.csv");

                Directory.CreateDirectory(Path.GetDirectoryName(filePath));

                var lines = new List<string> { "MaDocGia,HoTen,GioiTinh,NgaySinh,DiaChi,SoDienThoai,NgayLamThe,CMND" };
                lines.AddRange(ShareData.DocGiaList.Select(d =>
                    $"{d.MaDocGia},{d.HoTen},{d.GioiTinh},{d.NgaySinh:dd/MM/yyyy},{d.DiaChi},{d.SoDienThoai},{d.NgayLamThe:dd/MM/yyyy},{d.CMND}"));

                File.WriteAllLines(filePath, lines, new UTF8Encoding(false));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu dữ liệu: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInput()) return;

                string maDocGia = txtMaDocGia.Text.Trim().ToUpper();
                string soDienThoai = txtSoDienThoai.Text.Trim();
                string cmnd = txtCMND.Text.Trim();

                if (ShareData.DocGiaList.Any(d => d.MaDocGia.ToLower() == maDocGia.ToLower()))
                {
                    MessageBox.Show("Mã độc giả đã tồn tại!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaDocGia.Focus();
                    return;
                }

                if (ShareData.DocGiaList.Any(d => d.SoDienThoai == soDienThoai))
                {
                    MessageBox.Show("Số điện thoại đã tồn tại!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSoDienThoai.Focus();
                    return;
                }

                if (ShareData.DocGiaList.Any(d => d.CMND == cmnd))
                {
                    MessageBox.Show("CMND đã tồn tại!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCMND.Focus();
                    return;
                }

                var docGia = new DocGia
                {
                    MaDocGia = maDocGia,
                    HoTen = VietHoaChuCaiDau(txtHoTen.Text.Trim()),
                    GioiTinh = gioiTinhHienTai,
                    NgaySinh = dateTimePickerNgaySinh.Value,
                    DiaChi = VietHoaChuCaiDau(txtDiaChi.Text.Trim()),
                    SoDienThoai = soDienThoai,
                    NgayLamThe = dateTimePickerNgayLamThe.Value,
                    CMND = cmnd
                };

                ShareData.DocGiaList.Insert(0, docGia);

                SaveData();
                RefreshDataGrid();
                ClearForm();

                MessageBox.Show("Thêm độc giả thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (selectedIndex < 0 || selectedIndex >= ShareData.DocGiaList.Count)
            {
                MessageBox.Show("Vui lòng chọn độc giả cần sửa!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ValidateInput()) return;

            var docGia = ShareData.DocGiaList[selectedIndex];
            string newPhone = txtSoDienThoai.Text.Trim();
            string newCMND = txtCMND.Text.Trim();

            if (newPhone != docGia.SoDienThoai)
            {
                if (ShareData.DocGiaList.Any(d => d.SoDienThoai == newPhone))
                {
                    MessageBox.Show("Số điện thoại đã tồn tại!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSoDienThoai.Focus();
                    return;
                }
            }

            if (newCMND != docGia.CMND)
            {
                if (ShareData.DocGiaList.Any(d => d.CMND == newCMND))
                {
                    MessageBox.Show("CMND đã tồn tại!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCMND.Focus();
                    return;
                }
            }

            DialogResult confirm = MessageBox.Show("Bạn có chắc muốn cập nhật độc giả này không?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            docGia.HoTen = VietHoaChuCaiDau(txtHoTen.Text.Trim());
            docGia.GioiTinh = gioiTinhHienTai;
            docGia.NgaySinh = dateTimePickerNgaySinh.Value;
            docGia.DiaChi = VietHoaChuCaiDau(txtDiaChi.Text.Trim());
            docGia.SoDienThoai = newPhone;
            docGia.NgayLamThe = dateTimePickerNgayLamThe.Value;
            docGia.CMND = newCMND;

            SaveData();
            RefreshDataGrid();
            ClearForm();

            MessageBox.Show("Cập nhật thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (selectedIndex < 0 || selectedIndex >= ShareData.DocGiaList.Count)
            {
                MessageBox.Show("Vui lòng chọn độc giả cần xóa!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirm = MessageBox.Show("Bạn có chắc muốn xóa độc giả này không?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                ShareData.DocGiaList.RemoveAt(selectedIndex);
                SaveData();
                RefreshDataGrid();
                ClearForm();
                MessageBox.Show("Xóa thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var cellValue = dgvDocGia.Rows[e.RowIndex].Cells["MaDocGia"].Value;
            if (cellValue == null) return;

            string ma = cellValue.ToString();
            var docGia = ShareData.DocGiaList.FirstOrDefault(d => d.MaDocGia.ToUpper() == ma.ToUpper());
            if (docGia == null) return;

            selectedIndex = ShareData.DocGiaList.IndexOf(docGia);

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

            txtMaDocGia.ReadOnly = true;
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
            string keyword = txtTimKiem.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(keyword))
            {
                RefreshDataGrid();
                return;
            }

            var filtered = ShareData.DocGiaList
                .Where(d => d.HoTen.ToLower().Contains(keyword) || d.MaDocGia.ToLower().Contains(keyword))
                .ToList();

            dgvDocGia.Rows.Clear();

            for (int i = 0; i < filtered.Count; i++)
            {
                var docGia = filtered[i];
                dgvDocGia.Rows.Add(
                    i + 1,
                    docGia.MaDocGia.ToUpper(),
                    VietHoaChuCaiDau(docGia.HoTen),
                    docGia.GioiTinh,
                    docGia.NgaySinh.ToString("dd/MM/yyyy"),
                    VietHoaChuCaiDau(docGia.DiaChi),
                    docGia.SoDienThoai,
                    docGia.NgayLamThe.ToString("dd/MM/yyyy"),
                    docGia.CMND
                );
            }
            dgvDocGia.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            if (selectedIndex < 0 || selectedIndex >= ShareData.DocGiaList.Count)
            {
                MessageBox.Show("Vui lòng chọn độc giả cần xem chi tiết!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var docGia = ShareData.DocGiaList[selectedIndex];

            // Mở modal chi tiết giống như modal tác giả
            ModalChiTietDocGia modalChiTiet = new ModalChiTietDocGia(docGia);
            modalChiTiet.ShowDialog();
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
            txtMaDocGia.ReadOnly = false;
            txtMaDocGia.Focus();
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtMaDocGia.Text))
            {
                MessageBox.Show("Mã độc giả không được để trống", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaDocGia.Focus();
                return false;
            }

            if (FucString.ContainsSpecialCharacters(txtMaDocGia.Text))
            {
                MessageBox.Show("Mã độc giả không được có kí tự đặc biệt", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaDocGia.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Họ tên không được để trống", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHoTen.Focus();
                return false;
            }

            if (txtHoTen.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Họ tên không được chứa số", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHoTen.Focus();
                return false;
            }

            if (FucString.ContainsSpecialCharacters(txtHoTen.Text))
            {
                MessageBox.Show("Họ tên không được có kí tự đặc biệt", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHoTen.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSoDienThoai.Text))
            {
                MessageBox.Show("Số điện thoại không được để trống", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoDienThoai.Focus();
                return false;
            }

            if (!txtSoDienThoai.Text.StartsWith("0"))
            {
                MessageBox.Show("Số điện thoại phải bắt đầu bằng số 0!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoDienThoai.Focus();
                return false;
            }

            if (txtSoDienThoai.Text.Length >= 15)
            {
                MessageBox.Show("Số điện thoại phải dưới 15 số!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoDienThoai.Focus();
                return false;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(txtSoDienThoai.Text, @"^\d+$"))
            {
                MessageBox.Show("Số điện thoại chỉ được chứa chữ số!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoDienThoai.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCMND.Text))
            {
                MessageBox.Show("CMND không được để trống", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCMND.Focus();
                return false;
            }

            if (txtCMND.Text.Length >= 15)
            {
                MessageBox.Show("CMND phải dưới 15 số!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCMND.Focus();
                return false;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(txtCMND.Text, @"^\d+$"))
            {
                MessageBox.Show("CMND chỉ được chứa chữ số!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCMND.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                MessageBox.Show("Địa chỉ không được để trống", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDiaChi.Focus();
                return false;
            }

            if (!chkNam.Checked && !chkNu.Checked)
            {
                MessageBox.Show("Vui lòng chọn giới tính", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (dateTimePickerNgaySinh.Value > DateTime.Now.AddYears(-6))
            {
                MessageBox.Show("Độc giả phải ít nhất 6 tuổi!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (dateTimePickerNgaySinh.Value > DateTime.Now)
            {
                MessageBox.Show("Ngày sinh không thể ở tương lai!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}