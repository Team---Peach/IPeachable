namespace RPG_Game.Interfaces
{
    public interface IEquipable : IGameItem
    {
        int AttackBonus { get; set; }
        int DefenceBonus { get; set; }
        int HealthBonus { get; set; }
        int ManaBonus { get; set; }
    }
}
