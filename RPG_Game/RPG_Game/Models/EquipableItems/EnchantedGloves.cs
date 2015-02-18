using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using RPG_Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG_Game.Models.EquipableItems
{
    public class EnchantedGloves : Hand
    {
        private const string EnchantedGlovesName = "Enchanted Gloves";
        private const int EnchantedGlovesAttackBonus = 20;
        private const int EnchantedGlovesDefenceBonus = 20;
        private const int EnchantedGlovesHealthBonus = 0;
        private const int EnchantedGlovesManaBonus = 0;

        public EnchantedGloves(Texture2D texture, IMap map, Point position)
            : base(texture, map, position, EnchantedGlovesName, EnchantedGlovesAttackBonus, EnchantedGlovesDefenceBonus,
            EnchantedGlovesHealthBonus, EnchantedGlovesManaBonus)
        {
        }
    }
}
