namespace RPG_Game.Enums
{
    using System;

    [Flags]
    public enum Flags
    {
        IsPlayerControl,
        IsBlocked,
        IsItem,
        IsEnemy,
        None
    }
}
