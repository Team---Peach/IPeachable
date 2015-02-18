using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG_Game.Models
{
    public class Weapon : Equip
    {
        public Weapon(Microsoft.Xna.Framework.Graphics.Texture2D texture, Interfaces.IMap map, Point position, string name, 
            int attackBonus, int defenceBonus, int healthBonus, int manaBonus)
            : base(texture, map, position, name, attackBonus, defenceBonus, healthBonus, manaBonus, "weapon")
        {
        }
    }
}
