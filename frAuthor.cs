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
    public partial class frAuthor : Form
    {

        List<Author> authorList = new List<Author>();
        Author CreateAuthor = new Author();
        Author SelectedAuthor = new Author();
        int indexSelectedAuthor = -1;
        public frAuthor()
        {
            InitializeComponent();
        }

        private void frAuthor_Load(object sender, EventArgs e)
        {
            Author author = new Author();
            authorList = author.GetList();
            dgvAuthor.DataSource = authorList;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvAuthor_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvAuthor.Rows)
            {
                if (!row.IsNewRow)
                    row.Cells["SttAuthor"].Value = row.Index + 1;
            }
        }

        private void dgvAuthor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng có click vào dòng hợp lệ không 
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                indexSelectedAuthor = e.RowIndex;
                // Gắn giá trị đã chọn vào update Author
                SelectedAuthor.AuthorID = dgvAuthor.CurrentRow.Cells["AuthorId"].Value?.ToString() ?? "";
                SelectedAuthor.FullName = dgvAuthor.CurrentRow.Cells["FullName"].Value?.ToString() ?? "";
                SelectedAuthor.PenName = dgvAuthor.CurrentRow.Cells["PenName"].Value?.ToString() ?? "";

                // Hiện thị thông tin tại form
                txtAuthorId.Text = SelectedAuthor.AuthorID;
                txtName.Text = SelectedAuthor.FullName;
                txtPenName.Text = SelectedAuthor.PenName;

                // Xử lý giới tính
                string gender = dgvAuthor.CurrentRow.Cells["Gender"].Value?.ToString() ?? "";
                if (gender == "Nam")
                {
                    SelectedAuthor.Gender = "Nam";
                    chkNam.Checked = true;
                    chkNu.Checked = false;
                }
                else if (gender == "Nữ")
                {
                    SelectedAuthor.Gender = "Nữ";
                    chkNam.Checked = false;
                    chkNu.Checked = true;
                }
                else
                {
                    chkNam.Checked = false;
                    chkNu.Checked = false;
                }

                // Xử lý ngày sinh
                string birthDate = dgvAuthor.CurrentRow.Cells["BirthDate"].Value?.ToString() ?? "";
                if (DateTime.TryParse(birthDate, out DateTime dateValue))
                {
                    SelectedAuthor.BirthDate = birthDate;
                    dateTimePickerBirtday.Value = dateValue;
                }

                // Gắn thông tin hiện tại vào UpdateAuthor
                SelectedAuthor.PhoneNumber = dgvAuthor.CurrentRow.Cells["PhoneNumber"].Value?.ToString() ?? "";
                SelectedAuthor.Address = dgvAuthor.CurrentRow.Cells["Address"].Value?.ToString() ?? "";
                SelectedAuthor.CMND = dgvAuthor.CurrentRow.Cells["CMND"].Value?.ToString() ?? "";

                // Hiển thị thông tin ở form
                txtPhone.Text = SelectedAuthor.PhoneNumber;
                txtAddress.Text = SelectedAuthor.Address;
                txtCMND.Text = SelectedAuthor.CMND;


                // Khóa input AuthorID ko cho sửa
                txtAuthorId.ReadOnly = true;

            }
        }

        public void clearAuthorForm()
        {
            txtAuthorId.Text = txtAddress.Text = txtCMND.Text = txtName.Text = txtPenName.Text = txtPhone.Text = "";
            if (chkNam.Checked) chkNam.Checked = false;
            if (chkNu.Checked) chkNu.Checked = false;
            DateTime birthDate = dateTimePickerBirtday.Value;
            DateTime now = DateTime.Now;
            if (birthDate == now)
            {
                dateTimePickerBirtday.Value = now;
            }
        }



        private void btnCreate_Click(object sender, EventArgs e)
        {
            string authorId = txtAuthorId.Text;
            if (authorId == "")
            {
                MessageBox.Show("Mã tác giả không được để trống", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAuthorId.Focus();
                return;
            }

            if (FucString.ContainsSpecialCharacters(authorId))
            {
                MessageBox.Show("Mã tác giả không được có kí tự đặc biệt", "Lỗi",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAuthorId.Focus();
                return;
            }

            // Check trùng id
            if (authorList.Any(a => a.AuthorID.ToLower() == authorId.ToLower()))
            {
                MessageBox.Show("Mã tác giả đã tồn tại", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAuthorId.Focus();
                return;
            }

            CreateAuthor.AuthorID = FucString.Standard(authorId);

            // ful name
            if (txtName.Text == "")
            {
                MessageBox.Show("Tên không được để trống", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return;
            }

            // Kiểm tra có chứa số không
            if (txtName.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Họ tên không được chứa số", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return;
            }

            if (FucString.ContainsSpecialCharacters(txtName.Text))
            {
                MessageBox.Show("Họ tên không được có kí tự đặc biệt", "Lỗi",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return;
            }
            CreateAuthor.FullName = FucString.FirstCapitalLetter(txtName.Text);

            // Bút danh
            if (txtPenName.Text == "")
            {
                MessageBox.Show("Bút danh không được để trống", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPenName.Focus();
                return;
            }

            // Check trùng bút danh
            if (authorList.Any(a => a.PenName.ToLower() == txtPenName.Text.ToLower()))
            {
                MessageBox.Show("Bút danh đã tồn tại", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAuthorId.Focus();
                return;
            }

            CreateAuthor.PenName = FucString.FirstCapitalLetter(txtPenName.Text);

            // Giới tính
            if (chkNam.Checked && chkNu.Checked)
            {
                MessageBox.Show("Giới tính chỉ được chọn 1", "Lỗi",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                chkNam.Checked = false;
                chkNu.Checked = false;
                return;
            }
            else if (chkNam.Checked)
            {
                CreateAuthor.Gender = chkNam.Text;
            }
            else if (chkNu.Checked)
            {
                CreateAuthor.Gender = chkNu.Text;
            }
            else
            {
                MessageBox.Show("Giới tính chưa được chọn", "Lỗi",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Ngày sinh
            DateTime birthDate = dateTimePickerBirtday.Value;
            DateTime now = DateTime.Now;
            if (birthDate > now)
            {
                MessageBox.Show("Ngày sinh không thể ở tương lai!");
            }
            else
            {
                CreateAuthor.BirthDate = birthDate.ToString();

            }

            // Số điện thoại
            string phone = txtPhone.Text;
            long convertBigNumber;
            if (phone == "")
            {
                MessageBox.Show("Số điện thoại không được để trống", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Focus();
                return;
            }

            if (!long.TryParse(phone, out convertBigNumber))
            {
                MessageBox.Show("Số điện thoại không phải là số hợp lệ!");
                txtPhone.Text = "";
                txtPhone.Focus();
                return;
            }

            if (phone.Length >= 15)
            {
                MessageBox.Show("Số điện thoại phải dưới 15 số", "Lỗi",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Check trùng số điện thoại
            if (authorList.Any(a => a.PhoneNumber == phone))
            {
                MessageBox.Show("Số điện thoại đã tồn tại đã tồn tại", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAuthorId.Focus();
                return;
            }

            CreateAuthor.PhoneNumber = FucString.Standard(phone);

            // Địa chỉ
            if (txtAddress.Text == "")
            {
                MessageBox.Show("Đia chỉ không được để trống", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAddress.Focus();
                return;
            }

            CreateAuthor.Address = FucString.FirstCapitalLetter(txtAddress.Text);

            // CMMD
            string CMND = txtCMND.Text;
            if (CMND == "")
            {
                MessageBox.Show("CMMD không được để trống", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCMND.Focus();
                return;
            }

            if (!long.TryParse(CMND, out convertBigNumber))
            {
                MessageBox.Show("CMND không phải là số hợp lệ!");
                txtCMND.Text = "";
                txtCMND.Focus();
                return;
            }

            if (CMND.Length >= 15)
            {
                MessageBox.Show("Số CMND phải dưới 15 số", "Lỗi",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check cmmnd
            if (authorList.Any(a => a.CMND == CMND))
            {
                MessageBox.Show("CMND đã tồn tại đã tồn tại", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAuthorId.Focus();
                return;
            }

            CreateAuthor.CMND = FucString.Standard(txtCMND.Text);



            authorList.Insert(0, CreateAuthor);
            dgvAuthor.DataSource = null;
            dgvAuthor.DataSource = authorList;
            clearAuthorForm();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            clearAuthorForm();
            txtAuthorId.ReadOnly = false;
            txtAuthorId.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // ful name
            if (txtName.Text == "")
            {
                MessageBox.Show("Tên không được để trống", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return;
            }

            // Kiểm tra có chứa số không
            if (txtName.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Họ tên không được chứa số", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return;
            }

            if (FucString.ContainsSpecialCharacters(txtName.Text))
            {
                MessageBox.Show("Họ tên không được có kí tự đặc biệt", "Lỗi",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return;
            }
            SelectedAuthor.FullName = FucString.FirstCapitalLetter(txtName.Text);

            // Bút danh
            if (txtPenName.Text == "")
            {
                MessageBox.Show("Bút danh không được để trống", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPenName.Focus();
                return;
            }

            // Check trùng bút danh
            if (authorList.Any(a => a.PenName.ToLower() == txtPenName.Text.ToLower()))
            {
                MessageBox.Show("Bút danh đã tồn tại", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAuthorId.Focus();
                return;
            }

            SelectedAuthor.PenName = FucString.FirstCapitalLetter(txtPenName.Text);

            // Giới tính
            if (chkNam.Checked && chkNu.Checked)
            {
                MessageBox.Show("Giới tính chỉ được chọn 1", "Lỗi",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                chkNam.Checked = false;
                chkNu.Checked = false;
                return;
            }
            else if (chkNam.Checked)
            {
                CreateAuthor.Gender = chkNam.Text;
            }
            else if (chkNu.Checked)
            {
                CreateAuthor.Gender = chkNu.Text;
            }
            else
            {
                MessageBox.Show("Giới tính chưa được chọn", "Lỗi",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Ngày sinh
            DateTime birthDate = dateTimePickerBirtday.Value;
            DateTime now = DateTime.Now;
            if (birthDate > now)
            {
                MessageBox.Show("Ngày sinh không thể ở tương lai!");
            }
            else
            {
                SelectedAuthor.BirthDate = birthDate.ToString();

            }

            // Số điện thoại
            string phone = txtPhone.Text;
            long convertBigNumber;
            if (phone == "")
            {
                MessageBox.Show("Số điện thoại không được để trống", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Focus();
                return;
            }

            if (!long.TryParse(phone, out convertBigNumber))
            {
                MessageBox.Show("Số điện thoại không phải là số hợp lệ!");
                txtPhone.Text = "";
                txtPhone.Focus();
                return;
            }

            if (phone.Length >= 15)
            {
                MessageBox.Show("Số điện thoại phải dưới 15 số", "Lỗi",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SelectedAuthor.PhoneNumber = FucString.Standard(phone);

            // Địa chỉ
            if (txtAddress.Text == "")
            {
                MessageBox.Show("Đia chỉ không được để trống", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAddress.Focus();
                return;
            }

            if (FucString.ContainsSpecialCharacters(txtAddress.Text))
            {
                MessageBox.Show("Địa chỉ không được có kí tự đặc biệt", "Lỗi",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAddress.Focus();
                return;
            }
            SelectedAuthor.Address = FucString.FirstCapitalLetter(txtAddress.Text);

            // CMMD
            string CMND = txtCMND.Text;
            if (CMND == "")
            {
                MessageBox.Show("CMMD không được để trống", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCMND.Focus();
                return;
            }

            if (!long.TryParse(CMND, out convertBigNumber))
            {
                MessageBox.Show("CMND không phải là số hợp lệ!");
                txtCMND.Text = "";
                txtCMND.Focus();
                return;
            }

            if (CMND.Length >= 15)
            {
                MessageBox.Show("Số CMND phải dưới 15 số", "Lỗi",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SelectedAuthor.CMND = FucString.Standard(txtCMND.Text);

            // Xác nhận xóa
            DialogResult confirm = MessageBox.Show("Bạn có chắc muốn cập nhập tác giả này không?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                // Cập nhập lại thông tin tại list Author
                var existing = authorList.FirstOrDefault(s => s.AuthorID == SelectedAuthor.AuthorID);
                if (existing == null)
                {
                    MessageBox.Show("Không tìm thấy tác giả cần cập nhật", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (existing != null)
                {
                    existing.AuthorID = SelectedAuthor.AuthorID;
                    existing.FullName = SelectedAuthor.FullName;
                    existing.Address = SelectedAuthor.Address;
                    existing.BirthDate = SelectedAuthor.BirthDate;
                    existing.Gender = SelectedAuthor.Gender;
                    existing.PhoneNumber = SelectedAuthor.PhoneNumber;
                    existing.CMND = SelectedAuthor.CMND;
                    existing.PenName = SelectedAuthor.PenName;
                }
                // render giá trị
                dgvAuthor.DataSource = null;
                dgvAuthor.DataSource = authorList;

                // Xuất thông báo
                MessageBox.Show("Đã cập nhập tác giả thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            clearAuthorForm();
            txtAuthorId.Focus();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            // Xác nhận xóa
            DialogResult confirm = MessageBox.Show("Bạn có chắc muốn xóa tác giả này không?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                authorList.RemoveAt(indexSelectedAuthor);
                dgvAuthor.DataSource = null;
                dgvAuthor.DataSource = authorList;

                MessageBox.Show("Đã xóa tác giả thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string filterText = txtFilter.Text.ToLower();
            if (string.IsNullOrEmpty(filterText))
            {
                dgvAuthor.DataSource = authorList;
            }
            else
            {
                var filtered = authorList.Where(s =>
                    s.AuthorID.ToLower().Contains(filterText) ||
                    s.FullName.ToLower().Contains(filterText) ||
                    s.PenName.ToLower().Contains(filterText) 
                  
                ).ToList();

                dgvAuthor.DataSource = filtered;
            }
            dgvAuthor.Refresh();
        }
    }
}
