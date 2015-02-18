using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using RPG_Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG_Game.Models.Enemies
{
    public class AncientSwordsman : Enemy
    {
        private const string AncientSwordsmanName = "Ancient Swordsman";
        private const int AncientSwordsmanHealth = 400;
        private const int AncientSwordsmanMana = 0;
        private const int AncientSwordsmanAttack = 70;
        private const int AncientSwordsmanDefence = 60;

        private static List<string> dropList = new List<string>
        {
            // add few items
            "minorHP"
        };

        public AncientSwordsman(Texture2D texture, IMap map, Point position)
            : base(texture, map, position, AncientSwordsmanName, AncientSwordsmanHealth, AncientSwordsmanMana, AncientSwordsmanAttack, AncientSwordsmanDefence, dropList)
        {

        }
    }
}
