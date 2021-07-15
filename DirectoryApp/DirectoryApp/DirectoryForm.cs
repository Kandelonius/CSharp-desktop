using System;
using System.Windows.Forms;
using System.IO;

namespace DirectoryApp
{
    public partial class DirectoryForm : Form
    {
        public DirectoryForm()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists("folder2"))
            {
                Directory.CreateDirectory("folder2");
            }
            //DirectoryInfo dr = new DirectoryInfo("temp");
            //dr.Create();
            //MessageBox.Show("Folder was created");
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            Directory.Move("temp", @"C:newfolder/temp");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Directory.Delete("temp");
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            if (Directory.Exists("folder2"))
            {
                string accessTime = Directory.GetLastAccessTime("folder2").ToString();
                MessageBox.Show(accessTime);
            }
        }

        private void btnFCreate_Click(object sender, EventArgs e)
        {
            if(!File.Exists("newfile.txt"))
            {
            FileInfo myFile = new FileInfo("newfile.txt");
            myFile.Create();
            }
        }

        private void btnFDelete_Click(object sender, EventArgs e)
        {
            File.Delete("firstfile.txt");
        }
    }
}
