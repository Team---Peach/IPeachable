namespace RPG_Game.Models
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using Enums;
    using Interfaces;

    public abstract class GameUnit : GameObject, IGameUnit
    {
        private int health;

        protected GameUnit(Texture2D texture, IMap map, Point position,
            string name, int health, int mana, int attack, int defence)
            : base(texture, map, position, name)
        {
            this.Health = health;
            this.Mana = mana;
            this.Attack = attack;
            this.Defence = defence;

            this.Energy = 0;
            this.Speed = 10;
        }

        #region Properties
        public int Health
        {
            get { return this.health; }
            set
            {
                if (value <= 0)
                {
                    this.health = 0;
                }
                else
                {
                    this.health = value;
                }
            }
        }

        public int Mana { get; set; }

        public int Attack { get; set; }

        public int Defence { get; set; }

        public int Energy { get; set; }

        public int Speed { get; set; }

        #endregion

        public virtual void Move(CardinalDirection dir)
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

        public override bool Spawn(IMap map, Point position)
        {
            if (map.CheckTile(position))
            {
                map[position].Actor = this;

                this.Map = map;
                this.Position = position;

                return true;
            }

            return false;
        }

        public void Hit(IGameUnit target)
        {
            int damage = this.Attack - (this.Attack/target.Defence);
            target.Health -= damage;
            string info = GenerateInfoText(damage, target);
            InfoPanel.AddInfo(info);
        }

        private string GenerateInfoText(int damage, IGameUnit target)
        {
            if (this is IEnemy)
            {
                string result = this.Name + " hit you for " + damage + " damage!";
                return result;
            }
            else
            {
                string result = "You hit " +target.Name + " for " + damage + " damage!";
                return result;
            }
        }
    }
}
