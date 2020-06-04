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
using static System.Windows.Forms.ListView;

namespace myBrrowser
{
    public partial class fHistory : MetroFramework.Forms.MetroForm
    {
        fMain mainForm = new fMain();
        public fHistory()
        {
            InitializeComponent();
            //string history= File.ReadAllText(fMain.filename);
            //string[]sites= history.Split('\n');+
            using (StreamReader read = new StreamReader(fMain.historyfile))
            {
                string[] sites = read.ReadToEnd().Split('\n');
                listBox1.Items.AddRange(sites);
            }
           
            //listBox1.ClearSelected();
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            fMain.savedURL.RemoveRange(0, fMain.savedURL.Count);
            listBox1.Items.Clear();
        }

        private void metroLink2_Click(object sender, EventArgs e)
        {
            try
            {
                fMain.savedURL.Remove(listBox1.SelectedItem.ToString());
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
            catch
            {
                if (listBox1.Items.Count>0)
                {
                MessageBox.Show("Add or Select folder!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("is Empty", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

        }
    }
}
