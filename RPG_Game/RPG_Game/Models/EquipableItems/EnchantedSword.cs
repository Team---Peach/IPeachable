using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using RPG_Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG_Game.Models.EquipableItems
{
    public class EnchantedSword : Weapon
    {
        private const string EnchantedSwordName = "Enchanted Sword";
        private const int EnchantedSwordAttackBonus = 50;
        private const int EnchantedSwordDefenceBonus = 20;
        private const int EnchantedSwordHealthBonus = 20;
        private const int EnchantedSwordManaBonus = 0;

        public EnchantedSword(Texture2D texture, IMap map, Point position)
            : base(texture, map, position, EnchantedSwordName, EnchantedSwordAttackBonus, EnchantedSwordDefenceBonus, EnchantedSwordHealthBonus, EnchantedSwordManaBonus)
        {
        }
    }
}
