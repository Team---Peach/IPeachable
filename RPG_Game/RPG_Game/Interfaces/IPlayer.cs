namespace RPG_Game.Interfaces
{
    using RPG_Game.Enums;
    using System.Collections.Generic;

    public interface IPlayer : IGameUnit
    {
        int MaxHealth { get; set; }
        int MaxMana { get; set; }
        IList<IEquipable> WearedItems { get; }
        IList<IGameItem> InventoryItems { get; }

        bool Fight(IEnemy enemy);
        void WearItem(IEquipable itemToWear);
        void UseItem(IDrinkable itemToUse);
        void TakeItem(IGameItem item);
    }
}
