namespace RPG_Game.Models.Enemies
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using RPG_Game.Interfaces;
    using System.Collections.Generic;

    public class Ogre : Enemy
    {
        private const string OgreName = "Ogre";
        private const int OgreHealth = 100;
        private const int OgreMana = 0;
        private const int OgreAttack = 15;
        private const int OgreDefence = 10;

        private static List<string> dropList = new List<string>
        {
            // add few items
            "minorHP"
        };

        public Ogre(Texture2D texture, IMap map, Point position)
            : base(texture, map, position, OgreName, OgreHealth, OgreMana, OgreAttack, OgreDefence, dropList)
        {

        }
    }
}
