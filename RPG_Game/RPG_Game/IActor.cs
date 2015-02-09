using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
namespace RPG_Game
{
    public interface IActor
    {
        Point Position { get; set; }
        Flags Flags { get; set; }
        Texture2D Texture { get; }

        bool Move(CardinalDirection dir);
        bool Spawn();
    }
}
