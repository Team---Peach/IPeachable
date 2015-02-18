namespace RPG_Game.Models.Enemies
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using RPG_Game.Interfaces;
    using System.Collections.Generic;

    public class Goblin : Enemy
    {
        private const string GoblinName = "Goblin";
        private const int GoblinHealth = 45;
        private const int GoblinMana = 0;
        private const int GoblinAttack = 10;
        private const int GoblinDefence = 15;

        private static List<string> dropList = new List<string>
        {
            // add few items
            "minorHP"
        };

        public Goblin(Texture2D texture, IMap map, Point position)
            : base(texture, map, position, GoblinName, GoblinHealth, GoblinMana, GoblinAttack, GoblinDefence, dropList)
        {

        }
    }
}
