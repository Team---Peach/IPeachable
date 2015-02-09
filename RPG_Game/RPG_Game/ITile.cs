namespace RPG_Game
{
    public interface ITile
    {
        IActor Actor { get; set; }
        ITerrain Terrain { get; set; }
        IItem Item { get; set; }
        IObject GameObject { get; set; }
    }
}
