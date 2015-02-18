using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using RPG_Game.GameData;
using System.Collections.Generic;
using System.Text;

namespace RPG_Game.Models
{
    public class InfoPanel
    {
        private static IList<string> informationList = new List<string>();
        private Texture2D texture;

        public InfoPanel(Texture2D texture)
        {
            this.texture = texture;
        }

        public List<string> InformationList
        {
            get
            {
                return new List<string>(informationList);
            }
        }

        public static void AddInfo(string information)
        {
            informationList.Add(information);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            this.texture.SetData(new[] { Color.Black });

            spriteBatch.Begin();

            Rectangle rectangle = new Rectangle(10, 470, 600, 160);
            spriteBatch.Draw(this.texture, rectangle, Color.White);

            string info = GenerateInfo();

            

            spriteBatch.DrawString(Textures.SpriteFont, info, new Vector2(20, 475), Color.White);

            spriteBatch.End();
        }

        private string GenerateInfo()
        {
            StringBuilder info = new StringBuilder();
            if (this.InformationList.Count > 6)
            {
                for (int i = this.InformationList.Count - 6; i < this.InformationList.Count; i++)
                {
                    info.AppendLine(this.InformationList[i]);
                }
            }
            else
            {
                foreach (var information in this.InformationList)
                {
                    info.AppendLine(information);
                }
            }

            return info.ToString();
        }
    }
}
