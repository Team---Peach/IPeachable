using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using RPG_Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG_Game.Models.EquipableItems
{
    public class ShortStaff : Weapon
    {
        private const string ShortStaffName = "Short Staff";
        private const int ShortStaffAttackBonus = 10;
        private const int ShortStaffDefenceBonus = 0;
        private const int ShortStaffHealthBonus = 0;
        private const int ShortStaffManaBonus = 20;

        public ShortStaff(Texture2D texture, IMap map, Point position)
            : base(texture, map, position, ShortStaffName, ShortStaffAttackBonus, ShortStaffDefenceBonus, ShortStaffHealthBonus, ShortStaffManaBonus)
        {
        }
    }
}
