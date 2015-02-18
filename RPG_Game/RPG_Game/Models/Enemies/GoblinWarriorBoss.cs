using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using RPG_Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG_Game.Models.Enemies
{
    public class GoblinWarriorBoss : Enemy
    {
        private const string GoblinWarriorBossName = "Goblin Warrior Boss";
        private const int GoblinWarriorBossHealth = 200;
        private const int GoblinWarriorBossMana = 0;
        private const int GoblinWarriorBossAttack = 50;
        private const int GoblinWarriorBossDefence = 45;

        private static List<string> dropList = new List<string>
        {
            // add few items
            "minorHP"
        };

        public GoblinWarriorBoss(Texture2D texture, IMap map, Point position)
            : base(texture, map, position, GoblinWarriorBossName, GoblinWarriorBossHealth, GoblinWarriorBossMana, GoblinWarriorBossAttack, GoblinWarriorBossDefence, dropList)
        {

        }
    }
}
