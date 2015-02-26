namespace RPG_Game.GameData
{
    using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

    public static class Textures
    {
        // Base textures
        public static Texture2D MapFloor { get; set; }
        public static Texture2D MapWall { get; set; }
        public static Texture2D Player { get; set; }
        public static Texture2D GameOver { get; set; }

        // Enemy textures
        public static Texture2D Goblin { get; set; }
        public static Texture2D GoblinBoss { get; set; }
        public static Texture2D Ogre { get; set; }
        public static Texture2D Rat { get; set; }
        public static Texture2D OgreBoss { get; set; }
        public static Texture2D GoblinWarrior { get; set; }
        public static Texture2D GoblinWarriorBoss { get; set; }
        public static Texture2D Shade { get; set; }
        public static Texture2D ShadeBoss { get; set; }
        public static Texture2D Stranger { get; set; }
        public static Texture2D Spider { get; set; }
        public static Texture2D AncientSwordsman { get; set; }
        public static Texture2D Destructo { get; set; }
        public static Texture2D FinalBoss { get; set; }

        // Drinkable item textures
        public static Texture2D MinorHealthPotion { get; set; }
        public static Texture2D HealthPotion { get; set; }
        public static Texture2D MajorHealthPotion { get; set; }

        // Equipable item textures
        public static Texture2D Boots { get; set; }
        public static Texture2D LeatherBoots { get; set; }
        public static Texture2D EnchantedBoots { get; set; }
        public static Texture2D LeatherGloves { get; set; }
        public static Texture2D RunicGloves { get; set; }
        public static Texture2D EnchantedGloves { get; set; }
        public static Texture2D Hat { get; set; }
        public static Texture2D Helmet { get; set; }
        public static Texture2D EnchantedHelmet { get; set; }
        public static Texture2D LeatherArmor { get; set; }
        public static Texture2D IronArmor { get; set; }
        public static Texture2D EnchantedArmor { get; set; }
        public static Texture2D Pants { get; set; }
        public static Texture2D LeatherPants { get; set; }
        public static Texture2D EnchantedPants { get; set; }
        public static Texture2D ShortSword { get; set; }
        public static Texture2D Sword { get; set; }
        public static Texture2D EnchantedSword { get; set; }
        public static Texture2D ShortStaff { get; set; }
        public static Texture2D Staff { get; set; }
        public static Texture2D EnchantedStaff { get; set; }
        public static Texture2D LeatherShield { get; set; }
        public static Texture2D WoodenShield { get; set; }
        public static Texture2D EnchantedShield { get; set; }

        // Font textures
        public static SpriteFont SpriteFont { get; set; }

        public static void LoadTextures(ContentManager content)
        {
            // Base textures load
            MapFloor = content.Load<Texture2D>("Floor");
            MapWall = content.Load<Texture2D>("Wall");
            Player = content.Load<Texture2D>("Player");
            GameOver = content.Load<Texture2D>("GameOver");

            // Enemy textures load
            Goblin = content.Load<Texture2D>("Enemies/Goblin");
            GoblinBoss = content.Load<Texture2D>("Enemies/GoblinBoss");
            Ogre = content.Load<Texture2D>("Enemies/Ogre");
            Rat = content.Load<Texture2D>("Enemies/Rat");
            Spider = content.Load<Texture2D>("Enemies/Spider");
            OgreBoss = content.Load<Texture2D>("Enemies/OgreBoss");
            GoblinWarrior = content.Load<Texture2D>("Enemies/GoblinWarrior");
            GoblinWarriorBoss = content.Load<Texture2D>("Enemies/GoblinWarriorBoss");
            Shade = content.Load<Texture2D>("Enemies/Shade");
            ShadeBoss = content.Load<Texture2D>("Enemies/ShadeBoss");
            Destructo = content.Load<Texture2D>("Enemies/Destructo");
            Stranger = content.Load<Texture2D>("Enemies/Stranger");
            FinalBoss = content.Load<Texture2D>("Enemies/FinalBoss");
            AncientSwordsman = content.Load<Texture2D>("Enemies/AncientSwordsman");

            // Item textures load
            MinorHealthPotion = content.Load<Texture2D>("Items/Drink/MinorHealthPotion");
            HealthPotion = content.Load<Texture2D>("Items/Drink/HealthPotion");
            MajorHealthPotion = content.Load<Texture2D>("Items/Drink/MajorHealthPotion");

            // Equipable item textures load
            Boots = content.Load<Texture2D>("Items/Equip/Boots");
            EnchantedArmor = content.Load<Texture2D>("Items/Equip/EnchantedArmor");
            EnchantedBoots = content.Load<Texture2D>("Items/Equip/EnchantedBoots");
            EnchantedGloves = content.Load<Texture2D>("Items/Equip/EnchantedGloves");
            EnchantedHelmet = content.Load<Texture2D>("Items/Equip/EnchantedHelmet");
            EnchantedPants = content.Load<Texture2D>("Items/Equip/EnchantedPants");
            EnchantedStaff = content.Load<Texture2D>("Items/Equip/EnchantedStaff");
            EnchantedSword = content.Load<Texture2D>("Items/Equip/EnchantedSword");
            Hat = content.Load<Texture2D>("Items/Equip/Hat");
            Helmet = content.Load<Texture2D>("Items/Equip/Helmet");
            IronArmor = content.Load<Texture2D>("Items/Equip/IronArmor");
            LeatherArmor = content.Load<Texture2D>("Items/Equip/LeatherArmor");
            LeatherPants = content.Load<Texture2D>("Items/Equip/LeatherPants");
            LeatherBoots = content.Load<Texture2D>("Items/Equip/LeatherBoots");
            LeatherGloves = content.Load<Texture2D>("Items/Equip/LeatherGloves");
            LeatherShield = content.Load<Texture2D>("Items/Equip/LeatherShield");
            EnchantedShield = content.Load<Texture2D>("Items/Equip/EnchantedShield");
            Pants = content.Load<Texture2D>("Items/Equip/Pants");
            RunicGloves = content.Load<Texture2D>("Items/Equip/RunicGloves");
            ShortStaff = content.Load<Texture2D>("Items/Equip/ShortStaff");
            ShortSword = content.Load<Texture2D>("Items/Equip/ShortSword");
            Staff = content.Load<Texture2D>("Items/Equip/Staff");
            Sword = content.Load<Texture2D>("Items/Equip/Sword");
            WoodenShield = content.Load<Texture2D>("Items/Equip/WoodenShield");

            // Font textures load
            SpriteFont = content.Load<SpriteFont>("Fonts/GameFont");
        }
    }
}
