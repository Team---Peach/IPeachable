namespace RPG_Game.Models
{
    using System;
    using Microsoft.Xna.Framework.Graphics;
    using RPG_Game.Interfaces;
    using RPG_Game.Enums;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Content;
    using RPG_Game.GameData;

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
                StartGameEnemies.rat["count"],
                StartGameEnemies.rat["minDistance"],
                StartGameEnemies.rat["maxDistance"],
                "rat");

            GenerateObject(
                map,
                StartGameEnemies.spider["count"],
                StartGameEnemies.spider["minDistance"],
                StartGameEnemies.spider["maxDistance"],
                "spider");

            GenerateObject(
                map,
                StartGameEnemies.goblin["count"],
                StartGameEnemies.goblin["minDistance"],
                StartGameEnemies.goblin["maxDistance"],
                "goblin");

            GenerateObject(
                map,
                StartGameEnemies.ogre["count"],
                StartGameEnemies.ogre["minDistance"],
                StartGameEnemies.ogre["maxDistance"],
                "ogre"); 

            GenerateObject(
                map,
                StartGameEnemies.goblinBoss["count"],
                StartGameEnemies.goblinBoss["minDistance"],
                StartGameEnemies.goblinBoss["maxDistance"],
                "goblinBoss");

            GenerateObject(
                map,
                StartGameEnemies.goblinWarrior["count"],
                StartGameEnemies.goblinWarrior["minDistance"],
                StartGameEnemies.goblinWarrior["maxDistance"],
                "goblinWarrior");

            GenerateObject(
                map,
                StartGameEnemies.ogreBoss["count"],
                StartGameEnemies.ogreBoss["minDistance"],
                StartGameEnemies.ogreBoss["maxDistance"],
                "ogreBoss");

            GenerateObject(
                map,
                StartGameEnemies.shade["count"],
                StartGameEnemies.shade["minDistance"],
                StartGameEnemies.shade["maxDistance"],
                "shade");

            GenerateObject(
                map,
                StartGameEnemies.goblinWarriorBoss["count"],
                StartGameEnemies.goblinWarriorBoss["minDistance"],
                StartGameEnemies.goblinWarriorBoss["maxDistance"],
                "goblinWarriorBoss");

            GenerateObject(
                map,
                StartGameEnemies.stranger["count"],
                StartGameEnemies.stranger["minDistance"],
                StartGameEnemies.stranger["maxDistance"],
                "stranger");

            GenerateObject(
                map,
                StartGameEnemies.shadeBoss["count"],
                StartGameEnemies.shadeBoss["minDistance"],
                StartGameEnemies.shadeBoss["maxDistance"],
                "shadeBoss");

            GenerateObject(
                map,
                StartGameEnemies.ancientSwordsman["count"],
                StartGameEnemies.ancientSwordsman["minDistance"],
                StartGameEnemies.ancientSwordsman["maxDistance"],
                "ancientSwordsman");

            GenerateObject(
                map,
                StartGameEnemies.destructo["count"],
                StartGameEnemies.destructo["minDistance"],
                StartGameEnemies.destructo["maxDistance"],
                "destructo");

            GenerateObject(
                map,
                StartGameEnemies.finalBoss["count"],
                StartGameEnemies.finalBoss["minDistance"],
                StartGameEnemies.finalBoss["maxDistance"],
                "finalBoss"); 
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
                // Enemies
                #region Enemies
                case "rat":
                    Enemy rat = new Enemy(Textures.Rat, map, point,
                        ObjectsConstants.RatName,
                        ObjectsConstants.RatHealth,
                        ObjectsConstants.RatMana,
                        ObjectsConstants.RatAttack,
                        ObjectsConstants.RatDefence,
                        ObjectsConstants.RatDropList,
                        ObjectsConstants.RatAgression);
                    RPG_Game.Engine.GameMain.AddUnitToList(rat);
                    break;
                case "spider":
                    Enemy spider = new Enemy(Textures.Spider, map, point,
                        ObjectsConstants.SpiderName,
                        ObjectsConstants.SpiderHealth,
                        ObjectsConstants.SpiderMana,
                        ObjectsConstants.SpiderAttack,
                        ObjectsConstants.SpiderDefence,
                        ObjectsConstants.SpiderDropList,
                        ObjectsConstants.SpiderAgression);
                    RPG_Game.Engine.GameMain.AddUnitToList(spider);
                    break;
                case "goblin":
                    Enemy goblin = new Enemy(Textures.Goblin, map, point,
                        ObjectsConstants.GoblinName,
                        ObjectsConstants.GoblinHealth,
                        ObjectsConstants.GoblinMana,
                        ObjectsConstants.GoblinAttack,
                        ObjectsConstants.GoblinDefence,
                        ObjectsConstants.GoblinDropList,
                        ObjectsConstants.GoblinAgression);
                    RPG_Game.Engine.GameMain.AddUnitToList(goblin);
                    break;
                case "ogre":
                    Enemy ogre = new Enemy(Textures.Ogre, map, point,
                        ObjectsConstants.OgreName,
                        ObjectsConstants.OgreHealth,
                        ObjectsConstants.OgreMana,
                        ObjectsConstants.OgreAttack,
                        ObjectsConstants.OgreDefence,
                        ObjectsConstants.OgreDropList,
                        ObjectsConstants.OgreAgression);
                    RPG_Game.Engine.GameMain.AddUnitToList(ogre);
                    break;
                case "goblinBoss":
                    Enemy goblinBoss = new Enemy(Textures.GoblinBoss, map, point,
                        ObjectsConstants.GoblinBossName,
                        ObjectsConstants.GoblinBossHealth,
                        ObjectsConstants.GoblinBossMana,
                        ObjectsConstants.GoblinBossAttack,
                        ObjectsConstants.GoblinBossDefence,
                        ObjectsConstants.GoblinBossDropList,
                        ObjectsConstants.GoblinAgression);
                    RPG_Game.Engine.GameMain.AddUnitToList(goblinBoss);
                    break;
                case "goblinWarrior":
                    Enemy goblinWarrior = new Enemy(Textures.GoblinWarrior, map, point,
                        ObjectsConstants.GoblinWarriorName,
                        ObjectsConstants.GoblinWarriorHealth,
                        ObjectsConstants.GoblinWarriorMana,
                        ObjectsConstants.GoblinWarriorAttack,
                        ObjectsConstants.GoblinWarriorDefence,
                        ObjectsConstants.GoblinWarriorDropList,
                        ObjectsConstants.GoblinAgression);
                    RPG_Game.Engine.GameMain.AddUnitToList(goblinWarrior);
                    break;
                case "ogreBoss":
                    Enemy ogreBoss = new Enemy(Textures.OgreBoss, map, point,
                        ObjectsConstants.OgreBossName,
                        ObjectsConstants.OgreBossHealth,
                        ObjectsConstants.OgreBossMana,
                        ObjectsConstants.OgreBossAttack,
                        ObjectsConstants.OgreBossDefence,
                        ObjectsConstants.OgreBossDropList,
                        ObjectsConstants.OgreBossAgression);
                    RPG_Game.Engine.GameMain.AddUnitToList(ogreBoss);
                    break;
                case "shade":
                    Enemy shade = new Enemy(Textures.Shade, map, point,
                        ObjectsConstants.ShadeName,
                        ObjectsConstants.ShadeHealth,
                        ObjectsConstants.ShadeMana,
                        ObjectsConstants.ShadeAttack,
                        ObjectsConstants.ShadeDefence,
                        ObjectsConstants.ShadeDropList,
                        ObjectsConstants.ShadeAgression);
                    RPG_Game.Engine.GameMain.AddUnitToList(shade);
                    break;
                case "goblinWarriorBoss":
                    Enemy goblinWarriorBoss = new Enemy(Textures.GoblinWarriorBoss, map, point,
                        ObjectsConstants.GoblinWarriorBossName,
                        ObjectsConstants.GoblinWarriorBossHealth,
                        ObjectsConstants.GoblinWarriorBossMana,
                        ObjectsConstants.GoblinWarriorBossAttack,
                        ObjectsConstants.GoblinWarriorBossDefence,
                        ObjectsConstants.GoblinWarriorBossDropList,
                        ObjectsConstants.GoblinWarriorAgression);
                    RPG_Game.Engine.GameMain.AddUnitToList(goblinWarriorBoss);
                    break;
                case "stranger":
                    Enemy stranger = new Enemy(Textures.Stranger, map, point,
                        ObjectsConstants.StrangerName,
                        ObjectsConstants.StrangerHealth,
                        ObjectsConstants.StrangerMana,
                        ObjectsConstants.StrangerAttack,
                        ObjectsConstants.StrangerDefence,
                        ObjectsConstants.StrangerDropList,
                        ObjectsConstants.StrangerAgression);
                    RPG_Game.Engine.GameMain.AddUnitToList(stranger);
                    break;
                case "shadeBoss":
                    Enemy shadeBoss = new Enemy(Textures.ShadeBoss, map, point,
                        ObjectsConstants.ShadeBossName,
                        ObjectsConstants.ShadeBossHealth,
                        ObjectsConstants.ShadeBossMana,
                        ObjectsConstants.ShadeBossAttack,
                        ObjectsConstants.ShadeBossDefence,
                        ObjectsConstants.ShadeBossDropList,
                        ObjectsConstants.ShadeBossAgression);
                    RPG_Game.Engine.GameMain.AddUnitToList(shadeBoss);
                    break;
                case "ancientSwordsman":
                    Enemy ancientSwordsman = new Enemy(Textures.AncientSwordsman, map, point,
                        ObjectsConstants.AncientSwordsmanName,
                        ObjectsConstants.AncientSwordsmanHealth,
                        ObjectsConstants.AncientSwordsmanMana,
                        ObjectsConstants.AncientSwordsmanAttack,
                        ObjectsConstants.AncientSwordsmanDefence,
                        ObjectsConstants.AncientSwordsmanDropList,
                        ObjectsConstants.AncientSwordsmanAgression);
                    RPG_Game.Engine.GameMain.AddUnitToList(ancientSwordsman);
                    break;
                case "destructo":
                    Enemy destructo = new Enemy(Textures.Destructo, map, point,
                        ObjectsConstants.DestructoName,
                        ObjectsConstants.DestructoHealth,
                        ObjectsConstants.DestructoMana,
                        ObjectsConstants.DestructoAttack,
                        ObjectsConstants.DestructoDefence,
                        ObjectsConstants.DestructoDropList,
                        ObjectsConstants.DestructoAgression);
                    RPG_Game.Engine.GameMain.AddUnitToList(destructo);
                    break;
                case "finalBoss":
                    Enemy finalBoss = new Enemy(Textures.FinalBoss, map, point,
                        ObjectsConstants.FinalBossName,
                        ObjectsConstants.FinalBossHealth,
                        ObjectsConstants.FinalBossMana,
                        ObjectsConstants.FinalBossAttack,
                        ObjectsConstants.FinalBossDefence,
                        ObjectsConstants.FinalBossDropList,
                        ObjectsConstants.FinalBossAgression);
                    RPG_Game.Engine.GameMain.AddUnitToList(finalBoss);
                    break;
                #endregion

                // Drink items
                #region Drinks
                case "minorHP":
                    Drink minorHP = new Drink(Textures.MinorHealthPotion, map, point, ObjectsConstants.MinorHPName, ObjectsConstants.MinorHPHealthRP, 0,0,0,0,0);
                    break;
                case "healingPotion":
                    Drink healingPotion = new Drink(Textures.HealthPotion, map, point, ObjectsConstants.HealingPotionName, ObjectsConstants.HealingPotionHealthRP, 0, 0, 0, 0, 0);
                    break;
                case "majorHP":
                    Drink majorHP = new Drink(Textures.MajorHealthPotion, map, point, ObjectsConstants.MajorHPName, ObjectsConstants.MajorHPHealthRP, 0, 0, 0, 0, 0);
                    break;
                #endregion

                // Equip items
                #region Equip
                case "boots":
                    Equip boots = new Equip(Textures.Boots, map, point, 
                        ObjectsConstants.BootsName,
                        ObjectsConstants.BootsAttackBonus,
                        ObjectsConstants.BootsDefenceBonus,
                        ObjectsConstants.BootsHealthBonus,
                        ObjectsConstants.BootsManaBonus,
                        ObjectsConstants.BootsSlot);
                    break;
                case "leatherBoots":
                    Equip leatherBoots = new Equip(Textures.LeatherBoots, map, point,
                        ObjectsConstants.LeatherBootsName,
                        ObjectsConstants.LeatherBootsAttackBonus,
                        ObjectsConstants.LeatherBootsDefenceBonus,
                        ObjectsConstants.LeatherBootsHealthBonus,
                        ObjectsConstants.LeatherBootsManaBonus,
                        ObjectsConstants.LeatherBootsSlot);
                    break;
                case "enchantedBoots":
                    Equip enchantedBoots = new Equip(Textures.EnchantedBoots, map, point,
                        ObjectsConstants.EnchantedBootsName,
                        ObjectsConstants.EnchantedBootsAttackBonus,
                        ObjectsConstants.EnchantedBootsDefenceBonus,
                        ObjectsConstants.EnchantedBootsHealthBonus,
                        ObjectsConstants.EnchantedBootsManaBonus,
                        ObjectsConstants.EnchantedBootsSlot);
                    break;
                case "hat":
                    Equip hat = new Equip(Textures.Hat, map, point,
                        ObjectsConstants.HatName,
                        ObjectsConstants.HatAttackBonus,
                        ObjectsConstants.HatDefenceBonus,
                        ObjectsConstants.HatHealthBonus,
                        ObjectsConstants.HatManaBonus,
                        ObjectsConstants.HatSlot);
                    break;
                case "helmet":
                    Equip helmet = new Equip(Textures.Helmet, map, point,
                        ObjectsConstants.HelmetName,
                        ObjectsConstants.HelmetAttackBonus,
                        ObjectsConstants.HelmetDefenceBonus,
                        ObjectsConstants.HelmetHealthBonus,
                        ObjectsConstants.HelmetManaBonus,
                        ObjectsConstants.HelmetSlot);
                    break;
                case "enchantedHelmet":
                    Equip enchantedHelmet = new Equip(Textures.EnchantedHelmet, map, point,
                        ObjectsConstants.EnchantedHelmetName,
                        ObjectsConstants.EnchantedHelmetAttackBonus,
                        ObjectsConstants.EnchantedHelmetDefenceBonus,
                        ObjectsConstants.EnchantedHelmetHealthBonus,
                        ObjectsConstants.EnchantedHelmetManaBonus,
                        ObjectsConstants.EnchantedHelmetSlot);
                    break;
                case "leatherArmor":
                    Equip leatherArmor = new Equip(Textures.LeatherArmor, map, point,
                        ObjectsConstants.LeatherArmorName,
                        ObjectsConstants.LeatherArmorAttackBonus,
                        ObjectsConstants.LeatherArmorDefenceBonus,
                        ObjectsConstants.LeatherArmorHealthBonus,
                        ObjectsConstants.LeatherArmorManaBonus,
                        ObjectsConstants.LeatherArmorSlot);
                    break;
                case "ironArmor":
                    Equip ironArmor = new Equip(Textures.IronArmor, map, point,
                        ObjectsConstants.IronArmorName,
                        ObjectsConstants.IronArmorAttackBonus,
                        ObjectsConstants.IronArmorDefenceBonus,
                        ObjectsConstants.IronArmorHealthBonus,
                        ObjectsConstants.IronArmorManaBonus,
                        ObjectsConstants.IronArmorSlot);
                    break;
                case "enchantedArmor":
                    Equip enchantedArmor = new Equip(Textures.EnchantedArmor, map, point,
                        ObjectsConstants.EnchantedArmorName,
                        ObjectsConstants.EnchantedArmorAttackBonus,
                        ObjectsConstants.EnchantedArmorDefenceBonus,
                        ObjectsConstants.EnchantedArmorHealthBonus,
                        ObjectsConstants.EnchantedArmorManaBonus,
                        ObjectsConstants.EnchantedArmorSlot);
                    break;
                case "leatherGloves":
                    Equip leatherGloves = new Equip(Textures.LeatherGloves, map, point,
                        ObjectsConstants.LeatherGlovesName,
                        ObjectsConstants.LeatherGlovesAttackBonus,
                        ObjectsConstants.LeatherGlovesDefenceBonus,
                        ObjectsConstants.LeatherGlovesHealthBonus,
                        ObjectsConstants.LeatherGlovesManaBonus,
                        ObjectsConstants.LeatherGlovesSlot);
                    break;
                case "runicGloves":
                    Equip runicGloves = new Equip(Textures.RunicGloves, map, point,
                        ObjectsConstants.RunicGlovesName,
                        ObjectsConstants.RunicGlovesAttackBonus,
                        ObjectsConstants.RunicGlovesDefenceBonus,
                        ObjectsConstants.RunicGlovesHealthBonus,
                        ObjectsConstants.RunicGlovesManaBonus,
                        ObjectsConstants.RunicGlovesSlot);
                    break;
                case "enchantedGloves":
                    Equip enchantedGloves = new Equip(Textures.EnchantedGloves, map, point,
                        ObjectsConstants.EnchantedGlovesName,
                        ObjectsConstants.EnchantedGlovesAttackBonus,
                        ObjectsConstants.EnchantedGlovesDefenceBonus,
                        ObjectsConstants.EnchantedGlovesHealthBonus,
                        ObjectsConstants.EnchantedGlovesManaBonus,
                        ObjectsConstants.EnchantedGlovesSlot);
                    break;
                case "pants":
                    Equip pants = new Equip(Textures.Pants, map, point,
                        ObjectsConstants.PantsName,
                        ObjectsConstants.PantsAttackBonus,
                        ObjectsConstants.PantsDefenceBonus,
                        ObjectsConstants.PantsHealthBonus,
                        ObjectsConstants.PantsManaBonus,
                        ObjectsConstants.PantsSlot);
                    break;
                case "leatherPants":
                    Equip leatherPants = new Equip(Textures.LeatherPants, map, point,
                        ObjectsConstants.LeatherPantsName,
                        ObjectsConstants.LeatherPantsAttackBonus,
                        ObjectsConstants.LeatherPantsDefenceBonus,
                        ObjectsConstants.LeatherPantsHealthBonus,
                        ObjectsConstants.LeatherPantsManaBonus,
                        ObjectsConstants.LeatherPantsSlot);
                    break;
                case "enchantedPants":
                    Equip enchantedPants = new Equip(Textures.EnchantedPants, map, point,
                        ObjectsConstants.EnchantedPantsName,
                        ObjectsConstants.EnchantedPantsAttackBonus,
                        ObjectsConstants.EnchantedPantsDefenceBonus,
                        ObjectsConstants.EnchantedPantsHealthBonus,
                        ObjectsConstants.EnchantedPantsManaBonus,
                        ObjectsConstants.EnchantedPantsSlot);
                    break;
                case "woodenShield":
                    Equip woodenShield = new Equip(Textures.WoodenShield, map, point,
                        ObjectsConstants.WoodenShieldName,
                        ObjectsConstants.WoodenShieldAttackBonus,
                        ObjectsConstants.WoodenShieldDefenceBonus,
                        ObjectsConstants.WoodenShieldHealthBonus,
                        ObjectsConstants.WoodenShieldManaBonus,
                        ObjectsConstants.WoodenShieldSlot);
                    break;
                case "leatherShield":
                    Equip leatherShield = new Equip(Textures.LeatherShield, map, point,
                        ObjectsConstants.LeatherShieldName,
                        ObjectsConstants.LeatherShieldAttackBonus,
                        ObjectsConstants.LeatherShieldDefenceBonus,
                        ObjectsConstants.LeatherShieldHealthBonus,
                        ObjectsConstants.LeatherShieldManaBonus,
                        ObjectsConstants.LeatherShieldSlot);
                    break;
                case "enchantedShield":
                    Equip enchantedShield = new Equip(Textures.EnchantedShield, map, point,
                        ObjectsConstants.EnchantedShieldName,
                        ObjectsConstants.EnchantedShieldAttackBonus,
                        ObjectsConstants.EnchantedShieldDefenceBonus,
                        ObjectsConstants.EnchantedShieldHealthBonus,
                        ObjectsConstants.EnchantedShieldManaBonus,
                        ObjectsConstants.EnchantedShieldSlot);
                    break;
                case "shortSword":
                    Equip shortSword = new Equip(Textures.ShortSword, map, point,
                        ObjectsConstants.ShortSwordName,
                        ObjectsConstants.ShortSwordAttackBonus,
                        ObjectsConstants.ShortSwordDefenceBonus,
                        ObjectsConstants.ShortSwordHealthBonus,
                        ObjectsConstants.ShortSwordManaBonus,
                        ObjectsConstants.ShortSwordSlot);
                    break;
                case "sword":
                    Equip sword = new Equip(Textures.Sword, map, point,
                        ObjectsConstants.SwordName,
                        ObjectsConstants.SwordAttackBonus,
                        ObjectsConstants.SwordDefenceBonus,
                        ObjectsConstants.SwordHealthBonus,
                        ObjectsConstants.SwordManaBonus,
                        ObjectsConstants.SwordSlot);
                    break;
                case "enchantedSword":
                    Equip enchantedSword = new Equip(Textures.EnchantedSword, map, point,
                        ObjectsConstants.EnchantedSwordName,
                        ObjectsConstants.EnchantedSwordAttackBonus,
                        ObjectsConstants.EnchantedSwordDefenceBonus,
                        ObjectsConstants.EnchantedSwordHealthBonus,
                        ObjectsConstants.EnchantedSwordManaBonus,
                        ObjectsConstants.EnchantedSwordSlot);
                    break;
                case "staff":
                    Equip staff = new Equip(Textures.Staff, map, point,
                        ObjectsConstants.StaffName,
                        ObjectsConstants.StaffAttackBonus,
                        ObjectsConstants.StaffDefenceBonus,
                        ObjectsConstants.StaffHealthBonus,
                        ObjectsConstants.StaffManaBonus,
                        ObjectsConstants.StaffSlot);
                    break;
                case "shortStaff":
                    Equip shortStaff = new Equip(Textures.ShortStaff, map, point,
                        ObjectsConstants.ShortStaffName,
                        ObjectsConstants.ShortStaffAttackBonus,
                        ObjectsConstants.ShortStaffDefenceBonus,
                        ObjectsConstants.ShortStaffHealthBonus,
                        ObjectsConstants.ShortStaffManaBonus,
                        ObjectsConstants.ShortStaffSlot);
                    break;
                case "enchantedStaff":
                    Equip enchantedStaff = new Equip(Textures.EnchantedStaff, map, point,
                        ObjectsConstants.EnchantedStaffName,
                        ObjectsConstants.EnchantedStaffAttackBonus,
                        ObjectsConstants.EnchantedStaffDefenceBonus,
                        ObjectsConstants.EnchantedStaffHealthBonus,
                        ObjectsConstants.EnchantedStaffManaBonus,
                        ObjectsConstants.EnchantedStaffSlot);
                    break;
                #endregion
                default:
                    break;
            }
        }

        public static int RandomDrop(int itemsCount)
        {
            return RNG.Next(0, itemsCount);
        }

        public static CardinalDirection RandomDirection()
        {
            return (CardinalDirection)RNG.Next(0, 8);
        }
    }
}
