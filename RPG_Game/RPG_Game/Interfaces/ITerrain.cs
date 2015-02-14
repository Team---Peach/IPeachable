namespace RPG_Game.Interfaces
{
    using Enums;

    public interface ITerrain : IDrawable
    {
        Flags Flags { get; set; }
    }
}
