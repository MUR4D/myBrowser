using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myBrrowser
{
    public partial class fBookMarks : MetroFramework.Forms.MetroForm
    {
        fMain fmain = new fMain();
        public fBookMarks()
        {
            InitializeComponent();
            using (StreamReader read = new StreamReader(fMain.bookmarkfile))
            {
                string[] sites = read.ReadToEnd().Split('\n');
                for (int i = 0; i < sites.Length; i++)
                {
                treeView1.Nodes.Add(sites[i]);

                }
            }


        }

        private void metroLink3_Click(object sender, EventArgs e)
        {
            addBookmark add = new addBookmark();
            add.ShowDialog();
            var foldername = add.FolderName;
            treeView1.Nodes.Add(foldername);
            fMain.Writing("bookmarks.txt");
        }

        private void metroLink4_Click(object sender, EventArgs e)
        {
            try
            {
               treeView1.SelectedNode.Nodes.Add(fMain.bookMark);
                fMain.Writing("bookmarks.txt");

            }
            catch 
            {
                MessageBox.Show("Add or Select folder!","",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Nodes.Clear();
        }
    }
}
