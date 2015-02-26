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
using RPG_Game.Engine.FieldOfView;
#endregion

namespace RPG_Game.Engine
{
    public class GameMain : Game
    {
        private const int
            SCREEN_WIDTH = 1024,
            SCREEN_HEIGHT = 640,
            MIN_TURN_COST = 100;
        private int blinkCount = 0;

        private bool
            waitPlayerAction = false,
            gameOver = false;

        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        private IPlayer player;
        private IMap map;
        private Texture2D console;
        private InfoPanel infoPanel;
        private KeysPanel keysPanel;
        private StatsPanel statsPanel;
        private FieldOfView<ITile> fieldOfView;
        private static List<GameUnit> unitList;
        private static List<GameUnit> unitsToRemoveList;

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
            unitsToRemoveList = new List<GameUnit>();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            console = new Texture2D(GraphicsDevice, 1, 1);

            infoPanel = new InfoPanel(console);
            keysPanel = new KeysPanel(console);
            statsPanel = new StatsPanel(console);

            Textures.LoadTextures(Content);

            Point visibleTiles = new Point(
                (SCREEN_HEIGHT - 170) / Map.TILE_SIZE,
                (SCREEN_WIDTH - 320) / Map.TILE_SIZE);

            this.map = new Map(
                Tools.GenerateMap(40, 40, Textures.MapFloor, Textures.MapWall),
                visibleTiles);

            this.fieldOfView = new FieldOfView<ITile>(this.map.Tiles);

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

            if (!this.gameOver)
            {
                if (!waitPlayerAction)
                {
                    foreach (GameUnit unit in unitList)
                    {
                        unit.Energy += unit.Speed;
                    }
                }

                foreach (GameUnit unit in unitList)
                {
                    if (unit is Enemy)
                    {
                        (unit as Enemy).StartBattleIfInRange(this.map);
                    }
                    if (unit.Health <= 0)
                    {
                        if (unit is IPlayer)
                        {
                            this.gameOver = true;
                            InfoPanel.AddInfo("Game Over! You are dead");
                        }
                        else
                        {
                            string item = (unit as Enemy).ItemToDrop();
                            Tools.PlaceObjectOnMap(item, this.map, unit.Position);
                            this.map.Tiles[unit.Position.X, unit.Position.Y].Actor = null;
                            unitsToRemoveList.Add(unit);
                            InfoPanel.AddInfo(unit.Name + " is dead!");
                        }
                    }
                }

                foreach (var unitForRemove in unitsToRemoveList)
                {
                    unitList.Remove(unitForRemove);
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
                                this.player.UpdateMana();
                                this.player.DeactivateShield();
                                waitPlayerAction = false;
                            }

                            if (CheckKeys(Keys.Up, Keys.NumPad8))
                            {
                                this.player.Move(CardinalDirection.North);
                                this.player.Energy -= 100;
                                this.player.UpdateMana();
                                this.player.DeactivateShield();
                                waitPlayerAction = false;
                            }

                            if (CheckKeys(Keys.Left, Keys.NumPad4))
                            {
                                this.player.Move(CardinalDirection.West);
                                this.player.Energy -= 100;
                                this.player.UpdateMana();
                                this.player.DeactivateShield();
                                waitPlayerAction = false;
                            }

                            if (CheckKeys(Keys.Right, Keys.NumPad6))
                            {
                                this.player.Move(CardinalDirection.East);
                                this.player.Energy -= 100;
                                this.player.UpdateMana();
                                this.player.DeactivateShield();
                                waitPlayerAction = false;
                            }

                            //Diagonal movement
                            if (CheckKeys(Keys.NumPad7))
                            {
                                this.player.Move(CardinalDirection.NorthWest);
                                this.player.Energy -= 100;
                                this.player.UpdateMana();
                                this.player.DeactivateShield();
                                waitPlayerAction = false;
                            }

                            if (CheckKeys(Keys.NumPad9))
                            {
                                this.player.Move(CardinalDirection.NorthEast);
                                this.player.Energy -= 100;
                                this.player.UpdateMana();
                                this.player.DeactivateShield();
                                waitPlayerAction = false;
                            }

                            if (CheckKeys(Keys.NumPad1))
                            {
                                this.player.Move(CardinalDirection.SouthWest);
                                this.player.Energy -= 100;
                                this.player.UpdateMana();
                                this.player.DeactivateShield();
                                waitPlayerAction = false;
                            }

                            if (CheckKeys(Keys.NumPad3))
                            {
                                this.player.Move(CardinalDirection.SouthEast);
                                this.player.Energy -= 100;
                                this.player.UpdateMana();
                                this.player.DeactivateShield();
                                waitPlayerAction = false;
                            }

                            // Space -> Use/Equip
                            if (CheckKeys(Keys.Space))
                            {
                                if (this.map.Tiles[this.player.Position.X, this.player.Position.Y].Item is Drink)
                                {
                                    this.player.UseItem(this.map.Tiles[this.player.Position.X, this.player.Position.Y].Item as IDrinkable);
                                    this.map.Tiles[this.player.Position.X, this.player.Position.Y].Item = null;
                                }
                                if (this.map.Tiles[this.player.Position.X, this.player.Position.Y].Item is Equip)
                                {
                                    IEquipable itemToEquip =
                                        this.map.Tiles[this.player.Position.X, this.player.Position.Y].Item as IEquipable;
                                    IEquipable itemToDrop = (this.player as IPlayer).EquipedItems[itemToEquip.Slot];
                                    this.player.EquipItem(itemToEquip);
                                    this.map.Tiles[this.player.Position.X, this.player.Position.Y].Item = itemToDrop;
                                }
                            }
                            if (CheckKeys(Keys.H))
                            {
                                (this.player as Player).Heal();
                            }

                            if (CheckKeys(Keys.D))
                            {
                                (this.player as Player).Shield();
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
            }

            // Set the old keyboard state
            this.oldKBState = this.newKBState;

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            fieldOfView.ComputeFov(player.Position.X, player.Position.Y, 5, true, FOVMethod.MRPAS, RangeLimitShape.Circle);

            this.map.Draw(spriteBatch, player.Position);

            this.infoPanel.Draw(spriteBatch);
            this.keysPanel.Draw(spriteBatch);
            this.statsPanel.Draw(spriteBatch, this.player);

            if (this.gameOver)
            {
                this.spriteBatch.Begin();
                this.spriteBatch.Draw(GameData.Textures.GameOver, new Vector2(60, 20));
                this.spriteBatch.End();
            }

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
