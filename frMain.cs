namespace WinFormsApp1
{
    public partial class frMain : Form
    {
        public frMain()
        {
            InitializeComponent();
        }

        private void frMain_Load(object sender, EventArgs e)
        {
        }



        private void narbarDashboad_Click(object sender, EventArgs e)
        {

        }

        private void itemsLogin_Click(object sender, EventArgs e)
        {

        }

        private void itemsLogout_Click(object sender, EventArgs e)
        {

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

        private void itemLogout_Click(object sender, EventArgs e)
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
    }
}
