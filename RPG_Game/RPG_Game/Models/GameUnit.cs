namespace RPG_Game.Models
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using Enums;
    using Interfaces;

    public abstract class GameUnit : GameObject, IGameUnit
    {
        protected GameUnit(Texture2D texture, Flags flags, IMap map, Point position,
            string name, int health, int mana, int attack, int defence)
            : base(texture, flags, map, position, name)
        {
            this.Health = health;
            this.Mana = mana;
            this.Attack = attack;
            this.Defence = defence;
        }

        public int Health { get; set; }

        public int Mana { get; set; }

        public int Attack { get; set; }

        public int Defence { get; set; }
    }
}
