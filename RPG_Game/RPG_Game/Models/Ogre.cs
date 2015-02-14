namespace RPG_Game.Models
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using RPG_Game.Enums;
    using RPG_Game.Interfaces;

    public class Ogre : Enemy
    {
        private const string OgreName = "Ogre";
        private const int OgreHealth = 100;
        private const int OgreMana = 0;
        private const int OgreAttack = 10;
        private const int OgreDefence = 20;

        public Ogre(Texture2D texture, Flags flags, IMap map, Point position)
            : base(texture, flags, map, position, OgreName, OgreHealth, OgreMana, OgreAttack, OgreDefence)
        {

        }
    }
}
