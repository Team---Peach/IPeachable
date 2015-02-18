namespace RPG_Game.Models.DroppedItems
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using RPG_Game.Interfaces;

    class Shield : Equip
    {
        private const string ShieldName = "Shield";
        private const int ShieldAttackBonus = 0;
        private const int ShieldDefenceBonus = 20;
        private const int ShieldHealthBonus = 0;
        private const int ShieldManaBonus = 0;

        public Shield(Texture2D texture, IMap map, Point position)
            : base(texture, map, position, ShieldName, ShieldAttackBonus, ShieldDefenceBonus, ShieldHealthBonus, ShieldManaBonus)
        {
        }
    }
}
