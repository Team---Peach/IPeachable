namespace RPG_Game.GameData
{
    using RPG_Game.Interfaces;
    using System.Collections.Generic;

    public static class StartGameEnemies
    {
        public static Dictionary<string, int> rat = new Dictionary<string, int>()
	    {
	        {"count", 10},
	        {"minDistance", 4},
	        {"maxDistance", 16}
	    };

        public static Dictionary<string, int> spider = new Dictionary<string, int>()
	    {
	        {"count", 10},
	        {"minDistance", 8},
	        {"maxDistance", 20}
	    };

        public static Dictionary<string, int> goblin = new Dictionary<string, int>()
	    {
	        {"count", 10},
	        {"minDistance", 14},
	        {"maxDistance", 24}
	    };

        public static Dictionary<string, int> ogre = new Dictionary<string, int>()
	    {
	        {"count", 10},
	        {"minDistance", 18},
	        {"maxDistance", 28}
	    };

        public static Dictionary<string, int> goblinBoss = new Dictionary<string, int>()
	    {
	        {"count", 1},
	        {"minDistance", 20},
	        {"maxDistance", 22}
	    };

        public static Dictionary<string, int> goblinWarrior = new Dictionary<string, int>()
	    {
	        {"count", 10},
	        {"minDistance", 22},
	        {"maxDistance", 30}
	    };

        public static Dictionary<string, int> ogreBoss = new Dictionary<string, int>()
	    {
	        {"count", 1},
	        {"minDistance", 24},
	        {"maxDistance", 26}
	    };

        public static Dictionary<string, int> shade = new Dictionary<string, int>()
	    {
	        {"count", 10},
	        {"minDistance", 28},
	        {"maxDistance", 38}
	    };

        public static Dictionary<string, int> goblinWarriorBoss = new Dictionary<string, int>()
	    {
	        {"count", 1},
	        {"minDistance", 32},
	        {"maxDistance", 37}
	    };

        public static Dictionary<string, int> stranger = new Dictionary<string, int>()
	    {
	        {"count", 1},
	        {"minDistance", 34},
	        {"maxDistance", 36}
	    };

        public static Dictionary<string, int> shadeBoss = new Dictionary<string, int>()
	    {
	        {"count", 1},
	        {"minDistance", 34},
	        {"maxDistance", 36}
	    };

        public static Dictionary<string, int> ancientSwordsman = new Dictionary<string, int>()
	    {
	        {"count", 1},
	        {"minDistance", 34},
	        {"maxDistance", 36}
	    };

        public static Dictionary<string, int> destructo = new Dictionary<string, int>()
	    {
	        {"count", 1},
	        {"minDistance", 36},
	        {"maxDistance", 38}
	    };

        public static Dictionary<string, int> finalBoss = new Dictionary<string, int>()
	    {
	        {"count", 1},
	        {"minDistance", 38},
	        {"maxDistance", 40}
	    };
    }
}
