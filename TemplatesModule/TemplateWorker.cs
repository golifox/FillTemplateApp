using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using Aspose.Words;
using FillTemplateApp.DatabaseWorkerModule;

namespace FillTemplateApp.TemplatesModule
{
    public class Template
    {
        // method for uploading template and set uploaded text to templateText variable
        void UploadTemplate()
        {

        }

        //method for transformation template text to array args user have to change in program
        public List<string> GetArgsTemplate(RichTextBox rtb)
        {
            List<string> found = new List<string> ();



            return found;
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
