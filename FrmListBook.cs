using qlDsSinhVien;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FrmListBook : Form
    {
        // ===== Biến lưu trữ chính =====
        private List<ListBook> bookList = new List<ListBook>(); // Danh sách tất cả sách
        private ListBook selectedBook = null;                  // Sách hiện đang được chọn
        private ListBook createBook = new ListBook();          // Sách mới tạo để thêm
        private ListBook listBookHelper = new ListBook();      // Hỗ trợ lấy danh sách sách từ file/nguồn khác
        private List<string> categories = new List<string>()   // Danh sách thể loại có sẵn
        {
            "Văn học", "Khoa học", "Lịch sử", "Triết học", "Tâm lý học",
            "Kinh tế", "Kinh doanh", "Công nghệ thông tin", "Kỹ năng sống",
            "Sách thiếu nhi", "Trinh thám", "Viễn tưởng", "Tiểu thuyết",
            "Truyện ngắn", "Thơ", "Hồi ký", "Du ký", "Ẩm thực", "Nghệ thuật",
            "Âm nhạc", "Y học", "Sức khỏe", "Thể thao", "Tôn giáo", "Chính trị"
        };

        private int selectedBookIndex = -1; // Vị trí sách đang chọn trong danh sách

        public FrmListBook()
        {
            InitializeComponent();
            dgvListBook.SelectionChanged += dgvListBook_SelectionChanged; // Khi thay đổi dòng chọn trên DataGridView
        }

        // ===== Khi Form Load =====
        private void FrmListBook_Load(object sender, EventArgs e)
        {
            SetupDataGridView(); // Cấu hình DataGridView
            LoadBookData();      // Load dữ liệu sách từ ShareData hoặc file
            ClearForm();         // Xóa dữ liệu nhập liệu trước đó

            // Load danh sách tác giả nếu chưa có
            if (ShareData.AuthorList.Count == 0)
            {
                Author author = new Author();
                ShareData.AuthorList = author.GetList();
            }

            // ===== ComboBox thể loại =====
            comboBoxTheLoai.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxTheLoai.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxTheLoai.DataSource = categories;
            comboBoxTheLoai.SelectedIndex = -1;
            comboBoxTheLoai.Text = "Chọn thể loại...";

            // ===== ComboBox tác giả =====
            comboBoxMaTacGia.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxMaTacGia.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxMaTacGia.DisplayMember = "PenName";   // Hiển thị tên bút danh
            comboBoxMaTacGia.ValueMember = "AuthorID";    // Giá trị thực chất là ID tác giả
            comboBoxMaTacGia.DataSource = ShareData.AuthorList;
            comboBoxMaTacGia.SelectedIndex = -1;
            comboBoxMaTacGia.Text = "Chọn tác giả...";
        }

        // ===== Cấu hình DataGridView =====
        private void SetupDataGridView()
        {
            dgvListBook.Columns.Clear();

            dgvListBook.Columns.Add("Stt", "STT");
            dgvListBook.Columns.Add("MaSach", "Mã Sách");
            dgvListBook.Columns.Add("TenSach", "Tên Sách");
            dgvListBook.Columns.Add("TheLoai", "Thể Loại");
            dgvListBook.Columns.Add("NgayXB", "Ngày XB");
            dgvListBook.Columns.Add("MaTacGia", "Mã Tác Giả");
            dgvListBook.Columns.Add("GiaTien", "Giá Tiền");

            dgvListBook.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListBook.MultiSelect = false;
            dgvListBook.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvListBook.Columns["Stt"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvListBook.Columns["MaSach"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvListBook.Columns["MaTacGia"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvListBook.Columns["GiaTien"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dgvListBook.Columns["Stt"].MinimumWidth = 50;
            dgvListBook.Columns["MaSach"].MinimumWidth = 80;
            dgvListBook.Columns["TenSach"].MinimumWidth = 200;

            dgvListBook.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvListBook.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dgvListBook.Columns["Stt"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvListBook.Columns["GiaTien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        // ===== Load dữ liệu sách =====
        private void LoadBookData()
        {
            try
            {
                if (ShareData.bookList.Count > 0)
                    bookList = ShareData.bookList;
                else
                {
                    bookList = listBookHelper.GetList();
                    ShareData.bookList = bookList;
                }

                RefreshDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ===== Refresh DataGridView =====
        private void RefreshDataGrid()
        {
            dgvListBook.Rows.Clear();

            for (int i = 0; i < bookList.Count; i++)
            {
                var book = bookList[i];
                dgvListBook.Rows.Add(
                    i + 1,
                    book.MaSach,
                    book.TenSach,
                    book.TheLoai,
                    FormatDate(book.NgayXB),
                    book.MaTacGia,
                    FormatCurrency(book.GiaTien)
                );

                dgvListBook.Rows[dgvListBook.Rows.Count - 1].Tag = book;
            }

            dgvListBook.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
        }

        // ===== Khi chọn dòng trên DataGridView =====
        private void dgvListBook_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvListBook.SelectedRows.Count > 0)
            {
                try
                {
                    var row = dgvListBook.SelectedRows[0];
                    if (row == null) return;

                    var bookFromTag = row.Tag as ListBook;
                    if (bookFromTag != null)
                    {
                        selectedBook = bookFromTag;
                        selectedBookIndex = bookList.FindIndex(b => b.MaSach == selectedBook.MaSach);
                        DisplaySelectedBook();
                        return;
                    }

                    var maSachCell = row.Cells["MaSach"].Value;
                    if (maSachCell != null)
                    {
                        string maSach = maSachCell.ToString();
                        int idx = bookList.FindIndex(b => string.Equals(b.MaSach, maSach, StringComparison.OrdinalIgnoreCase));
                        if (idx >= 0)
                        {
                            selectedBookIndex = idx;
                            selectedBook = bookList[idx];
                            DisplaySelectedBook();
                            return;
                        }
                    }

                    selectedBook = null;
                    selectedBookIndex = -1;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Lỗi khi chọn sách: {ex.Message}");
                }
            }
            else
            {
                selectedBook = null;
                selectedBookIndex = -1;
            }
        }

        // ===== Hiển thị thông tin sách lên form =====
        private void DisplaySelectedBook()
        {
            if (selectedBook == null) return;

            try
            {
                txtMaSach.Text = selectedBook.MaSach;
                txtTenSach.Text = selectedBook.TenSach;
                comboBoxMaTacGia.SelectedValue = selectedBook.MaTacGia;
                comboBoxTheLoai.Text = selectedBook.TheLoai;

                if (long.TryParse(selectedBook.GiaTien, out long gia))
                    txtGiaTien.Text = gia.ToString();
                else
                {
                    string cleanGia = selectedBook.GiaTien.Replace(" VNĐ", "").Replace(".", "").Replace(" ", "").Replace(",", "");
                    txtGiaTien.Text = long.TryParse(cleanGia, out gia) ? gia.ToString() : selectedBook.GiaTien;
                }

                if (DateTime.TryParse(selectedBook.NgayXB, out DateTime date))
                    dateTimePickerBook.Value = date;

                txtMaSach.ReadOnly = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi hiển thị thông tin sách: {ex.Message}");
            }
        }

        // ===== Xóa form nhập liệu =====
        private void ClearForm()
        {
            txtMaSach.ReadOnly = false;
            txtMaSach.Text = "";
            txtTenSach.Text = "";
            comboBoxMaTacGia.SelectedIndex = -1;
            comboBoxTheLoai.SelectedIndex = -1;
            txtGiaTien.Text = "";
            dateTimePickerBook.Value = DateTime.Now;
            selectedBook = null;
            selectedBookIndex = -1;
            dgvListBook.ClearSelection();
            txtMaSach.Focus();
        }

        // ===== Thêm sách mới =====
        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                string maSach = txtMaSach.Text.Trim();
                if (string.IsNullOrWhiteSpace(maSach))
                {
                    MessageBox.Show("Mã sách không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaSach.Focus();
                    return;
                }

                if (bookList.Any(b => b.MaSach.Trim().ToLower() == maSach.ToLower()))
                {
                    MessageBox.Show("Mã sách đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaSach.Focus();
                    return;
                }

                if (bookList.Any(b => b.TenSach.Trim().ToLower() == txtTenSach.Text.Trim().ToLower()))
                {
                    MessageBox.Show("Tên sách đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTenSach.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtTenSach.Text))
                {
                    MessageBox.Show("Tên sách không được để trống", "Lỗi");
                    txtTenSach.Focus();
                    return;
                }

                string selectedTheLoai = comboBoxTheLoai.Text;
                if (string.IsNullOrWhiteSpace(selectedTheLoai) || selectedTheLoai == "Chọn thể loại...")
                {
                    MessageBox.Show("Vui lòng chọn thể loại!");
                    return;
                }

                if (dateTimePickerBook.Value > DateTime.Now)
                {
                    MessageBox.Show("Ngày xuất bản không thể ở tương lai!");
                    return;
                }

                if (comboBoxMaTacGia.SelectedIndex == -1 || comboBoxMaTacGia.Text == "Chọn tác giả...")
                {
                    MessageBox.Show("Vui lòng chọn tác giả!");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtGiaTien.Text) || !long.TryParse(txtGiaTien.Text, out long gia) || gia < 0)
                {
                    MessageBox.Show("Giá tiền phải là số hợp lệ và lớn hơn 0", "Lỗi");
                    txtGiaTien.Focus();
                    return;
                }

                createBook = new ListBook
                {
                    MaSach = maSach.Trim().ToUpper(),
                    TenSach = txtTenSach.Text.Trim(),
                    TheLoai = selectedTheLoai,
                    NgayXB = dateTimePickerBook.Value.ToString("yyyy-MM-dd"),
                    MaTacGia = comboBoxMaTacGia.SelectedValue.ToString(),
                    GiaTien = gia.ToString()
                };

                bookList.Insert(0, createBook);
                ShareData.bookList = bookList;
                RefreshDataGrid();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm sách: {ex.Message}", "Lỗi");
            }
        }

        // ===== Cập nhật sách =====
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedBook == null)
                {
                    MessageBox.Show("Vui lòng chọn sách để cập nhật", "Lỗi");
                    return;
                }

                if (bookList.Any(b => b.TenSach.Trim().ToLower() == txtTenSach.Text.Trim().ToLower()
                                      && b.MaSach != selectedBook.MaSach))
                {
                    MessageBox.Show("Tên sách đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTenSach.Focus();
                    return;
                }

                string selectedTheLoai = comboBoxTheLoai.Text;
                if (string.IsNullOrWhiteSpace(selectedTheLoai) || selectedTheLoai == "Chọn thể loại...")
                {
                    MessageBox.Show("Vui lòng chọn thể loại!", "Lỗi");
                    return;
                }

                if (dateTimePickerBook.Value > DateTime.Now)
                {
                    MessageBox.Show("Ngày xuất bản không thể ở tương lai!");
                    return;
                }

                if (comboBoxMaTacGia.SelectedIndex == -1 || comboBoxMaTacGia.Text == "Chọn tác giả...")
                {
                    MessageBox.Show("Vui lòng chọn tác giả!", "Lỗi");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtGiaTien.Text) || !long.TryParse(txtGiaTien.Text, out long gia) || gia < 0)
                {
                    MessageBox.Show("Giá tiền phải là số hợp lệ", "Lỗi");
                    txtGiaTien.Focus();
                    return;
                }

                DialogResult confirm = MessageBox.Show(
                    $"Bạn có chắc muốn cập nhật sách '{selectedBook.TenSach}' không?",
                    "Xác nhận cập nhật",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    selectedBook.TenSach = txtTenSach.Text.Trim();
                    selectedBook.TheLoai = selectedTheLoai;
                    selectedBook.NgayXB = dateTimePickerBook.Value.ToString("yyyy-MM-dd");
                    selectedBook.MaTacGia = comboBoxMaTacGia.SelectedValue.ToString();
                    selectedBook.GiaTien = txtGiaTien.Text.Trim();

                    ShareData.bookList = bookList;
                    RefreshDataGrid();
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật sách: {ex.Message}", "Lỗi");
            }
        }

        // ===== Xóa sách =====
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedBook == null)
                {
                    MessageBox.Show("Vui lòng chọn sách để xóa", "Lỗi");
                    return;
                }

                DialogResult confirm = MessageBox.Show(
                    $"Bạn có CHẮC CHẮN muốn xóa sách '{selectedBook.TenSach}' không?\n\nHành động này không thể hoàn tác!",
                    "XÁC NHẬN XÓA",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    bookList.Remove(selectedBook);
                    ShareData.bookList = bookList;
                    RefreshDataGrid();
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa sách: {ex.Message}", "Lỗi");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string filterText = txtFilter.Text.Trim().ToLower();
                if (string.IsNullOrEmpty(filterText))
                {
                    RefreshDataGrid();
                }
                else
                {
                    var filtered = bookList.Where(b =>
                        (b.MaSach?.ToLower().Contains(filterText) ?? false) ||
                        (b.TenSach?.ToLower().Contains(filterText) ?? false) ||
                        (b.TheLoai?.ToLower().Contains(filterText) ?? false) ||
                        (b.MaTacGia?.ToLower().Contains(filterText) ?? false) ||
                        (b.GiaTien?.ToLower().Contains(filterText) ?? false)
                    ).ToList();

                    dgvListBook.Rows.Clear();
                    for (int i = 0; i < filtered.Count; i++)
                    {
                        var book = filtered[i];
                        dgvListBook.Rows.Add(
                            i + 1,
                            book.MaSach,
                            book.TenSach,
                            book.TheLoai,
                            FormatDate(book.NgayXB),
                            book.MaTacGia,
                            FormatCurrency(book.GiaTien)
                        );
                        dgvListBook.Rows[dgvListBook.Rows.Count - 1].Tag = book;
                    }
                    dgvListBook.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi tìm kiếm: {ex.Message}");
            }
        }

        private void dgvListBook_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private string FormatCurrency(string amount)
        {
            if (long.TryParse(amount, out long value))
                return value.ToString("N0") + " VNĐ";
            return amount;
        }

        private string FormatDate(string dateString)
        {
            if (DateTime.TryParse(dateString, out DateTime date))
                return date.ToString("dd/MM/yyyy");
            return dateString;
        }

        private void btnTacGia_Click(object sender, EventArgs e)
        {
            if (selectedBook == null)
            {
                MessageBox.Show("Vui lòng chọn sách để xem thông tin tác giả", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Author authorDetail = ShareData.AuthorList
                .FirstOrDefault(a => a.AuthorID == selectedBook.MaTacGia);

            ModalTacGia frInForTacGia = new ModalTacGia(authorDetail);
            frInForTacGia.ShowDialog();
        }
    }
}
