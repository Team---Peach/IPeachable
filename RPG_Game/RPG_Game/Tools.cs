using System;
using Microsoft.Xna.Framework.Graphics;

namespace RPG_Game
{
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
    }
}
