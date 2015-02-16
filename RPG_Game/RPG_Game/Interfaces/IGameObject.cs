namespace RPG_Game.Interfaces
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using RPG_Game.Enums;

    public interface IGameObject : IDrawable
    {
        string Name { get; set; }
        Flags Flags { get; set; }
        Texture2D Texture { get; }
        Point Position { get; set; }

        bool Spawn(IMap map, Point position);
    }
}
