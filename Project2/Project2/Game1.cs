using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Project2
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        GameState currentstate;
        SpriteFont font;
        Texture2D main, start, exit, howPlay, rMain, spell, port, comb, bas;
        Button startB, exitB, howPlayB, mainMenuB;
        List<Button> spells;
        List<Button> portraits;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            graphics.PreferredBackBufferHeight = Stat.CONSOLEH;
            graphics.PreferredBackBufferWidth = Stat.CONSOLEW;
        }

        public enum GameState
        {
            Menu,
            HowtoPlay,
            Themechange,
            Battle,
            Campfire,
            Gameover
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
            //Creates characters on initalization
            //Needs some sort of file reader beforehand to input stats
            //For now they have defaults
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            //sometexturevalue = Content.Load<Texture2D>(@"images/sometexture");

            // TODO: use this.Content to load your game content here

            //Main Menu Assets
            main = Content.Load<Texture2D>(@"UI\MainMenu");
            start = Content.Load<Texture2D>(@"UI\Start");
            exit = Content.Load<Texture2D>(@"UI\Exit");
            howPlay = Content.Load<Texture2D>(@"UI\HowToPlay");
            rMain = Content.Load<Texture2D>(@"UI\ReturnMainMenu");

            //Game Assets
            spell = Content.Load<Texture2D>(@"UI\SpellBox");
            comb = Content.Load<Texture2D>(@"UI\CombatLog");
            port = Content.Load<Texture2D>(@"UI\Potrait");
            bas = Content.Load<Texture2D>(@"UI\Base");
            font = Content.Load<SpriteFont>(@"UI\Font");

            IsMouseVisible = true;

            Buttons();
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            MouseState mouse = Mouse.GetState();

            // TODO: Add your update logic here

            switch (currentstate)
            {
                case GameState.Menu:
                    MainButtonClick(mouse);
                    break;
                case GameState.HowtoPlay:
                    if (mainMenuB.Click == true) { currentstate = GameState.Menu; }
                    mainMenuB.ClickUpdate(mouse);
                    break;
                case GameState.Battle:
                    /*
                    if (mouse click on attack button)
                    {
                     *  get damage stat of player object
                     *  remove x health from monster object
                     *  (are we doing health bars or just numerical attributes on a styleized heart?)
                     *  (are we doing a scrolling log for the battle window or a turn based "this is what just happened and will go away for next action" thing?)
                     *  spriteBatch.DrawString(font, "You deal " + x + " damage to the enemy", new Vector2(chosen location of the battle log on the screen), Color.Black);
                     *
                    }
                    */
                    break;
            }

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            spriteBatch.Begin();

            switch (currentstate)
            {
                case GameState.Menu:
                    //background
                    Rectangle recM;
                    spriteBatch.Draw(main, recM = new Rectangle(0, 0, 720, 600), Color.White);
                    //Start
                    spriteBatch.Draw(start, startB.Rect, Color.White);
                    //Exit
                    spriteBatch.Draw(exit, exitB.Rect, Color.White);
                    //How to play
                    spriteBatch.Draw(howPlay, howPlayB.Rect, Color.White);
                    break;
                case GameState.HowtoPlay:
                    spriteBatch.Draw(rMain, mainMenuB.Rect, Color.White);

                    break;
                case GameState.Battle:
                    //Draw Base Background
                    Rectangle recB;
                    spriteBatch.Draw(bas, recB = new Rectangle(0, 0, 720, 600), Color.White);
                    //Draw Combat Log
                    Rectangle recCL;
                    spriteBatch.Draw(comb, recCL = new Rectangle(234, 288, 450, 108), Color.White);
                    //Draw spells
                    foreach (Button o in spells)
                    {
                        spriteBatch.Draw(spell, o.Rect, Color.White);
                        o.Draw(spriteBatch);
                    }
                    //Draw portraits
                    foreach (Button p in portraits)
                    {
                        spriteBatch.Draw(port, p.Rect, Color.White);
                        p.Draw(spriteBatch);
                    }
                    //draw health/mana 100 are place holders
                    spriteBatch.DrawString(font, String.Format("Health {0}/{1} ", 100, 100), new Vector2(108, 36), Color.Black);
                    spriteBatch.DrawString(font, String.Format("Mana {0}/{1} ", 100, 100), new Vector2(108, 72), Color.Black);
                    spriteBatch.DrawString(font, String.Format("Health {0}/{1} ", 100, 100), new Vector2(108, 149), Color.Black);
                    spriteBatch.DrawString(font, String.Format("Mana {0}/{1} ", 100, 100), new Vector2(108, 185), Color.Black);
                    spriteBatch.DrawString(font, String.Format("Health {0}/{1} ", 100, 100), new Vector2(108, 298), Color.Black);
                    spriteBatch.DrawString(font, String.Format("Mana {0}/{1} ", 100, 100), new Vector2(108, 334), Color.Black);
                    spriteBatch.DrawString(font, String.Format("Health {0}/{1} ", 100, 100), new Vector2(108, 447), Color.Black);
                    spriteBatch.DrawString(font, String.Format("Mana {0}/{1} ", 100, 100), new Vector2(108, 483), Color.Black);
                    spriteBatch.DrawString(font, String.Format("Health {0}/{1} ", 100, 100), new Vector2(108, 596), Color.Black);
                    spriteBatch.DrawString(font, String.Format("Mana {0}/{1} ", 100, 100), new Vector2(108, 632), Color.Black);
                    break;
            }

            spriteBatch.End();

            base.Draw(gameTime);
        }

        protected void Buttons()
        {
            //Game spells
            spells = new List<Button>();
            int spellNum = 7;
            int spellX = 237;
            int spellY = 453;
            int i = 0;
            while (i < spellNum)
            {
                spells.Add(new Button(spellX, spellY, Stat.SPELLW, Stat.SPELLH, spell));
                spellX = spellX + 65;
                i++;
            }
            //Game portraits
            portraits = new List<Button>();
            int portNum = 5;
            int portX = 30;
            int portY = 31;
            int e = 0;
            while (e < portNum)
            {
                portraits.Add(new Button(portX, portY, Stat.PORTW, Stat.PORTH, port));
                portY = portY + 113;
                e++;
            }

            //Main Menu/How to Play Buttons
            startB = new Button(279, 216, 162, 64, start);
            exitB = new Button(279, 396, 162, 64, exit);
            howPlayB = new Button(279, 306, 162, 64, howPlay);
            mainMenuB = new Button(486, 440, 162, 64, rMain);
        }

        protected void MainButtonClick(MouseState mouse)
        {
            if (startB.Click == true) { currentstate = GameState.Battle; }
            startB.ClickUpdate(mouse);
            if (exitB.Click == true) { Exit(); }
            exitB.ClickUpdate(mouse);
            if (howPlayB.Click == true) { currentstate = GameState.HowtoPlay; }
            howPlayB.ClickUpdate(mouse);
        }
    }
}
