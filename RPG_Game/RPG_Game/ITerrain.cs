using Microsoft.Xna.Framework.Graphics;

namespace RPG_Game
{
    public interface ITerrain : IDrawable
    {
        Flags Flags { get; set; }
    }
}
