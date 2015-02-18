using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using RPG_Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG_Game.Models.EquipableItems
{
    public class EnchantedBoots : Feet
    {
        private const string EnchantedBootsName = "Enchanted Boots";
        private const int EnchantedBootsAttackBonus = 0;
        private const int EnchantedBootsDefenceBonus = 40;
        private const int EnchantedBootsHealthBonus = 20;
        private const int EnchantedBootsManaBonus = 0;

        public EnchantedBoots(Texture2D texture, IMap map, Point position)
            : base(texture, map, position, EnchantedBootsName, EnchantedBootsAttackBonus, EnchantedBootsDefenceBonus,
            EnchantedBootsHealthBonus, EnchantedBootsManaBonus)
        {
        }
    }
}
