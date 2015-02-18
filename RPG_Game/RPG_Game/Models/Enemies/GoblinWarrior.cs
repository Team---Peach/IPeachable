using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using RPG_Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG_Game.Models.Enemies
{
    public class GoblinWarrior : Enemy
    {
        private const string GoblinWarriorName = "Goblin Warrior";
        private const int GoblinWarriorHealth = 120;
        private const int GoblinWarriorMana = 0;
        private const int GoblinWarriorAttack = 20;
        private const int GoblinWarriorDefence = 25;

        private static List<string> dropList = new List<string>
        {
            // add few items
            "minorHP"
        };

        public GoblinWarrior(Texture2D texture, IMap map, Point position)
            : base(texture, map, position, GoblinWarriorName, GoblinWarriorHealth, GoblinWarriorMana, GoblinWarriorAttack, GoblinWarriorDefence, dropList)
        {

        }
    }
}
