using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using RPG_Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG_Game.Models.EquipableItems
{
    public class LeatherPants : Pant
    {
        private const string LeatherPantsName = "Leather Pants";
        private const int LeatherPantsAttackBonus = 0;
        private const int LeatherPantsDefenceBonus = 20;
        private const int LeatherPantsHealthBonus = 0;
        private const int LeatherPantsManaBonus = 10;

        public LeatherPants(Texture2D texture, IMap map, Point position)
            : base(texture, map, position, LeatherPantsName, LeatherPantsAttackBonus, LeatherPantsDefenceBonus,
            LeatherPantsHealthBonus, LeatherPantsManaBonus)
        {
        }
    }
}
