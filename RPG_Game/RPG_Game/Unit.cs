using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace RPG_Game
{
    public class Unit : IActor
    {
        private Texture2D texture;
        private Point position;
        private Flags flags;
        private IMap map;

        public Unit(Texture2D texture, Flags flags)
        {
            this.texture = texture;
            this.Flags = flags;
        }

        public Unit(Texture2D texture, Flags flags, IMap map, Point position)
            : this(texture, flags)
        {
            Spawn(map, position);
        }

        #region Properties
        public Point Position
        {
            get { return this.position; }
            set { this.position = value; }
        }

        public Flags Flags
        {
            get { return this.flags; }
            set { this.flags = value; }
        }

        public Texture2D Texture
        {
            get { return this.texture; }

        }
        #endregion

        public bool Move(CardinalDirection dir)
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

            return 
                this.map.MoveUnit(this, this.position + delta);
        }

        public bool Spawn(IMap map, Point position)
        {
            if (map.CheckTile(position))
            {
                map[position].Actor = this;

                this.map = map;
                this.Position = position;

                return true;
            }

            return false;
        }
    }
}
