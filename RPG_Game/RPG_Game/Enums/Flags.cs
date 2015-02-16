using System;
namespace RPG_Game.Enums
{
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
