using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FillTemplateApp.FillTreeModule
{
    internal class TreeNodeWorker: MainForm
    {
        public void FillTree(ref TreeView tree)
        { 
            string currentDir = Application.StartupPath + "\\templates";
            LoadDirectory(currentDir, tree);
        }

        public void LoadDirectory(string dir, TreeView tree)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(dir);

            tree.Nodes.Clear();
            TreeNode tds = tree.Nodes.Add(dirInfo.Name);

            // Load other nested directories and files
            LoadSubDirectory(dir, tds);
            LoadFilesInDirectory(dir, tds);
        }
        public void LoadSubDirectory(string dir, TreeNode tree)
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
        public void LoadFilesInDirectory(string dir, TreeNode tree)
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
}
