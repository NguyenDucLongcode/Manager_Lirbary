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
            menuStrip1.Items.AddRange(new ToolStripItem[] { navbarSystem, navbarBook, navbarAuthor, narbarReaders, quảnLýMượnTrảToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 2, 0, 2);
            menuStrip1.Size = new Size(1924, 53);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // navbarSystem
            // 
            navbarSystem.DropDownItems.AddRange(new ToolStripItem[] { itemLogin, itemLogout });
            navbarSystem.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            navbarSystem.Name = "navbarSystem";
            navbarSystem.Size = new Size(180, 49);
            navbarSystem.Text = "Hệ Thống";
            navbarSystem.Click += navbarSystem_Click;
            // 
            // itemLogin
            // 
            itemLogin.Name = "itemLogin";
            itemLogin.Size = new Size(291, 54);
            itemLogin.Text = "Đăng nhập";
            itemLogin.Click += itemLogin_Click;
            // 
            // itemLogout
            // 
            itemLogout.Name = "itemLogout";
            itemLogout.Size = new Size(291, 54);
            itemLogout.Text = "Đăng xuất";
            itemLogout.Click += itemLogout_Click;
            // 
            // navbarBook
            // 
            navbarBook.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            navbarBook.Name = "navbarBook";
            navbarBook.Size = new Size(104, 49);
            navbarBook.Text = "Sách";
            navbarBook.Click += navbarBook_Click;
            // 
            // navbarAuthor
            // 
            navbarAuthor.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            navbarAuthor.Name = "navbarAuthor";
            navbarAuthor.Size = new Size(136, 49);
            navbarAuthor.Text = "Tác giả";
            navbarAuthor.Click += navbarAuthor_Click;
            // 
            // narbarReaders
            // 
            narbarReaders.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            narbarReaders.Name = "narbarReaders";
            narbarReaders.Size = new Size(146, 49);
            narbarReaders.Text = "Độc giả";
            narbarReaders.Click += narbarReaders_Click;
            // 
            // quảnLýMượnTrảToolStripMenuItem
            // 
            quảnLýMượnTrảToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mượnSáchToolStripMenuItem, trảSáchToolStripMenuItem });
            quảnLýMượnTrảToolStripMenuItem.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            quảnLýMượnTrảToolStripMenuItem.Name = "quảnLýMượnTrảToolStripMenuItem";
            quảnLýMượnTrảToolStripMenuItem.Size = new Size(294, 49);
            quảnLýMượnTrảToolStripMenuItem.Text = "Quản lý mượn trả";
            quảnLýMượnTrảToolStripMenuItem.Click += quảnLýMượnTrảToolStripMenuItem_Click;
            // 
            // mượnSáchToolStripMenuItem
            // 
            mượnSáchToolStripMenuItem.Name = "mượnSáchToolStripMenuItem";
            mượnSáchToolStripMenuItem.Size = new Size(293, 54);
            mượnSáchToolStripMenuItem.Text = "Mượn sách";
            mượnSáchToolStripMenuItem.Click += mượnSáchToolStripMenuItem_Click;
            // 
            // trảSáchToolStripMenuItem
            // 
            trảSáchToolStripMenuItem.Name = "trảSáchToolStripMenuItem";
            trảSáchToolStripMenuItem.Size = new Size(293, 54);
            trảSáchToolStripMenuItem.Text = "Trả sách";
            trảSáchToolStripMenuItem.Click += trảSáchToolStripMenuItem_Click;
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
            // 
            // panelMain
            // 
            panelMain.Location = new Point(0, 55);
            panelMain.Margin = new Padding(4, 4, 4, 4);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(2378, 1232);
            panelMain.TabIndex = 2;
            // 
            // frMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1050);
            Controls.Add(panelMain);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 4, 4, 4);
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
        private ToolStripMenuItem itemLogin;
        private ToolStripMenuItem itemLogout;
        private Panel panelMain;
        private ToolStripMenuItem quảnLýMượnTrảToolStripMenuItem;
        private ToolStripMenuItem mượnSáchToolStripMenuItem;
        private ToolStripMenuItem trảSáchToolStripMenuItem;
    }
}
