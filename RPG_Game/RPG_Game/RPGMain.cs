#region Using Statements
using RPG_Game.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
#endregion

namespace RPG_Game
{
#if WINDOWS || LINUX
    /// <summary>
    /// The main class.
    /// </summary>
    public static class RPGMain
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var game = new GameMain())
                game.Run();
        }
    }
#endif
}
