namespace WinFormsApp1
{
    partial class FrmTraSach
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            dateTimePickerNgayTraThucTe = new DateTimePicker();
            label7 = new Label();
            txtSoLuong = new TextBox();
            label5 = new Label();
            label4 = new Label();
            groupBox3 = new GroupBox();
            comboBoxMaDocGia = new ComboBox();
            comboBoxMaSach = new ComboBox();
            dateTimePickerNgayTraDuKien = new DateTimePicker();
            label6 = new Label();
            label12 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            txtTimKiem = new TextBox();
            label1 = new Label();
            dgvTraSach = new DataGridView();
            SttTraSach = new DataGridViewTextBoxColumn();
            MaSach = new DataGridViewTextBoxColumn();
            MaDocGia = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            NgayTraDuKien = new DataGridViewTextBoxColumn();
            NgayTraThucTe = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            groupBox4 = new GroupBox();
            btnHuy = new Button();
            btnDetail = new Button();
            btnXoa = new Button();
            btnUpdate = new Button();
            btnCreate = new Button();
            groupBox3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTraSach).BeginInit();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // dateTimePickerNgayTraThucTe
            // 
            dateTimePickerNgayTraThucTe.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerNgayTraThucTe.Location = new Point(192, 344);
            dateTimePickerNgayTraThucTe.Margin = new Padding(4, 4, 4, 4);
            dateTimePickerNgayTraThucTe.Name = "dateTimePickerNgayTraThucTe";
            dateTimePickerNgayTraThucTe.Size = new Size(338, 39);
            dateTimePickerNgayTraThucTe.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(35, 349);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(220, 36);
            label7.TabIndex = 9;
            label7.Text = "Ngày Trả Thực Tế";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSoLuong.Location = new Point(190, 206);
            txtSoLuong.Margin = new Padding(4, 4, 4, 4);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(338, 42);
            txtSoLuong.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(31, 210);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(128, 36);
            label5.TabIndex = 2;
            label5.Text = "Số Lượng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(25, 72);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(114, 36);
            label4.TabIndex = 0;
            label4.Text = "Tên sách";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(comboBoxMaDocGia);
            groupBox3.Controls.Add(comboBoxMaSach);
            groupBox3.Controls.Add(dateTimePickerNgayTraDuKien);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(dateTimePickerNgayTraThucTe);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(txtSoLuong);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = Color.Blue;
            groupBox3.Location = new Point(30, 19);
            groupBox3.Margin = new Padding(4, 4, 4, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 4, 4, 4);
            groupBox3.Size = new Size(551, 518);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin trả sách";
            // 
            // comboBoxMaDocGia
            // 
            comboBoxMaDocGia.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxMaDocGia.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxMaDocGia.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxMaDocGia.FormattingEnabled = true;
            comboBoxMaDocGia.Location = new Point(191, 135);
            comboBoxMaDocGia.Margin = new Padding(4, 4, 4, 4);
            comboBoxMaDocGia.Name = "comboBoxMaDocGia";
            comboBoxMaDocGia.Size = new Size(339, 36);
            comboBoxMaDocGia.TabIndex = 21;
            // 
            // comboBoxMaSach
            // 
            comboBoxMaSach.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxMaSach.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxMaSach.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxMaSach.FormattingEnabled = true;
            comboBoxMaSach.Location = new Point(190, 71);
            comboBoxMaSach.Margin = new Padding(4, 4, 4, 4);
            comboBoxMaSach.Name = "comboBoxMaSach";
            comboBoxMaSach.Size = new Size(339, 36);
            comboBoxMaSach.TabIndex = 20;
            // 
            // dateTimePickerNgayTraDuKien
            // 
            dateTimePickerNgayTraDuKien.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerNgayTraDuKien.Location = new Point(190, 279);
            dateTimePickerNgayTraDuKien.Margin = new Padding(4, 4, 4, 4);
            dateTimePickerNgayTraDuKien.Name = "dateTimePickerNgayTraDuKien";
            dateTimePickerNgayTraDuKien.Size = new Size(338, 39);
            dateTimePickerNgayTraDuKien.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(25, 279);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(222, 36);
            label6.TabIndex = 9;
            label6.Text = "Ngày Trả Dự Kiến";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.ActiveCaptionText;
            label12.Location = new Point(25, 136);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(150, 36);
            label12.TabIndex = 2;
            label12.Text = "Tên độc giả";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.5544319F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 74.44557F));
            tableLayoutPanel1.Controls.Add(groupBox1, 1, 0);
            tableLayoutPanel1.Controls.Add(dgvTraSach, 1, 1);
            tableLayoutPanel1.Controls.Add(groupBox2, 0, 1);
            tableLayoutPanel1.Location = new Point(-1, 1);
            tableLayoutPanel1.Margin = new Padding(4, 4, 4, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel1.Size = new Size(2380, 1288);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonFace;
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtTimKiem);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Blue;
            groupBox1.Location = new Point(612, 4);
            groupBox1.Margin = new Padding(4, 4, 4, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 4, 4, 4);
            groupBox1.Size = new Size(340, 120);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(18, 48);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(237, 30);
            label3.TabIndex = 3;
            label3.Text = "Tìm kiếm theo Mã Sách";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(19, 49);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 32);
            label2.TabIndex = 2;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTimKiem.Location = new Point(25, 80);
            txtTimKiem.Margin = new Padding(4, 4, 4, 4);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(278, 28);
            txtTimKiem.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(18, 59);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 21);
            label1.TabIndex = 0;
            // 
            // dgvTraSach
            // 
            dgvTraSach.AllowUserToOrderColumns = true;
            dgvTraSach.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvTraSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTraSach.Columns.AddRange(new DataGridViewColumn[] { SttTraSach, MaSach, MaDocGia, SoLuong, NgayTraDuKien, NgayTraThucTe });
            dgvTraSach.Cursor = Cursors.Hand;
            dgvTraSach.Location = new Point(612, 132);
            dgvTraSach.Margin = new Padding(4, 4, 4, 4);
            dgvTraSach.Name = "dgvTraSach";
            dgvTraSach.RowHeadersWidth = 51;
            dgvTraSach.Size = new Size(1764, 1152);
            dgvTraSach.TabIndex = 2;
            dgvTraSach.CellClick += dgvTraSach_CellClick;
            dgvTraSach.DataBindingComplete += dgvTraSach_DataBindingComplete;
            // 
            // SttTraSach
            // 
            SttTraSach.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SttTraSach.HeaderText = "STT";
            SttTraSach.MinimumWidth = 6;
            SttTraSach.Name = "SttTraSach";
            // 
            // MaSach
            // 
            MaSach.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaSach.DataPropertyName = "MaSach";
            MaSach.HeaderText = "Mã Sách";
            MaSach.MinimumWidth = 6;
            MaSach.Name = "MaSach";
            // 
            // MaDocGia
            // 
            MaDocGia.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaDocGia.HeaderText = "Mã Độc Giả";
            MaDocGia.MinimumWidth = 6;
            MaDocGia.Name = "MaDocGia";
            // 
            // SoLuong
            // 
            SoLuong.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SoLuong.DataPropertyName = "SoLuong";
            SoLuong.HeaderText = "Số Lượng";
            SoLuong.MinimumWidth = 6;
            SoLuong.Name = "SoLuong";
            // 
            // NgayTraDuKien
            // 
            NgayTraDuKien.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NgayTraDuKien.DataPropertyName = "NgayTraDuKien";
            NgayTraDuKien.HeaderText = "Ngày Trả Dự Kiến";
            NgayTraDuKien.MinimumWidth = 6;
            NgayTraDuKien.Name = "NgayTraDuKien";
            // 
            // NgayTraThucTe
            // 
            NgayTraThucTe.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NgayTraThucTe.DataPropertyName = "NgayTraThucTe";
            NgayTraThucTe.HeaderText = "Ngày Trả Thực Tế";
            NgayTraThucTe.MinimumWidth = 6;
            NgayTraThucTe.Name = "NgayTraThucTe";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(4, 132);
            groupBox2.Margin = new Padding(4, 4, 4, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 4, 4, 4);
            groupBox2.Size = new Size(600, 1151);
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
            groupBox4.Location = new Point(21, 561);
            groupBox4.Margin = new Padding(4, 4, 4, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4, 4, 4, 4);
            groupBox4.Size = new Size(551, 454);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Chức năng";
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(31, 332);
            btnHuy.Margin = new Padding(4, 4, 4, 4);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(129, 59);
            btnHuy.TabIndex = 7;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnDetail
            // 
            btnDetail.Location = new Point(31, 230);
            btnDetail.Margin = new Padding(4, 4, 4, 4);
            btnDetail.Name = "btnDetail";
            btnDetail.Size = new Size(129, 59);
            btnDetail.TabIndex = 6;
            btnDetail.Text = "Chi tiết";
            btnDetail.UseVisualStyleBackColor = true;
            btnDetail.Click += btnDetail_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(300, 230);
            btnXoa.Margin = new Padding(4, 4, 4, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(129, 59);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(301, 132);
            btnUpdate.Margin = new Padding(4, 4, 4, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(129, 59);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(31, 132);
            btnCreate.Margin = new Padding(4, 4, 4, 4);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(129, 59);
            btnCreate.TabIndex = 0;
            btnCreate.Text = "Thêm ";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // FrmTraSach
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1050);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "FrmTraSach";
            Text = "Quản Lý Trả Sách";
            Load += FrmTraSach_Load;
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTraSach).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DateTimePicker dateTimePickerNgayTraThucTe;
        private Label label7;
        private TextBox txtSoLuong;
        private Label label5;
        private Label label4;
        private GroupBox groupBox3;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private TextBox txtTimKiem;
        private Label label1;
        private DataGridView dgvTraSach;
        private GroupBox groupBox2;
        private GroupBox groupBox4;
        private Button btnUpdate;
        private Button btnCreate;
        private DateTimePicker dateTimePickerNgayTraDuKien;
        private Label label6;
        private Button btnHuy;
        private Button btnDetail;
        private Button btnXoa;
        private Label label12;
        private ComboBox comboBoxMaDocGia;
        private ComboBox comboBoxMaSach;
        private DataGridViewTextBoxColumn SttTraSach;
        private DataGridViewTextBoxColumn MaSach;
        private DataGridViewTextBoxColumn MaDocGia;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn NgayTraDuKien;
        private DataGridViewTextBoxColumn NgayTraThucTe;
    }
}