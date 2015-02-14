namespace RPG_Game.Models
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using RPG_Game.Enums;
    using RPG_Game.Interfaces;
    using System;

    public abstract class Enemy : GameUnit, IEnemy
    {
        protected Enemy(Texture2D texture, Flags flags, IMap map, Point position, 
            string name, int health, int mana, int attack, int defence) 
            : base(texture, flags, map, position, name, health, mana, attack, defence)
        {
        }
    }
}
