using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace RPG_Game
{
    public class Map : IMap
    {
        public const int TILE_SIZE = 32;

        private ITile[,] tiles;
        private Point 
            topLeft,
            bottomRight;
        private Point mapBoxTiles;

        public Map(ITile[,] tiles, Point mapBoxTiles)
        {
            this.tiles = tiles;
            this.mapBoxTiles = mapBoxTiles;
        }

        public ITile[,] Tiles
        {
            get { return this.tiles; }
            set { this.tiles = value; }
        }

        public int Height
        {
            get { return this.Tiles.GetLength(0); }
        }

        public int Width
        {
            get { return this.Tiles.GetLength(1); }
        }
        
        public bool MoveUnit(IActor actor, Point newLocation)
        {
            if (CheckTile(newLocation))
            {
                this.Tiles[actor.Position.X, actor.Position.Y].Actor = null;
                actor.Position = newLocation;
                this.Tiles[newLocation.X, newLocation.Y].Actor = actor;

                return true;
            }
            else
            {
                return false;
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
                    Vector2 position = new Vector2(10 + TILE_SIZE * y, 10 + TILE_SIZE * x);
                    Point draw = new Point(startTile.X + x, startTile.Y + y);

                    spriteBatch.Draw(this.Tiles[draw.X, draw.Y].Terrain.Texture, position);
                    
                    if (this.Tiles[x, y].GameObject != null)
                    {
                        spriteBatch.Draw(this.Tiles[draw.X, draw.Y].GameObject.Texture, position);
                    }

                    if (this.Tiles[x, y].Item != null)
                    {
                        spriteBatch.Draw(this.Tiles[draw.X, draw.Y].Item.Texture, position);
                    }

                    if (this.Tiles[x, y].Actor != null)
                    {
                        spriteBatch.Draw(this.Tiles[draw.X, draw.Y].Actor.Texture, position);
                    }
                }
            }

            spriteBatch.End();
        }

        public bool CheckTile(Point p)
        {
            if (this.Tiles[p.X, p.Y].Terrain.Flags.HasFlag(Flags.IsBlocked))
            {
                return false;
            }

            return true;
        }
    }
}
