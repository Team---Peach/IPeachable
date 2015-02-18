namespace RPG_Game.Models
{
    using System;
    using System.Collections.Generic;
    using Microsoft.Xna.Framework.Graphics;
    using Microsoft.Xna.Framework;
    using RPG_Game.Interfaces;
    using RPG_Game.Enums;
    using System.Diagnostics;
    using System.Threading;

    public class Player : GameUnit, IPlayer
    {
        private const string PlayerName = "Peachabolator";
        private const int PlayerHealth = 500;
        private const int PlayerMana = 500;
        private const int PlayerAttack = 25;
        private const int PlayerDefence = 50;
        private int turns = 0;
        private int lastHeal = 0;

        private IDictionary<string, IEquipable> equipedItems = new Dictionary<string, IEquipable>
        {
            {"head", null},
	        {"body", null},
	        {"hand", null},
	        {"weapon", null},
	        {"shield", null},
	        {"pant", null},
	        {"feet", null}
        };

        public Player(Texture2D texture, IMap map, Point position)
            : base(texture, map, position, PlayerName, PlayerHealth, PlayerMana, PlayerAttack, PlayerDefence)
        {
            this.MaxHealth = PlayerHealth;
            this.MaxMana = PlayerMana;
        }

        #region Properties

        public int MaxHealth { get; set; }
        public int MaxMana { get; set; }

        public IDictionary<string, IEquipable> EquipedItems
        {
            get
            {
                return new Dictionary<string, IEquipable>(equipedItems);
            }
        }
        public int Turns 
        {
            get { return this.turns; }
            set
            {
                this.turns = value;
            } 
        }
        #endregion

        public void EquipItem(IEquipable itemToWear)

        {
            throw new NotImplementedException();
        }

        public void UseItem(IDrinkable itemToUse)
        {
            string info = "You drinked " + itemToUse.Name + " and restore " + itemToUse.HealthRestorationPower + " health";
            this.Health += itemToUse.HealthRestorationPower;
            InfoPanel.AddInfo(info);
        }
        public void Heal()
        {
            
            if (this.Turns - this.lastHeal > 20 && this.Mana >= 300)
            {
                this.Health += 50;
                this.Mana -= 300;
                this.lastHeal = this.Turns;
                string info = "You healed yourself for 50 Health";
                InfoPanel.AddInfo(info);
            }
            else if (this.Turns - this.lastHeal < 20)
            {
                string info = string.Format("Heal is on cooldown wait {0} more turns", 20 - (this.Turns - this.lastHeal));
                InfoPanel.AddInfo(info);
            }
            else
            {
                string info = string.Format("Not enough mana!");
                InfoPanel.AddInfo(info);
            }
        }
    }
}
