using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using RPG_Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG_Game.Models.EquipableItems
{
    public class Helmet : Head
    {
        private const string HelmetName = "Helmet";
        private const int HelmetAttackBonus = 0;
        private const int HelmetDefenceBonus = 30;
        private const int HelmetHealthBonus = 0;
        private const int HelmetManaBonus = 0;

        public Helmet(Texture2D texture, IMap map, Point position)
            : base(texture, map, position, HelmetName, HelmetAttackBonus, HelmetDefenceBonus,
            HelmetHealthBonus, HelmetManaBonus)
        {
        }
    }
}
