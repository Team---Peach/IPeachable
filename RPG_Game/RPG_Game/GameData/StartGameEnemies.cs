namespace RPG_Game.GameData
{
    using RPG_Game.Interfaces;
    using System.Collections.Generic;

    public static class StartGameEnemies
    {
        public static Dictionary<string, int> goblin = new Dictionary<string, int>()
	    {
	        {"count", 15},
	        {"minDistance", 4},
	        {"maxDistance", 16}
	    };

        public static Dictionary<string, int> goblinBoss = new Dictionary<string, int>()
	    {
	        {"count", 1},
	        {"minDistance", 13},
	        {"maxDistance", 15}
	    };

        public static Dictionary<string, int> ogre = new Dictionary<string, int>()
	    {
	        {"count", 15},
	        {"minDistance", 14},
	        {"maxDistance", 20}
	    };

        public static Dictionary<string, int> ogreBoss = new Dictionary<string, int>()
	    {
	        {"count", 1},
	        {"minDistance", 17},
	        {"maxDistance", 19}
	    };
    }
}
