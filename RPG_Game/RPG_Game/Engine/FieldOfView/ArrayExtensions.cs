using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG_Game.Engine.FieldOfView
{
    internal static class ArrayExtensions
    {
        public static int Width<T>(this T[,] array)
        {
            return array.GetLength(0);
        }

        public static int Height<T>(this T[,] array)
        {
            return array.GetLength(1);
        }
    }
}
