using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG_Game
{
    public class Tile : ITile
    {
        public IActor Actor { get; set; }
        public ITerrain Terrain { get; set; }
        public IItem Item { get; set; }
        public IObject GameObject { get; set; }

        public Tile(ITerrain terrain, IActor actor, IItem item, IObject gameObj)
        {
            this.Terrain = terrain;
            this.Actor = actor;
            this.Item = item;
            this.GameObject = gameObj;
        }

        public Tile(ITerrain terrain)
            : this(terrain, null, null, null)
        { }
    }
}
