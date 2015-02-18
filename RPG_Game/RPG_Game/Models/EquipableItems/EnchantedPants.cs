using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using RPG_Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG_Game.Models.EquipableItems
{
    public class EnchantedPants : Pant
    {
        private const string EnchantedPantsName = "Enchanted Pants";
        private const int EnchantedPantsAttackBonus = 0;
        private const int EnchantedPantsDefenceBonus = 40;
        private const int EnchantedPantsHealthBonus = 0;
        private const int EnchantedPantsManaBonus = 20;

        public EnchantedPants(Texture2D texture, IMap map, Point position)
            : base(texture, map, position, EnchantedPantsName, EnchantedPantsAttackBonus, EnchantedPantsDefenceBonus,
            EnchantedPantsHealthBonus, EnchantedPantsManaBonus)
        {
        }
    }
}
