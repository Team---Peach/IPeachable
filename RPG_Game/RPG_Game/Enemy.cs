using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace RPG_Game
{
    class Enemy
   {
        private int x = 350;
        private int y = 260;
        public Texture2D Texture { get; set; }
      
        public Enemy(Texture2D texture)
        {
            this.Texture = texture;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(this.Texture, new Vector2(this.x, this.y), Color.White);
            spriteBatch.End();
            
        }
       
    }
}
