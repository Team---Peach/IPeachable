namespace RPG_Game.Models
{
    using Interfaces;

    public class Tile : ITile
    {
        public IGameObject Actor { get; set; }
        public ITerrain Terrain { get; set; }
        public IItem Item { get; set; }
        public IObject GameObject { get; set; }

        public Tile(ITerrain terrain, IGameObject actor, IItem item, IObject gameObj)
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
