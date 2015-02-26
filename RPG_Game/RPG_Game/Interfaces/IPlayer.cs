namespace RPG_Game.Interfaces
{
    using RPG_Game.Enums;
    using System.Collections.Generic;

    public interface IPlayer : IGameUnit
    {
        int MaxHealth { get; set; }
        int MaxMana { get; set; }
        int Turns { get; set; }
        int LastHeal { get; set; }
        int LastShield { get; }

        IDictionary<string, IEquipable> EquipedItems { get; }

        void EquipItem(IEquipable itemToWear);
        void UseItem(IDrinkable itemToUse);
        void Heal();
        void UpdateMana();
        void Shield();
        void DeactivateShield();
    }
}
