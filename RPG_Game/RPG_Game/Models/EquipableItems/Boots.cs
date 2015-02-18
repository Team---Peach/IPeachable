using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using RPG_Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG_Game.Models.EquipableItems
{
    public class Boots : Feet
    {
        private const string BootsName = "Boots";
        private const int BootsAttackBonus = 0;
        private const int BootsDefenceBonus = 10;
        private const int BootsHealthBonus = 0;
        private const int BootsManaBonus = 0;

        public Boots(Texture2D texture, IMap map, Point position)
            : base(texture, map, position, BootsName, BootsAttackBonus, BootsDefenceBonus,
            BootsHealthBonus, BootsManaBonus)
        {
        }
    }
}
