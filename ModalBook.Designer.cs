namespace WinFormsApp1
{
    partial class ModalBook
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
            groupBox3 = new GroupBox();
            txtNgayXB = new TextBox();
            txtTacGia = new TextBox();
            txtTheLoai = new TextBox();
            btnDong = new Button();
            label11 = new Label();
            txtGiaTien = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            txtTenSach = new TextBox();
            label5 = new Label();
            txtMaSach = new TextBox();
            label4 = new Label();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtNgayXB);
            groupBox3.Controls.Add(txtTacGia);
            groupBox3.Controls.Add(txtTheLoai);
            groupBox3.Controls.Add(btnDong);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(txtGiaTien);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(txtTenSach);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(txtMaSach);
            groupBox3.Controls.Add(label4);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = Color.Blue;
            groupBox3.Location = new Point(0, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(461, 468);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin sách";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // txtNgayXB
            // 
            txtNgayXB.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNgayXB.Location = new Point(151, 234);
            txtNgayXB.Name = "txtNgayXB";
            txtNgayXB.Size = new Size(271, 36);
            txtNgayXB.TabIndex = 24;
            // 
            // txtTacGia
            // 
            txtTacGia.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTacGia.Location = new Point(152, 295);
            txtTacGia.Name = "txtTacGia";
            txtTacGia.Size = new Size(271, 36);
            txtTacGia.TabIndex = 23;
            // 
            // txtTheLoai
            // 
            txtTheLoai.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTheLoai.Location = new Point(151, 180);
            txtTheLoai.Name = "txtTheLoai";
            txtTheLoai.Size = new Size(271, 36);
            txtTheLoai.TabIndex = 22;
            // 
            // btnDong
            // 
            btnDong.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDong.Location = new Point(328, 415);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(94, 41);
            btnDong.TabIndex = 21;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            btnDong.Click += btnDong_Click;
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
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(19, 295);
            label8.Name = "label8";
            label8.Size = new Size(82, 30);
            label8.TabIndex = 11;
            label8.Text = "Tác Giả";
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
            // ModalBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 468);
            Controls.Add(groupBox3);
            Name = "ModalBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ModalBook";
            Load += ModalBook_Load;
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox3;
        private Label label11;
        private TextBox txtGiaTien;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox txtTenSach;
        private Label label5;
        private TextBox txtMaSach;
        private Label label4;
        private Button btnDong;
        private TextBox txtTheLoai;
        private TextBox txtTacGia;
        private TextBox txtNgayXB;
    }
}