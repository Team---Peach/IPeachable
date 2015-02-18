using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using RPG_Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG_Game.Models.EquipableItems
{
    public class ShortSword : Weapon
    {
        private const string ShortSwordName = "Short Sword";
        private const int ShortSwordAttackBonus = 15;
        private const int ShortSwordDefenceBonus = 0;
        private const int ShortSwordHealthBonus = 0;
        private const int ShortSwordManaBonus = 0;

        public ShortSword(Texture2D texture, IMap map, Point position)
            : base(texture, map, position, ShortSwordName, ShortSwordAttackBonus, ShortSwordDefenceBonus, ShortSwordHealthBonus, ShortSwordManaBonus)
        {
        }
    }
}
