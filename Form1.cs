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
using FillTemplateApp.FillTreeModule;
using FillTemplateApp.DatabaseWorkerModule;

namespace FillTemplateApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //заполняем форму из текущей директории с шаблонами
            TreeNodeWorker nodeFiller = new TreeNodeWorker(); 
            nodeFiller.FillTree(ref templatesTree);
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

        private void templatesTree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //код чтобы вывести выбранный шаблон на экран
            //templatesTree.SelectedNode = e.Node;
            string filepath = e.Node.FullPath;
            if (filepath.EndsWith(".rtf"))
            {
                richTextBox.LoadFile(filepath);
            }
        }

        private void templatesTree_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //код чтобы открыть шаблон для изменения
        }
    }

}
