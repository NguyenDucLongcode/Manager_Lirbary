namespace WinFormsApp1
{
    partial class FrmMuonSach
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
            dateTimePickerNgayTra = new DateTimePicker();
            label7 = new Label();
            txtSoLuong = new TextBox();
            label5 = new Label();
            label4 = new Label();
            groupBox3 = new GroupBox();
            comboBoxMaDocGia = new ComboBox();
            comboBoxMaSach = new ComboBox();
            dateTimePickerNgayMuon = new DateTimePicker();
            label6 = new Label();
            label12 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            txtTimKiem = new TextBox();
            label1 = new Label();
            dgvMuonSach = new DataGridView();
            SttMuonSach = new DataGridViewTextBoxColumn();
            MaSach = new DataGridViewTextBoxColumn();
            MaDocGia = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            NgayMuon = new DataGridViewTextBoxColumn();
            NgayTra = new DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)dgvMuonSach).BeginInit();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // dateTimePickerNgayTra
            // 
            dateTimePickerNgayTra.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerNgayTra.Format = DateTimePickerFormat.Short;
            dateTimePickerNgayTra.Location = new Point(154, 275);
            dateTimePickerNgayTra.Name = "dateTimePickerNgayTra";
            dateTimePickerNgayTra.Size = new Size(271, 34);
            dateTimePickerNgayTra.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(28, 279);
            label7.Name = "label7";
            label7.Size = new Size(100, 30);
            label7.TabIndex = 9;
            label7.Text = "Ngày Trả";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSoLuong.Location = new Point(152, 165);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(271, 36);
            txtSoLuong.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(25, 168);
            label5.Name = "label5";
            label5.Size = new Size(108, 30);
            label5.TabIndex = 2;
            label5.Text = "Số Lượng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(20, 58);
            label4.Name = "label4";
            label4.Size = new Size(97, 30);
            label4.TabIndex = 0;
            label4.Text = "Tên sách";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(comboBoxMaDocGia);
            groupBox3.Controls.Add(comboBoxMaSach);
            groupBox3.Controls.Add(dateTimePickerNgayMuon);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(dateTimePickerNgayTra);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(txtSoLuong);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = Color.Blue;
            groupBox3.Location = new Point(24, 15);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(441, 414);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin sách";
            // 
            // comboBoxMaDocGia
            // 
            comboBoxMaDocGia.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxMaDocGia.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxMaDocGia.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxMaDocGia.FormattingEnabled = true;
            comboBoxMaDocGia.Location = new Point(153, 108);
            comboBoxMaDocGia.Name = "comboBoxMaDocGia";
            comboBoxMaDocGia.Size = new Size(272, 31);
            comboBoxMaDocGia.TabIndex = 21;
            // 
            // comboBoxMaSach
            // 
            comboBoxMaSach.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxMaSach.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxMaSach.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxMaSach.FormattingEnabled = true;
            comboBoxMaSach.Location = new Point(152, 57);
            comboBoxMaSach.Name = "comboBoxMaSach";
            comboBoxMaSach.Size = new Size(272, 31);
            comboBoxMaSach.TabIndex = 20;
            // 
            // dateTimePickerNgayMuon
            // 
            dateTimePickerNgayMuon.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerNgayMuon.Format = DateTimePickerFormat.Short;
            dateTimePickerNgayMuon.Location = new Point(152, 223);
            dateTimePickerNgayMuon.Name = "dateTimePickerNgayMuon";
            dateTimePickerNgayMuon.Size = new Size(271, 34);
            dateTimePickerNgayMuon.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(20, 223);
            label6.Name = "label6";
            label6.Size = new Size(131, 30);
            label6.TabIndex = 9;
            label6.Text = "Ngày Mượn";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.ActiveCaptionText;
            label12.Location = new Point(20, 109);
            label12.Name = "label12";
            label12.Size = new Size(126, 30);
            label12.TabIndex = 2;
            label12.Text = "Tên độc giả";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.5544319F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 74.44557F));
            tableLayoutPanel1.Controls.Add(groupBox1, 1, 0);
            tableLayoutPanel1.Controls.Add(dgvMuonSach, 1, 1);
            tableLayoutPanel1.Controls.Add(groupBox2, 0, 1);
            tableLayoutPanel1.Location = new Point(-1, 1);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel1.Size = new Size(1904, 1030);
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
            label3.Size = new Size(191, 23);
            label3.TabIndex = 3;
            label3.Text = "Tìm kiếm theo Mã Sách";
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
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTimKiem.Location = new Point(20, 64);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(223, 25);
            txtTimKiem.TabIndex = 1;
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
            // dgvMuonSach
            // 
            dgvMuonSach.AllowUserToOrderColumns = true;
            dgvMuonSach.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvMuonSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMuonSach.Columns.AddRange(new DataGridViewColumn[] { SttMuonSach, MaSach, MaDocGia, SoLuong, NgayMuon, NgayTra });
            dgvMuonSach.Cursor = Cursors.Hand;
            dgvMuonSach.Location = new Point(489, 106);
            dgvMuonSach.Name = "dgvMuonSach";
            dgvMuonSach.RowHeadersWidth = 51;
            dgvMuonSach.Size = new Size(1412, 921);
            dgvMuonSach.TabIndex = 2;
            dgvMuonSach.CellClick += dgvMuonSach_CellClick;
            dgvMuonSach.DataBindingComplete += dgvMuonSach_DataBindingComplete;
            // 
            // SttMuonSach
            // 
            SttMuonSach.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SttMuonSach.HeaderText = "STT";
            SttMuonSach.MinimumWidth = 6;
            SttMuonSach.Name = "SttMuonSach";
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
            // NgayMuon
            // 
            NgayMuon.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NgayMuon.DataPropertyName = "NgayMuon";
            NgayMuon.HeaderText = "Ngày Mượn";
            NgayMuon.MinimumWidth = 6;
            NgayMuon.Name = "NgayMuon";
            // 
            // NgayTra
            // 
            NgayTra.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NgayTra.DataPropertyName = "NgayTra";
            NgayTra.HeaderText = "Ngày Trả";
            NgayTra.MinimumWidth = 6;
            NgayTra.Name = "NgayTra";
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
            groupBox4.Location = new Point(24, 465);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(441, 363);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Chức năng";
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(25, 266);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(103, 47);
            btnHuy.TabIndex = 7;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnLamMoi_Click;
            // 
            // btnDetail
            // 
            btnDetail.Location = new Point(25, 184);
            btnDetail.Name = "btnDetail";
            btnDetail.Size = new Size(103, 47);
            btnDetail.TabIndex = 6;
            btnDetail.Text = "Chi tiết";
            btnDetail.UseVisualStyleBackColor = true;
            btnDetail.Click += btnDetail_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(240, 184);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(103, 47);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(241, 106);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(103, 47);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnSua_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(25, 106);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(103, 47);
            btnCreate.TabIndex = 0;
            btnCreate.Text = "Thêm ";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnThem_Click;
            // 
            // FrmMuonSach
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(tableLayoutPanel1);
            Name = "FrmMuonSach";
            Text = "FrmMuonSach";
            Load += FrmMuonSach_Load;
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMuonSach).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DateTimePicker dateTimePickerNgayTra;
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
        private DataGridView dgvMuonSach;
        private GroupBox groupBox2;
        private GroupBox groupBox4;
        private Button btnUpdate;
        private Button btnCreate;
        private DateTimePicker dateTimePickerNgayMuon;
        private Label label6;
        private Button btnHuy;
        private Button btnDetail;
        private Button btnXoa;
        private Label label12;
        private ComboBox comboBoxMaDocGia;
        private ComboBox comboBoxMaSach;
        private DataGridViewTextBoxColumn SttMuonSach;
        private DataGridViewTextBoxColumn MaSach;
        private DataGridViewTextBoxColumn MaDocGia;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn NgayMuon;
        private DataGridViewTextBoxColumn NgayTra;
    }
}