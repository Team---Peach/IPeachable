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

        public static void GenerateEnemy(ContentManager content, IMap map)
        {
            Texture2D goblinTexture = content.Load<Texture2D>("Goblin");
            GenerateObject(map, goblinTexture, StartGameEnemies.goblin["count"],
                StartGameEnemies.goblin["minDistance"], StartGameEnemies.goblin["maxDistance"], "goblin");

            Texture2D goblinBossTexture = content.Load<Texture2D>("GoblinBoss");
            GenerateObject(map, goblinBossTexture, StartGameEnemies.goblinBoss["count"],
                StartGameEnemies.goblinBoss["minDistance"], StartGameEnemies.goblinBoss["maxDistance"], "goblinBoss"); 

            Texture2D ogreTexture = content.Load<Texture2D>("Ogre");
            GenerateObject(map, ogreTexture, StartGameEnemies.ogre["count"],
                StartGameEnemies.ogre["minDistance"], StartGameEnemies.ogre["maxDistance"], "ogre"); 
        }

        internal static void GenerateItems(ContentManager content, IMap map)
        {
            Texture2D minorHPTexture = content.Load<Texture2D>("MinorHealthPotion");
            GenerateObject(map, minorHPTexture, StartGameItems.minorHP["count"],
                StartGameItems.minorHP["minDistance"], StartGameItems.minorHP["maxDistance"], "minorHP");
        }

        private static void GenerateObject(IMap map, Texture2D enemyTexture, int count, int minDistance, int maxDistance, string name)
        {
            int objectCount = count;
            while (objectCount != 0)
            {
                for (int i = 0; i < maxDistance; i++)
                {
                    for (int j = 0; j < maxDistance; j++)
                    {
                        if (map.CheckTile(new Point(i, j)) && objectCount != 0 && (i > minDistance || j > minDistance))
                        {
                            int next = RNG.Next(0, 100);
                            if (next < 4)
                            {
                                PlaceObjectOnMap(name, enemyTexture, map, new Point(i, j));
                                objectCount--;
                            }
                        }
                    }
                }
            }
        }

        private static void PlaceObjectOnMap(string name, Texture2D enemyTexture, IMap map, Point point)
        {
            switch (name)
            {
                case "goblin":
                    Goblin goblin = new Goblin(enemyTexture, map, point);
                    map.Tiles[point.X, point.Y].Terrain.Flags |= Flags.IsEnemy;
                    break;
                case "goblinBoss":
                    GoblinBoss goblinBoss = new GoblinBoss(enemyTexture, map, point);
                    map.Tiles[point.X, point.Y].Terrain.Flags |= Flags.IsEnemy;
                    break;
                case "ogre":
                    Ogre ogre = new Ogre(enemyTexture, map, point);
                    map.Tiles[point.X, point.Y].Terrain.Flags |= Flags.IsEnemy;
                    break;
                case "minorHP":
                    MinorHealingPotion minorHP = new MinorHealingPotion(enemyTexture, map, point);
                    map.Tiles[point.X, point.Y].Terrain.Flags |= Flags.IsItem;
                    break;
                default:
                    break;
            }
        }

        
    }
}
