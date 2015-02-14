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
        private Flags flags;
        private readonly Texture2D texture;
        private Point position;
        private IMap map;

        protected GameObject(Texture2D texture, Flags flags, string name)
        {
            this.Name = name;
            this.texture = texture;
            this.Flags = flags;
        }

        protected GameObject(Texture2D texture, Flags flags, IMap map, Point position, string name)
            : this(texture, flags, name)
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

        public Flags Flags
        {
            get { return this.flags; }
            set { this.flags = value; }
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

        public bool Spawn(IMap map, Point position)
        {
            if (map.CheckTile(position))
            {
                map[position].Actor = this;

                this.Map = map;
                this.Position = position;

                return true;
            }

            return false;
        }
    }
}
