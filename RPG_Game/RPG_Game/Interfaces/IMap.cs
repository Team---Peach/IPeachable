namespace RPG_Game.Interfaces
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    public interface IMap
    {
        ITile[,] Tiles { get; set; }
        ITile this[Point index] { get; set; }

        void Draw(SpriteBatch spriteBatch, Point center);
        bool CheckIfTileIsOutOfBounds(Point p);
        void MoveUnit(IGameUnit actor, Point newLocation);
    }
}
