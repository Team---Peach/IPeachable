using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using RPG_Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG_Game.Models.EquipableItems
{
    public class LeatherGloves : Hand
    {
        private const string LeatherGlovesName = "Leather Gloves";
        private const int LeatherGlovesAttackBonus = 0;
        private const int LeatherGlovesDefenceBonus = 10;
        private const int LeatherGlovesHealthBonus = 0;
        private const int LeatherGlovesManaBonus = 0;

        public LeatherGloves(Texture2D texture, IMap map, Point position)
            : base(texture, map, position, LeatherGlovesName, LeatherGlovesAttackBonus, LeatherGlovesDefenceBonus,
            LeatherGlovesHealthBonus, LeatherGlovesManaBonus)
        {
        }
    }
}
