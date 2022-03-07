using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FileSizeReader
{
    public partial class Form1 : Form
    {
        public static List<string> folders = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void chooseFileButton_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            string folder = folderBrowserDialog1.SelectedPath;

            filepathText.Text = folder;
        }

        private void scanFilesButton_Click(object sender, EventArgs e)
        {
            foreach (string folder in Directory.GetDirectories(filepathText.Text))
            {
                folders.Add(folder);
                getMoreFolders(folder);
            }

            foreach (string folder in folders)
            {
                string[] row = { folder, toGigabytes(DirSize(new DirectoryInfo(folder))).ToString() + "GB" };
                folderStorage.Rows.Add(row);
            }
        }

        private void getMoreFolders(string path)
        {
            try
            {
                if (Directory.GetDirectories(path).Length == 0)
                    return;

                List<string> tempFolders = new List<string>();

                foreach (string folder in Directory.GetDirectories(path))
                {
                    tempFolders.Add(folder);
                    folders.Add(folder);

                    getMoreFolders(folder);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("cringe");
            }

        }

        private long DirSize(DirectoryInfo d)
        {
            long size = 0;

            try
            {
                // Add file sizes.
                FileInfo[] fis = d.GetFiles();
                foreach (FileInfo fi in fis)
                {
                    size += fi.Length;
                }
                // Add subdirectory sizes.
                DirectoryInfo[] dis = d.GetDirectories();
                foreach (DirectoryInfo di in dis)
                {
                    size += DirSize(di);
                }
                
            }
            catch (Exception e)
            {

                Console.WriteLine("cringes");
            }

            return size;
        }

        private float toGigabytes(long x)
        {
            return (float)Math.Round((double)x / 1000000000, 3);
        }
    }
}
