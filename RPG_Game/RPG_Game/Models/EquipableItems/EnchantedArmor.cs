using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using RPG_Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG_Game.Models.EquipableItems
{
    public class EnchantedArmor : Body
    {
        private const string EnchantedArmorName = "Enchanted Armor";
        private const int EnchantedArmorAttackBonus = 10;
        private const int EnchantedArmorDefenceBonus = 40;
        private const int EnchantedArmorHealthBonus = 0;
        private const int EnchantedArmorManaBonus = 0;

        public EnchantedArmor(Texture2D texture, IMap map, Point position)
            : base(texture, map, position, EnchantedArmorName, EnchantedArmorAttackBonus, EnchantedArmorDefenceBonus,
            EnchantedArmorHealthBonus, EnchantedArmorManaBonus)
        {
        }
    }
}
