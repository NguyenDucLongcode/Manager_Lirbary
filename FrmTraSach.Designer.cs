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
            dateTimePickerNgayMuon = new DateTimePicker();
            label8 = new Label();
            comboBoxMaDocGia = new ComboBox();
            comboBoxMaSach = new ComboBox();
            dateTimePickerNgayTraDuKien = new DateTimePicker();
            label6 = new Label();
            label12 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            checkBoxDungHan = new CheckBox();
            checkBoxTraSom = new CheckBox();
            checkBoxTraTre = new CheckBox();
            label3 = new Label();
            label2 = new Label();
            txtTimKiem = new TextBox();
            label1 = new Label();
            dgvTraSach = new DataGridView();
            SttTraSach = new DataGridViewTextBoxColumn();
            MaSach = new DataGridViewTextBoxColumn();
            MaDocGia = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            NgayMuon = new DataGridViewTextBoxColumn();
            NgayTraDuKien = new DataGridViewTextBoxColumn();
            NgayTraThucTe = new DataGridViewTextBoxColumn();
            TinhTrang = new DataGridViewTextBoxColumn();
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
            dateTimePickerNgayTraThucTe.Format = DateTimePickerFormat.Short;
            dateTimePickerNgayTraThucTe.Location = new Point(152, 321);
            dateTimePickerNgayTraThucTe.Name = "dateTimePickerNgayTraThucTe";
            dateTimePickerNgayTraThucTe.Size = new Size(271, 34);
            dateTimePickerNgayTraThucTe.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(25, 321);
            label7.Name = "label7";
            label7.Size = new Size(84, 46);
            label7.TabIndex = 9;
            label7.Text = "Ngày Trả \r\nThực Tế";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSoLuong.Location = new Point(152, 165);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(271, 36);
            txtSoLuong.TabIndex = 3;
            txtSoLuong.KeyPress += txtSoLuong_KeyPress;
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
            groupBox3.Controls.Add(dateTimePickerNgayMuon);
            groupBox3.Controls.Add(label8);
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
            groupBox3.Location = new Point(24, 15);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(441, 414);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin trả sách";
            // 
            // dateTimePickerNgayMuon
            // 
            dateTimePickerNgayMuon.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerNgayMuon.Format = DateTimePickerFormat.Short;
            dateTimePickerNgayMuon.ImeMode = ImeMode.NoControl;
            dateTimePickerNgayMuon.Location = new Point(153, 217);
            dateTimePickerNgayMuon.Margin = new Padding(2);
            dateTimePickerNgayMuon.Name = "dateTimePickerNgayMuon";
            dateTimePickerNgayMuon.Size = new Size(272, 34);
            dateTimePickerNgayMuon.TabIndex = 12;
            dateTimePickerNgayMuon.CloseUp += ComboBox_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(25, 227);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(103, 23);
            label8.TabIndex = 11;
            label8.Text = "Ngày Mượn";
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
            comboBoxMaDocGia.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
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
            comboBoxMaSach.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            // 
            // dateTimePickerNgayTraDuKien
            // 
            dateTimePickerNgayTraDuKien.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerNgayTraDuKien.Format = DateTimePickerFormat.Short;
            dateTimePickerNgayTraDuKien.Location = new Point(152, 265);
            dateTimePickerNgayTraDuKien.Name = "dateTimePickerNgayTraDuKien";
            dateTimePickerNgayTraDuKien.Size = new Size(271, 34);
            dateTimePickerNgayTraDuKien.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(25, 265);
            label6.Name = "label6";
            label6.Size = new Size(84, 46);
            label6.TabIndex = 9;
            label6.Text = "Ngày Trả \r\nDự Kiến";
            label6.Click += label6_Click;
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
            tableLayoutPanel1.Controls.Add(dgvTraSach, 1, 1);
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
            groupBox1.Controls.Add(checkBoxDungHan);
            groupBox1.Controls.Add(checkBoxTraSom);
            groupBox1.Controls.Add(checkBoxTraTre);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtTimKiem);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Blue;
            groupBox1.Location = new Point(489, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(658, 97);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm";
            // 
            // checkBoxDungHan
            // 
            checkBoxDungHan.AutoSize = true;
            checkBoxDungHan.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBoxDungHan.ForeColor = Color.Green;
            checkBoxDungHan.Location = new Point(450, 32);
            checkBoxDungHan.Margin = new Padding(2);
            checkBoxDungHan.Name = "checkBoxDungHan";
            checkBoxDungHan.Size = new Size(178, 24);
            checkBoxDungHan.TabIndex = 6;
            checkBoxDungHan.Text = "Hiển thị trả đúng hạn";
            checkBoxDungHan.UseVisualStyleBackColor = true;
            checkBoxDungHan.CheckedChanged += CheckBoxFilter_CheckedChanged;
            // 
            // checkBoxTraSom
            // 
            checkBoxTraSom.AutoSize = true;
            checkBoxTraSom.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBoxTraSom.ForeColor = Color.Orange;
            checkBoxTraSom.Location = new Point(281, 50);
            checkBoxTraSom.Margin = new Padding(2);
            checkBoxTraSom.Name = "checkBoxTraSom";
            checkBoxTraSom.Size = new Size(174, 24);
            checkBoxTraSom.TabIndex = 5;
            checkBoxTraSom.Text = "Hiển thị sách trả sớm";
            checkBoxTraSom.UseVisualStyleBackColor = true;
            checkBoxTraSom.CheckedChanged += CheckBoxFilter_CheckedChanged;
            // 
            // checkBoxTraTre
            // 
            checkBoxTraTre.AutoSize = true;
            checkBoxTraTre.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBoxTraTre.ForeColor = Color.Red;
            checkBoxTraTre.Location = new Point(281, 22);
            checkBoxTraTre.Margin = new Padding(2);
            checkBoxTraTre.Name = "checkBoxTraTre";
            checkBoxTraTre.Size = new Size(165, 24);
            checkBoxTraTre.TabIndex = 4;
            checkBoxTraTre.Text = "Hiển thị sách trả trễ";
            checkBoxTraTre.UseVisualStyleBackColor = true;
            checkBoxTraTre.CheckedChanged += checkBoxTraTre_CheckedChanged;
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
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
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
            // dgvTraSach
            // 
            dgvTraSach.AllowUserToOrderColumns = true;
            dgvTraSach.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvTraSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTraSach.Columns.AddRange(new DataGridViewColumn[] { SttTraSach, MaSach, MaDocGia, SoLuong, NgayMuon, NgayTraDuKien, NgayTraThucTe, TinhTrang });
            dgvTraSach.Cursor = Cursors.Hand;
            dgvTraSach.Location = new Point(489, 106);
            dgvTraSach.Name = "dgvTraSach";
            dgvTraSach.RowHeadersWidth = 51;
            dgvTraSach.Size = new Size(1412, 921);
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
            MaDocGia.DataPropertyName = "MaDocGia";
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
            // TinhTrang
            // 
            TinhTrang.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TinhTrang.DataPropertyName = "TinhTrang";
            TinhTrang.HeaderText = "Tình Trạng";
            TinhTrang.MinimumWidth = 6;
            TinhTrang.Name = "TinhTrang";
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
            groupBox4.Location = new Point(17, 449);
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
            btnHuy.Click += btnHuy_Click;
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
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(25, 106);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(103, 47);
            btnCreate.TabIndex = 0;
            btnCreate.Text = "Thêm ";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // FrmTraSach
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1539, 840);
            Controls.Add(tableLayoutPanel1);
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
        private CheckBox checkBoxTraTre;
        private DataGridViewTextBoxColumn SttTraSach;
        private DataGridViewTextBoxColumn MaSach;
        private DataGridViewTextBoxColumn MaDocGia;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn NgayMuon;
        private DataGridViewTextBoxColumn NgayTraDuKien;
        private DataGridViewTextBoxColumn NgayTraThucTe;
        private DataGridViewTextBoxColumn TinhTrang;
        private DateTimePicker dateTimePickerNgayMuon;
        private Label label8;
        private CheckBox checkBoxTraSom;
        private CheckBox checkBoxDungHan;
    }
}