namespace RPG_Game.Models
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using RPG_Game.Enums;
    using RPG_Game.Interfaces;
    using System;

    public abstract class GameObject : IGameObject
    {
        private string name;
        private readonly Texture2D texture;
        private Point position;
        private IMap map;

        protected GameObject(Texture2D texture, string name)
        {
            this.Name = name;
            this.texture = texture;
        }

        protected GameObject(Texture2D texture, IMap map, Point position, string name)
            : this(texture, name)
        {
            Spawn(map, position);
        }

        #region Properties
        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("name", "Name can not be null or empty");
                }

                this.name = value;
            }
        }

        public Point Position
        {
            get { return this.position; }
            set { this.position = value; }
        }

        public Texture2D Texture
        {
            get { return this.texture; }
        }

        public IMap Map
        {
            get { return this.map; }
            set { this.map = value; }
        }

        #endregion

        public abstract bool Spawn(IMap map, Point position);
        
    }
}
