﻿namespace RPG_Game.Interfaces
{
    public interface ITile
    {
        IGameObject Actor { get; set; }
        ITerrain Terrain { get; set; }
        IGameItem Item { get; set; }
        IObject GameObject { get; set; }
    }
}
