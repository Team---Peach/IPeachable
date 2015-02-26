namespace RPG_Game.Models
{
    using System.Collections.Generic;
    using Microsoft.Xna.Framework.Graphics;
    using Microsoft.Xna.Framework;
    using Interfaces;

    public class Player : GameUnit, IPlayer
    {
        private const string PlayerName = "Peachabolator";
        private const int PlayerHealth = 500;
        private const int PlayerMana = 500;
        private const int PlayerAttack = 25;
        private const int PlayerDefence = 50;
        private int turns = 0;
        private int lastHeal = 0;
        private int lastDevineShield = 0;
        private int defaultDefence;
        private bool isShieldActive = false;

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

        public int LastShield
        {
            get { return this.lastDevineShield; }
        }

        public int Turns 
        {
            get { return this.turns; }
            set
            {
                this.turns = value;
            } 
        }

        public int LastHeal
        {
            get { return this.lastHeal; }
            set
            {
                this.lastHeal = value; 
            }
        }
        #endregion

        public void EquipItem(IEquipable itemToWear)
        {
            if (this.EquipedItems[itemToWear.Slot] == null)
            {
                this.equipedItems[itemToWear.Slot] = itemToWear;
                AddStats(itemToWear);
            }
            else
            {
                RemoveStats(this.EquipedItems[itemToWear.Slot]);
                this.equipedItems[itemToWear.Slot] = null;
                this.equipedItems[itemToWear.Slot] = itemToWear;
                AddStats(itemToWear);
            }

            string info = "You have equiped " + itemToWear.Name;
            InfoPanel.AddInfo(info);
        }

        private void RemoveStats(IEquipable itemToRemove)
        {
            this.Health -= itemToRemove.HealthBonus;
            this.MaxHealth -= itemToRemove.HealthBonus;
            this.Mana -= itemToRemove.ManaBonus;
            this.MaxMana -= itemToRemove.ManaBonus;
            this.Attack -= itemToRemove.AttackBonus;
            this.Defence -= itemToRemove.DefenceBonus;
        }

        private void AddStats(IEquipable itemToWear)
        {
            this.Health += itemToWear.HealthBonus;
            this.MaxHealth += itemToWear.HealthBonus;
            this.Mana += itemToWear.ManaBonus;
            this.MaxMana += itemToWear.ManaBonus;
            this.Attack += itemToWear.AttackBonus;
            this.Defence += itemToWear.DefenceBonus;
        }

        public void UseItem(IDrinkable itemToUse)
        {
            string info = "";
            if (this.Health + itemToUse.HealthRestorationPower > this.MaxHealth)
            {
                info = "You drinked " + itemToUse.Name + " and restore " + (this.MaxHealth - this.Health) + " health";
                this.Health = this.MaxHealth;
            }
            else
            {
                info = "You drinked " + itemToUse.Name + " and restore " + itemToUse.HealthRestorationPower + " health";
                this.Health += itemToUse.HealthRestorationPower;
            }
            InfoPanel.AddInfo(info);
        }

        public void Heal()
        {
            
            if (this.Turns - this.lastHeal > 20 && this.Mana >= 100)
            {
                int healedAmount;
                if (this.MaxHealth - this.Health < 50)
                {
                    healedAmount = this.MaxHealth - this.Health;
                    this.Health = this.MaxHealth;
                }
                else
                {
                    this.Health += 50;
                    healedAmount = 50;
                }
                this.Mana -= 100;
                this.lastHeal = this.Turns;
                string info = string.Format("You healed yourself for {0} Health", healedAmount);
                InfoPanel.AddInfo(info);
            }
            else if (this.Turns - this.lastHeal < 20)
            {
                string info = string.Format("Heal is on cooldown wait {0} more turns.", 20 - (this.Turns - this.lastHeal));
                InfoPanel.AddInfo(info);
            }
            else
            {
                string info = string.Format("Not enough mana!");
                InfoPanel.AddInfo(info);
            }
        }

        public void UpdateMana()
        {
            if (this.Mana < 500)
            {
                this.Mana++;
            }
        }

        public void Shield()
        {
            if (this.Turns - this.lastDevineShield < 50)
            {
                string info = string.Format("Devine Shield is on cooldown wait {0} more turns."
                    , 50 - (this.Turns - this.lastDevineShield));
                InfoPanel.AddInfo(info);
            }
            else
            {
                this.defaultDefence = this.Defence;
                this.isShieldActive = true;
                this.Defence += 500;
                this.Mana = 0;
                this.lastDevineShield = this.Turns;
                string info = string.Format("Devine Shield has been used!"
                    , 50 - (this.Turns - this.lastHeal));
                InfoPanel.AddInfo(info);
            }
        }

        public void DeactivateShield()
        {
            if (this.isShieldActive && lastDevineShield + 5 == this.Turns)
            {
                isShieldActive = false;
                this.Defence = defaultDefence;
                string info = string.Format("Devine Shield is over!"
                    , 150 - (this.Turns - this.lastHeal));
                InfoPanel.AddInfo(info);
            }
        }
    }
}
