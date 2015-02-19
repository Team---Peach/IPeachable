using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using RPG_Game.GameData;
using RPG_Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG_Game.Models
{
    class StatsPanel
    {
        private Texture2D texture;

        public StatsPanel(Texture2D texture)
        {
            this.texture = texture;
        }

        public void Draw(SpriteBatch spriteBatch, IPlayer player)
        {
            this.texture.SetData(new[] { Color.Black });

            spriteBatch.Begin();

            Rectangle rectangle = new Rectangle(725, 10, 285, 450);
            spriteBatch.Draw(this.texture, rectangle, Color.White);

            StringBuilder info = new StringBuilder();
            info.AppendFormat("     {0}", player.Name).AppendLine().AppendLine()
                .AppendFormat("Attack:  {0}", player.Attack).AppendLine()
                .AppendFormat("Defence: {0}", player.Defence).AppendLine()
                .AppendFormat("Health:  {0}/{1}", player.Health, player.MaxHealth).AppendLine()
                .AppendFormat("Mana:    {0}/{1}", player.Mana, player.MaxMana).AppendLine().AppendLine()
                .AppendFormat("Head: {0}", player.EquipedItems["head"] == null ? "Not Equiped" : player.EquipedItems["head"].Name).AppendLine()
                .AppendFormat("Body: {0}", player.EquipedItems["body"] == null ? "Not Equiped" : player.EquipedItems["body"].Name).AppendLine()
                .AppendFormat("Pants: {0}", player.EquipedItems["pant"] == null ? "Not Equiped" : player.EquipedItems["pant"].Name).AppendLine()
                .AppendFormat("Gloves: {0}", player.EquipedItems["hand"] == null ? "Not Equiped" : player.EquipedItems["hand"].Name).AppendLine()
                .AppendFormat("Feet: {0}", player.EquipedItems["feet"] == null ? "Not Equiped" : player.EquipedItems["feet"].Name).AppendLine()
                .AppendFormat("Weapon: {0}", player.EquipedItems["weapon"] == null ? "Not Equiped" : player.EquipedItems["weapon"].Name).AppendLine()
                .AppendFormat("Shield: {0}", player.EquipedItems["shield"] == null ? "Not Equiped" : player.EquipedItems["shield"].Name).AppendLine().AppendLine()
                .AppendFormat("Heal cooldown: {0} turns", 
                (player.Turns - player.LastHeal) < 20 ? (20 - (player.Turns - player.LastHeal)).ToString() : "Ready");
            
            spriteBatch.DrawString(Textures.SpriteFont, info, new Vector2(735, 15), Color.White);

            spriteBatch.End();
        }
    }
}
