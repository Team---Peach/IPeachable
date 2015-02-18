using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using RPG_Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG_Game.Models.EquipableItems
{
    public class RunicGloves : Hand
    {
        private const string RunicGlovesName = "Runic Gloves";
        private const int RunicGlovesAttackBonus = 10;
        private const int RunicGlovesDefenceBonus = 10;
        private const int RunicGlovesHealthBonus = 0;
        private const int RunicGlovesManaBonus = 0;

        public RunicGloves(Texture2D texture, IMap map, Point position)
            : base(texture, map, position, RunicGlovesName, RunicGlovesAttackBonus, RunicGlovesDefenceBonus,
            RunicGlovesHealthBonus, RunicGlovesManaBonus)
        {
        }
    }
}
