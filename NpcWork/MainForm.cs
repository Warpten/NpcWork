using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using NpcWork.Database;

namespace NpcWork
{
    public partial class mainWindow : Form
    {
        public mainWindow()
        {
            InitializeComponent();
        }

        /* Called when clicking on the "settings" menu option */
        private void SettingsClick(object sender, EventArgs e)
        {
            var frm = new DatabaseSettings();
            frm.ShowDialog(this);
            ConnStatus();
        }

        /* Used to update the status of the connexion at the bottom of the main window */
        private void ConnStatus()
        {
            if (MySqlConnection.Connected)
            {
                DatabaseStatusLabel.Text = String.Format("Successfully connect to {0} with username {1} and password {2} on database {3}", 
                    NpcWork.Properties.Settings.Default.host,
                    NpcWork.Properties.Settings.Default.username,
                    NpcWork.Properties.Settings.Default.password,
                    NpcWork.Properties.Settings.Default.database);
                switchConnectionToolStripMenuItem.Text = @"Disconnect";
                DatabaseStatusLabel.ForeColor = Color.Green;
            }
            else
            {
                DatabaseStatusLabel.Text = @"No DB Connected";
                DatabaseStatusLabel.ForeColor = Color.Red;
                switchConnectionToolStripMenuItem.Text = @"Connect";
            }
        }

        /* Connect or disconnect from the database */
        private void DBConnect(object sender, EventArgs e)
        {
            if (MySqlConnection.Connected)
            {
                switchConnectionToolStripMenuItem.Text = @"Disconnect";
                NpcWork.Database.MySqlConnection.CloseConnexion();
            }
            else
            {
                switchConnectionToolStripMenuItem.Text = @"Connect";
                NpcWork.Database.MySqlConnection.OpenConnexion();
            }

            ConnStatus();
        }

        private void DoSeekNPC(object sender, EventArgs e)
        {
            var _query = String.Format("SELECT * FROM creature_template WHERE entry = {0}", _npcIdToSeek);
            MySqlConnection.DoSeekNPCUsingQuery(_query);
        }
    }
}
