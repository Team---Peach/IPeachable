using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using RPG_Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG_Game.Models.Enemies
{
    public class FinalBoss : Enemy
    {
        private const string FinalBossName = "Final Boss";
        private const int FinalBossHealth = 1000;
        private const int FinalBossMana = 0;
        private const int FinalBossAttack = 100;
        private const int FinalBossDefence = 100;

        private static List<string> dropList = new List<string>
        {
            // add few items
            "minorHP"
        };

        public FinalBoss(Texture2D texture, IMap map, Point position)
            : base(texture, map, position, FinalBossName, FinalBossHealth, FinalBossMana, FinalBossAttack, FinalBossDefence, dropList)
        {

        }
    }
}
