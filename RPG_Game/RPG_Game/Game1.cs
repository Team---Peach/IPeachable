#region Using Statements
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.GamerServices;
#endregion

namespace RPG_Game
{

    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        private Background background;
        private Player player;
        private Enemy enemy;

        public Game1()
            : base()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {

            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            Texture2D backgroundTexture = Content.Load<Texture2D>("Background");
            background = new Background(backgroundTexture);
            Texture2D playerTexture = Content.Load<Texture2D>("Player");
            player = new Player(playerTexture);
            Texture2D enemyTexture = Content.Load<Texture2D>("Enemy");
            enemy = new Enemy(enemyTexture);
        }

        protected override void UnloadContent()
        {

        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            player.Move();
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            background.Draw(spriteBatch);
            player.Draw(spriteBatch);
            enemy.Draw(spriteBatch);

            base.Draw(gameTime);
        }
    }
}
