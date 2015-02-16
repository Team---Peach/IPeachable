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

        private IList<IWearable> wearedItems = new List<IWearable>();
        private IList<IGameItem> inventory = new List<IGameItem>();

        public Player(Texture2D texture, IMap map, Point position)
            : base(texture, Flags.IsPlayerControl, map, position, PlayerName, PlayerHealth, PlayerMana, PlayerAttack, PlayerDefence)
        {
            this.MaxHealth = PlayerHealth;
            this.MaxMana = PlayerMana;
        }

        #region Properties

        public int MaxHealth { get; set; }
        public int MaxMana { get; set; }

        public IList<IWearable> WearedItems
        {
            get
            {
                return new List<IWearable>(wearedItems);
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

        /*
        public void Move(CardinalDirection dir)
        {
            #region Delta Coordinates
            Point delta = Point.Zero;

            switch (dir)
            {
                case CardinalDirection.North:
                    delta.X = -1;
                    break;

                case CardinalDirection.South:
                    delta.X = 1;
                    break;

                case CardinalDirection.West:
                    delta.Y = -1;
                    break;

                case CardinalDirection.East:
                    delta.Y = 1;
                    break;

                case CardinalDirection.NorthWest:
                    delta.X = -1;
                    delta.Y = -1;
                    break;

                case CardinalDirection.NorthEast:
                    delta.X = -1;
                    delta.Y = 1;
                    break;

                case CardinalDirection.SouthWest:
                    delta.X = 1;
                    delta.Y = -1;
                    break;

                case CardinalDirection.SouthEast:
                    delta.X = 1;
                    delta.Y = 1;
                    break;
            }
            #endregion

            this.Map.MoveUnit(this, this.Position + delta);
        }
        */

        public void WearItem(IWearable itemToWear)
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
