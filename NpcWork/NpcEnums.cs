using System;

namespace NpcWork
{
    /// <summary>
    /// A NPC's DB Template
    /// </summary>
    public static readonly struct NpcTemplate
    {
        uint entry;
        fixed uint difficultyEntry[3];
        fixed uint killCredit[2];
        fixed uint modelID[4];
        string name;
        string subname;
        string iconName;
        uint gossipMenuId;
        uint minLevel;
        uint maxLevel;
        uint expansion;
        fixed uint faction[2];
        uint npcFlag;
        fixed float speed[2];
        float scale;
        uint rank;
        fixed float dmg[2];
        uint dmgSchool;
        uint attackPower;
        float dmgMultiplier;
        uint baseAttackTime;
        uint rangeAttackTime;
        uint unitClass;
        uint unitFlags;
        uint dynamicFlags;
        uint family;
        uint trainerType;
        uint trainerSpell;
        uint trainerClass;
        uint trainerRace;
        fixed float rangeDmg[2];
        uint rangedAttackPower;
        uint type;
        uint typeFlags;
        uint lootID;
        uint pickPocketLoot;
        uint skinLoot;
        fixed uint resistance[6];
        fixed uint spell[8];
        uint PetSpellDataId;
        uint VehicleID;
        fixed uint gold[2];
        string AIName;
        uint movementType;
        uint inhabitType;
        float healthMod;
        float manaMod;
        float armorMod;
        uint racialLeader;
        fixed uint QuestItem[6];
        uint movementID;
        uint regenHealth;
        uint equipmentID;
        uint MechanicImmuneMask;
        uint flagsExtra;
        string ScriptName;
    };
}
