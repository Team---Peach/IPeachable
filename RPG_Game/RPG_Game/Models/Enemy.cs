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
        private int aggresion;

        public Enemy(Texture2D texture, IMap map, Point position,
            string name, int health, int mana, int attack, int defence, List<string> dropList, int aggresion)
            : base(texture, map, position, name, health, mana, attack, defence)
        {
            this.dropList = dropList;
            this.Agression = aggresion;
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

        public int Agression
        {
            get { return this.aggresion; }
            set
            {
                this.aggresion = value;
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
        public void StartBattleIfInRange(IMap map)
        {
            int startX = this.Position.X - this.Agression;
            int startY = this.Position.Y - this.Agression;

            for (int x = startX; x < startX + (aggresion * 2) + 1; x++)
            {
                for (int y = startY; y < startY + (aggresion * 2) + 1; y++)
                {
                    if (x > 0 && x < 40 && y > 0 && y < 40)
                    {
                        if (this.inBattle)
                        {
                            if (map.Tiles[x, y].Actor is Enemy)
                            {
                                (map.Tiles[x, y].Actor as Enemy).inBattle = true;
                                (map.Tiles[x, y].Actor as Enemy).Player = this.Player;
                            }
                        }
                        if (map.Tiles[x, y].Actor is Player)
                        {
                            this.inBattle = true;
                            this.player = map.Tiles[x, y].Actor as Player;
                        }
                        if (map.Tiles[x, y].Actor is Enemy)
                        {
                            if ((map.Tiles[x, y].Actor as Enemy).InBattle)
                            {
                                this.inBattle = true;
                                this.player = (map.Tiles[x, y].Actor as Enemy).Player;
                            }
                        }
                        
                    }
                }
            }
        }
    }
}
