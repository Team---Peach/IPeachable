namespace RPG_Game.Models.DrinkableItems
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using RPG_Game.Enums;
    using RPG_Game.Interfaces;

    public class HealingPotion : Drink
    {
        private const string HealingPotionName = "Healing Potion";
        private const int HealingPotionHealthRP = 50;


        public HealingPotion(Texture2D texture, IMap map, Point position)
            : base(texture, map, position, HealingPotionName, HealingPotionHealthRP, 0, 0, 0, 0, 0)
        {
        }
    }
}
