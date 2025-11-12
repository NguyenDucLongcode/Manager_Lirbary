namespace WinFormsApp1
{
    partial class FrmDocGia
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
            grbTTDocGia = new GroupBox();
            txtCMND = new TextBox();
            dateTimePickerNgayLamThe = new DateTimePicker();
            txtSoDienThoai = new TextBox();
            txtDiaChi = new TextBox();
            dateTimePickerNgaySinh = new DateTimePicker();
            chkNu = new CheckBox();
            chkNam = new CheckBox();
            txtHoTen = new TextBox();
            lblCMND = new Label();
            lblSDT = new Label();
            lblNgayLamThe = new Label();
            lblDiaChi = new Label();
            lblNgaySinh = new Label();
            lblGioiTinh = new Label();
            lblHoTen = new Label();
            lblMaDG = new Label();
            txtMaDocGia = new TextBox();
            grbTimKiem = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            txtTimKiem = new TextBox();
            label1 = new Label();
            dgvDocGia = new DataGridView();
            MaDocGia = new DataGridViewTextBoxColumn();
            HoTen = new DataGridViewTextBoxColumn();
            GioiTinh = new DataGridViewTextBoxColumn();
            NgaySinh = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            SoDienThoai = new DataGridViewTextBoxColumn();
            NgayLamThe = new DataGridViewTextBoxColumn();
            CMND = new DataGridViewTextBoxColumn();
            grbChucNang = new GroupBox();
            btnHuy = new Button();
            btnChiTiet = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnCreate = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            tableLayoutPanel1.SuspendLayout();
            grbTTDocGia.SuspendLayout();
            grbTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDocGia).BeginInit();
            grbChucNang.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.5544319F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 74.44557F));
            tableLayoutPanel1.Controls.Add(grbTTDocGia, 0, 1);
            tableLayoutPanel1.Controls.Add(grbTimKiem, 1, 0);
            tableLayoutPanel1.Controls.Add(dgvDocGia, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(1904, 1033);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // grbTTDocGia
            // 
            grbTTDocGia.Controls.Add(txtCMND);
            grbTTDocGia.Controls.Add(dateTimePickerNgayLamThe);
            grbTTDocGia.Controls.Add(txtSoDienThoai);
            grbTTDocGia.Controls.Add(grbChucNang);
            grbTTDocGia.Controls.Add(txtDiaChi);
            grbTTDocGia.Controls.Add(dateTimePickerNgaySinh);
            grbTTDocGia.Controls.Add(chkNu);
            grbTTDocGia.Controls.Add(chkNam);
            grbTTDocGia.Controls.Add(txtHoTen);
            grbTTDocGia.Controls.Add(lblCMND);
            grbTTDocGia.Controls.Add(lblSDT);
            grbTTDocGia.Controls.Add(lblNgayLamThe);
            grbTTDocGia.Controls.Add(lblDiaChi);
            grbTTDocGia.Controls.Add(lblNgaySinh);
            grbTTDocGia.Controls.Add(lblGioiTinh);
            grbTTDocGia.Controls.Add(lblHoTen);
            grbTTDocGia.Controls.Add(lblMaDG);
            grbTTDocGia.Controls.Add(txtMaDocGia);
            grbTTDocGia.Dock = DockStyle.Fill;
            grbTTDocGia.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbTTDocGia.ForeColor = Color.Blue;
            grbTTDocGia.Location = new Point(3, 106);
            grbTTDocGia.Name = "grbTTDocGia";
            grbTTDocGia.Size = new Size(480, 820);
            grbTTDocGia.TabIndex = 1;
            grbTTDocGia.TabStop = false;
            grbTTDocGia.Text = "Thông Tin Độc Giả";
            // 
            // txtCMND
            // 
            txtCMND.Location = new Point(132, 344);
            txtCMND.Name = "txtCMND";
            txtCMND.Size = new Size(256, 34);
            txtCMND.TabIndex = 16;
            // 
            // dateTimePickerNgayLamThe
            // 
            dateTimePickerNgayLamThe.Format = DateTimePickerFormat.Short;
            dateTimePickerNgayLamThe.Location = new Point(133, 293);
            dateTimePickerNgayLamThe.Name = "dateTimePickerNgayLamThe";
            dateTimePickerNgayLamThe.Size = new Size(255, 34);
            dateTimePickerNgayLamThe.TabIndex = 15;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(132, 232);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(256, 34);
            txtSoDienThoai.TabIndex = 14;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(133, 185);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(255, 34);
            txtDiaChi.TabIndex = 13;
            // 
            // dateTimePickerNgaySinh
            // 
            dateTimePickerNgaySinh.Format = DateTimePickerFormat.Short;
            dateTimePickerNgaySinh.Location = new Point(133, 143);
            dateTimePickerNgaySinh.Name = "dateTimePickerNgaySinh";
            dateTimePickerNgaySinh.Size = new Size(255, 34);
            dateTimePickerNgaySinh.TabIndex = 12;
            // 
            // chkNu
            // 
            chkNu.AutoSize = true;
            chkNu.ForeColor = Color.Black;
            chkNu.Location = new Point(213, 108);
            chkNu.Name = "chkNu";
            chkNu.Size = new Size(61, 32);
            chkNu.TabIndex = 11;
            chkNu.Text = "Nữ";
            chkNu.UseVisualStyleBackColor = true;
            chkNu.CheckedChanged += chkNu_CheckedChanged;
            // 
            // chkNam
            // 
            chkNam.AutoSize = true;
            chkNam.ForeColor = Color.Black;
            chkNam.Location = new Point(133, 107);
            chkNam.Name = "chkNam";
            chkNam.Size = new Size(77, 32);
            chkNam.TabIndex = 10;
            chkNam.Text = "Nam";
            chkNam.UseVisualStyleBackColor = true;
            chkNam.CheckedChanged += chkNam_CheckedChanged;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(135, 76);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(253, 34);
            txtHoTen.TabIndex = 9;
            // 
            // lblCMND
            // 
            lblCMND.AutoSize = true;
            lblCMND.ForeColor = Color.Black;
            lblCMND.Location = new Point(14, 344);
            lblCMND.Name = "lblCMND";
            lblCMND.Size = new Size(71, 28);
            lblCMND.TabIndex = 8;
            lblCMND.Text = "CMND";
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.ForeColor = Color.Black;
            lblSDT.Location = new Point(14, 234);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(89, 56);
            lblSDT.TabIndex = 7;
            lblSDT.Text = "Số Điện \r\nThoại";
            // 
            // lblNgayLamThe
            // 
            lblNgayLamThe.AutoSize = true;
            lblNgayLamThe.ForeColor = Color.Black;
            lblNgayLamThe.Location = new Point(14, 293);
            lblNgayLamThe.Name = "lblNgayLamThe";
            lblNgayLamThe.Size = new Size(103, 56);
            lblNgayLamThe.TabIndex = 6;
            lblNgayLamThe.Text = "Ngày Làm\r\nThẻ";
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.ForeColor = Color.Black;
            lblDiaChi.Location = new Point(14, 187);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(76, 28);
            lblDiaChi.TabIndex = 5;
            lblDiaChi.Text = "Địa Chỉ";
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.ForeColor = Color.Black;
            lblNgaySinh.Location = new Point(12, 147);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(105, 28);
            lblNgaySinh.TabIndex = 4;
            lblNgaySinh.Text = "Ngày Sinh";
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.AutoSize = true;
            lblGioiTinh.ForeColor = Color.Black;
            lblGioiTinh.Location = new Point(13, 108);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(94, 28);
            lblGioiTinh.TabIndex = 3;
            lblGioiTinh.Text = "Giới Tính";
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.ForeColor = Color.Black;
            lblHoTen.Location = new Point(13, 76);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(77, 28);
            lblHoTen.TabIndex = 2;
            lblHoTen.Text = "Họ Tên";
            // 
            // lblMaDG
            // 
            lblMaDG.AutoSize = true;
            lblMaDG.ForeColor = Color.Black;
            lblMaDG.Location = new Point(12, 38);
            lblMaDG.Name = "lblMaDG";
            lblMaDG.Size = new Size(116, 28);
            lblMaDG.TabIndex = 1;
            lblMaDG.Text = "Mã Độc Giả";
            // 
            // txtMaDocGia
            // 
            txtMaDocGia.Location = new Point(135, 33);
            txtMaDocGia.Name = "txtMaDocGia";
            txtMaDocGia.Size = new Size(253, 34);
            txtMaDocGia.TabIndex = 0;
            // 
            // grbTimKiem
            // 
            grbTimKiem.BackColor = SystemColors.ButtonFace;
            grbTimKiem.Controls.Add(label3);
            grbTimKiem.Controls.Add(label2);
            grbTimKiem.Controls.Add(txtTimKiem);
            grbTimKiem.Controls.Add(label1);
            grbTimKiem.Dock = DockStyle.Fill;
            grbTimKiem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbTimKiem.ForeColor = Color.Blue;
            grbTimKiem.Location = new Point(489, 3);
            grbTimKiem.Name = "grbTimKiem";
            grbTimKiem.Size = new Size(1412, 97);
            grbTimKiem.TabIndex = 4;
            grbTimKiem.TabStop = false;
            grbTimKiem.Text = "Tìm kiếm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(14, 38);
            label3.Name = "label3";
            label3.Size = new Size(183, 23);
            label3.TabIndex = 3;
            label3.Text = "Tìm kiếm theo Tên/Mã";
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
            // dgvDocGia
            // 
            dgvDocGia.AllowUserToOrderColumns = true;
            dgvDocGia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDocGia.Columns.AddRange(new DataGridViewColumn[] { MaDocGia, HoTen, GioiTinh, NgaySinh, DiaChi, SoDienThoai, NgayLamThe, CMND });
            dgvDocGia.Dock = DockStyle.Fill;
            dgvDocGia.Location = new Point(489, 106);
            dgvDocGia.Name = "dgvDocGia";
            dgvDocGia.RowHeadersWidth = 51;
            dgvDocGia.Size = new Size(1412, 820);
            dgvDocGia.TabIndex = 5;
            dgvDocGia.CellClick += dgvDocGia_CellClick;
            // 
            // MaDocGia
            // 
            MaDocGia.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaDocGia.DataPropertyName = "MaDocGia";
            MaDocGia.HeaderText = "Mã Độc Giả";
            MaDocGia.MinimumWidth = 6;
            MaDocGia.Name = "MaDocGia";
            // 
            // HoTen
            // 
            HoTen.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            HoTen.DataPropertyName = "HoTen";
            HoTen.HeaderText = "Họ Tên";
            HoTen.MinimumWidth = 6;
            HoTen.Name = "HoTen";
            // 
            // GioiTinh
            // 
            GioiTinh.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            GioiTinh.DataPropertyName = "GioiTinh";
            GioiTinh.HeaderText = "Giới Tính";
            GioiTinh.MinimumWidth = 6;
            GioiTinh.Name = "GioiTinh";
            // 
            // NgaySinh
            // 
            NgaySinh.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NgaySinh.DataPropertyName = "NgaySinh";
            NgaySinh.HeaderText = "Ngày Sinh";
            NgaySinh.MinimumWidth = 6;
            NgaySinh.Name = "NgaySinh";
            // 
            // DiaChi
            // 
            DiaChi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DiaChi.DataPropertyName = "DiaChi";
            DiaChi.HeaderText = "Địa Chỉ";
            DiaChi.MinimumWidth = 6;
            DiaChi.Name = "DiaChi";
            // 
            // SoDienThoai
            // 
            SoDienThoai.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SoDienThoai.DataPropertyName = "SoDienThoai";
            SoDienThoai.HeaderText = "Số Điện Thoại";
            SoDienThoai.MinimumWidth = 6;
            SoDienThoai.Name = "SoDienThoai";
            // 
            // NgayLamThe
            // 
            NgayLamThe.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NgayLamThe.DataPropertyName = "NgayLamThe";
            NgayLamThe.HeaderText = "Ngày Làm Thẻ";
            NgayLamThe.MinimumWidth = 6;
            NgayLamThe.Name = "NgayLamThe";
            // 
            // CMND
            // 
            CMND.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CMND.DataPropertyName = "CMND";
            CMND.HeaderText = "CMND";
            CMND.MinimumWidth = 6;
            CMND.Name = "CMND";
            // 
            // grbChucNang
            // 
            grbChucNang.Controls.Add(btnHuy);
            grbChucNang.Controls.Add(btnChiTiet);
            grbChucNang.Controls.Add(btnXoa);
            grbChucNang.Controls.Add(btnSua);
            grbChucNang.Controls.Add(btnCreate);
            grbChucNang.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbChucNang.ForeColor = Color.Blue;
            grbChucNang.Location = new Point(9, 410);
            grbChucNang.Name = "grbChucNang";
            grbChucNang.Size = new Size(471, 237);
            grbChucNang.TabIndex = 4;
            grbChucNang.TabStop = false;
            grbChucNang.Text = "Chức năng";
            // 
            // btnHuy
            // 
            btnHuy.ForeColor = Color.Black;
            btnHuy.Location = new Point(29, 184);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(103, 47);
            btnHuy.TabIndex = 4;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnChiTiet
            // 
            btnChiTiet.ForeColor = Color.Black;
            btnChiTiet.Location = new Point(29, 113);
            btnChiTiet.Name = "btnChiTiet";
            btnChiTiet.Size = new Size(103, 47);
            btnChiTiet.TabIndex = 3;
            btnChiTiet.Text = "Chi tiết";
            btnChiTiet.UseVisualStyleBackColor = true;
            btnChiTiet.Click += btnChiTiet_Click;
            // 
            // btnXoa
            // 
            btnXoa.ForeColor = Color.Black;
            btnXoa.Location = new Point(165, 113);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(103, 47);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.ForeColor = Color.Black;
            btnSua.Location = new Point(164, 36);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(103, 47);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnCreate
            // 
            btnCreate.ForeColor = Color.Black;
            btnCreate.Location = new Point(29, 36);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(103, 47);
            btnCreate.TabIndex = 0;
            btnCreate.Text = "Thêm ";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // FrmDocGia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1033);
            Controls.Add(tableLayoutPanel1);
            Name = "FrmDocGia";
            Text = "FrmDocGia";
            tableLayoutPanel1.ResumeLayout(false);
            grbTTDocGia.ResumeLayout(false);
            grbTTDocGia.PerformLayout();
            grbTimKiem.ResumeLayout(false);
            grbTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDocGia).EndInit();
            grbChucNang.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox grbTTDocGia;
        private TextBox txtCMND;
        private DateTimePicker dateTimePickerNgayLamThe;
        private TextBox txtSoDienThoai;
        private TextBox txtDiaChi;
        private DateTimePicker dateTimePickerNgaySinh;
        private CheckBox chkNu;
        private CheckBox chkNam;
        private TextBox txtHoTen;
        private Label lblCMND;
        private Label lblSDT;
        private Label lblNgayLamThe;
        private Label lblDiaChi;
        private Label lblNgaySinh;
        private Label lblGioiTinh;
        private Label lblHoTen;
        private Label lblMaDG;
        private TextBox txtMaDocGia;
        private GroupBox grbTimKiem;
        private Label label3;
        private Label label2;
        private TextBox txtTimKiem;
        private Label label1;
        private GroupBox grbChucNang;
        private Button btnHuy;
        private Button btnChiTiet;
        private Button btnXoa;
        private Button btnSua;
        private Button btnCreate;
        private DataGridView dgvDocGia;
        private DataGridViewTextBoxColumn MaDocGia;
        private DataGridViewTextBoxColumn HoTen;
        private DataGridViewTextBoxColumn GioiTinh;
        private DataGridViewTextBoxColumn NgaySinh;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn SoDienThoai;
        private DataGridViewTextBoxColumn NgayLamThe;
        private DataGridViewTextBoxColumn CMND;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}