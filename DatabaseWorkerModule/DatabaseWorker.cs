using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SQLite;
using System.Windows.Forms;

namespace FillTemplateApp.DatabaseWorkerModule
{
    internal class DatabaseWorker
    {
        private SQLiteConnection _connection = new SQLiteConnection();
        private SQLiteCommand _command = new SQLiteCommand();
 
        public void OpenDataBase (string pathToDatabase)
        {
            try
            {
                _connection.ConnectionString = "DataSource=" + pathToDatabase;
                // _connection = new SQLiteConnection("Data Source=" + pathToDatabase);

                MessageBox.Show("Connection complete!");
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void ExecuteCommand(string command)
        {
            try
            {
                if(_connection.State != System.Data.ConnectionState.Open)
                {
                    _connection.Open();
                }

                _command.Connection = _connection;
                _command.CommandText = command;

                _command.ExecuteNonQuery();

                MessageBox.Show("Execute query success!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void ExecuteCommand(string command, string pathToDatabase)
        {
            try
            {
                OpenDataBase (pathToDatabase);

                if (_connection.State != System.Data.ConnectionState.Open)
                {
                    _connection.Open();
                }

                _command.Connection = _connection;
                _command.CommandText = command;

                _command.ExecuteNonQuery();

                MessageBox.Show("Execute query success!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    
        // we can add another functions to work with sqlite db like read from db, insert into
        // executeCommand is universal method, but it don`t return any data or objects
    }
}
