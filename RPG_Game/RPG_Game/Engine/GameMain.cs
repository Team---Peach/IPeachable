#region Using Statements
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Storage;
using RPG_Game.Interfaces;
using RPG_Game.Models;
using RPG_Game.Enums;
using RPG_Game.GameData;
#endregion

namespace RPG_Game.Engine
{
    public class GameMain : Game
    {
        private const int
            SCREEN_WIDTH = 1024,
            SCREEN_HEIGHT = 640,
            MIN_TURN_COST = 100;

        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        private IPlayer player;
        private IMap map;
        private static List<GameUnit> unitList;
        private bool waitPlayerAction = false;

        // The previous (old) and the current (new)
        // keyboard states to check for key presses
        private KeyboardState
            oldKBState,
            newKBState;

        public GameMain()
            : base()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            // Window size
            graphics.PreferredBackBufferWidth = SCREEN_WIDTH;
            graphics.PreferredBackBufferHeight = SCREEN_HEIGHT;
            graphics.ApplyChanges();

            this.oldKBState = new KeyboardState();
            unitList = new List<GameUnit>();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            Textures.LoadTextures(Content);

            Point visibleTiles = new Point(
                (SCREEN_HEIGHT - 10) / Map.TILE_SIZE,
                (SCREEN_WIDTH - 10) / Map.TILE_SIZE);

            this.map = new Map(
                Tools.GenerateMap(40, 40, Textures.MapFloor, Textures.MapWall),
                visibleTiles);

            // Creates a new unit with flag IsPlayerControl, and spawns it at map/point.
            this.player = new Player(Textures.Player, this.map, Point.Zero);
            unitList.Add(player as GameUnit);

            Tools.GenerateEnemy(this.map);
            Tools.GenerateItems(this.map);
        }

        protected override void UnloadContent()
        { }

        protected override void Update(GameTime gameTime)
        {
            // Get the current keyboard state.
            this.newKBState = Keyboard.GetState();

            if (CheckKeys(Keys.Escape))
            {
                Exit();
            }

            if (!waitPlayerAction)
            {
                foreach (GameUnit unit in unitList)
                {
                    unit.Energy += unit.Speed;
                }
            }

            // Sort units in list by their energy.
            unitList.Sort((x, y) => x.Energy.CompareTo(y.Energy));

            foreach (GameUnit unit in unitList)
            {
                //unit.Energy += unit.Speed;

                if (unit.Energy >= MIN_TURN_COST)
                {
                    if (unit is IPlayer)
                    {
                        waitPlayerAction = true;

                        #region Keys Check
                        // Horizonta/Vertical movement
                        if (CheckKeys(Keys.Down, Keys.NumPad2))
                        {
                            this.player.Move(CardinalDirection.South);
                            this.player.Energy -= 100;
                            waitPlayerAction = false;
                        }

                        if (CheckKeys(Keys.Up, Keys.NumPad8))
                        {
                            this.player.Move(CardinalDirection.North);
                            this.player.Energy -= 100;
                            waitPlayerAction = false;
                        }

                        if (CheckKeys(Keys.Left, Keys.NumPad4))
                        {
                            this.player.Move(CardinalDirection.West);
                            this.player.Energy -= 100;
                            waitPlayerAction = false;
                        }

                        if (CheckKeys(Keys.Right, Keys.NumPad6))
                        {
                            this.player.Move(CardinalDirection.East);
                            this.player.Energy -= 100;
                            waitPlayerAction = false;
                        }

                        //Diagonal movement
                        if (CheckKeys(Keys.NumPad7))
                        {
                            this.player.Move(CardinalDirection.NorthWest);
                            this.player.Energy -= 100;
                            waitPlayerAction = false;
                        }

                        if (CheckKeys(Keys.NumPad9))
                        {
                            this.player.Move(CardinalDirection.NorthEast);
                            this.player.Energy -= 100;
                            waitPlayerAction = false;
                        }

                        if (CheckKeys(Keys.NumPad1))
                        {
                            this.player.Move(CardinalDirection.SouthWest);
                            this.player.Energy -= 100;
                            waitPlayerAction = false;
                        }

                        if (CheckKeys(Keys.NumPad3))
                        {
                            this.player.Move(CardinalDirection.SouthEast);
                            this.player.Energy -= 100;
                            waitPlayerAction = false;
                        }
                        #endregion
                    }
                    else
                    {
                        //AI
                        if (!waitPlayerAction)
                        {
                            unit.Move(Tools.RandomDirection());
                            unit.Energy -= 100;
                        }
                    }
                }
            }
            
            // Set the old keyboard state
            this.oldKBState = this.newKBState;

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            this.map.Draw(spriteBatch, player.Position);

            base.Draw(gameTime);
        }

        public static void AddUnitToList(GameUnit unit)
        {
            unitList.Add(unit);
        }

        private bool CheckKeys(params Keys[] keysDown)
        {
            bool result = false;

            foreach (var key in keysDown)
            {
                if (this.oldKBState.IsKeyUp(key) &&
                    this.newKBState.IsKeyDown(key))
                    result = true;
            }

            return result;
        }
    }
}
