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
        //UI Sprites
        Texture2D main, start, exit, howPlay, rMain, spell, port, comb, bas, invisB;
        //Player Sprites
        Texture2D Healer, Mage, Tank, Dps;
        //Enemy Sprites
        Texture2D PurpleEvilDragon, RobotSnowFrog;
        //Background Sprites
        Texture2D DiamondWorld;

        Button startB, exitB, howPlayB, mainMenuB;
        List<Button> spells;
        List<Button> portraits;
        List<Button> charSelect;

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
            Actor Healer = new Actor("testHealer");
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
            invisB = Content.Load<Texture2D>(@"UI\InvisB");

            //Players Sprites
            Healer = Content.Load<Texture2D>(@"ActorSprites\Healer");
            Mage = Content.Load<Texture2D>(@"ActorSprites\Mage");
            Tank = Content.Load<Texture2D>(@"ActorSprites\Tank");
            Dps = Content.Load<Texture2D>(@"ActorSprites\Warrior"); //slight filename change
            //Enemies Sprites
            PurpleEvilDragon = Content.Load<Texture2D>(@"ActorSprites\PurpleEvilDragon");
            RobotSnowFrog = Content.Load<Texture2D>(@"ActorSprites\RobotSnowFrog");

            //Background
            DiamondWorld = Content.Load<Texture2D>(@"BackgroundSprites\DiamondWORLD"); //slight filename change

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
                    SpellButtonClick(mouse);  //Note logic mentioned below can be put into the SpellButtonClick Method further down this class
                    CharacterClick(mouse);
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
                    spriteBatch.Draw(comb, recB = new Rectangle(0, 0, 720, 600), Color.White);
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
                    //Draw invisible buttons
                    foreach (Button c in charSelect)
                    {
                        spriteBatch.Draw(invisB, c.Rect, Color.White);
                        c.Draw(spriteBatch);
                    }
                    //draw health/mana 100 are place holders
                    spriteBatch.DrawString(font, String.Format("HP {0}/{1} ", 100, 100), new Vector2(100, 36), Color.Black);
                    spriteBatch.DrawString(font, String.Format("MP {0}/{1} ", 100, 100), new Vector2(100, 64), Color.Black);
                    spriteBatch.DrawString(font, String.Format("HP {0}/{1} ", 100, 100), new Vector2(100, 144), Color.Black);
                    spriteBatch.DrawString(font, String.Format("MP {0}/{1} ", 100, 100), new Vector2(100, 172), Color.Black);
                    spriteBatch.DrawString(font, String.Format("HP {0}/{1} ", 100, 100), new Vector2(100, 258), Color.Black);
                    spriteBatch.DrawString(font, String.Format("MP {0}/{1} ", 100, 100), new Vector2(100, 286), Color.Black);
                    spriteBatch.DrawString(font, String.Format("HP {0}/{1} ", 100, 100), new Vector2(100, 372), Color.Black);
                    spriteBatch.DrawString(font, String.Format("MP {0}/{1} ", 100, 100), new Vector2(100, 400), Color.Black);
                    spriteBatch.DrawString(font, String.Format("HP {0}/{1} ", 100, 100), new Vector2(100, 485), Color.Black);
                    spriteBatch.DrawString(font, String.Format("MP {0}/{1} ", 100, 100), new Vector2(100, 510), Color.Black);
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
            //Invisible Character select buttons(for casting spells)
            charSelect = new List<Button>();
            int charNum = 5;
            int charX = 19;
            int charY = 20;
            int k = 0;
            while (k < charNum)
            {
                charSelect.Add(new Button(charX, charY, Stat.CHARW, Stat.CHARH, invisB));
                charY = charY + 111;
                k++;
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

        protected void SpellButtonClick(MouseState mouse)
        {
            //Check if each button and mouse intersect
            foreach(Button b in spells)
            {
                b.ClickUpdate(mouse);
            }
            //Insert spell action/logic in brackets
            if (spells[0].Click == true) { }
            if (spells[1].Click == true) { }
            if (spells[2].Click == true) { }
            if (spells[3].Click == true) { }
            if (spells[4].Click == true) { }
            if (spells[5].Click == true) { }
            if (spells[6].Click == true) { }

        }

        protected void CharacterClick(MouseState mouse)
        {
            //Check if each button and mouse intersect
            foreach (Button b in charSelect)
            {
                b.ClickUpdate(mouse);
            }
            //insert logic for when character is selected
            if (charSelect[0].Click == true) { }
            if (charSelect[1].Click == true) { }
            if (charSelect[2].Click == true) { }
            if (charSelect[3].Click == true) { }
            if (charSelect[4].Click == true) { }
        }
    }
}
