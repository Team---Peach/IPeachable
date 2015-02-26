using System.Collections.Generic;
using RPG_Game.Enums;

namespace RPG_Game.Interfaces
{
    public interface IEnemy : IGameUnit
    {
        List<string> DropList { get; }
        bool InBattle { get; set; }
        IPlayer Player { get; set; }
        int Agression { get; set; }

        string ItemToDrop();
        void StartBattleIfInRange(IMap map);
    }
}
