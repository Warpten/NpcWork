using System;
using System.Runtime.InteropServices;

namespace NpcWork.Enums
{
    /// <summary>
    /// A NPC's DB Template
    /// </summary>
    public struct NpcTemplate
    {
        public uint Entry;
        public uint difficultyEntry1;
        public uint difficultyEntry2;
        public uint difficultyEntry3;
        public uint killCredit1;
        public uint killCredit2;
        public uint modelID1;
        public uint modelID2;
        public uint modelID3;
        public uint modelID4;
        public string name;
        public string subname;
        public string iconName;
        public uint gossipMenuId;
        public uint minLevel;
        public uint maxLevel;
        public uint expansion;
        public uint factionA;
        public uint factionH;
        public uint npcFlag;
        public float speedWalk;
        public float speedRun;
        public float scale;
        public uint rank;
        public float minDmg;
        public float maxDmg;
        public uint dmgSchool;
        public uint attackPower;
        public float dmgMultiplier;
        public uint baseAttackTime;
        public uint rangeAttackTime;
        public uint unitClass;
        public uint unitFlags;
        public uint dynamicFlags;
        public uint family;
        public uint trainerType;
        public uint trainerSpell;
        public uint trainerClass;
        public uint trainerRace;
        public float minRangeDmg;
        public float maxRangeDmg;
        public uint rangedAttackPower;
        public uint type;
        public uint typeFlags;
        public uint lootID;
        public uint pickPocketLoot;
        public uint skinLoot;
        public uint resistance1;
        public uint resistance2;
        public uint resistance3;
        public uint resistance4;
        public uint resistance5;
        public uint resistance6;
        public uint spell1;
        public uint spell2;
        public uint spell3;
        public uint spell4;
        public uint spell5;
        public uint spell6;
        public uint spell7;
        public uint spell8;
        public uint PetSpellDataId;
        public uint VehicleID;
        public uint minGold;
        public uint maxGold;
        public string AIName;
        public uint movementType;
        public uint inhabitType;
        public float healthMod;
        public float manaMod;
        public float armorMod;
        public uint racialLeader;
        public uint QuestItem1;
        public uint QuestItem2;
        public uint QuestItem3;
        public uint QuestItem4;
        public uint QuestItem5;
        public uint QuestItem6;
        public uint movementID;
        public uint regenHealth;
        public uint equipmentID;
        public uint MechanicImmuneMask;
        public uint flagsExtra;
        public string ScriptName;
    };
}
