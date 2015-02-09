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
              
        public Unit(Texture2D texture, IMap map, Point position, Flags flags)
        {
            this.texture = texture;
            this.map = map;
            this.Position = position;
            this.Flags = flags;
        }

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
        /* *
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(this.Texture, new Vector2(this.x, this.y), Color.White);
            spriteBatch.End();            
        }
        * */
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

            /* *
            KeyboardState newState = Keyboard.GetState();

            if (newState.IsKeyDown(Keys.Up))
            {
                this.y--;
            }
            if (newState.IsKeyDown(Keys.Down))
            {
                this.y++;
            }
            if (newState.IsKeyDown(Keys.Right))
            {
                this.x++;
            }
            if (newState.IsKeyDown(Keys.Left))
            {
                this.x--;
            }
             * */
        }

        public bool Spawn()
        {
            if (this.map.CheckTile(this.position)) 
            {
                this.map.Tiles[this.position.X, this.position.Y].Actor = this;
                return true;
            }

            return false;
        }
    }
}
