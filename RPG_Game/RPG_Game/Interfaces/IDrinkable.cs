namespace RPG_Game.Interfaces
{
    public interface IDrinkable : IGameItem
    {
        int HealthRestorationPower { get; set; }
        int ManaRestorationPower { get; set; }
        int HealthIncreasePower { get; set; }
        int ManaIncreasePower { get; set; }
        int AttackIncreasePower { get; set; }
        int DefenceIncreasePower { get; set; }
    }
}
