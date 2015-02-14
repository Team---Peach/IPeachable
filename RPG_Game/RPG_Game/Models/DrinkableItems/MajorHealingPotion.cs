namespace RPG_Game.Models.DrinkableItems
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using RPG_Game.Enums;
    using RPG_Game.Interfaces;

    public class MajorHealingPotion : Drink
    {
        private const string MajorHPName = "Major Healing Potion";
        private const int MajorHPHealthRP = 20;


        public MajorHealingPotion(Texture2D texture, IMap map, Point position)
            : base(texture, map, position, MajorHPName, MajorHPHealthRP, 0, 0, 0, 0, 0)
        {
        }
    }
}
