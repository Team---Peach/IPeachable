namespace RPG_Game.Models.EquipableItems
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using RPG_Game.Interfaces;

    class LeatherShield : Shield
    {
        private const string LeatherShieldName = "Leather Shield";
        private const int LeatherShieldAttackBonus = 0;
        private const int LeatherShieldDefenceBonus = 20;
        private const int LeatherShieldHealthBonus = 0;
        private const int LeatherShieldManaBonus = 0;

        public LeatherShield(Texture2D texture, IMap map, Point position)
            : base(texture, map, position, LeatherShieldName, LeatherShieldAttackBonus, LeatherShieldDefenceBonus,
            LeatherShieldHealthBonus, LeatherShieldManaBonus)
        {
        }
    }
}
