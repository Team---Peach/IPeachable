using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using RPG_Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG_Game.Models.Enemies
{
    public class OgreBoss : Enemy
    {
        private const string OgreBossName = "Ogre Boss";
        private const int OgreBossHealth = 250;
        private const int OgreBossMana = 0;
        private const int OgreBossAttack = 40;
        private const int OgreBossDefence = 15;

        private static List<string> dropList = new List<string>
        {
            // add few items
            "minorHP"
        };

        public OgreBoss(Texture2D texture, IMap map, Point position)
            : base(texture, map, position, OgreBossName, OgreBossHealth, OgreBossMana, OgreBossAttack, OgreBossDefence, dropList)
        {

        }
    }
}
