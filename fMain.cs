using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myBrrowser
{
    public partial class fMain : MetroFramework.Forms.MetroForm
    {
        Regex URLregex = new Regex(@"^(?:http(s)?:\/\/)?[\w.-]+(?:\.[\w\.-]+)+[\w\-\._~:/?#[\]@!\$&'\(\)\*\+,;=.]+$");

        public static List<string> savedURL = new List<string>();

        public static string bookMark;

        public static string historyfile="history.txt";

        public static string bookmarkfile = "bookmarks.txt";

        //static TabPage newTab = new TabPage("New Tab");

        //WebBrowser myBrowser = new WebBrowser()
        //{
        //    Parent = newTab,
        //    Dock = DockStyle.Fill,

        //};

        public static void Writing(string filename)
        {
            using (StreamWriter file = new StreamWriter(filename))
            {
                foreach (var line in savedURL)
                {

                    file.Write(line + '\n');
                }
            }
        }
       
        public fMain()
        {
            InitializeComponent();
           
            myBrowser.Navigate("google.com");

        }

        private void urlBox_Click(object sender, EventArgs e)
        {
            if (urlBox.Text=="Search") urlBox.Text = "";

        }

        private void urlBox_KeyDown(object sender, KeyEventArgs e)
        {
            Match match = URLregex.Match(urlBox.Text);
            TabPage tb = tabsControl.SelectedTab;
            
            if (e.KeyCode==Keys.Enter)
            {
                if (match.Success)
                {
                    //myBrowser.Navigate(urlBox.Text);
                    //savedURL.Add(urlBox.Text);
                    savedURL.Add(myBrowser.Url.ToString());
                    

                    foreach (Control item in tb.Controls)
                    {
                        if (item is WebBrowser)
                        {
                            WebBrowser wb = (WebBrowser)item;
                            wb.Navigate(urlBox.Text);
                           // urlBox.Text = wb.Url.ToString();
                            savedURL.Add(wb.Url.ToString());
                            Writing(bookmarkfile);
                        }
                    }
                   


                }
                else
                {
                   
                    savedURL.Add(myBrowser.Url.ToString());
                 
                     //tb = tabsControl.SelectedTab;

                    foreach (Control item in tb.Controls)
                    {
                        if (item is WebBrowser)
                        {
                            WebBrowser wb   = (WebBrowser)item;
                            wb.Navigate($"https://www.google.com/search?q={urlBox.Text}&rlz=1C1GCEB_enAZ876AZ876&oq=foo&aqs=chrome.1.69i57j0l6j69i60.1487j0j7&sourceid=chrome&ie=UTF-8");
                            //urlBox.Text = wb.Url.ToString();
                            Writing(bookmarkfile);
                        }
                    }
                }
            }
        }

       

        private void backButton_Click(object sender, EventArgs e)
        {
            myBrowser.GoBack();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            myBrowser.GoForward();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            myBrowser.Refresh();
        }

        private void bookmarkButton_Click(object sender, EventArgs e)
        {
            myBrowser.Navigate("google.com");
            
        }

        private void historyButton_Click(object sender, EventArgs e)
        {
            fHistory fHistory = new fHistory();
            fHistory.ShowDialog();
        }

        private void myBrowser_Navigated_1(object sender, WebBrowserNavigatedEventArgs e)
        {
            
            urlBox.Text = myBrowser.Url.ToString();
            

            
        }

        private void bookmarkButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                bookMark = myBrowser.Url.ToString();
            }
            catch
            {

                MessageBox.Show("NO URL!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            finally
            {

                fBookMarks bookMarks = new fBookMarks();
                bookMarks.Show();
            }
        }

        private void add_tab_Click(object sender, EventArgs e)
        {

            TabPage tabpage = new TabPage();
            tabpage.Text = "New Tab";
            tabsControl.TabPages.Add(tabpage);
           
            WebBrowser webbrowser = new WebBrowser();
            webbrowser.Dock = DockStyle.Fill;
            webbrowser.Navigate("https://www.google.com/");

            tabpage.Controls.Add(webbrowser as WebBrowser);
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            tabsControl.TabPages.Remove(tabsControl.SelectedTab);
        }
    }
}
