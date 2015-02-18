using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using RPG_Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG_Game.Models.EquipableItems
{
    public class LeatherArmor : Body
    {
        private const string LeatherArmorName = "Leather Armor";
        private const int LeatherArmorAttackBonus = 0;
        private const int LeatherArmorDefenceBonus = 20;
        private const int LeatherArmorHealthBonus = 0;
        private const int LeatherArmorManaBonus = 0;

        public LeatherArmor(Texture2D texture, IMap map, Point position)
            : base(texture, map, position, LeatherArmorName, LeatherArmorAttackBonus, LeatherArmorDefenceBonus,
            LeatherArmorHealthBonus, LeatherArmorManaBonus)
        {
        }
    }
}
