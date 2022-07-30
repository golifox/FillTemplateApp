using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace FillTemplateApp.DatabaseWorkerModule
{
    internal class Logger
    {
        private DatabaseWorker dbWorker = new DatabaseWorker();

        public Logger (string pathToDatabase)
        {
            // default constructor
            dbWorker.OpenDataBase(pathToDatabase);
        }
        
        // Main method to logging actions
        public void LogAction(string username, string action)
        {           
            // create log string with parameteres
            string command = CreateLogString(username, action);

            // execute sql query
            dbWorker.ExecuteCommand(command);

            MessageBox.Show($"Logged: {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")} user: {username} was {action}");
        }

        public string CreateLogString(string username, string action)
        {
            // get cur_time in nessesary format
            string currentTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");

            // return sql query
            return $"INSERT INTO ActionLogs ('Time', 'UserName', 'Action') values('{currentTime}','{username}','{action}')";
        }
    }
}
