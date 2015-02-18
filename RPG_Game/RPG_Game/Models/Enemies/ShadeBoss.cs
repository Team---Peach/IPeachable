using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using RPG_Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG_Game.Models.Enemies
{
    public class ShadeBoss : Enemy
    {
        private const string ShadeBossName = "Shade Boss";
        private const int ShadeBossHealth = 300;
        private const int ShadeBossMana = 0;
        private const int ShadeBossAttack = 60;
        private const int ShadeBossDefence = 55;

        private static List<string> dropList = new List<string>
        {
            // add few items
            "minorHP"
        };

        public ShadeBoss(Texture2D texture, IMap map, Point position)
            : base(texture, map, position, ShadeBossName, ShadeBossHealth, ShadeBossMana, ShadeBossAttack, ShadeBossDefence, dropList)
        {

        }
    }
}
