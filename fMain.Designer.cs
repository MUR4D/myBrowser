namespace myBrrowser
{
    partial class fMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.backButton = new MetroFramework.Controls.MetroLink();
            this.goButton = new MetroFramework.Controls.MetroLink();
            this.refreshButton = new MetroFramework.Controls.MetroLink();
            this.homeButton = new MetroFramework.Controls.MetroLink();
            this.bookmarkButton = new MetroFramework.Controls.MetroLink();
            this.urlBox = new MetroFramework.Controls.MetroTextBox();
            this.historyButton = new MetroFramework.Controls.MetroLink();
            this.add_tab = new MetroFramework.Controls.MetroLink();
            this.tabsControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.myBrowser = new System.Windows.Forms.WebBrowser();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabsControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabsControl, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(501, 370);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.Controls.Add(this.backButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.goButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.refreshButton, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.homeButton, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.bookmarkButton, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.urlBox, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.historyButton, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.add_tab, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.metroLink1, 2, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(495, 52);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // backButton
            // 
            this.backButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backButton.Image = ((System.Drawing.Image)(resources.GetObject("backButton.Image")));
            this.backButton.Location = new System.Drawing.Point(3, 3);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(52, 22);
            this.backButton.TabIndex = 0;
            this.backButton.UseSelectable = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // goButton
            // 
            this.goButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.goButton.Image = ((System.Drawing.Image)(resources.GetObject("goButton.Image")));
            this.goButton.Location = new System.Drawing.Point(61, 3);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(33, 22);
            this.goButton.TabIndex = 1;
            this.goButton.UseSelectable = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.refreshButton.Image = ((System.Drawing.Image)(resources.GetObject("refreshButton.Image")));
            this.refreshButton.Location = new System.Drawing.Point(100, 3);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(76, 22);
            this.refreshButton.TabIndex = 2;
            this.refreshButton.UseSelectable = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homeButton.Image = ((System.Drawing.Image)(resources.GetObject("homeButton.Image")));
            this.homeButton.Location = new System.Drawing.Point(402, 3);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(26, 22);
            this.homeButton.TabIndex = 3;
            this.homeButton.UseSelectable = true;
            this.homeButton.Click += new System.EventHandler(this.bookmarkButton_Click);
            // 
            // bookmarkButton
            // 
            this.bookmarkButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookmarkButton.Image = ((System.Drawing.Image)(resources.GetObject("bookmarkButton.Image")));
            this.bookmarkButton.Location = new System.Drawing.Point(434, 3);
            this.bookmarkButton.Name = "bookmarkButton";
            this.bookmarkButton.Size = new System.Drawing.Size(26, 22);
            this.bookmarkButton.TabIndex = 4;
            this.bookmarkButton.UseSelectable = true;
            this.bookmarkButton.Click += new System.EventHandler(this.bookmarkButton_Click_1);
            // 
            // urlBox
            // 
            // 
            // 
            // 
            this.urlBox.CustomButton.Image = null;
            this.urlBox.CustomButton.Location = new System.Drawing.Point(169, 2);
            this.urlBox.CustomButton.Name = "";
            this.urlBox.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.urlBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.urlBox.CustomButton.TabIndex = 1;
            this.urlBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.urlBox.CustomButton.UseSelectable = true;
            this.urlBox.CustomButton.Visible = false;
            this.urlBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.urlBox.Lines = new string[] {
        "Search"};
            this.urlBox.Location = new System.Drawing.Point(182, 3);
            this.urlBox.MaxLength = 32767;
            this.urlBox.Name = "urlBox";
            this.urlBox.PasswordChar = '\0';
            this.urlBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.urlBox.SelectedText = "";
            this.urlBox.SelectionLength = 0;
            this.urlBox.SelectionStart = 0;
            this.urlBox.ShortcutsEnabled = true;
            this.urlBox.Size = new System.Drawing.Size(214, 22);
            this.urlBox.TabIndex = 5;
            this.urlBox.Text = "Search";
            this.urlBox.UseSelectable = true;
            this.urlBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.urlBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.urlBox.Click += new System.EventHandler(this.urlBox_Click);
            this.urlBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.urlBox_KeyDown);
            // 
            // historyButton
            // 
            this.historyButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.historyButton.Image = ((System.Drawing.Image)(resources.GetObject("historyButton.Image")));
            this.historyButton.Location = new System.Drawing.Point(466, 3);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(26, 22);
            this.historyButton.TabIndex = 6;
            this.historyButton.UseSelectable = true;
            this.historyButton.Click += new System.EventHandler(this.historyButton_Click);
            // 
            // add_tab
            // 
            this.add_tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.add_tab.Location = new System.Drawing.Point(3, 31);
            this.add_tab.Name = "add_tab";
            this.add_tab.Size = new System.Drawing.Size(52, 18);
            this.add_tab.TabIndex = 7;
            this.add_tab.Text = "Add Tab";
            this.add_tab.UseSelectable = true;
            this.add_tab.Click += new System.EventHandler(this.add_tab_Click);
            // 
            // tabsControl
            // 
            this.tabsControl.Controls.Add(this.tabPage1);
            this.tabsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabsControl.Location = new System.Drawing.Point(3, 61);
            this.tabsControl.Name = "tabsControl";
            this.tabsControl.SelectedIndex = 0;
            this.tabsControl.Size = new System.Drawing.Size(495, 306);
            this.tabsControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.myBrowser);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(487, 280);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "New Tab";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // myBrowser
            // 
            this.myBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myBrowser.Location = new System.Drawing.Point(3, 3);
            this.myBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.myBrowser.Name = "myBrowser";
            this.myBrowser.Size = new System.Drawing.Size(481, 274);
            this.myBrowser.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // metroLink1
            // 
            this.metroLink1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroLink1.Location = new System.Drawing.Point(100, 31);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(76, 18);
            this.metroLink1.TabIndex = 8;
            this.metroLink1.Text = "Remove tab";
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "fMain";
            this.Text = "       myBrowser";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tabsControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl tabsControl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MetroFramework.Controls.MetroLink backButton;
        private MetroFramework.Controls.MetroLink goButton;
        private MetroFramework.Controls.MetroLink refreshButton;
        private MetroFramework.Controls.MetroLink homeButton;
        private MetroFramework.Controls.MetroLink bookmarkButton;
        private MetroFramework.Controls.MetroTextBox urlBox;
        private MetroFramework.Controls.MetroLink historyButton;
        private MetroFramework.Controls.MetroLink add_tab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.WebBrowser myBrowser;
        private MetroFramework.Controls.MetroLink metroLink1;
    }
}

