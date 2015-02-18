using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG_Game.Models
{
    public class Body : Equip
    {
        public Body(Microsoft.Xna.Framework.Graphics.Texture2D texture, Interfaces.IMap map, Point position, string name, 
            int attackBonus, int defenceBonus, int healthBonus, int manaBonus) 
            : base(texture, map, position, name, attackBonus, defenceBonus, healthBonus, manaBonus, "body")
        {
        }
    }
}
