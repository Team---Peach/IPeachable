namespace RPG_Game.Models
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using RPG_Game.Enums;
    using RPG_Game.Interfaces;

    public class GameItem : GameObject, IGameItem
    {
        public GameItem(Texture2D texture, IMap map, Point position, string name) 
            : base(texture, map, position, name)
        {
            this.Map = map;
            this.Position = position;
            this.Name = name;
        }

        public override bool Spawn(IMap map, Point position)
        {
            if (map.CheckTile(position))
            {
                map[position].Item = this;

                this.Map = map;
                this.Position = position;

                return true;
            }

            return false;
        }
    }
}
