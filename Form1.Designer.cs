namespace FillTemplateApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьШаблонToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.всеШаблоныToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отправитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControlTemplateCollection = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainerFillTemplate = new System.Windows.Forms.SplitContainer();
            this.templatesTree = new System.Windows.Forms.TreeView();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControlTemplateCollection.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerFillTemplate)).BeginInit();
            this.splitContainerFillTemplate.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.отправитьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1064, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьШаблонToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem,
            this.всеШаблоныToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьШаблонToolStripMenuItem
            // 
            this.открытьШаблонToolStripMenuItem.Name = "открытьШаблонToolStripMenuItem";
            this.открытьШаблонToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.открытьШаблонToolStripMenuItem.Text = "Открыть шаблон";
            this.открытьШаблонToolStripMenuItem.Click += new System.EventHandler(this.открытьШаблонToolStripMenuItem_Click);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как";
            // 
            // всеШаблоныToolStripMenuItem
            // 
            this.всеШаблоныToolStripMenuItem.Name = "всеШаблоныToolStripMenuItem";
            this.всеШаблоныToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.всеШаблоныToolStripMenuItem.Text = "Все шаблоны";
            // 
            // отправитьToolStripMenuItem
            // 
            this.отправитьToolStripMenuItem.Name = "отправитьToolStripMenuItem";
            this.отправитьToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.отправитьToolStripMenuItem.Text = "Отправить";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControlTemplateCollection);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1064, 607);
            this.panel1.TabIndex = 1;
            // 
            // tabControlTemplateCollection
            // 
            this.tabControlTemplateCollection.Controls.Add(this.tabPage1);
            this.tabControlTemplateCollection.Controls.Add(this.tabPage2);
            this.tabControlTemplateCollection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlTemplateCollection.Location = new System.Drawing.Point(0, 0);
            this.tabControlTemplateCollection.Name = "tabControlTemplateCollection";
            this.tabControlTemplateCollection.SelectedIndex = 0;
            this.tabControlTemplateCollection.Size = new System.Drawing.Size(1064, 607);
            this.tabControlTemplateCollection.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1056, 581);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Коллеция шаблонов";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainerFillTemplate);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1056, 581);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Заполнить шаблон";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.templatesTree);
            this.splitContainer1.Size = new System.Drawing.Size(1050, 575);
            this.splitContainer1.SplitterDistance = 488;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainerFillTemplate
            // 
            this.splitContainerFillTemplate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerFillTemplate.Location = new System.Drawing.Point(3, 3);
            this.splitContainerFillTemplate.Name = "splitContainerFillTemplate";
            this.splitContainerFillTemplate.Size = new System.Drawing.Size(1050, 575);
            this.splitContainerFillTemplate.SplitterDistance = 475;
            this.splitContainerFillTemplate.TabIndex = 0;
            // 
            // templatesTree
            // 
            this.templatesTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.templatesTree.Location = new System.Drawing.Point(0, 0);
            this.templatesTree.Name = "templatesTree";
            this.templatesTree.Size = new System.Drawing.Size(488, 575);
            this.templatesTree.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 631);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabControlTemplateCollection.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerFillTemplate)).EndInit();
            this.splitContainerFillTemplate.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьШаблонToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem всеШаблоныToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отправитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControlTemplateCollection;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView templatesTree;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainerFillTemplate;
    }
}

