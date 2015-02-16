namespace RPG_Game.Interfaces
{
    using RPG_Game.Enums;
    using System.Collections.Generic;

    public interface IPlayer : IGameUnit
    {
        int MaxHealth { get; set; }
        int MaxMana { get; set; }
        IList<IWearable> WearedItems { get; }
        IList<IGameItem> InventoryItems { get; }

        bool Fight(IEnemy enemy);
        void WearItem(IWearable itemToWear);
        void UseItem(IDrinkable itemToUse);
        void TakeItem(IGameItem item);
    }
}
