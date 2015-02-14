namespace RPG_Game.Interfaces
{
    public interface IGameUnit : IGameObject
    {
        int Health { get; set; }
        int Mana { get; set; }
        int Attack { get; set; }
        int Defence { get; set; }
    }
}
