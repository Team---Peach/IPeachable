using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using RPG_Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG_Game.Models.Enemies
{
    public class Shade : Enemy
    {
        private const string ShadeName = "Shade";
        private const int ShadeHealth = 150;
        private const int ShadeMana = 0;
        private const int ShadeAttack = 30;
        private const int ShadeDefence = 35;

        private static List<string> dropList = new List<string>
        {
            // add few items
            "minorHP"
        };

        public Shade(Texture2D texture, IMap map, Point position)
            : base(texture, map, position, ShadeName, ShadeHealth, ShadeMana, ShadeAttack, ShadeDefence, dropList)
        {

        }
    }
}
