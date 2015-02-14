namespace RPG_Game.Models.DrinkableItems
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using RPG_Game.Enums;
    using RPG_Game.Interfaces;

    public class MinorHealingPotion : Drink
    {
        private const string MinorHPName = "Minor Healing Potion";
        private const int MinorHPHealthRP = 20;


        public MinorHealingPotion(Texture2D texture, IMap map, Point position)
            : base(texture, map, position, MinorHPName, MinorHPHealthRP, 0, 0, 0, 0, 0)
        {
        }
    }
}
