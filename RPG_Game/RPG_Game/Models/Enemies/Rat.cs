using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using RPG_Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG_Game.Models.Enemies
{
    public class Rat : Enemy
    {
        private const string RatName = "Rat";
        private const int RatHealth = 20;
        private const int RatMana = 0;
        private const int RatAttack = 5;
        private const int RatDefence = 10;

        private static List<string> dropList = new List<string>
        {
            // add few items
            "minorHP"
        };

        public Rat(Texture2D texture, IMap map, Point position)
            : base(texture, map, position, RatName, RatHealth, RatMana, RatAttack, RatDefence, dropList)
        {

        }
    }
}
