namespace RPG_Game.Models
{
    using System;
    using Microsoft.Xna.Framework.Graphics;
    using RPG_Game.Interfaces;
    using RPG_Game.Enums;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Content;
    using RPG_Game.GameData;
    using RPG_Game.Models.Enemies;
    using RPG_Game.Models.DrinkableItems;

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

        public static void GenerateEnemy(IMap map)
        {
            GenerateObject(
                map,
                StartGameEnemies.goblin["count"],
                StartGameEnemies.goblin["minDistance"],
                StartGameEnemies.goblin["maxDistance"],
                "goblin");

            GenerateObject(
                map,
                StartGameEnemies.goblinBoss["count"],
                StartGameEnemies.goblinBoss["minDistance"],
                StartGameEnemies.goblinBoss["maxDistance"],
                "goblinBoss"); 

            GenerateObject(
                map,
                StartGameEnemies.ogre["count"],
                StartGameEnemies.ogre["minDistance"],
                StartGameEnemies.ogre["maxDistance"],
                "ogre"); 
        }

        internal static void GenerateItems(IMap map)
        {
            GenerateObject(
                map,
                StartGameItems.minorHP["count"],
                StartGameItems.minorHP["minDistance"],
                StartGameItems.minorHP["maxDistance"],
                "minorHP");
        }

        /// <summary>
        /// Randomly check every tile on the map in given range (min - max distance) and place the object if this position is empty
        /// </summary>
        /// <param name="map">Current map</param>
        /// <param name="count">Number of objects from the same type we want to place on the map</param>
        /// <param name="minDistance">Minimum distance from Point.Zero</param>
        /// <param name="maxDistance">Maximum distance from Point.Zero</param>
        /// <param name="name">The name of the object we want to place</param>
        private static void GenerateObject(IMap map, int count, int minDistance, int maxDistance, string name)
        {
            int objectCount = count;
            while (objectCount != 0)
            {
                for (int i = 0; i < maxDistance; i++)
                {
                    for (int j = 0; j < maxDistance; j++)
                    {
                        if (map.CheckTile(new Point(i, j)) 
                            && objectCount != 0 
                            && (i > minDistance || j > minDistance)
                            && map.Tiles[i,j].Terrain.Flags.HasFlag(Flags.None)
                            && map.Tiles[i,j].Actor == null
                            && map.Tiles[i, j].Item == null)
                        {
                            int next = RNG.Next(0, 100);
                            if (next < 4)
                            {
                                PlaceObjectOnMap(name, map, new Point(i, j));
                                objectCount--;
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Place specific GameObject at given position on the map
        /// </summary>
        /// <param name="name">String with the name of the GameObject that will be placed on the map</param>
        /// <param name="map">Current map</param>
        /// <param name="point">the tail position on the map</param>
        public static void PlaceObjectOnMap(string name, IMap map, Point point)
        {
            switch (name)
            {
                case "goblin":
                    Goblin goblin = new Goblin(Textures.Goblin, map, point);
                    RPG_Game.Engine.GameMain.AddUnitToList(goblin);
                    break;

                case "goblinBoss":
                    GoblinBoss goblinBoss = new GoblinBoss(Textures.GoblinBoss, map, point);
                    RPG_Game.Engine.GameMain.AddUnitToList(goblinBoss);
                    break;

                case "ogre":
                    Ogre ogre = new Ogre(Textures.Ogre, map, point);
                    RPG_Game.Engine.GameMain.AddUnitToList(ogre);
                    break;

                case "minorHP":
                    MinorHealingPotion minorHP = new MinorHealingPotion(Textures.MinorHealthPotion, map, point);
                    break;

                default:
                    break;
            }
        }

        public static CardinalDirection RandomDirection()
        {
            return (CardinalDirection)RNG.Next(0, 8);
        }
    }
}
