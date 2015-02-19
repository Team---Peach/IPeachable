using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG_Game.GameData
{
    public static class ObjectsConstants
    {
        // Drink items stats

        #region Healing potions
        // Minor Healing Potion
        public const string MinorHPName = "Minor Healing Potion";
        public const int MinorHPHealthRP = 20;

        // Healing Potion
        public const string HealingPotionName = "Healing Potion";
        public const int HealingPotionHealthRP = 50;

        // Major Healing Potion
        public const string MajorHPName = "Major Healing Potion";
        public const int MajorHPHealthRP = 100;
        #endregion

        // Equip items stats

        #region Feet
        // Boots
        public const string BootsName = "Boots";
        public const int BootsAttackBonus = 0;
        public const int BootsDefenceBonus = 10;
        public const int BootsHealthBonus = 0;
        public const int BootsManaBonus = 0;
        public const string BootsSlot = "feet";

        // Leather Boots
        public const string LeatherBootsName = "Leather Boots";
        public const int LeatherBootsAttackBonus = 0;
        public const int LeatherBootsDefenceBonus = 20;
        public const int LeatherBootsHealthBonus = 0;
        public const int LeatherBootsManaBonus = 0;
        public const string LeatherBootsSlot = "feet";

        // Enchanted Boots
        public const string EnchantedBootsName = "Enchanted Boots";
        public const int EnchantedBootsAttackBonus = 0;
        public const int EnchantedBootsDefenceBonus = 40;
        public const int EnchantedBootsHealthBonus = 20;
        public const int EnchantedBootsManaBonus = 0;
        public const string EnchantedBootsSlot = "feet";
        #endregion

        #region Head

        // Hat
        public const string HatName = "Hat";
        public const int HatAttackBonus = 0;
        public const int HatDefenceBonus = 10;
        public const int HatHealthBonus = 0;
        public const int HatManaBonus = 0;
        public const string HatSlot = "head";

        // Helmet
        public const string HelmetName = "Helmet";
        public const int HelmetAttackBonus = 0;
        public const int HelmetDefenceBonus = 30;
        public const int HelmetHealthBonus = 0;
        public const int HelmetManaBonus = 0;
        public const string HelmetSlot = "head";

        // Enchanted Helmet
        public const string EnchantedHelmetName = "Enchanted Helmet";
        public const int EnchantedHelmetAttackBonus = 10;
        public const int EnchantedHelmetDefenceBonus = 40;
        public const int EnchantedHelmetHealthBonus = 0;
        public const int EnchantedHelmetManaBonus = 0;
        public const string EnchantedHelmetSlot = "head";

        #endregion

        #region Body
        // Leather Armor
        public const string LeatherArmorName = "Leather Armor";
        public const int LeatherArmorAttackBonus = 0;
        public const int LeatherArmorDefenceBonus = 20;
        public const int LeatherArmorHealthBonus = 0;
        public const int LeatherArmorManaBonus = 0;
        public const string LeatherArmorSlot = "body";

        // Iron Armor
        public const string IronArmorName = "Iron Armor";
        public const int IronArmorAttackBonus = 10;
        public const int IronArmorDefenceBonus = 40;
        public const int IronArmorHealthBonus = 0;
        public const int IronArmorManaBonus = 0;
        public const string IronArmorSlot = "body";

        // Enchanted Armor
        public const string EnchantedArmorName = "Enchanted Armor";
        public const int EnchantedArmorAttackBonus = 20;
        public const int EnchantedArmorDefenceBonus = 50;
        public const int EnchantedArmorHealthBonus = 0;
        public const int EnchantedArmorManaBonus = 0;
        public const string EnchantedArmorSlot = "body";
        #endregion

        #region Hand

        // Leather Gloves
        public const string LeatherGlovesName = "Leather Gloves";
        public const int LeatherGlovesAttackBonus = 0;
        public const int LeatherGlovesDefenceBonus = 10;
        public const int LeatherGlovesHealthBonus = 0;
        public const int LeatherGlovesManaBonus = 0;
        public const string LeatherGlovesSlot = "hand";

        //Runic Gloves
        public const string RunicGlovesName = "Runic Gloves";
        public const int RunicGlovesAttackBonus = 10;
        public const int RunicGlovesDefenceBonus = 10;
        public const int RunicGlovesHealthBonus = 0;
        public const int RunicGlovesManaBonus = 0;
        public const string RunicGlovesSlot = "hand";

        // Enchanted Gloves
        public const string EnchantedGlovesName = "Enchanted Gloves";
        public const int EnchantedGlovesAttackBonus = 20;
        public const int EnchantedGlovesDefenceBonus = 20;
        public const int EnchantedGlovesHealthBonus = 0;
        public const int EnchantedGlovesManaBonus = 0;
        public const string EnchantedGlovesSlot = "hand";

        #endregion

        #region Pant

        // Pants
        public const string PantsName = "Pants";
        public const int PantsAttackBonus = 0;
        public const int PantsDefenceBonus = 10;
        public const int PantsHealthBonus = 0;
        public const int PantsManaBonus = 0;
        public const string PantsSlot = "pant";

        // Leather Pants
        public const string LeatherPantsName = "Leather Pants";
        public const int LeatherPantsAttackBonus = 0;
        public const int LeatherPantsDefenceBonus = 20;
        public const int LeatherPantsHealthBonus = 0;
        public const int LeatherPantsManaBonus = 10;
        public const string LeatherPantsSlot = "pant";

        // Enchanted Pants
        public const string EnchantedPantsName = "Enchanted Pants";
        public const int EnchantedPantsAttackBonus = 0;
        public const int EnchantedPantsDefenceBonus = 40;
        public const int EnchantedPantsHealthBonus = 0;
        public const int EnchantedPantsManaBonus = 20;
        public const string EnchantedPantsSlot = "pant";

        #endregion

        #region Weapon

        // Short Sword
        public const string ShortSwordName = "Short Sword";
        public const int ShortSwordAttackBonus = 15;
        public const int ShortSwordDefenceBonus = 0;
        public const int ShortSwordHealthBonus = 0;
        public const int ShortSwordManaBonus = 0;
        public const string ShortSwordSlot = "weapon";

        // Sword
        public const string SwordName = "Sword";
        public const int SwordAttackBonus = 30;
        public const int SwordDefenceBonus = 0;
        public const int SwordHealthBonus = 0;
        public const int SwordManaBonus = 0;
        public const string SwordSlot = "weapon";

        // Enchanted Sword
        public const string EnchantedSwordName = "Enchanted Sword";
        public const int EnchantedSwordAttackBonus = 50;
        public const int EnchantedSwordDefenceBonus = 20;
        public const int EnchantedSwordHealthBonus = 20;
        public const int EnchantedSwordManaBonus = 0;
        public const string EnchantedSwordSlot = "weapon";

        //Short Staff
        public const string ShortStaffName = "Short Staff";
        public const int ShortStaffAttackBonus = 10;
        public const int ShortStaffDefenceBonus = 0;
        public const int ShortStaffHealthBonus = 0;
        public const int ShortStaffManaBonus = 20;
        public const string ShortStaffSlot = "weapon";

        // Staff
        public const string StaffName = "Staff";
        public const int StaffAttackBonus = 20;
        public const int StaffDefenceBonus = 0;
        public const int StaffHealthBonus = 0;
        public const int StaffManaBonus = 50;
        public const string StaffSlot = "weapon";

        // Enchanted Staff
        public const string EnchantedStaffName = "Enchanted Staff";
        public const int EnchantedStaffAttackBonus = 20;
        public const int EnchantedStaffDefenceBonus = 0;
        public const int EnchantedStaffHealthBonus = 0;
        public const int EnchantedStaffManaBonus = 50;
        public const string EnchantedStaffSlot = "weapon";

        #endregion

        #region Shield

        // Wooden Shield
        public const string WoodenShieldName = "Wooden Shield";
        public const int WoodenShieldAttackBonus = 0;
        public const int WoodenShieldDefenceBonus = 10;
        public const int WoodenShieldHealthBonus = 0;
        public const int WoodenShieldManaBonus = 0;
        public const string WoodenShieldSlot = "shield";

        // Leather Shield
        public const string LeatherShieldName = "Leather Shield";
        public const int LeatherShieldAttackBonus = 0;
        public const int LeatherShieldDefenceBonus = 20;
        public const int LeatherShieldHealthBonus = 0;
        public const int LeatherShieldManaBonus = 0;
        public const string LeatherShieldSlot = "shield";

        // Enchanted Shield
        public const string EnchantedShieldName = "Enchanted Shield";
        public const int EnchantedShieldAttackBonus = 0;
        public const int EnchantedShieldDefenceBonus = 30;
        public const int EnchantedShieldHealthBonus = 20;
        public const int EnchantedShieldManaBonus = 0;
        public const string EnchantedShieldSlot = "shield";

        #endregion

        // Enemies stats

        #region Enemies

        // Rat
        public const string RatName = "Rat";
        public const int RatHealth = 20;
        public const int RatMana = 0;
        public const int RatAttack = 5;
        public const int RatDefence = 10;
        public static readonly List<string> RatDropList = new List<string>()
        {
            "minorHP",
            "boots",
            "shortSword",
            "hat"
        };

        // Spider
        public const string SpiderName = "Spider";
        public const int SpiderHealth = 35;
        public const int SpiderMana = 0;
        public const int SpiderAttack = 10;
        public const int SpiderDefence = 15;
        public static readonly List<string> SpiderDropList = new List<string>
        {
            "minorHP",
            "pants",
            "shortStaff",
            "leatherGloves"
        };

        // Goblin
        public const string GoblinName = "Goblin";
        public const int GoblinHealth = 45;
        public const int GoblinMana = 0;
        public const int GoblinAttack = 10;
        public const int GoblinDefence = 15;
        public static readonly List<string> GoblinDropList = new List<string>
        {
            "minorHP",
            "woodenShield",
            "sword"
        };

        //Ogre
        public const string OgreName = "Ogre";
        public const int OgreHealth = 100;
        public const int OgreMana = 0;
        public const int OgreAttack = 15;
        public const int OgreDefence = 10;
        public static readonly List<string> OgreDropList = new List<string>
        {
            "minorHP",
            "helmet",
            "ironArmor",
            "leather shield"
        };

        // Goblin Boss
        public const string GoblinBossName = "Goblin Boss";
        public const int GoblinBossHealth = 150;
        public const int GoblinBossMana = 0;
        public const int GoblinBossAttack = 30;
        public const int GoblinBossDefence = 30;
        public static readonly List<string> GoblinBossDropList = new List<string>
        {
            "enchantedGloves"
        };

        // Goblin Warrior
        public const string GoblinWarriorName = "Goblin Warrior";
        public const int GoblinWarriorHealth = 120;
        public const int GoblinWarriorMana = 0;
        public const int GoblinWarriorAttack = 30;
        public const int GoblinWarriorDefence = 25;
        public static readonly List<string> GoblinWarriorDropList = new List<string>
        {
            "healingPotion",
            "leatherArmor",
            "runicGloves",
            "staff"
        };

        // Ogre Boss
        public const string OgreBossName = "Ogre Boss";
        public const int OgreBossHealth = 250;
        public const int OgreBossMana = 0;
        public const int OgreBossAttack = 50;
        public const int OgreBossDefence = 15;
        public static readonly List<string> OgreBossDropList = new List<string>
        {
            "enchantedArmor"
        };

        // Shade
        public const string ShadeName = "Shade";
        public const int ShadeHealth = 150;
        public const int ShadeMana = 0;
        public const int ShadeAttack = 45;
        public const int ShadeDefence = 35;
        public static readonly List<string> ShadeDropList = new List<string>
        {
            "majorHP",
            "leather boots",
            "leather pants",
            "enchantedStaff"
        };

        // Goblin Warrior Boss
        public const string GoblinWarriorBossName = "Goblin Warrior Boss";
        public const int GoblinWarriorBossHealth = 200;
        public const int GoblinWarriorBossMana = 0;
        public const int GoblinWarriorBossAttack = 60;
        public const int GoblinWarriorBossDefence = 45;
        public static readonly List<string> GoblinWarriorBossDropList = new List<string>
        {
            "enchantedShield"
        };

        // Stranger
        public const string StrangerName = "Stranger";
        public const int StrangerHealth = 250;
        public const int StrangerMana = 0;
        public const int StrangerAttack = 80;
        public const int StrangerDefence = 55;
        public static readonly List<string> StrangerDropList = new List<string>
        {
            "enchantedBoots"
        };

        // Shade Boss
        public const string ShadeBossName = "Shade Boss";
        public const int ShadeBossHealth = 300;
        public const int ShadeBossMana = 0;
        public const int ShadeBossAttack = 80;
        public const int ShadeBossDefence = 55;
        public static readonly List<string> ShadeBossDropList = new List<string>
        {
            "enchantedHelmet"
        };

        // Ancient Swordsman
        public const string AncientSwordsmanName = "Ancient Swordsman";
        public const int AncientSwordsmanHealth = 400;
        public const int AncientSwordsmanMana = 0;
        public const int AncientSwordsmanAttack = 90;
        public const int AncientSwordsmanDefence = 60;
        public static readonly List<string> AncientSwordsmanDropList = new List<string>
        {
            "enchantedSword"
        };

        // Destructo
        public const string DestructoName = "Destructo";
        public const int DestructoHealth = 500;
        public const int DestructoMana = 0;
        public const int DestructoAttack = 120;
        public const int DestructoDefence = 80;
        public static readonly List<string> DestructoDropList = new List<string>
        {
            "enchantedPants"
        };

        // Final Boss
        public const string FinalBossName = "Final Boss";
        public const int FinalBossHealth = 1000;
        public const int FinalBossMana = 0;
        public const int FinalBossAttack = 150;
        public const int FinalBossDefence = 100;
        public static readonly List<string> FinalBossDropList = new List<string>();

        #endregion
    }
}
