using RPG_Game.Enums;
namespace RPG_Game.Interfaces
{
    public interface IGameUnit : IGameObject
    {
        int Health { get; set; }
        int Mana { get; set; }
        int Attack { get; set; }
        int Defence { get; set; }
        int Energy { get; set; }
        int Speed { get; set; }
        void Move(CardinalDirection dir);
        void Hit(IGameUnit target);
    }
}
