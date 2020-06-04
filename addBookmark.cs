using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myBrrowser
{
    public partial class addBookmark : MetroFramework.Forms.MetroForm
    {
        //public List<string> folders = new List<string>();
        public string FolderName { get; set; }
        public addBookmark()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            FolderName = folderName.Text;
            Close();
        //    if (folderName.Text.Length>0)
        //    {

            //    folders.Add(folderName.Text);
            //fBookMarks marks = new fBookMarks(folderName.Text);
            //    }
        }
    }
}
