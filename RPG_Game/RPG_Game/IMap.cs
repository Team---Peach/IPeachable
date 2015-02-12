using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace RPG_Game
{
    public interface IMap
    {
        ITile[,] Tiles { get; set; }
        ITile this[Point index] { get; set; }

        void Draw(SpriteBatch spriteBatch, Point center);
        bool CheckTile(Point p);
        bool MoveUnit(IActor actor, Point newLocation);
    }
}
