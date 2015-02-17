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
        private readonly List<string> dropList;

        protected Enemy(Texture2D texture, IMap map, Point position,
            string name, int health, int mana, int attack, int defence, List<string> dropList)
            : base(texture, map, position, name, health, mana, attack, defence)
        {
            this.dropList = dropList;
        }

        public List<string> DropList
        {
            get
            {
                return new List<string>(dropList);
            }
        }

        public string ItemToDrop()
        {
            return this.dropList[0];
        }
    }
}
