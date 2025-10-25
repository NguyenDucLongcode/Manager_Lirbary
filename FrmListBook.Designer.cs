namespace WinFormsApp1
{
    partial class FrmListBook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            txtFilter = new TextBox();
            label1 = new Label();
            dgvListBook = new DataGridView();
            MaSach = new DataGridViewTextBoxColumn();
            TenSach = new DataGridViewTextBoxColumn();
            TheLoai = new DataGridViewTextBoxColumn();
            NhaXB = new DataGridViewTextBoxColumn();
            NgayXB = new DataGridViewTextBoxColumn();
            MaTacGia = new DataGridViewTextBoxColumn();
            GiaTien = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            groupBox4 = new GroupBox();
            btnHuy = new Button();
            btnDetail = new Button();
            btnXoa = new Button();
            btnUpdate = new Button();
            btnCreate = new Button();
            groupBox3 = new GroupBox();
            comboBoxTheLoai = new ComboBox();
            label11 = new Label();
            txtGiaTien = new TextBox();
            label9 = new Label();
            txtMaTacGia = new TextBox();
            label8 = new Label();
            dateTimePickerBook = new DateTimePicker();
            label7 = new Label();
            txtTenSach = new TextBox();
            label5 = new Label();
            txtMaSach = new TextBox();
            label4 = new Label();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListBook).BeginInit();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.5544319F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 74.44557F));
            tableLayoutPanel1.Controls.Add(groupBox1, 1, 0);
            tableLayoutPanel1.Controls.Add(dgvListBook, 1, 1);
            tableLayoutPanel1.Controls.Add(groupBox2, 0, 1);
            tableLayoutPanel1.Location = new Point(0, 1);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel1.Size = new Size(1904, 1030);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonFace;
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtFilter);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Blue;
            groupBox1.Location = new Point(489, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(272, 97);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(14, 38);
            label3.Name = "label3";
            label3.Size = new Size(228, 23);
            label3.TabIndex = 3;
            label3.Text = "Tìm kiếm theo tên/ Mã Sách";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(15, 39);
            label2.Name = "label2";
            label2.Size = new Size(0, 28);
            label2.TabIndex = 2;
            // 
            // txtFilter
            // 
            txtFilter.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFilter.Location = new Point(20, 64);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(223, 25);
            txtFilter.TabIndex = 1;
            txtFilter.TextChanged += txtFilter_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(14, 47);
            label1.Name = "label1";
            label1.Size = new Size(0, 17);
            label1.TabIndex = 0;
            // 
            // dgvListBook
            // 
            dgvListBook.AllowUserToOrderColumns = true;
            dgvListBook.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvListBook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListBook.Columns.AddRange(new DataGridViewColumn[] { MaSach, TenSach, TheLoai, NhaXB, NgayXB, MaTacGia, GiaTien });
            dgvListBook.Cursor = Cursors.Hand;
            dgvListBook.Location = new Point(489, 106);
            dgvListBook.Name = "dgvListBook";
            dgvListBook.RowHeadersWidth = 51;
            dgvListBook.Size = new Size(1412, 921);
            dgvListBook.TabIndex = 2;
            dgvListBook.CellContentClick += dgvListBook_CellContentClick;
            // 
            // MaSach
            // 
            MaSach.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaSach.HeaderText = "Mã Sách";
            MaSach.MinimumWidth = 6;
            MaSach.Name = "MaSach";
            // 
            // TenSach
            // 
            TenSach.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TenSach.HeaderText = "Tên Sách";
            TenSach.MinimumWidth = 6;
            TenSach.Name = "TenSach";
            // 
            // TheLoai
            // 
            TheLoai.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TheLoai.HeaderText = "Thể Loại";
            TheLoai.MinimumWidth = 6;
            TheLoai.Name = "TheLoai";
            // 
            // NhaXB
            // 
            NhaXB.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NhaXB.HeaderText = "Nhà XB";
            NhaXB.MinimumWidth = 6;
            NhaXB.Name = "NhaXB";
            // 
            // NgayXB
            // 
            NgayXB.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NgayXB.HeaderText = "Ngày XB";
            NgayXB.MinimumWidth = 6;
            NgayXB.Name = "NgayXB";
            // 
            // MaTacGia
            // 
            MaTacGia.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaTacGia.HeaderText = "Mã Tác Giả";
            MaTacGia.MinimumWidth = 6;
            MaTacGia.Name = "MaTacGia";
            // 
            // GiaTien
            // 
            GiaTien.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            GiaTien.HeaderText = "Giá Tiền";
            GiaTien.MinimumWidth = 6;
            GiaTien.Name = "GiaTien";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(3, 106);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(480, 921);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnHuy);
            groupBox4.Controls.Add(btnDetail);
            groupBox4.Controls.Add(btnXoa);
            groupBox4.Controls.Add(btnUpdate);
            groupBox4.Controls.Add(btnCreate);
            groupBox4.Location = new Point(24, 590);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(441, 238);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Chức năng";
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(245, 129);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(103, 47);
            btnHuy.TabIndex = 4;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnDetail
            // 
            btnDetail.Location = new Point(94, 129);
            btnDetail.Name = "btnDetail";
            btnDetail.Size = new Size(103, 47);
            btnDetail.TabIndex = 3;
            btnDetail.Text = "Chi tiết";
            btnDetail.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(291, 53);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(103, 47);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(164, 53);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(103, 47);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(29, 53);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(103, 47);
            btnCreate.TabIndex = 0;
            btnCreate.Text = "Thêm ";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(comboBoxTheLoai);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(txtGiaTien);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(txtMaTacGia);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(dateTimePickerBook);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(txtTenSach);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(txtMaSach);
            groupBox3.Controls.Add(label4);
            groupBox3.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = Color.Blue;
            groupBox3.Location = new Point(24, 15);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(441, 547);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin sách";
            // 
            // comboBoxTheLoai
            // 
            comboBoxTheLoai.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxTheLoai.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxTheLoai.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxTheLoai.FormattingEnabled = true;
            comboBoxTheLoai.Location = new Point(151, 179);
            comboBoxTheLoai.Name = "comboBoxTheLoai";
            comboBoxTheLoai.Size = new Size(272, 31);
            comboBoxTheLoai.TabIndex = 19;
            // 
            // txtTheLoai
            // 
            txtTheLoai.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTheLoai.Location = new Point(152, 176);
            txtTheLoai.Name = "txtTheLoai";
            txtTheLoai.Size = new Size(271, 36);
            txtTheLoai.TabIndex = 18;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ActiveCaptionText;
            label11.Location = new Point(20, 180);
            label11.Name = "label11";
            label11.Size = new Size(97, 30);
            label11.TabIndex = 17;
            label11.Text = "Thể Loại";
            // 
            // txtGiaTien
            // 
            txtGiaTien.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtGiaTien.Location = new Point(151, 349);
            txtGiaTien.Name = "txtGiaTien";
            txtGiaTien.Size = new Size(271, 36);
            txtGiaTien.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(19, 354);
            label9.Name = "label9";
            label9.Size = new Size(94, 30);
            label9.TabIndex = 13;
            label9.Text = "Giá Tiền";
            // 
            // txtMaTacGia
            // 
            txtMaTacGia.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMaTacGia.Location = new Point(151, 286);
            txtMaTacGia.Name = "txtMaTacGia";
            txtMaTacGia.Size = new Size(271, 36);
            txtMaTacGia.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(19, 295);
            label8.Name = "label8";
            label8.Size = new Size(119, 30);
            label8.TabIndex = 11;
            label8.Text = "Mã Tác Giả";
            // 
            // dateTimePickerBook
            // 
            dateTimePickerBook.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerBook.Location = new Point(151, 234);
            dateTimePickerBook.Name = "dateTimePickerBook";
            dateTimePickerBook.Size = new Size(271, 34);
            dateTimePickerBook.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(19, 234);
            label7.Name = "label7";
            label7.Size = new Size(98, 30);
            label7.TabIndex = 9;
            label7.Text = "Ngày XB";
            // 
            // txtTenSach
            // 
            txtTenSach.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTenSach.Location = new Point(152, 114);
            txtTenSach.Name = "txtTenSach";
            txtTenSach.Size = new Size(271, 36);
            txtTenSach.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(20, 119);
            label5.Name = "label5";
            label5.Size = new Size(100, 30);
            label5.TabIndex = 2;
            label5.Text = "Tên Sách";
            // 
            // txtMaSach
            // 
            txtMaSach.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMaSach.Location = new Point(152, 53);
            txtMaSach.Name = "txtMaSach";
            txtMaSach.Size = new Size(271, 36);
            txtMaSach.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(20, 58);
            label4.Name = "label4";
            label4.Size = new Size(96, 30);
            label4.TabIndex = 0;
            label4.Text = "Mã Sách";
            // 
            // FrmListBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(tableLayoutPanel1);
            Name = "FrmListBook";
            Text = "Tác giả";
            Load += FrmListBook_Load;
            tableLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListBook).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private TextBox txtFilter;
        private Label label1;
        private DataGridView dgvListBook;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label4;
        private TextBox txtMaSach;
        private TextBox txtTenSach;
        private Label label5;
        private Label label7;
        private DateTimePicker dateTimePickerBook;
        private TextBox txtGiaTien;
        private Label label9;
        private TextBox txtMaTacGia;
        private Label label8;
        private TextBox txtTheLoai;
        private Label label11;
        private GroupBox groupBox4;
        private Button btnDetail;
        private Button btnXoa;
        private Button btnUpdate;
        private Button btnCreate;
        private Button btnHuy;
        private TextBox txtNhaXB;
        private Label label6;
        private DataGridViewTextBoxColumn MaSach;
        private DataGridViewTextBoxColumn TenSach;
        private DataGridViewTextBoxColumn TheLoai;
        private DataGridViewTextBoxColumn NhaXB;
        private DataGridViewTextBoxColumn NgayXB;
        private DataGridViewTextBoxColumn MaTacGia;
        private DataGridViewTextBoxColumn GiaTien;
        private ComboBox comboBoxTheLoai;
    }
}