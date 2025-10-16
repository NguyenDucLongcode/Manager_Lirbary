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
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            narbarDashboad = new ToolStripMenuItem();
            navbarBook = new ToolStripMenuItem();
            navbarAuthor = new ToolStripMenuItem();
            narbarReaders = new ToolStripMenuItem();
            itemsLogin = new ToolStripMenuItem();
            itemsLogout = new ToolStripMenuItem();
            panelContainer = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem, narbarDashboad, navbarBook, navbarAuthor, narbarReaders });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(810, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(14, 24);
            // 
            // narbarDashboad
            // 
            narbarDashboad.Name = "narbarDashboad";
            narbarDashboad.Size = new Size(94, 24);
            narbarDashboad.Text = "Tổng quan";
            narbarDashboad.Click += narbarDashboad_Click;
            // 
            // navbarBook
            // 
            navbarBook.Name = "navbarBook";
            navbarBook.Size = new Size(54, 24);
            navbarBook.Text = "Sách";
            navbarBook.Click += navbarBook_Click;
            // 
            // navbarAuthor
            // 
            navbarAuthor.Name = "navbarAuthor";
            navbarAuthor.Size = new Size(69, 24);
            navbarAuthor.Text = "Tác giả";
            navbarAuthor.Click += navbarAuthor_Click;
            // 
            // narbarReaders
            // 
            narbarReaders.Name = "narbarReaders";
            narbarReaders.Size = new Size(75, 24);
            narbarReaders.Text = "Độc giả";
            narbarReaders.Click += narbarReaders_Click;
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
            // panelContainer
            // 
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(0, 28);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(810, 422);
            panelContainer.TabIndex = 1;
            // 
            // frMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 450);
            Controls.Add(panelContainer);
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
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem itemsLogin;
        private ToolStripMenuItem itemsLogout;
        private ToolStripMenuItem navbarBook;
        private ToolStripMenuItem navbarAuthor;
        private ToolStripMenuItem narbarReaders;
        private ToolStripMenuItem narbarDashboad;
        private Panel panelContainer;

    }
}
