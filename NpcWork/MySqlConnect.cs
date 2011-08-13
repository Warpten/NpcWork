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
using NpcWork.Extensions;
using NpcWork.Enums;

namespace NpcWork.Database
{
    public static class MySqlConnection
    {
        private static MySql.Data.MySqlClient.MySqlConnection _conn;
        private static MySqlCommand _command;
        private static NpcTemplate _npc;
        private static bool _didFind;

        public static bool Connected { get; private set; }

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
                _conn.Open();
                Connected = true;
            }
            catch
            {
                Connected = false;
            }
        }

        internal static void DoSeekNPCUsingQuery(string _query)
        {
            OpenConnexion();

            if (!Connected)
                throw new Exception("Could not connect to database");

            _didFind = false;
            _command = new MySqlCommand(_query, _conn);

            using (var reader = _command.ExecuteReader())
            {
                while (reader.Read())
                {
                    _didFind = true;
                    _npc = new NpcTemplate
                    {
                        Entry            = reader[0].ToUInt32(),
                        difficultyEntry1 = reader[1].ToUInt32(),
                        difficultyEntry2 = reader[2].ToUInt32(),
                        difficultyEntry3 = reader[3].ToUInt32(),
                        killCredit1      = reader[4].ToUInt32(),
                        killCredit2      = reader[5].ToUInt32(),
                        modelID1         = reader[6].ToUInt32(),
                        modelID2         = reader[7].ToUInt32(),
                        modelID3         = reader[8].ToUInt32(),
                        modelID4         = reader[9].ToUInt32(),
                        name             = reader[10].ToString(),
                        subname          = reader[11].ToString(),
                        iconName         = reader[12].ToString(),
                        gossipMenuId     = reader[13].ToUInt32(),
                        minLevel         = reader[14].ToUInt32(),
                        maxLevel         = reader[15].ToUInt32(),
                        expansion        = reader[16].ToUInt32(),
                        factionA         = reader[17].ToUInt32(),
                        factionH         = reader[18].ToUInt32(),
                        npcFlag          = reader[19].ToUInt32(),
                        speedWalk        = reader[20].ToFloat(),
                        speedRun         = reader[21].ToFloat(),
                        scale            = reader[22].ToFloat(),
                        rank             = reader[23].ToUInt32(),
                        minDmg           = reader[24].ToUInt32(),
                        maxDmg           = reader[25].ToUInt32(),
                        dmgSchool        = reader[26].ToUInt32(),
                        attackPower      = reader[27].ToUInt32(),
                        dmgMultiplier    = reader[28].ToFloat(),
                        baseAttackTime   = reader[29].ToUInt32(),
                        rangeAttackTime  = reader[30].ToUInt32(),
                        unitClass        = reader[31].ToUInt32(),
                        unitFlags        = reader[32].ToUInt32(),
                        dynamicFlags     = reader[33].ToUInt32(),
                        family           = reader[34].ToUInt32(),
                        trainerType      = reader[35].ToUInt32(),
                        trainerSpell     = reader[36].ToUInt32(),
                        trainerClass     = reader[37].ToUInt32(),
                        trainerRace      = reader[38].ToUInt32(),
                        minRangeDmg      = reader[39].ToUInt32(),
                        maxRangeDmg      = reader[40].ToUInt32(),
                        rangedAttackPower= reader[41].ToUInt32(),
                        type             = reader[42].ToUInt32(),
                        typeFlags        = reader[43].ToUInt32(),
                        lootID           = reader[44].ToUInt32(),
                        pickPocketLoot   = reader[45].ToUInt32(),
                        skinLoot         = reader[46].ToUInt32(),
                        resistance1      = reader[47].ToUInt32(),
                        resistance2      = reader[48].ToUInt32(),
                        resistance3      = reader[49].ToUInt32(),
                        resistance4      = reader[50].ToUInt32(),
                        resistance5      = reader[51].ToUInt32(),
                        resistance6      = reader[52].ToUInt32(),
                        spell1           = reader[53].ToUInt32(),
                        spell2           = reader[54].ToUInt32(),
                        spell3           = reader[55].ToUInt32(),
                        spell4           = reader[56].ToUInt32(),
                        spell5           = reader[57].ToUInt32(),
                        spell6           = reader[58].ToUInt32(),
                        spell7           = reader[59].ToUInt32(),
                        spell8           = reader[60].ToUInt32(),
                        PetSpellDataId   = reader[61].ToUInt32(),
                        VehicleID        = reader[62].ToUInt32(),
                        minGold          = reader[63].ToUInt32(),
                        maxGold          = reader[64].ToUInt32(),
                        AIName           = reader[65].ToString(),
                        movementType     = reader[66].ToUInt32(),
                        inhabitType      = reader[67].ToUInt32(),
                        healthMod        = reader[68].ToUInt32(),
                        manaMod          = reader[69].ToUInt32(),
                        armorMod         = reader[70].ToUInt32(),
                        racialLeader     = reader[71].ToUInt32(),
                        QuestItem1       = reader[72].ToUInt32(),
                        QuestItem2       = reader[73].ToUInt32(),
                        QuestItem3       = reader[74].ToUInt32(),
                        QuestItem4       = reader[75].ToUInt32(),
                        QuestItem5       = reader[76].ToUInt32(),
                        QuestItem6       = reader[77].ToUInt32(),
                        movementID       = reader[78].ToUInt32(),
                        regenHealth      = reader[79].ToUInt32(),
                        equipmentID      = reader[80].ToUInt32(),
                        MechanicImmuneMask = reader[81].ToUInt32(),
                        flagsExtra       = reader[82].ToUInt32(),
                        ScriptName       = reader[83].ToString(),
                    };
                }
            }
        }

        public static bool DidFindNPC() { return _didFind; }
        public static NpcTemplate GetNPCTemplate() { return _npc; }
    }
}