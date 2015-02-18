using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using RPG_Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG_Game.Models.EquipableItems
{
    public class EnchantedHelmet : Head
    {
        private const string EnchantedHelmetName = "Enchanted Helmet";
        private const int EnchantedHelmetAttackBonus = 0;
        private const int EnchantedHelmetDefenceBonus = 30;
        private const int EnchantedHelmetHealthBonus = 0;
        private const int EnchantedHelmetManaBonus = 0;

        public EnchantedHelmet(Texture2D texture, IMap map, Point position)
            : base(texture, map, position, EnchantedHelmetName, EnchantedHelmetAttackBonus, EnchantedHelmetDefenceBonus,
            EnchantedHelmetHealthBonus, EnchantedHelmetManaBonus)
        {
        }
    }
}
