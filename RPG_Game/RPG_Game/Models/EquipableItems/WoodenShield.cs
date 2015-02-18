using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using RPG_Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG_Game.Models.EquipableItems
{
    class WoodenShield : Shield
    {
        private const string WoodenShieldName = "Wooden Shield";
        private const int WoodenShieldAttackBonus = 0;
        private const int WoodenShieldDefenceBonus = 10;
        private const int WoodenShieldHealthBonus = 0;
        private const int WoodenShieldManaBonus = 0;

        public WoodenShield(Texture2D texture, IMap map, Point position)
            : base(texture, map, position, WoodenShieldName, WoodenShieldAttackBonus, WoodenShieldDefenceBonus,
            WoodenShieldHealthBonus, WoodenShieldManaBonus)
        {
        }
    }
}
