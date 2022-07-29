using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Aspose.Words;

namespace FillTemplateApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillTree(this.templatesTree);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //
            // add Dialog to Close form
            //
        }

        private void открытьШаблонToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"));
        }

        private void FillTree (TreeView tree)
        {
            string currentDir = Application.StartupPath + "\\templates";
            LoadDirectory(currentDir, tree);
        }

        private void LoadDirectory (string dir, TreeView tree)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(dir);

            tree.Nodes.Clear();
            TreeNode tds = tree.Nodes.Add(dirInfo.Name);

            // Load other nested directories and files
            LoadSubDirectory(dir, tds);
            LoadFilesInDirectory(dir, tds); 
        }
        private void LoadSubDirectory(string dir, TreeNode tree)
        {
            // Get all subdirectories  
            string[] subdirectoryEntries = Directory.GetDirectories(dir);

            // Loop through them to see if they have any other subdirectories  
            foreach (string subdirectory in subdirectoryEntries)
            {
                DirectoryInfo dirInfo = new DirectoryInfo(subdirectory);

                TreeNode tds = tree.Nodes.Add(dirInfo.Name);

                tds.StateImageIndex = 0;
                tds.Tag = dirInfo.FullName;

                // Load other nested directories and files
                LoadSubDirectory(subdirectory, tds);
                LoadFilesInDirectory(subdirectory, tds);
            }
        }
        private void LoadFilesInDirectory(string dir, TreeNode tree)
        {
            string[] Files = Directory.GetFiles(dir, "*.*");

            foreach (string file in Files)
            {
                FileInfo fileInfo = new FileInfo(file);
                tree.Nodes.Add(fileInfo.Name);
                tree.Tag = fileInfo.FullName;
                tree.StateImageIndex = 1;
            }
        }

    }
    
    public class ITemplate
    {
        // method for uploading template and set uploaded text to templateText variable
        void UploadTemplate()
        {

        }

        //method for transformation template text to array args user have to change in program
        void GetArgsTemplate()
        {
        }

        void SaveTemplate()
        {
            MessageBox.Show("Template was saved!");
        }

        void SetTableFromTemplate()
        {
            //
            // method to ouput tamplate.args [] to table in view
            //
        }
    }
    public class Template : ITemplate
    {
        private Document doc = new Document();
        
    }
    public class Mailer
    {
        public void SentMail(string mailFrom, string mailTo, string failPath)
        {
            //
            // some code to sent file from {failPath} to e-mail {mailTo} from user`s mail {mailFrom}
            //

            MessageBox.Show($"E-mail from {mailFrom} to {mailTo} with file sended!");
        }
    }
    public class Logger
    {
        public void LogToDatabase(string userName, string stringForLog, string connectionString)
        {
            //
            // some code to open DB from {connectionString} to log in table user`s {userName} action {stringForLog}
            //

            MessageBox.Show($"Logged: {DateTime.Now}: {userName} was {stringForLog}");
        }
    }


}
