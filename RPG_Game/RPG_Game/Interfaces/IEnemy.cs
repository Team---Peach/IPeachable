using System.Collections.Generic;
using RPG_Game.Enums;

namespace RPG_Game.Interfaces
{
    public interface IEnemy : IGameUnit
    {
        string ItemToDrop();
    }
}
