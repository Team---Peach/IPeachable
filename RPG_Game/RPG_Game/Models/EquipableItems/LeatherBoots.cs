using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using RPG_Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG_Game.Models.EquipableItems
{
    public class LeatherBoots : Feet
    {
        private const string LeatherBootsName = "Leather Boots";
        private const int LeatherBootsAttackBonus = 0;
        private const int LeatherBootsDefenceBonus = 20;
        private const int LeatherBootsHealthBonus = 0;
        private const int LeatherBootsManaBonus = 0;

        public LeatherBoots(Texture2D texture, IMap map, Point position)
            : base(texture, map, position, LeatherBootsName, LeatherBootsAttackBonus, LeatherBootsDefenceBonus,
            LeatherBootsHealthBonus, LeatherBootsManaBonus)
        {
        }
    }
}
