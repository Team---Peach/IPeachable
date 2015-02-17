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

namespace RPG_Game.Models.DroppedItems
{
    class Staff : GameItem, IWearable
    {
      public Staff(int attackBonuc, int defenceBonus, int healthBonus, int manaBonus, 
          Texture2D texture, IMap map, Point position, string name) 
            : base(texture, map, position, name)
        {
            this.AttackBonus = attackBonuc;
            this.DefenceBonus = defenceBonus;
            this.HealthBonus = healthBonus;
            this.ManaBonus = manaBonus;
        }

        public int AttackBonus { get; set; }

        public int DefenceBonus { get; set; }

        public int HealthBonus { get; set; }

        public int ManaBonus { get; set; }
    }
}
