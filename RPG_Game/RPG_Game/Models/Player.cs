namespace RPG_Game.Models
{
    using System;
    using System.Collections.Generic;
    using Microsoft.Xna.Framework.Graphics;
    using Microsoft.Xna.Framework;
    using RPG_Game.Interfaces;
    using RPG_Game.Enums;
    using System.Diagnostics;
    using System.Threading;

    public class Player : GameUnit, IPlayer
    {
        private const string PlayerName = "Peachabolator";
        private const int PlayerHealth = 500;
        private const int PlayerMana = 500;
        private const int PlayerAttack = 25;
        private const int PlayerDefence = 50;

        private IList<IEquipable> wearedItems = new List<IEquipable>();
        private IList<IGameItem> inventory = new List<IGameItem>();

        public Player(Texture2D texture, IMap map, Point position)
            : base(texture, map, position, PlayerName, PlayerHealth, PlayerMana, PlayerAttack, PlayerDefence)
        {
            this.MaxHealth = PlayerHealth;
            this.MaxMana = PlayerMana;
        }

        #region Properties

        public int MaxHealth { get; set; }
        public int MaxMana { get; set; }

        public IList<IEquipable> WearedItems
        {
            get
            {
                return new List<IEquipable>(wearedItems);
            }
        }

        public IList<IGameItem> InventoryItems
        {
            get
            {
                return new List<IGameItem>(inventory);
            }
        }
        #endregion

        public void WearItem(IEquipable itemToWear)
        {
            throw new NotImplementedException();
        }

        public void UseItem(IDrinkable itemToUse)
        {
            throw new NotImplementedException();
        }


        public bool Fight(IEnemy enemy)
        {
            Stopwatch stopWatch = new Stopwatch();

            while (this.Health > 0 && enemy.Health > 0)
            {
                stopWatch.Start();
                Thread.Sleep(1000);
                stopWatch.Stop();
                this.Health = this.Health - (enemy.Attack - (enemy.Attack * (this.Defence / 100)));
                enemy.Health = enemy.Health - (this.Attack - (this.Attack * (enemy.Defence / 100)));
            }

            if (this.Health == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void TakeItem(IGameItem item)
        {
            inventory.Add(item);
        }
    }
}
