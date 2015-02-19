using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using RPG_Game.GameData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG_Game.Models
{
    class KeysPanel
    {
        private Texture2D texture;

        public KeysPanel(Texture2D texture)
        {
            this.texture = texture;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            this.texture.SetData(new[] { Color.Black });

            spriteBatch.Begin();

            Rectangle rectangle = new Rectangle(725, 470, 285, 160);
            spriteBatch.Draw(this.texture, rectangle, Color.White);

            StringBuilder info = new StringBuilder();
            info.AppendLine("Move - 'KeyPad'")
                .AppendLine("PickUp - 'Space'")
                .AppendLine("Heal - 'H'");
            
            spriteBatch.DrawString(Textures.SpriteFont, info, new Vector2(735, 475), Color.White);

            spriteBatch.End();
        }
    }
}
