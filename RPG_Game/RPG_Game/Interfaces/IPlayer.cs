namespace RPG_Game.Interfaces
{
    using RPG_Game.Enums;
    using System.Collections.Generic;

    public interface IPlayer : IGameUnit
    {
        IList<IWearable> WearedItems { get; }
        IList<IGameItem> InventoryItems { get; }

        bool Move(CardinalDirection dir);
        void WearItem(IWearable itemToWear);
        void UseItem(IDrinkable itemToUse);
        void AddToInventory(IGameItem itemToAdd);
    }
}
