#region Using Statements
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Storage;
#endregion

namespace RPG_Game
{
    public class GameMain : Game
    {
        private const int
            SCREEN_WIDTH = 1024,
            SCREEN_HEIGHT = 640;

        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        //private Background background;
        private IActor player;
        //private Enemy enemy;
        private IMap map;

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

            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            /* *
            Texture2D backgroundTexture = Content.Load<Texture2D>("Background");
            background = new Background(backgroundTexture);
            Texture2D playerTexture = Content.Load<Texture2D>("Player");
            player = new Player(playerTexture);
            Texture2D enemyTexture = Content.Load<Texture2D>("Enemy");
            enemy = new Enemy(enemyTexture);
            * */

            Texture2D mapFloor = Content.Load<Texture2D>("pebble_brown0");
            Texture2D playerTexture = Content.Load<Texture2D>("human_m");

            Point visibleTiles = new Point(
                SCREEN_HEIGHT / Map.TILE_SIZE,
                SCREEN_WIDTH / Map.TILE_SIZE);

            this.map = new Map(
                GenerateMap(40, 40, mapFloor),
                visibleTiles);

            this.player = new Unit(playerTexture, this.map, Point.Zero, Flags.IsPlayerControl);
            this.player.Spawn();
        }

        protected override void UnloadContent()
        { }

        protected override void Update(GameTime gameTime)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            /* *
            player.Move();
            * */

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            this.map.Draw(spriteBatch, player.Position);

            /* *
            background.Draw(spriteBatch);
            player.Draw(spriteBatch);
            enemy.Draw(spriteBatch);
            * */

            base.Draw(gameTime);
        }

        public ITile[,] GenerateMap(int height, int width, Texture2D texture)
        {
            Tile[,] resultTiles = new Tile[height, width];

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Terrain sampleTerrain = new Terrain(texture, Flags.None);
                    resultTiles[i, j] = new Tile(sampleTerrain);
                }
            }

            return resultTiles;
        }
    }
}
