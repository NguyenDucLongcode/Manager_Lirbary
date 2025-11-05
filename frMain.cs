namespace WinFormsApp1
{
    public partial class frMain : Form
    { 
        sbyte statusLogin = 0; // Biến trạng thái đăng nhập: 0 = Chưa đăng nhập, 1 = Đã đăng nhập
        public frMain()
        {
            InitializeComponent();
            //CheckLogin(); // Gọi kiểm tra đăng nhập ngay khi khởi tạo form

        }

        private void CheckLogin()
        {
            if (statusLogin == 0)
            {
                // Chưa đăng nhập - Ẩn form chính và hiển thị form đăng nhập
                this.Hide();

                frLogin loginForm = new frLogin();
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    // Đăng nhập thành công
                    statusLogin = 1;

                    // Đã đăng nhập
                    itemLogin.Enabled = false;
                    itemLogout.Enabled = true;
                    navbarAuthor.Enabled = true;
                    quảnLýMượnTrảToolStripMenuItem.Enabled = true;
                    navbarBook.Enabled = true;
                    narbarReaders.Enabled = true;
                    this.Show();
                }
                else
                {
                    // Đăng nhập thất bại - LUÔN QUAY LẠI FORM ĐĂNG NHẬP
                    MessageBox.Show("Bạn cần đăng nhập để sử dụng phần mềm!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Gọi lại chính nó để hiển thị form đăng nhập lại
                    CheckLogin();
                }
            }
            else
            {
                statusLogin = 1;
                // Đã đăng nhập
                itemLogin.Enabled = false;
                itemLogout.Enabled = true;
                navbarAuthor.Enabled = true;
                quảnLýMượnTrảToolStripMenuItem.Enabled = true;
                navbarBook.Enabled = true;
                narbarReaders.Enabled = true;
            }
        }


        private void frMain_Load(object sender, EventArgs e)
        {
           
            // Chỉ cần mở form Author nếu đã đăng nhập
            if (statusLogin == 1)
            {
                OpenFormInPanel(new frAuthor());
            }

        }



        private void narbarDashboad_Click(object sender, EventArgs e)
        {

        }

        private void itemsLogin_Click(object sender, EventArgs e)
        {

        }

        private void itemLogout_Click(object sender, EventArgs e)
        {
            // Xác nhận đăng xuất
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận đăng xuất",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;

            // Đăng xuất
            statusLogin = 0;
            // Chưa đăng nhập
            itemsLogin.Enabled = true;
            itemLogout.Enabled = false;
            navbarAuthor.Enabled = false;
            quảnLýMượnTrảToolStripMenuItem.Enabled = false;
            navbarBook.Enabled = false;
            narbarReaders.Enabled = false;

            CheckLogin();
        }

        private void navbarBook_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new FrmListBook());
        }

        private void navbarAuthor_Click(object sender, EventArgs e)
        {
            // Khi click nhúng form Author vòa  form chính
            OpenFormInPanel(new frAuthor());
        }

        private void narbarReaders_Click(object sender, EventArgs e)
        {

        }

        private void itemLogin_Click(object sender, EventArgs e)
        {

        }

      


        // Hàm dùng đề nhúng form vào panel main
        private void OpenFormInPanel(Form childForm)
        {
            panelMain.Controls.Clear();       // Xóa các control cũ trong panel
            childForm.TopLevel = false;      // Form con không phải top-level
            childForm.FormBorderStyle = FormBorderStyle.None; // Xóa border
            childForm.Dock = DockStyle.Fill; // Lấp đầy panel
            panelMain.Controls.Add(childForm); // Thêm vào panel
            panelMain.Tag = childForm;
            childForm.Show();
        }

        private void navbarSystem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mượnSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new FrmMuonSach());
        }

        private void quảnLýMượnTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
