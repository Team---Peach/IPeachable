namespace RPG_Game.Models.Enemies
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using RPG_Game.Enums;
    using RPG_Game.Interfaces;

    public class Goblin : Enemy
    {
        private const string GoblinName = "Goblin";
        private const int GoblinHealth = 20;
        private const int GoblinMana = 0;
        private const int GoblinAttack = 5;
        private const int GoblinDefence = 10;

        public Goblin(Texture2D texture, IMap map, Point position)
            : base(texture, map, position, GoblinName, GoblinHealth, GoblinMana, GoblinAttack, GoblinDefence)
        {

        }
    }
}
