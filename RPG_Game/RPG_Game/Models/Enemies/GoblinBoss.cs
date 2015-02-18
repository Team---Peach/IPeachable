namespace RPG_Game.Models.Enemies
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using RPG_Game.Interfaces;
    using System.Collections.Generic;

    public class GoblinBoss : Enemy
    {
        private const string GoblinBossName = "Goblin Boss";
        private const int GoblinBossHealth = 150;
        private const int GoblinBossMana = 0;
        private const int GoblinBossAttack = 15;
        private const int GoblinBossDefence = 20;

        private static List<string> dropList = new List<string>
        {
            // add few items
            "minorHP"
        };

        public GoblinBoss(Texture2D texture, IMap map, Point position)
            : base(texture, map, position, GoblinBossName, GoblinBossHealth, GoblinBossMana, GoblinBossAttack, GoblinBossDefence, dropList)
        {

        }
    }
}
