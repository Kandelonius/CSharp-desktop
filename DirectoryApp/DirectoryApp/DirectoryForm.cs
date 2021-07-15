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
            Directory.Move("folder2", @"C:\temp");
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

        private void btnWrite_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("third.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("This is the first line");
            sw.WriteLine("This is the second line");
            sw.Flush();
            sw.Close();
            fs.Close();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("third.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string text = "";
            while (!sr.EndOfStream)
            {
                text += sr.ReadLine() + Environment.NewLine;
            }
            sr.Close();
            fs.Close();
            textBox1.Text = text;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            File.Copy("newfile.txt", @"C:\temp\newfile.txt");
        }

        private void btnProperty_Click(object sender, EventArgs e)
        {
            FileInfo myfile = new FileInfo("third.txt");
            string name = myfile.FullName;
            MessageBox.Show(name);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string myfile = @"C:\temp\apple.png";
            textBox1.Text += Path.GetDirectoryName(myfile) + Environment.NewLine;
            textBox1.Text += Path.GetExtension(myfile) + Environment.NewLine;
            textBox1.Text += Path.GetFileName(myfile) + Environment.NewLine;
            textBox1.Text += Path.GetFileNameWithoutExtension(myfile) + Environment.NewLine;
            textBox1.Text += Path.GetPathRoot(myfile) + Environment.NewLine;
            textBox1.Text += Path.GetFullPath(myfile) + Environment.NewLine;
        }
    }
}
