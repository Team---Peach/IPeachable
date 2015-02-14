namespace RPG_Game.Models
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using RPG_Game.Enums;
    using RPG_Game.Interfaces;
    using System;
    using System.Collections.Generic;

    public abstract class Enemy : GameUnit, IEnemy
    {
        private readonly IList<IEnemy> dropList = new List<IEnemy>(); 

        protected Enemy(Texture2D texture, IMap map, Point position,
            string name, int health, int mana, int attack, int defence, List<IEnemy> dropList = null)
            : base(texture, Flags.IsEnemy, map, position, name, health, mana, attack, defence)
        {
            this.dropList = dropList;
        }

        public IList<IEnemy> DropList
        {
            get
            {
                return new List<IEnemy>(dropList);
            }
        }
    }
}
