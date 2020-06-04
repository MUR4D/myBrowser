namespace myBrrowser
{
    partial class addBookmark
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
            this.folderName = new MetroFramework.Controls.MetroTextBox();
            this.addButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // folderName
            // 
            // 
            // 
            // 
            this.folderName.CustomButton.Image = null;
            this.folderName.CustomButton.Location = new System.Drawing.Point(302, 1);
            this.folderName.CustomButton.Name = "";
            this.folderName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.folderName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.folderName.CustomButton.TabIndex = 1;
            this.folderName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.folderName.CustomButton.UseSelectable = true;
            this.folderName.CustomButton.Visible = false;
            this.folderName.Lines = new string[] {
        "metroTextBox1"};
            this.folderName.Location = new System.Drawing.Point(23, 77);
            this.folderName.MaxLength = 32767;
            this.folderName.Name = "folderName";
            this.folderName.PasswordChar = '\0';
            this.folderName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.folderName.SelectedText = "";
            this.folderName.SelectionLength = 0;
            this.folderName.SelectionStart = 0;
            this.folderName.ShortcutsEnabled = true;
            this.folderName.Size = new System.Drawing.Size(324, 23);
            this.folderName.TabIndex = 0;
            this.folderName.Text = "metroTextBox1";
            this.folderName.UseSelectable = true;
            this.folderName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.folderName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.addButton.Location = new System.Drawing.Point(23, 143);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(324, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add";
            this.addButton.UseSelectable = true;
            this.addButton.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // addBookmark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 189);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.folderName);
            this.Name = "addBookmark";
            this.Text = "add bookmark folder";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox folderName;
        private MetroFramework.Controls.MetroButton addButton;
    }
}