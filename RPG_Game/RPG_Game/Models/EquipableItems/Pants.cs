using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using RPG_Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG_Game.Models.EquipableItems
{
    public class Pants : Pant
    {
        private const string PantsName = "Pants";
        private const int PantsAttackBonus = 0;
        private const int PantsDefenceBonus = 10;
        private const int PantsHealthBonus = 0;
        private const int PantsManaBonus = 0;

        public Pants(Texture2D texture, IMap map, Point position)
            : base(texture, map, position, PantsName, PantsAttackBonus, PantsDefenceBonus,
            PantsHealthBonus, PantsManaBonus)
        {
        }
    }
}
