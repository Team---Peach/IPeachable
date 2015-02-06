using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace RPG_Game
{
    class Background
    {
        public Texture2D Texture { get; set; }

        public Background(Texture2D texture)
        {
            this.Texture = texture;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(this.Texture, new Rectangle(0, 0, 800, 480), Color.White);
            spriteBatch.End();
        }
    }
}
