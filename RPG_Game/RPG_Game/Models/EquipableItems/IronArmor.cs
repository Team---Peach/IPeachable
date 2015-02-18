using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using RPG_Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG_Game.Models.EquipableItems
{
    public class IronArmor : Body
    {
        private const string IronArmorName = "Iron Armor";
        private const int IronArmorAttackBonus = 10;
        private const int IronArmorDefenceBonus = 40;
        private const int IronArmorHealthBonus = 0;
        private const int IronArmorManaBonus = 0;

        public IronArmor(Texture2D texture, IMap map, Point position)
            : base(texture, map, position, IronArmorName, IronArmorAttackBonus, IronArmorDefenceBonus,
            IronArmorHealthBonus, IronArmorManaBonus)
        {
        }
    }
}
