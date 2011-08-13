using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NpcWork.Properties;
using NpcWork.Database;

namespace NpcWork
{
    public partial class DatabaseSettings : Form
    {
        public DatabaseSettings()
        {
            InitializeComponent();
        }

        /* Save provided settings */
        private void DBSaveSettingsClick(object sender, EventArgs e)
        {
            Settings.Default.host = _dbSettingsHost.Text;
            Settings.Default.port = "3306";
            Settings.Default.username = _dbSettingsUserName.Text;
            Settings.Default.password = _dbSettingsPassword.Text;
            Settings.Default.database = _dbSettingsDBName.Text;

            MySqlConnection.TestConnect();

            if (((Button)sender).Text != @"Save")
            {
                if (MySqlConnection.Connected)
                {
                    MessageBox.Show(@"Successfully connected to the database", @"MySQL Connection",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(@"Connection failed!", @"ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (((Button)sender).Text != @"Save")
                return;

            Settings.Default.Save();
            Close();

        }

        /* Called when the window for setting arguments to log in MySQL is loaded */
        private void DatabaseSettings_Load(object sender, EventArgs e)
        {
            _dbSettingsHost.Text = Settings.Default.host;
            _dbSettingsUserName.Text = Settings.Default.username;
            _dbSettingsPassword.Text = Settings.Default.password;
            _dbSettingsDBName.Text = Settings.Default.database;
        }
    }
}
