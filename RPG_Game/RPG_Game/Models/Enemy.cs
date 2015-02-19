namespace RPG_Game.Models
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using RPG_Game.Enums;
    using RPG_Game.Interfaces;
    using System;
    using System.Collections.Generic;

    public class Enemy : GameUnit, IEnemy
    {
        private readonly List<string> dropList;
        private bool inBattle = false;
        private IPlayer player;

        public Enemy(Texture2D texture, IMap map, Point position,
            string name, int health, int mana, int attack, int defence, List<string> dropList)
            : base(texture, map, position, name, health, mana, attack, defence)
        {
            this.dropList = dropList;
        }

        public List<string> DropList
        {
            get
            {
                return new List<string>(dropList);
            }
        }

        public bool InBattle 
        {
            get { return this.inBattle; }
            set
            {
                this.inBattle = value;
            }
        }

        public IPlayer Player 
        {
            get { return this.player; }
            set
            {
                this.player = value;
            }
        }

        /// <summary>
        /// Random pick from droplist and returns the name of the item that will be droped
        /// </summary>
        /// <returns>The name of the item as a string</returns>
        public string ItemToDrop()
        {
            return this.DropList[Tools.RandomDrop(this.DropList.Count)];
        }

        // Enemy starts tracing the player when in battle
        public override void Move(CardinalDirection dir)
        {
            if (this.InBattle == true)
            {
                // Checks if the player and the enemy are in same line
                if (this.Position.X == this.Player.Position.X)
                {
                    if (this.Position.Y > this.player.Position.Y)
                    {
                        dir = CardinalDirection.West;
                    }
                    else
                    {
                        dir = CardinalDirection.East;
                    }

                }
                // Checks if enemy is nother to the person
                if (this.Position.X > this.Player.Position.X)
                {
                    if (this.Position.Y == this.player.Position.Y)
                    {
                        dir = CardinalDirection.North;
                    }
                    else if (this.Position.Y > this.player.Position.Y)
                    {
                        dir = CardinalDirection.NorthWest;
                    }
                    else
                    {
                        dir = CardinalDirection.NorthEast;
                    }

                }
                // Checks if enemy is souther to player
                if (this.Position.X < this.Player.Position.X)
                {
                    if (this.Position.Y == this.player.Position.Y)
                    {
                        dir = CardinalDirection.South;
                    }
                    else if (this.Position.Y > this.player.Position.Y)
                    {
                        dir = CardinalDirection.SouthWest;
                    }
                    else
                    {
                        dir = CardinalDirection.SouthEast;
                    }

                }
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
            else
            {
                base.Move(dir);
            }

            
        }
    }
}
