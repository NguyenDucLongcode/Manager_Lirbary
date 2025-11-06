namespace WinFormsApp1
{
    partial class ModalTacGia
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
            txtGender = new TextBox();
            txtNgaySinh = new TextBox();
            btnDong = new Button();
            txtPenName = new TextBox();
            label11 = new Label();
            txtCMND = new TextBox();
            label10 = new Label();
            txtPhone = new TextBox();
            label9 = new Label();
            txtAddress = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            txtName = new TextBox();
            label5 = new Label();
            txtAuthorId = new TextBox();
            label4 = new Label();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtGender);
            groupBox3.Controls.Add(txtNgaySinh);
            groupBox3.Controls.Add(btnDong);
            groupBox3.Controls.Add(txtPenName);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(txtCMND);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(txtPhone);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(txtAddress);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(txtName);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(txtAuthorId);
            groupBox3.Controls.Add(label4);
            groupBox3.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = Color.Blue;
            groupBox3.Location = new Point(0, 1);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(413, 563);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin tác giả";
            // 
            // txtGender
            // 
            txtGender.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtGender.Location = new Point(135, 230);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(89, 36);
            txtGender.TabIndex = 23;
            // 
            // txtNgaySinh
            // 
            txtNgaySinh.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNgaySinh.Location = new Point(135, 283);
            txtNgaySinh.Name = "txtNgaySinh";
            txtNgaySinh.Size = new Size(242, 36);
            txtNgaySinh.TabIndex = 22;
            // 
            // btnDong
            // 
            btnDong.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDong.Location = new Point(283, 511);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(94, 43);
            btnDong.TabIndex = 21;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            btnDong.Click += btnDong_Click;
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
            // ModalTacGia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 567);
            Controls.Add(groupBox3);
            Name = "ModalTacGia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ModalTacGia";
            Load += ModalTacGia_Load;
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox3;
        private TextBox txtGender;
        private TextBox txtNgaySinh;
        private Button btnDong;
        private TextBox txtPenName;
        private Label label11;
        private TextBox txtCMND;
        private Label label10;
        private TextBox txtPhone;
        private Label label9;
        private TextBox txtAddress;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox txtName;
        private Label label5;
        private TextBox txtAuthorId;
        private Label label4;
    }
}