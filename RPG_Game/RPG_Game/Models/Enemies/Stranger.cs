using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using RPG_Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG_Game.Models.Enemies
{
    public class Stranger : Enemy
    {
        private const string StrangerName = "Stranger";
        private const int StrangerHealth = 250;
        private const int StrangerMana = 0;
        private const int StrangerAttack = 50;
        private const int StrangerDefence = 55;

        private static List<string> dropList = new List<string>
        {
            // add few items
            "minorHP"
        };

        public Stranger(Texture2D texture, IMap map, Point position)
            : base(texture, map, position, StrangerName, StrangerHealth, StrangerMana, StrangerAttack, StrangerDefence, dropList)
        {

        }
    }
}
