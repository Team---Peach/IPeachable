namespace RPG_Game.Models.Enemies
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using RPG_Game.Interfaces;

    public class GoblinBoss : Enemy
    {
        private const string GoblinBossName = "GoblinBoss";
        private const int GoblinBossHealth = 150;
        private const int GoblinBossMana = 0;
        private const int GoblinBossAttack = 15;
        private const int GoblinBossDefence = 20;

        public GoblinBoss(Texture2D texture, IMap map, Point position)
            : base(texture, map, position, GoblinBossName, GoblinBossHealth, GoblinBossMana, GoblinBossAttack, GoblinBossDefence)
        {

        }
    }
}
