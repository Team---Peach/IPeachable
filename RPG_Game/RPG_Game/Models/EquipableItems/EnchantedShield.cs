using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using RPG_Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG_Game.Models.EquipableItems
{
    class EnchantedShield : Shield
    {
        private const string EnchantedShieldName = " Enchanted Shield";
        private const int EnchantedShieldAttackBonus = 0;
        private const int EnchantedShieldDefenceBonus = 30;
        private const int EnchantedShieldHealthBonus = 20;
        private const int EnchantedShieldManaBonus = 0;

        public EnchantedShield(Texture2D texture, IMap map, Point position)
            : base(texture, map, position, EnchantedShieldName, EnchantedShieldAttackBonus, EnchantedShieldDefenceBonus,
            EnchantedShieldHealthBonus, EnchantedShieldManaBonus)
        {
        }
    }
}
