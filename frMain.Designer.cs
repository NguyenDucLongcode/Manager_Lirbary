namespace WinFormsApp1
{
    partial class frMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            navbarSystem = new ToolStripMenuItem();
            itemLogin = new ToolStripMenuItem();
            itemLogout = new ToolStripMenuItem();
            narbarDashboad = new ToolStripMenuItem();
            navbarBook = new ToolStripMenuItem();
            navbarAuthor = new ToolStripMenuItem();
            narbarReaders = new ToolStripMenuItem();
            quảnLýMượnTrảToolStripMenuItem = new ToolStripMenuItem();
            mượnSáchToolStripMenuItem = new ToolStripMenuItem();
            trảSáchToolStripMenuItem = new ToolStripMenuItem();
            itemsLogin = new ToolStripMenuItem();
            itemsLogout = new ToolStripMenuItem();
            panelMain = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ActiveCaption;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { navbarSystem, narbarDashboad, navbarBook, navbarAuthor, narbarReaders, quảnLýMượnTrảToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1902, 45);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // navbarSystem
            // 
            navbarSystem.DropDownItems.AddRange(new ToolStripItem[] { itemLogin, itemLogout });
            navbarSystem.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            navbarSystem.Name = "navbarSystem";
            navbarSystem.Size = new Size(151, 41);
            navbarSystem.Text = "Hệ Thống";
            navbarSystem.Click += navbarSystem_Click;
            // 
            // itemLogin
            // 
            itemLogin.Name = "itemLogin";
            itemLogin.Size = new Size(242, 42);
            itemLogin.Text = "Đăng nhập";
            itemLogin.Click += itemLogin_Click;
            // 
            // itemLogout
            // 
            itemLogout.Name = "itemLogout";
            itemLogout.Size = new Size(242, 42);
            itemLogout.Text = "Đăng xuất";
            itemLogout.Click += itemLogout_Click;
            // 
            // narbarDashboad
            // 
            narbarDashboad.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            narbarDashboad.Name = "narbarDashboad";
            narbarDashboad.Size = new Size(163, 41);
            narbarDashboad.Text = "Tổng quan";
            narbarDashboad.Click += narbarDashboad_Click;
            // 
            // navbarBook
            // 
            navbarBook.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            navbarBook.Name = "navbarBook";
            navbarBook.Size = new Size(89, 41);
            navbarBook.Text = "Sách";
            navbarBook.Click += navbarBook_Click;
            // 
            // navbarAuthor
            // 
            navbarAuthor.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            navbarAuthor.Name = "navbarAuthor";
            navbarAuthor.Size = new Size(114, 41);
            navbarAuthor.Text = "Tác giả";
            navbarAuthor.Click += navbarAuthor_Click;
            // 
            // narbarReaders
            // 
            narbarReaders.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            narbarReaders.Name = "narbarReaders";
            narbarReaders.Size = new Size(123, 41);
            narbarReaders.Text = "Độc giả";
            narbarReaders.Click += narbarReaders_Click;
            // 
            // quảnLýMượnTrảToolStripMenuItem
            // 
            quảnLýMượnTrảToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mượnSáchToolStripMenuItem, trảSáchToolStripMenuItem });
            quảnLýMượnTrảToolStripMenuItem.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            quảnLýMượnTrảToolStripMenuItem.Name = "quảnLýMượnTrảToolStripMenuItem";
            quảnLýMượnTrảToolStripMenuItem.Size = new Size(247, 41);
            quảnLýMượnTrảToolStripMenuItem.Text = "Quản lý mượn trả";
            quảnLýMượnTrảToolStripMenuItem.Click += quảnLýMượnTrảToolStripMenuItem_Click;
            // 
            // mượnSáchToolStripMenuItem
            // 
            mượnSáchToolStripMenuItem.Name = "mượnSáchToolStripMenuItem";
            mượnSáchToolStripMenuItem.Size = new Size(245, 42);
            mượnSáchToolStripMenuItem.Text = "Mượn sách";
            mượnSáchToolStripMenuItem.Click += mượnSáchToolStripMenuItem_Click;
            // 
            // trảSáchToolStripMenuItem
            // 
            trảSáchToolStripMenuItem.Name = "trảSáchToolStripMenuItem";
            trảSáchToolStripMenuItem.Size = new Size(245, 42);
            trảSáchToolStripMenuItem.Text = "Trả sách";
            // 
            // itemsLogin
            // 
            itemsLogin.Name = "itemsLogin";
            itemsLogin.Size = new Size(224, 26);
            itemsLogin.Text = "Đăng nhập";
            itemsLogin.Click += itemsLogin_Click;
            // 
            // itemsLogout
            // 
            itemsLogout.Name = "itemsLogout";
            itemsLogout.Size = new Size(224, 26);
            itemsLogout.Text = "Đăng xuẩt";
            itemsLogout.Click += itemsLogout_Click;
            // 
            // panelMain
            // 
            panelMain.Location = new Point(0, 44);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1902, 986);
            panelMain.TabIndex = 2;
            // 
            // frMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(panelMain);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý thư viện";
            Load += frMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem navbarSystem;
        private ToolStripMenuItem itemsLogin;
        private ToolStripMenuItem itemsLogout;
        private ToolStripMenuItem navbarBook;
        private ToolStripMenuItem navbarAuthor;
        private ToolStripMenuItem narbarReaders;
        private ToolStripMenuItem narbarDashboad;
        private ToolStripMenuItem itemLogin;
        private ToolStripMenuItem itemLogout;
        private Panel panelMain;
        private ToolStripMenuItem quảnLýMượnTrảToolStripMenuItem;
        private ToolStripMenuItem mượnSáchToolStripMenuItem;
        private ToolStripMenuItem trảSáchToolStripMenuItem;
    }
}
