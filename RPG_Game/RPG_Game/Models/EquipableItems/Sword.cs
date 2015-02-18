using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Storage;
using RPG_Game.Interfaces;
using RPG_Game.Models;
using RPG_Game.Enums;
using RPG_Game.GameData;

namespace RPG_Game.Models.EquipableItems
{
    class Sword : Weapon
    {
        private const string SwordName = "Sword";
        private const int SwordAttackBonus = 30;
        private const int SwordDefenceBonus = 0;
        private const int SwordHealthBonus = 0;
        private const int SwordManaBonus = 0;

        public Sword(Texture2D texture, IMap map, Point position)
            : base(texture, map, position, SwordName, SwordAttackBonus, SwordDefenceBonus, SwordHealthBonus, SwordManaBonus)
        {
        }
    }
}
