namespace RPG_Game.Models
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using RPG_Game.Enums;
    using RPG_Game.Interfaces;
    using System;

    public class Map : IMap
    {
        public const int TILE_SIZE = 32;

        private ITile[,] tiles;
        private Point mapBoxTiles;

        public Map(ITile[,] tiles, Point mapBoxTiles)
        {
            this.tiles = tiles;
            this.mapBoxTiles = mapBoxTiles;
        }

        #region Properties
        public ITile[,] Tiles
        {
            get { return this.tiles; }
            set { this.tiles = value; }
        }

        public ITile this[Point index]
        {
            get { return this.Tiles[index.X, index.Y]; }
            set { this.Tiles[index.X, index.Y] = value; }
        }

        public int Height
        {
            get { return this.Tiles.GetLength(0); }
        }

        public int Width
        {
            get { return this.Tiles.GetLength(1); }
        }
        #endregion

        public void MoveUnit(IGameUnit actor, Point newLocation)
        {
            if (CheckTile(newLocation))
            {
                this[actor.Position].Actor = null;
                actor.Position = newLocation;
                this[newLocation].Actor = actor;

                /*
                switch (this.Tiles[newLocation.X, newLocation.Y].Terrain.Flags)
                {
                    case Flags.None:
                        this[actor.Position].Actor = null;
                        actor.Position = newLocation;
                        this[newLocation].Actor = actor;
                        break;
                    case Flags.IsEnemy:
                        bool playerWin = (actor as Player).Fight(this.Tiles[newLocation.X, newLocation.Y].Actor as Enemy);
                        if (playerWin)
                        {
                            string dropItemName = (this.Tiles[newLocation.X, newLocation.Y].Actor as Enemy).ItemToDrop();
                            this.Tiles[newLocation.X, newLocation.Y].Actor = null;
                            Tools.PlaceObjectOnMap(dropItemName, this, new Point(newLocation.X, newLocation.Y));
                        }
                        else
                        {
                            // Game Over
                        }
                        break;
                    case Flags.IsItem:
                        (actor as Player).TakeItem(this.Tiles[newLocation.X, newLocation.Y].Actor as GameItem);
                        this[actor.Position].Actor = null;
                        actor.Position = newLocation;
                        this[newLocation].Actor = actor;
                        break;
                    default:
                        break;
                }*/
            }
        }

        public void Draw(SpriteBatch spriteBatch, Point center)
        {
            spriteBatch.Begin();

            // Get the start (Tile)coordinates  for the Map
            Point startTile = new Point(
                center.X - (mapBoxTiles.X / 2),
                center.Y - (mapBoxTiles.Y / 2));

            // Check coordinates lower bound < 0
            if (startTile.X < 0)
            {
                startTile.X = 0;
            }
            if (startTile.Y < 0)
            {
                startTile.Y = 0;
            }

            // Check coordinates higher bound > 0
            if (startTile.X + mapBoxTiles.X >= this.Height)
            {
                startTile.X = this.Height - mapBoxTiles.X;
            }
            if (startTile.Y + mapBoxTiles.Y >= this.Width)
            {
                startTile.Y = this.Width - mapBoxTiles.Y;
            }


            for (int x = 0; x < this.mapBoxTiles.X; x++)
            {
                for (int y = 0; y < this.mapBoxTiles.Y; y++)
                {
                    Vector2 drawPosition = new Vector2(10 + TILE_SIZE * y, 10 + TILE_SIZE * x);
                    Point tile = new Point(startTile.X + x, startTile.Y + y);

                    spriteBatch.Draw(this[tile].Terrain.Texture, drawPosition);

                    if (this[tile].GameObject != null)
                    {
                        spriteBatch.Draw(this[tile].GameObject.Texture, drawPosition);
                    }

                    if (this[tile].Item != null)
                    {
                        spriteBatch.Draw(this[tile].Item.Texture, drawPosition);
                    }

                    if (this[tile].Actor != null)
                    {
                        spriteBatch.Draw(this[tile].Actor.Texture, drawPosition);
                    }
                }
            }

            spriteBatch.End();
        }

        public bool CheckTile(Point point)
        {
            // Return false if the point is out of bounds
            if (point.X < 0 || point.X >= this.Height ||
                point.Y < 0 || point.Y >= this.Width)
            {
                return false;
            }

            if (this[point].Terrain.Flags.HasFlag(Flags.IsBlocked))
            {
                return false;
            }

            return true;
        }
    }
}
