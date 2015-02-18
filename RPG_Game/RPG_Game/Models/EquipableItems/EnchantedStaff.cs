using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using RPG_Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG_Game.Models.EquipableItems
{
    public class EnchantedStaff : Weapon
    {
        private const string EnchantedStaffName = "Enchanted Staff";
        private const int EnchantedStaffAttackBonus = 20;
        private const int EnchantedStaffDefenceBonus = 0;
        private const int EnchantedStaffHealthBonus = 0;
        private const int EnchantedStaffManaBonus = 50;

        public EnchantedStaff(Texture2D texture, IMap map, Point position)
            : base(texture, map, position, EnchantedStaffName, EnchantedStaffAttackBonus, EnchantedStaffDefenceBonus, EnchantedStaffHealthBonus, EnchantedStaffManaBonus)
        {
        }
    }
}
