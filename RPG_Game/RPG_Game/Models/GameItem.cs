namespace RPG_Game.Models
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using RPG_Game.Enums;
    using RPG_Game.Interfaces;

    public class GameItem : GameObject, IGameItem
    {
        public GameItem(Texture2D texture, IMap map, Point position, string name) 
            : base(texture, Flags.IsItem, map, position, name)
        {
        }
    }
}
