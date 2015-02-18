using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using RPG_Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG_Game.Models.EquipableItems
{
    public class Hat : Head
    {
        private const string HatName = "Hat";
        private const int HatAttackBonus = 0;
        private const int HatDefenceBonus = 10;
        private const int HatHealthBonus = 0;
        private const int HatManaBonus = 0;

        public Hat(Texture2D texture, IMap map, Point position)
            : base(texture, map, position, HatName, HatAttackBonus, HatDefenceBonus,
            HatHealthBonus, HatManaBonus)
        {
        }
    }
}
