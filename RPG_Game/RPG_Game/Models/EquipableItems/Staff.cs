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
    class Staff : Weapon
    {
        private const string StaffName = "Staff";
        private const int StaffAttackBonus = 20;
        private const int StaffDefenceBonus = 0;
        private const int StaffHealthBonus = 0;
        private const int StaffManaBonus = 50;

        public Staff(Texture2D texture, IMap map, Point position)
            : base(texture, map, position, StaffName, StaffAttackBonus, StaffDefenceBonus, StaffHealthBonus, StaffManaBonus)
        {
        }
    }
}
