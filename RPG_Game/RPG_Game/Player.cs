using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace RPG_Game
{
    class Player
    {
        private int x = 20;
        private int y = 20;

        public Texture2D Texture { get; set; }
      
        public Player(Texture2D texture)
        {
            this.Texture = texture;
            this.x = 10;
            this.y = 10;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(this.Texture, new Vector2(this.x, this.y), Color.White);
            spriteBatch.End();
            
        }

        public void Move()
        {
            KeyboardState newState = Keyboard.GetState();

            if (newState.IsKeyDown(Keys.Up))
            {
                this.y--;
            }
            if (newState.IsKeyDown(Keys.Down))
            {
                this.y++;
            }
            if (newState.IsKeyDown(Keys.Right))
            {
                this.x++;
            }
            if (newState.IsKeyDown(Keys.Left))
            {
                this.x--;
            }
        }
    }

}
