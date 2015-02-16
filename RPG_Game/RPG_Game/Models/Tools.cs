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

        private static void GenerateObject(IMap map, int count, int minDistance, int maxDistance, string name)
        {
            int objectCount = count;
            while (objectCount != 0)
            {
                for (int i = 0; i < maxDistance; i++)
                {
                    for (int j = 0; j < maxDistance; j++)
                    {
                        if (map.CheckIfTileIsOutOfBounds(new Point(i, j)) 
                            && objectCount != 0 
                            && (i > minDistance || j > minDistance)
                            && map.Tiles[i,j].Terrain.Flags.HasFlag(Flags.None))
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

        public static void PlaceObjectOnMap(string name, IMap map, Point point)
        {
            switch (name)
            {
                case "goblin":
                    Goblin goblin = new Goblin(Textures.Goblin, map, point);
                    RPG_Game.Engine.GameMain.AddUnitToList(goblin);
                    map.Tiles[point.X, point.Y].Terrain.Flags = Flags.IsEnemy;
                    break;

                case "goblinBoss":
                    GoblinBoss goblinBoss = new GoblinBoss(Textures.GoblinBoss, map, point);
                    RPG_Game.Engine.GameMain.AddUnitToList(goblinBoss);
                    map.Tiles[point.X, point.Y].Terrain.Flags = Flags.IsEnemy;
                    break;

                case "ogre":
                    Ogre ogre = new Ogre(Textures.Ogre, map, point);
                    RPG_Game.Engine.GameMain.AddUnitToList(ogre);
                    map.Tiles[point.X, point.Y].Terrain.Flags = Flags.IsEnemy;
                    break;

                case "minorHP":
                    MinorHealingPotion minorHP = new MinorHealingPotion(Textures.MinorHealthPotion, map, point);
                    map.Tiles[point.X, point.Y].Terrain.Flags = Flags.IsItem;
                    break;

                default:
                    break;
            }
        }

        
    }
}
