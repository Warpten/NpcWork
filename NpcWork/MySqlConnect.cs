using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using NpcWork.Properties;

namespace NpcWork.Database
{
    public static class MySqlConnection
    {
        private static MySql.Data.MySqlClient.MySqlConnection _conn;
        private static MySqlCommand _command;

        public static bool Connected { get; private set; }
        public static List<string> Dropped = new List<string>();

        private static String ConnectionString
        {
            get
            {
                return String.Format("Server={0};Port={1};Uid={2};Pwd={3};Database={4};character set=utf8;Connection Timeout=10",
                    Settings.Default.host,
                    Settings.Default.port,
                    Settings.Default.username,
                    Settings.Default.password,
                    Settings.Default.database);
            }
        }

        public static void TestConnect()
        {
            try
            {
                _conn = new MySql.Data.MySqlClient.MySqlConnection(ConnectionString);
                _conn.Open();
                _conn.Close();
                Connected = true;
            }
            catch
            {
                Connected = false;
            }
        }

        public static void CloseConnexion()
        {
            _conn.Close();
            Connected = false;
        }

        public static void OpenConnexion()
        {
            try
            {
                _conn = new MySql.Data.MySqlClient.MySqlConnection(ConnectionString);
                Connected = true;
            }
            catch
            {
                Connected = false;
            }
        }

        internal static void DoSeekNPCUsingQuery(string _query)
        {
            if (!Connected)
                OpenConnexion();

            _command = new MySqlCommand(_query, _conn);

            using (var reader = _command.ExecuteReader())
            {
                while (reader.Read())
                {

                }
            }
        }
    }
}