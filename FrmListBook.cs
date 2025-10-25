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
        private List<ListBook> bookList = new List<ListBook>();
        private ListBook selectedBook = null;
        private ListBook createBook = new ListBook();
        private ListBook listBookHelper = new ListBook();
        private List<string> categories = new List<string>()
    {
        "Văn học", "Khoa học", "Lịch sử", "Triết học", "Tâm lý học",
        "Kinh tế", "Kinh doanh", "Công nghệ thông tin", "Kỹ năng sống",
        "Sách thiếu nhi", "Trinh thám", "Viễn tưởng", "Tiểu thuyết",
        "Truyện ngắn", "Thơ", "Hồi ký", "Du ký", "Ẩm thực", "Nghệ thuật",
        "Âm nhạc", "Y học", "Sức khỏe", "Thể thao", "Tôn giáo", "Chính trị"
    };

        private int selectedBookIndex = -1;

        public FrmListBook()
        {
            InitializeComponent();
            dgvListBook.SelectionChanged += dgvListBook_SelectionChanged;
        }

        private void FrmListBook_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
            LoadBookData();
            ClearForm();

            // comboBox
            comboBoxTheLoai.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxTheLoai.AutoCompleteSource = AutoCompleteSource.CustomSource;

            AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();
            autoComplete.AddRange(categories.ToArray());
            comboBoxTheLoai.AutoCompleteCustomSource = autoComplete;

            comboBoxTheLoai.DataSource = categories;
            comboBoxTheLoai.SelectedIndex = -1; // Không chọn mục nào
            comboBoxTheLoai.Text = "Chọn thể loại..."; // Hiển thị placeholder
        }

        private void SetupDataGridView()
        {
            dgvListBook.Columns.Clear();

            dgvListBook.Columns.Add("Stt", "STT");
            dgvListBook.Columns.Add("MaSach", "Mã Sách");
            dgvListBook.Columns.Add("TenSach", "Tên Sách");
            dgvListBook.Columns.Add("TheLoai", "Thể Loại");
            dgvListBook.Columns.Add("NhaXB", "Nhà XB");
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

        private void LoadBookData()
        {
            try
            {
                bookList = listBookHelper.GetList();
                RefreshDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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
                    book.NhaXB,
                    FormatDate(book.NgayXB),
                    book.MaTacGia,
                    FormatCurrency(book.GiaTien)
                );
            }
            dgvListBook.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
        }

        private void dgvListBook_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvListBook.SelectedRows.Count > 0)
            {
                try
                {
                    int rowIndex = dgvListBook.SelectedRows[0].Index;
                    if (rowIndex >= 0 && rowIndex < bookList.Count)
                    {
                        selectedBookIndex = rowIndex;
                        selectedBook = bookList[rowIndex];
                        DisplaySelectedBook();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Lỗi khi chọn sách: {ex.Message}");
                }
            }
        }

        private void DisplaySelectedBook()
        {
            if (selectedBook == null) return;

            try
            {
                txtMaSach.Text = selectedBook.MaSach;
                txtTenSach.Text = selectedBook.TenSach;
                //txtTheLoai.Text = selectedBook.TheLoai;
                txtMaTacGia.Text = selectedBook.MaTacGia;

                // Xử lý giá tiền
                string giaTien = selectedBook.GiaTien;
                if (long.TryParse(giaTien, out long gia))
                {
                    txtGiaTien.Text = gia.ToString();
                }
                else
                {
                    string cleanGia = giaTien.Replace(" VNĐ", "").Replace(".", "").Replace(" ", "").Replace(",", "");
                    if (long.TryParse(cleanGia, out gia))
                    {
                        txtGiaTien.Text = gia.ToString();
                    }
                    else
                    {
                        txtGiaTien.Text = giaTien;
                    }
                }

                // Xử lý ngày xuất bản
                if (DateTime.TryParse(selectedBook.NgayXB, out DateTime date))
                {
                    dateTimePickerBook.Value = date;
                }

                // QUAN TRỌNG: Chỉ khóa mã sách khi đang chỉnh sửa
                txtMaSach.ReadOnly = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi hiển thị thông tin sách: {ex.Message}");
            }
        }

        private void ClearForm()
        {
            // QUAN TRỌNG: Phải mở khóa txtMaSach trước khi xóa
            txtMaSach.ReadOnly = false;

            txtMaSach.Text = "";
            txtTenSach.Text = "";
            //txtTheLoai.Text = "";
            txtMaTacGia.Text = "";
            txtGiaTien.Text = "";
            dateTimePickerBook.Value = DateTime.Now;

            selectedBook = null;
            selectedBookIndex = -1;
            dgvListBook.ClearSelection();
            txtMaSach.Focus(); // Focus vào ô mã sách
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate Mã sách
                string maSach = txtMaSach.Text.Trim();
                if (string.IsNullOrWhiteSpace(maSach))
                {
                    MessageBox.Show("Mã sách không được để trống", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaSach.Focus();
                    return;
                }

                // Check trùng mã sách
                if (bookList.Any(b => b.MaSach.ToLower() == maSach.ToLower()))
                {
                    MessageBox.Show("Mã sách đã tồn tại", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaSach.Focus();
                    return;
                }

                // Validate các trường khác
                if (string.IsNullOrWhiteSpace(txtTenSach.Text))
                {
                    MessageBox.Show("Tên sách không được để trống", "Lỗi");
                    txtTenSach.Focus();
                    return;
                }

                //if (string.IsNullOrWhiteSpace(txtTheLoai.Text))
                //{
                //    MessageBox.Show("Thể loại không được để trống", "Lỗi");
                //    txtTheLoai.Focus();
                //    return;
                //}

                if (string.IsNullOrWhiteSpace(txtMaTacGia.Text))
                {
                    MessageBox.Show("Mã tác giả không được để trống", "Lỗi");
                    txtMaTacGia.Focus();
                    return;
                }

                string giaTien = txtGiaTien.Text.Trim();
                if (string.IsNullOrWhiteSpace(giaTien) || !long.TryParse(giaTien, out long gia) || gia < 0)
                {
                    MessageBox.Show("Giá tiền phải là số hợp lệ và lớn hơn 0", "Lỗi");
                    txtGiaTien.Focus();
                    return;
                }

                // Tạo sách mới
                createBook = new ListBook
                {
                    MaSach = maSach.Trim().ToUpper(),
                    TenSach = txtTenSach.Text.Trim(),
                    //TheLoai = txtTheLoai.Text.Trim(),
                    NgayXB = dateTimePickerBook.Value.ToString("yyyy-MM-dd"),
                    MaTacGia = txtMaTacGia.Text.Trim().ToUpper(),
                    GiaTien = gia.ToString()
                };

                // Thêm sách vào danh sách
                bookList.Insert(0, createBook);
                RefreshDataGrid();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm sách: {ex.Message}", "Lỗi");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedBook == null)
                {
                    MessageBox.Show("Vui lòng chọn sách để cập nhật", "Lỗi");
                    return;
                }

                // Validate các trường
                if (string.IsNullOrWhiteSpace(txtTenSach.Text))
                {
                    MessageBox.Show("Tên sách không được để trống", "Lỗi");
                    txtTenSach.Focus();
                    return;
                }

                //if (string.IsNullOrWhiteSpace(txtTheLoai.Text))
                //{
                //    MessageBox.Show("Thể loại không được để trống", "Lỗi");
                //    txtTheLoai.Focus();
                //    return;
                //}


                if (string.IsNullOrWhiteSpace(txtNhaXB.Text))
                {
                    MessageBox.Show("Nhà xuất bản không được để trống", "Lỗi");
                    txtNhaXB.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtMaTacGia.Text))
                {
                    MessageBox.Show("Mã tác giả không được để trống", "Lỗi");
                    txtMaTacGia.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtGiaTien.Text) || !long.TryParse(txtGiaTien.Text, out long gia) || gia < 0)
                {
                    MessageBox.Show("Giá tiền phải là số hợp lệ", "Lỗi");
                    txtGiaTien.Focus();
                    return;
                }

                // Xác nhận cập nhật
                DialogResult confirm = MessageBox.Show(
                    $"Bạn có chắc muốn cập nhật sách '{selectedBook.TenSach}' không?",
                    "Xác nhận cập nhật",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    // Cập nhật thông tin
                    selectedBook.TenSach = txtTenSach.Text.Trim();
                    //selectedBook.TheLoai = txtTheLoai.Text.Trim();
                  
                    selectedBook.NgayXB = dateTimePickerBook.Value.ToString("yyyy-MM-dd");
                    selectedBook.MaTacGia = txtMaTacGia.Text.Trim().ToUpper();
                    selectedBook.GiaTien = gia.ToString();

                    RefreshDataGrid();
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật sách: {ex.Message}", "Lỗi");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedBook == null)
                {
                    MessageBox.Show("Vui lòng chọn sách để xóa", "Lỗi");
                    return;
                }

                // Xác nhận xóa
                DialogResult confirm = MessageBox.Show(
                    $"Bạn có CHẮC CHẮN muốn xóa sách '{selectedBook.TenSach}' không?\n\nHành động này không thể hoàn tác!",
                    "XÁC NHẬN XÓA",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    var bookToRemove = bookList.FirstOrDefault(b => b.MaSach == selectedBook.MaSach);
                    if (bookToRemove != null)
                    {
                        bookList.Remove(bookToRemove);
                        RefreshDataGrid();
                        ClearForm();
                    }
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
                        (b.NhaXB?.ToLower().Contains(filterText) ?? false) ||
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
                            book.NhaXB,
                            FormatDate(book.NgayXB),
                            book.MaTacGia,
                            FormatCurrency(book.GiaTien)
                        );
                    }
                    dgvListBook.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi tìm kiếm: {ex.Message}");
            }
        }

        private void dgvListBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Không cần xử lý
        }

        // Các phương thức helper
        private string FormatCurrency(string amount)
        {
            if (long.TryParse(amount, out long value))
            {
                return value.ToString("N0") + " VNĐ";
            }
            return amount;
        }

        private string FormatDate(string dateString)
        {
            if (DateTime.TryParse(dateString, out DateTime date))
            {
                return date.ToString("dd/MM/yyyy");
            }
            return dateString;
        }


     
    }
}