﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace RPG_Game
{
    public class Terrain : ITerrain
    {
        private Flags flags;
        private Texture2D texture;

        public Terrain(Texture2D texture, Flags flags)
        {
            this.texture = texture;
            this.Flags = flags;
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
    }
}
