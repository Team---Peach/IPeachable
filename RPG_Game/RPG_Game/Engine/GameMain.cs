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
#endregion

namespace RPG_Game.Engine
{
    public class GameMain : Game
    {
        private const int
            SCREEN_WIDTH = 1024,
            SCREEN_HEIGHT = 640;

        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        private IPlayer player;
        private IMap map;

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

            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            Texture2D mapFloor = Content.Load<Texture2D>("pebble_brown0");
            Texture2D mapWall = Content.Load<Texture2D>("brick_brown0");
            Texture2D playerTexture = Content.Load<Texture2D>("human_m");

            Point visibleTiles = new Point(
                (SCREEN_HEIGHT - 10) / Map.TILE_SIZE,
                (SCREEN_WIDTH - 10) / Map.TILE_SIZE);

            this.map = new Map(
                Tools.GenerateMap(40, 40, mapFloor, mapWall),
                visibleTiles);

            // Creates a new unit with flag IsPlayerControl, and spawns it at map/point.
            this.player = new Player(playerTexture, this.map, Point.Zero);
            Tools.GenerateEnemy(Content, this.map, 10);
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

            #region Keys Check
            // Horizonta/Vertical movement
            if (CheckKeys(Keys.Down, Keys.NumPad2))
            {
                this.player.Move(CardinalDirection.South);
            }

            if (CheckKeys(Keys.Up, Keys.NumPad8))
            {
                this.player.Move(CardinalDirection.North);
            }

            if (CheckKeys(Keys.Left, Keys.NumPad4))
            {
                this.player.Move(CardinalDirection.West);
            }

            if (CheckKeys(Keys.Right, Keys.NumPad6))
            {
                this.player.Move(CardinalDirection.East);
            }

            //Diagonal movement
            if (CheckKeys(Keys.NumPad7))
            {
                this.player.Move(CardinalDirection.NorthWest);
            }

            if (CheckKeys(Keys.NumPad9))
            {
                this.player.Move(CardinalDirection.NorthEast);
            }

            if (CheckKeys(Keys.NumPad1))
            {
                this.player.Move(CardinalDirection.SouthWest);
            }

            if (CheckKeys(Keys.NumPad3))
            {
                this.player.Move(CardinalDirection.SouthEast);
            }
            #endregion

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
