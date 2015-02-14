namespace RPG_Game.Models
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using RPG_Game.Enums;
    using RPG_Game.Interfaces;

    public class Drink : GameItem, IDrinkable
    {
        public Drink(Texture2D texture, Flags flags, IMap map, Point position, 
            string name, int healthRestorationPower, int manaRestorationPower, int healthIncreasePower, 
            int manaIncreasePower, int attackIncreasePower, int defenceIncreasePower) 
            : base(texture, flags, map, position, name)
        {
            this.HealthRestorationPower = healthRestorationPower;
            this.ManaRestorationPower = manaRestorationPower;
            this.HealthIncreasePower = healthIncreasePower;
            this.ManaIncreasePower = manaIncreasePower;
            this.AttackIncreasePower = attackIncreasePower;
            this.DefenceIncreasePower = defenceIncreasePower;
        }

        public int HealthRestorationPower { get; set; }

        public int ManaRestorationPower { get; set; }

        public int HealthIncreasePower { get; set; }

        public int ManaIncreasePower { get; set; }

        public int AttackIncreasePower { get; set; }

        public int DefenceIncreasePower { get; set; }
    }
}
