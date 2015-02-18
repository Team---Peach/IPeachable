using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using RPG_Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG_Game.Models.Enemies
{
    public class Spider : Enemy
    {
        private const string SpiderName = "Spider";
        private const int SpiderHealth = 35;
        private const int SpiderMana = 0;
        private const int SpiderAttack = 10;
        private const int SpiderDefence = 15;

        private static List<string> dropList = new List<string>
        {
            // add few items
            "minorHP"
        };

        public Spider(Texture2D texture, IMap map, Point position)
            : base(texture, map, position, SpiderName, SpiderHealth, SpiderMana, SpiderAttack, SpiderDefence, dropList)
        {

        }
    }
}
