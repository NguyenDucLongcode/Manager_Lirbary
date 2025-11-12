namespace WinFormsApp1
{
    partial class frAuthor
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
            dgvAuthor = new DataGridView();
            SttAuthor = new DataGridViewTextBoxColumn();
            AuthorID = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewTextBoxColumn();
            BirthDate = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            PhoneNumber = new DataGridViewTextBoxColumn();
            CMND = new DataGridViewTextBoxColumn();
            PenName = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            groupBox4 = new GroupBox();
            btnHuy = new Button();
            btnXoa = new Button();
            btnUpdate = new Button();
            btnCreate = new Button();
            groupBox3 = new GroupBox();
            radioNu = new RadioButton();
            radioNam = new RadioButton();
            txtPenName = new TextBox();
            label11 = new Label();
            txtCMND = new TextBox();
            label10 = new Label();
            txtPhone = new TextBox();
            label9 = new Label();
            txtAddress = new TextBox();
            label8 = new Label();
            dateTimePickerBirtday = new DateTimePicker();
            label7 = new Label();
            label6 = new Label();
            txtName = new TextBox();
            label5 = new Label();
            txtAuthorId = new TextBox();
            label4 = new Label();
            groupBox5 = new GroupBox();
            dataGridViewBook = new DataGridView();
            STTBook = new DataGridViewTextBoxColumn();
            TenSach = new DataGridViewTextBoxColumn();
            MaSach = new DataGridViewTextBoxColumn();
            GiaTien = new DataGridViewTextBoxColumn();
            NgayXB = new DataGridViewTextBoxColumn();
            MaTacGia = new DataGridViewTextBoxColumn();
            TheLoai = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAuthor).BeginInit();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBook).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.0305862F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58.85806F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.1113586F));
            tableLayoutPanel1.Controls.Add(groupBox1, 1, 0);
            tableLayoutPanel1.Controls.Add(dgvAuthor, 1, 1);
            tableLayoutPanel1.Controls.Add(groupBox2, 0, 1);
            tableLayoutPanel1.Controls.Add(groupBox5, 2, 1);
            tableLayoutPanel1.Location = new Point(0, 1);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel1.Size = new Size(1906, 1030);
            tableLayoutPanel1.TabIndex = 5;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
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
            groupBox1.Location = new Point(422, 3);
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
            label3.Size = new Size(232, 23);
            label3.TabIndex = 3;
            label3.Text = "Tìm kiếm theo tên/ Bút danh";
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
            // dgvAuthor
            // 
            dgvAuthor.AllowUserToOrderColumns = true;
            dgvAuthor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAuthor.Columns.AddRange(new DataGridViewColumn[] { SttAuthor, AuthorID, FullName, Gender, BirthDate, Address, PhoneNumber, CMND, PenName });
            dgvAuthor.Cursor = Cursors.Hand;
            dgvAuthor.Dock = DockStyle.Fill;
            dgvAuthor.Location = new Point(422, 106);
            dgvAuthor.Name = "dgvAuthor";
            dgvAuthor.RowHeadersWidth = 51;
            dgvAuthor.Size = new Size(1115, 921);
            dgvAuthor.TabIndex = 2;
            dgvAuthor.CellContentClick += dgvAuthor_CellContentClick;
            dgvAuthor.DataBindingComplete += dgvAuthor_DataBindingComplete;
            // 
            // SttAuthor
            // 
            SttAuthor.HeaderText = "Stt";
            SttAuthor.MinimumWidth = 6;
            SttAuthor.Name = "SttAuthor";
            SttAuthor.Width = 50;
            // 
            // AuthorID
            // 
            AuthorID.DataPropertyName = "AuthorID";
            AuthorID.HeaderText = "Mã tác gả";
            AuthorID.MinimumWidth = 6;
            AuthorID.Name = "AuthorID";
            AuthorID.Width = 110;
            // 
            // FullName
            // 
            FullName.DataPropertyName = "FullName";
            FullName.HeaderText = "Họ tên";
            FullName.MinimumWidth = 6;
            FullName.Name = "FullName";
            FullName.Width = 150;
            // 
            // Gender
            // 
            Gender.DataPropertyName = "Gender";
            Gender.HeaderText = "Giới tính";
            Gender.MinimumWidth = 6;
            Gender.Name = "Gender";
            Gender.Width = 125;
            // 
            // BirthDate
            // 
            BirthDate.DataPropertyName = "BirthDate";
            BirthDate.HeaderText = "Ngày sinh";
            BirthDate.MinimumWidth = 6;
            BirthDate.Name = "BirthDate";
            BirthDate.Width = 125;
            // 
            // Address
            // 
            Address.DataPropertyName = "Address";
            Address.HeaderText = "Địa chỉ";
            Address.MinimumWidth = 6;
            Address.Name = "Address";
            Address.Width = 130;
            // 
            // PhoneNumber
            // 
            PhoneNumber.DataPropertyName = "PhoneNumber";
            PhoneNumber.HeaderText = "Số diện thoại";
            PhoneNumber.MinimumWidth = 6;
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.Width = 125;
            // 
            // CMND
            // 
            CMND.DataPropertyName = "CMND";
            CMND.HeaderText = "CMND";
            CMND.MinimumWidth = 6;
            CMND.Name = "CMND";
            CMND.Width = 125;
            // 
            // PenName
            // 
            PenName.DataPropertyName = "PenName";
            PenName.HeaderText = "Bút danh";
            PenName.MinimumWidth = 6;
            PenName.Name = "PenName";
            PenName.Width = 120;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(3, 106);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(396, 921);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnHuy);
            groupBox4.Controls.Add(btnXoa);
            groupBox4.Controls.Add(btnUpdate);
            groupBox4.Controls.Add(btnCreate);
            groupBox4.Location = new Point(-3, 585);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(399, 243);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Chức năng";
            groupBox4.Enter += groupBox4_Enter;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(235, 129);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(103, 47);
            btnHuy.TabIndex = 4;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(235, 53);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(103, 47);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(45, 129);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(103, 47);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(45, 53);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(103, 47);
            btnCreate.TabIndex = 0;
            btnCreate.Text = "Thêm ";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(radioNu);
            groupBox3.Controls.Add(radioNam);
            groupBox3.Controls.Add(txtPenName);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(txtCMND);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(txtPhone);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(txtAddress);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(dateTimePickerBirtday);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(txtName);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(txtAuthorId);
            groupBox3.Controls.Add(label4);
            groupBox3.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = Color.Blue;
            groupBox3.Location = new Point(0, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(413, 563);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin tác giả";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // radioNu
            // 
            radioNu.AutoSize = true;
            radioNu.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioNu.Location = new Point(245, 230);
            radioNu.Name = "radioNu";
            radioNu.Size = new Size(60, 32);
            radioNu.TabIndex = 20;
            radioNu.TabStop = true;
            radioNu.Text = "Nữ";
            radioNu.UseVisualStyleBackColor = true;
            // 
            // radioNam
            // 
            radioNam.AutoSize = true;
            radioNam.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioNam.Location = new Point(152, 230);
            radioNam.Name = "radioNam";
            radioNam.Size = new Size(76, 32);
            radioNam.TabIndex = 19;
            radioNam.TabStop = true;
            radioNam.Text = "Nam";
            radioNam.UseVisualStyleBackColor = true;
            // 
            // txtPenName
            // 
            txtPenName.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPenName.Location = new Point(135, 174);
            txtPenName.Name = "txtPenName";
            txtPenName.Size = new Size(242, 36);
            txtPenName.TabIndex = 18;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ActiveCaptionText;
            label11.Location = new Point(20, 180);
            label11.Name = "label11";
            label11.Size = new Size(95, 28);
            label11.TabIndex = 17;
            label11.Text = "Bút danh";
            // 
            // txtCMND
            // 
            txtCMND.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCMND.Location = new Point(135, 456);
            txtCMND.Name = "txtCMND";
            txtCMND.Size = new Size(242, 36);
            txtCMND.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ActiveCaptionText;
            label10.Location = new Point(29, 464);
            label10.Name = "label10";
            label10.Size = new Size(74, 25);
            label10.TabIndex = 15;
            label10.Text = "CMMD";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(135, 390);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(242, 36);
            txtPhone.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(20, 398);
            label9.Name = "label9";
            label9.Size = new Size(106, 28);
            label9.TabIndex = 13;
            label9.Text = "Điện thoại";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(135, 340);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(242, 36);
            txtAddress.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(20, 344);
            label8.Name = "label8";
            label8.Size = new Size(73, 28);
            label8.TabIndex = 11;
            label8.Text = "Địa chỉ";
            // 
            // dateTimePickerBirtday
            // 
            dateTimePickerBirtday.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerBirtday.Format = DateTimePickerFormat.Short;
            dateTimePickerBirtday.Location = new Point(135, 283);
            dateTimePickerBirtday.Name = "dateTimePickerBirtday";
            dateTimePickerBirtday.Size = new Size(242, 32);
            dateTimePickerBirtday.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(20, 283);
            label7.Name = "label7";
            label7.Size = new Size(103, 28);
            label7.TabIndex = 9;
            label7.Text = "Ngày sinh";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(20, 230);
            label6.Name = "label6";
            label6.Size = new Size(90, 28);
            label6.TabIndex = 6;
            label6.Text = "Giới tính";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtName.Location = new Point(135, 115);
            txtName.Name = "txtName";
            txtName.Size = new Size(242, 36);
            txtName.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(20, 119);
            label5.Name = "label5";
            label5.Size = new Size(75, 28);
            label5.TabIndex = 2;
            label5.Text = "Họ tên";
            // 
            // txtAuthorId
            // 
            txtAuthorId.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAuthorId.Location = new Point(135, 53);
            txtAuthorId.Name = "txtAuthorId";
            txtAuthorId.Size = new Size(242, 36);
            txtAuthorId.TabIndex = 1;
            txtAuthorId.TextChanged += txtAuthorId_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(20, 58);
            label4.Name = "label4";
            label4.Size = new Size(105, 28);
            label4.TabIndex = 0;
            label4.Text = "Mã tác giả";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(dataGridViewBook);
            groupBox5.Location = new Point(1543, 106);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(296, 921);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            // 
            // dataGridViewBook
            // 
            dataGridViewBook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBook.Columns.AddRange(new DataGridViewColumn[] { STTBook, TenSach, MaSach, GiaTien, NgayXB, MaTacGia, TheLoai });
            dataGridViewBook.Location = new Point(6, 0);
            dataGridViewBook.Name = "dataGridViewBook";
            dataGridViewBook.RowHeadersVisible = false;
            dataGridViewBook.RowHeadersWidth = 51;
            dataGridViewBook.Size = new Size(357, 901);
            dataGridViewBook.TabIndex = 0;
            dataGridViewBook.CellContentClick += dataGridViewBook_CellContentClick;
            dataGridViewBook.DataBindingComplete += dataGridViewBook_DataBindingComplete;
            // 
            // STTBook
            // 
            STTBook.HeaderText = "STT";
            STTBook.MinimumWidth = 6;
            STTBook.Name = "STTBook";
            STTBook.Width = 50;
            // 
            // TenSach
            // 
            TenSach.DataPropertyName = "TenSach";
            TenSach.HeaderText = "Tên Sách";
            TenSach.MinimumWidth = 6;
            TenSach.Name = "TenSach";
            TenSach.Width = 125;
            // 
            // MaSach
            // 
            MaSach.DataPropertyName = "MaSach";
            MaSach.HeaderText = "Mã Sách";
            MaSach.MinimumWidth = 6;
            MaSach.Name = "MaSach";
            MaSach.Width = 125;
            // 
            // GiaTien
            // 
            GiaTien.DataPropertyName = "GiaTien";
            GiaTien.HeaderText = "Giá tiến";
            GiaTien.MinimumWidth = 6;
            GiaTien.Name = "GiaTien";
            GiaTien.Width = 125;
            // 
            // NgayXB
            // 
            NgayXB.DataPropertyName = "NgayXB";
            NgayXB.HeaderText = "Ngay XB";
            NgayXB.MinimumWidth = 6;
            NgayXB.Name = "NgayXB";
            NgayXB.Width = 125;
            // 
            // MaTacGia
            // 
            MaTacGia.DataPropertyName = "MaTacGia";
            MaTacGia.HeaderText = "Mã TG";
            MaTacGia.MinimumWidth = 6;
            MaTacGia.Name = "MaTacGia";
            MaTacGia.Width = 125;
            // 
            // TheLoai
            // 
            TheLoai.DataPropertyName = "TheLoai";
            TheLoai.HeaderText = "Thể loại";
            TheLoai.MinimumWidth = 6;
            TheLoai.Name = "TheLoai";
            TheLoai.Width = 125;
            // 
            // frAuthor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(tableLayoutPanel1);
            Name = "frAuthor";
            Text = "Tác giả";
            Load += frAuthor_Load;
            tableLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAuthor).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewBook).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private TextBox txtFilter;
        private Label label1;
        private CheckBox chkNu;
        private DataGridView dgvAuthor;
        private GroupBox groupBox2;
        private GroupBox groupBox4;
        private Button btnHuy;
        private Button btnXoa;
        private Button btnUpdate;
        private Button btnCreate;
        private GroupBox groupBox3;
        private RadioButton radioNu;
        private RadioButton radioNam;
        private TextBox txtPenName;
        private Label label11;
        private TextBox txtCMND;
        private Label label10;
        private TextBox txtPhone;
        private Label label9;
        private TextBox txtAddress;
        private Label label8;
        private DateTimePicker dateTimePickerBirtday;
        private Label label7;
        private Label label6;
        private TextBox txtName;
        private Label label5;
        private TextBox txtAuthorId;
        private Label label4;
        private GroupBox groupBox5;
        private DataGridView dataGridViewBook;
        private DataGridViewTextBoxColumn STTBook;
        private DataGridViewTextBoxColumn TenSach;
        private DataGridViewTextBoxColumn MaSach;
        private DataGridViewTextBoxColumn GiaTien;
        private DataGridViewTextBoxColumn NgayXB;
        private DataGridViewTextBoxColumn MaTacGia;
        private DataGridViewTextBoxColumn TheLoai;
        private DataGridViewTextBoxColumn SttAuthor;
        private DataGridViewTextBoxColumn AuthorID;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn BirthDate;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn PhoneNumber;
        private DataGridViewTextBoxColumn CMND;
        private DataGridViewTextBoxColumn PenName;
    }
}