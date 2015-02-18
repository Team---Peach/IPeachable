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

        // Enemy textures
        public static Texture2D Goblin { get; set; }
        public static Texture2D GoblinBoss { get; set; }
        public static Texture2D Ogre { get; set; }
        public static Texture2D Rat { get; set; }
        public static Texture2D Spider { get; set; }

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

        // Font textures
        public static SpriteFont SpriteFont { get; set; }

        public static void LoadTextures(ContentManager content)
        {
            // Base textures load
            MapFloor = content.Load<Texture2D>("Floor");
            MapWall = content.Load<Texture2D>("Wall");
            Player = content.Load<Texture2D>("Player");

            // Enemy textures load
            Goblin = content.Load<Texture2D>("Enemies/Goblin");
            GoblinBoss = content.Load<Texture2D>("Enemies/GoblinBoss");
            Ogre = content.Load<Texture2D>("Enemies/Ogre");
            Rat = content.Load<Texture2D>("Enemies/Rat");
            Spider = content.Load<Texture2D>("Enemies/Spider");

            // Item textures load
            MinorHealthPotion = content.Load<Texture2D>("Items/Drink/MinorHealthPotion");
            HealthPotion = content.Load<Texture2D>("Items/Drink/HealthPotion");
            MajorHealthPotion = content.Load<Texture2D>("Items/Drink/MajorHealthPotion");

            // Font textures load
            SpriteFont = content.Load<SpriteFont>("GameFont");
        }
    }
}
