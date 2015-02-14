namespace RPG_Game.Models
{
    using System;
    using Microsoft.Xna.Framework.Graphics;
    using RPG_Game.Interfaces;
    using RPG_Game.Enums;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Content;

    public static class Tools
    {
        public static Random RNG = new Random();

        public static ITile[,] GenerateMap(int height, int width, Texture2D texture, Texture2D blockedTexture)
        {
            Tile[,] resultTiles = new Tile[height, width];

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    int next = RNG.Next(0, 10);
                    Terrain sampleTerrain;

                    if (next < 8)
                    {
                        sampleTerrain = new Terrain(texture, Flags.None);
                    }
                    else
                    {
                        sampleTerrain = new Terrain(blockedTexture, Flags.IsBlocked);
                    }

                    resultTiles[i, j] = new Tile(sampleTerrain);
                }
            }
            // Make starting tile free, for player spawn
            resultTiles[0, 0] = new Tile(new Terrain(texture, Flags.None));

            return resultTiles;
        }

        public static void GenerateEnemy(ContentManager content, IMap map, int enemyCount)
        {
            Texture2D enemyTexture = content.Load<Texture2D>("Goblin");
            int count = enemyCount;
            for (int i = 0; i < map.Tiles.Length; i++)
            {
                for (int j = 0; j < map.Tiles.Length; j++)
                {
                    if (map.CheckTile(new Point(i, j)) && count != 0)
                    {
                        int next = RNG.Next(0, 100);

                        if (next < 2)
                        {
                            Goblin goblin = new Goblin(enemyTexture, Flags.IsEnemy, map, new Point(i, j));
                            count--;
                        }
                    }
                }
            }
        }
    }
}
