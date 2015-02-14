using System.Collections.Generic;
namespace RPG_Game.Interfaces
{
    public interface IEnemy : IGameUnit
    {
        IList<IEnemy> DropList { get; }
    }
}
