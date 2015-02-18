using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using RPG_Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG_Game.Models.Enemies
{
    public class Destructo : Enemy
    {
        private const string DestructoName = "Destructo";
        private const int DestructoHealth = 500;
        private const int DestructoMana = 0;
        private const int DestructoAttack = 85;
        private const int DestructoDefence = 80;

        private static List<string> dropList = new List<string>
        {
            // add few items
            "minorHP"
        };

        public Destructo(Texture2D texture, IMap map, Point position)
            : base(texture, map, position, DestructoName, DestructoHealth, DestructoMana, DestructoAttack, DestructoDefence, dropList)
        {

        }
    }
}
