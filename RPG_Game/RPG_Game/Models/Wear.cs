namespace RPG_Game.Models
{
    using Interfaces;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using RPG_Game.Enums;

    public class Wear : GameItem, IEquipable
    {
        public Wear(Texture2D texture, IMap map, Point position, 
            string name, int attackBonus, int defenceBonus, int healthBonus, int manaBonus) 
            : base(texture, map, position, name)
        {
            this.AttackBonus = attackBonus;
            this.DefenceBonus = defenceBonus;
            this.HealthBonus = healthBonus;
            this.ManaBonus = manaBonus;
        }

        public int AttackBonus { get; set; }

        public int DefenceBonus { get; set; }

        public int HealthBonus { get; set; }

        public int ManaBonus { get; set; }
    }
}
