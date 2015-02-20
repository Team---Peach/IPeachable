namespace RPG_Game.Interfaces
{
    using Engine.FieldOfView;

    public interface ITile : IFovCell
    {
        IGameObject Actor { get; set; }
        ITerrain Terrain { get; set; }
        IGameItem Item { get; set; }
        IObject GameObject { get; set; }
        bool WasSeen { get; set; }
    }
}
