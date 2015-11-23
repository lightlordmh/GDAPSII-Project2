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
        Texture2D main, start, exit, howPlay, rMain, spell, port, comb, bas, invisB, campfiretest;
        //Potion Sprites
        Texture2D RedBottle, GreenBottle, BlueBottle, OrangeBottle, YellowBottle, PurpleBottle, MilkBottle, BlackPetalBottle;
        //Player Sprites
        Texture2D Healer, Mage, Tank, Dps;
        //Enemy Sprites
        Texture2D PurpleEvilDragon, RobotSnowFrog;
        //Background Sprites
        Texture2D DiamondWorld, CampfireBackground;

        //Potions
        Potions RedPotion, GreenPotion, BluePotion, OrangePotion, YellowPotion, PurplePotion, MilkPotion, BlackPetalPotion;
        //Actors
        Actor HealerObj, TankObj, MageObj, DpsObj, Dragon, Frog, DragonObj, FrogObj, GenericEnemy;

        int turn;
        public int monstersKilled;
        float currentTime;

        Button startB, exitB, howPlayB, mainMenuB, campfiretestb;
        List<Button> spells;
        List<Button> portraits;
        List<Button> charSelect;

        Move testHeal;
        Move testBash;
        Move testCast;
        Move testSlash;
        Move testFireBreath;
        Move testClaw;
        Move testCannon;
        Move testHop;

        List<Actor> monsterList;
        List<Move> enemyAttackList;

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
            turn = 0;
            monstersKilled = 0;
            currentTime = 0;

            RedPotion = new Potions(0);
            GreenPotion = new Potions(1);
            BluePotion = new Potions(2);
            OrangePotion = new Potions(3);
            YellowPotion = new Potions(4);
            PurplePotion = new Potions(5);
            MilkPotion = new Potions(6);
            BlackPetalPotion = new Potions(7);


            HealerObj = new Actor("Healer");
            TankObj = new Actor("Tank");
            MageObj = new Actor("Mage");
            DpsObj = new Actor("Warrior");

            HealerObj.ActorFile("Healer");
            TankObj.ActorFile("Tank");
            MageObj.ActorFile("Mage");
            DpsObj.ActorFile("Warrior");

            GenericEnemy = new Actor("Generic");
            DragonObj = new Actor("PurpleEvilDragon");
            FrogObj = new Actor("RobotSnowFrog");

            DragonObj.ActorFile("PurpleEvilDragon");
            FrogObj.ActorFile("RobotSnowFrog");

            testHeal = new Move("testHeal");
            testBash = new Move("testBash");
            testCast = new Move("testCast");
            testSlash = new Move("testSlash");

            testFireBreath = new Move("testFireBreath");
            testClaw = new Move("testClaw");
            testCannon = new Move("testCannon");
            testHop = new Move("testHop");

            testHeal.MoveRead("testHeal");
            testBash.MoveRead("testBash");
            testCast.MoveRead("testCast");
            testSlash.MoveRead("testSlash");

            testFireBreath.MoveRead("testFireBreath");
            testClaw.MoveRead("testClaw");
            testCannon.MoveRead("testCannon");
            testHop.MoveRead("testHop");

            monsterList = new List<Actor>();
            monsterList.Add(DragonObj);
            monsterList.Add(FrogObj);

            enemyAttackList = new List<Move>();
            enemyAttackList.Add(testFireBreath);
            enemyAttackList.Add(testClaw);
            enemyAttackList.Add(testCannon);
            enemyAttackList.Add(testHop);

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
            //campfiretest = Content.Load<Texture2D>(@"UI\Campfiretestbutton");

            //Game Assets
            spell = Content.Load<Texture2D>(@"UI\SpellBox");
            comb = Content.Load<Texture2D>(@"UI\CombatLog");
            port = Content.Load<Texture2D>(@"UI\Potrait");
            bas = Content.Load<Texture2D>(@"UI\Base");
            font = Content.Load<SpriteFont>(@"UI\Font");
            invisB = Content.Load<Texture2D>(@"UI\InvisB");

            //Potion Sprites
            RedBottle = Content.Load<Texture2D>(@"IconSprites\RedBottle");
            GreenBottle = Content.Load<Texture2D>(@"IconSprites\RedBottle");
            BlueBottle = Content.Load<Texture2D>(@"IconSprites\RedBottle");
            OrangeBottle = Content.Load<Texture2D>(@"IconSprites\RedBottle");
            PurpleBottle = Content.Load<Texture2D>(@"IconSprites\RedBottle");
            YellowBottle = Content.Load<Texture2D>(@"IconSprites\RedBottle");
            MilkBottle = Content.Load<Texture2D>(@"IconSprites\RedBottle");
            BlackPetalBottle = Content.Load<Texture2D>(@"IconSprites\BlackPetalBottle");


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
            CampfireBackground = Content.Load<Texture2D>(@"BackgroundSprites\Campfirebackground");
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
                    MainButtonClick(mouse);
                    break;
                case GameState.Battle:
                    SpellButtonClick(mouse);  //Note logic mentioned below can be put into the SpellButtonClick Method further down this class
                    CharacterClick(mouse);

                    Random rand = new Random();
                    if (HealerObj.curHealth < 0)
                    {
                        Initialize();
                        currentstate = GameState.Menu;
                    }
                    if (turn == 0)
                    {
                        if (rand.Next(0, 2) == 1)
                        {
                            GenericEnemy = FrogObj;
                            turn = 1;
                        }
                        else
                        {
                            GenericEnemy = DragonObj;
                            turn = 1;
                        }
                    }

                    //Turn 1 is intermission

                    if (turn == 2)
                    {
                        spells[0].Click = false;
                        if (HealerObj.curHealth > HealerObj.Health)
                        {
                            HealerObj.curHealth = HealerObj.Health;
                        }
                        if (TankObj.curHealth > TankObj.Health)
                        {
                            TankObj.curHealth = TankObj.Health;
                        }
                        if (MageObj.curHealth > MageObj.Health)
                        {
                            MageObj.curHealth = MageObj.Health;
                        }
                        if (DpsObj.curHealth > DpsObj.Health)
                        {
                            DpsObj.curHealth = DpsObj.Health;
                        }
                        if (TankObj.curHealth > 0)
                        {
                            PlayerMove(TankObj, testBash, GenericEnemy);
                        }
                        if (MageObj.curHealth > 0)
                        {
                            PlayerMove(MageObj, testCast, GenericEnemy);
                        }
                        if (DpsObj.curHealth > 0)
                        {
                            PlayerMove(DpsObj, testSlash, GenericEnemy);
                        }

                        if (GenericEnemy.curHealth >= 0)
                        {
                            if (GenericEnemy == FrogObj)
                            {
                                if (rand.Next(0, 2) == 0)
                                {
                                    EnemyMove(GenericEnemy, testCannon);
                                }
                                else
                                {
                                    EnemyMove(GenericEnemy, testHop);
                                }
                            }
                            else if (GenericEnemy == DragonObj)
                            {
                                if (rand.Next(0, 2) == 0)
                                {
                                    EnemyMove(GenericEnemy, testFireBreath);
                                }
                                else
                                {
                                    EnemyMove(GenericEnemy, testClaw);
                                }
                            }
                        }
                        turn = 3;
                    }
                    if (turn == 3)
                    {
                        currentTime += (float)gameTime.ElapsedGameTime.TotalSeconds;
                        if (currentTime > 1)
                        {
                            HealerObj.curStamina += 10;
                            TankObj.curStamina += 10;
                            MageObj.curStamina += 10;
                            DpsObj.curStamina += 10;
                            currentTime = 0;
                            turn = 1;
                            if (GenericEnemy.curHealth <= 0)
                            {
                                GenericEnemy.curHealth = GenericEnemy.Health;
                                monstersKilled++;
                                turn = 0;
                            }
                        }
                    }

                    break;


                case GameState.Campfire:
                    //    //Checks to see if player leveled up
                    //    if(HealerObj.curExperience >= HealerObj.Experience)
                    //    {
                    //        HealerObj.Level++;
                    //        HealerObj.curExperience -= HealerObj.Experience;
                    //        HealerObj.Experience = HealerObj.Experience + HealerObj.Experience/10;
                    //    }
                    //    if (TankObj.curExperience >= TankObj.Experience)
                    //    {
                    //        TankObj.Level++;
                    //        TankObj.curExperience -= TankObj.Experience;
                    //        TankObj.Experience = TankObj.Experience + TankObj.Experience / 10;
                    //    }
                    //    if (MageObj.curExperience >= MageObj.Experience)
                    //    {
                    //        MageObj.Level++;
                    //        MageObj.curExperience -= MageObj.Experience;
                    //        MageObj.Experience = MageObj.Experience + MageObj.Experience / 10;
                    //    }
                    //    if (DpsObj.curExperience >= DpsObj.Experience)
                    //    {
                    //        DpsObj.Level++;
                    //        DpsObj.curExperience -= DpsObj.Experience;
                    //        DpsObj.Experience = DpsObj.Experience + DpsObj.Experience / 10;
                    //    }



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
            GraphicsDevice.Clear(Color.White);

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

                    //spriteBatch.Draw(campfiretest, campfiretestb.Rect, Color.White);



                    break;
                case GameState.HowtoPlay:
                    spriteBatch.Draw(rMain, mainMenuB.Rect, Color.White);

                    break;
                case GameState.Battle:
                    //Draw Base Background
                    Rectangle recB;
                    spriteBatch.Draw(bas, recB = new Rectangle(0, 0, 720, 600), Color.White);
                    Rectangle recCB;
                    spriteBatch.Draw(DiamondWorld, recCB = new Rectangle(234, 19, 454, 334), Color.White);

                    //Draw Combat Log
                    Rectangle recCL;
                    spriteBatch.Draw(comb, recCL = new Rectangle(234, 288, 450, 108), Color.White);
                    //Draw spells
                    foreach (Button o in spells)
                    {
                        spriteBatch.Draw(spell, o.Rect, Color.White);
                        o.Draw(spriteBatch);
                    }
                    //Draw Actors
                    if (HealerObj.curHealth > 0) { spriteBatch.Draw(Healer, new Rectangle(230, 190, 80, 80), Color.White); }
                    if (TankObj.curHealth > 0) { spriteBatch.Draw(Tank, new Rectangle(370, 190, 80, 80), Color.White); }
                    if (MageObj.curHealth > 0) { spriteBatch.Draw(Mage, new Rectangle(300, 190, 80, 80), Color.White); }
                    if (DpsObj.curHealth > 0) { spriteBatch.Draw(Dps, new Rectangle(440, 190, 80, 80), Color.White); }
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
                    //draw monsters
                    if (GenericEnemy == FrogObj)
                    {
                        spriteBatch.Draw(RobotSnowFrog, new Rectangle(550, 150, 120, 100), Color.White);

                    }
                    else
                    {
                        spriteBatch.Draw(PurpleEvilDragon, new Rectangle(550, 150, 120, 100), Color.White);
                    }
                    //draw health/mana 100 are place holders
                    //tank
                    spriteBatch.DrawString(font, String.Format("HP {0}/{1} ", TankObj.Health, TankObj.curHealth), new Vector2(100, 36), Color.Black);
                    spriteBatch.DrawString(font, String.Format("MP {0}/{1} ", TankObj.Stamina, TankObj.curStamina), new Vector2(100, 64), Color.Black);
                    //mage
                    spriteBatch.DrawString(font, String.Format("HP {0}/{1} ", MageObj.Health, MageObj.curHealth), new Vector2(100, 144), Color.Black);
                    spriteBatch.DrawString(font, String.Format("MP {0}/{1} ", MageObj.Stamina, MageObj.curStamina), new Vector2(100, 172), Color.Black);
                    //warrior
                    spriteBatch.DrawString(font, String.Format("HP {0}/{1} ", DpsObj.Health, DpsObj.curHealth), new Vector2(100, 258), Color.Black);
                    spriteBatch.DrawString(font, String.Format("MP {0}/{1} ", DpsObj.Stamina, DpsObj.curStamina), new Vector2(100, 286), Color.Black);
                    //healer
                    spriteBatch.DrawString(font, String.Format("HP {0}/{1} ", HealerObj.Health, HealerObj.curHealth), new Vector2(100, 372), Color.Black);
                    spriteBatch.DrawString(font, String.Format("MP {0}/{1} ", HealerObj.Stamina, HealerObj.curStamina), new Vector2(100, 400), Color.Black);
                    //empty?
                    spriteBatch.DrawString(font, String.Format("HP {0}/{1} ", GenericEnemy.curHealth, GenericEnemy.Health), new Vector2(100, 485), Color.DarkRed);

                    //Button Text

                    spriteBatch.DrawString(font, String.Format("AOE~H"), new Vector2(237, 460), Color.Blue);
                    spriteBatch.DrawString(font, String.Format("+100"), new Vector2(230, 475), Color.Green);
                    spriteBatch.DrawString(font, String.Format("-50"), new Vector2(270, 475), Color.Orange);
                    if (HealerObj.curStamina < 50)
                    {
                        spriteBatch.DrawString(font, String.Format("X" + (HealerObj.curStamina - 50).ToString() + "mpX"), new Vector2(230, 510), Color.DarkRed);
                    }
                    spriteBatch.DrawString(font, String.Format("Items"), new Vector2(310, 460), Color.Blue);
                    spriteBatch.DrawString(font, String.Format("Equips"), new Vector2(370, 460), Color.Blue);
                    spriteBatch.DrawString(font, String.Format("N/a"), new Vector2(450, 460), Color.Blue);
                    spriteBatch.DrawString(font, String.Format("N/a"), new Vector2(515, 460), Color.Blue);
                    spriteBatch.DrawString(font, String.Format("N/a"), new Vector2(580, 460), Color.Blue);
                    spriteBatch.DrawString(font, String.Format("N/a"), new Vector2(645, 460), Color.Blue);
                    //MonsterKillCount
                    spriteBatch.DrawString(font, String.Format("Monsters Killed: " + monstersKilled), new Vector2(30, 0), Color.Red);

                    break;


                case GameState.Campfire:
                    //Draw Base Background
                    Rectangle recBackground;
                    spriteBatch.Draw(bas, recBackground = new Rectangle(0, 0, 720, 600), Color.White);
                    Rectangle recCampfire;
                    spriteBatch.Draw(CampfireBackground, recCampfire = new Rectangle(234, 19, 454, 334), Color.White);

                    //Draw Combat Log
                    //Rectangle recCL2;
                    //spriteBatch.Draw(comb, recCL2 = new Rectangle(234, 288, 450, 108), Color.White);
                    //Draw spells
                    foreach (Button o in spells)
                    {
                        spriteBatch.Draw(spell, o.Rect, Color.White);
                        o.Draw(spriteBatch);
                    }
                    //Draw Actors
                    if (HealerObj.curHealth > 0) { spriteBatch.Draw(Healer, new Rectangle(350, 190, 80, 80), Color.White); }
                    if (TankObj.curHealth > 0) { spriteBatch.Draw(Tank, new Rectangle(490, 190, 80, 80), Color.White); }
                    if (MageObj.curHealth > 0) { spriteBatch.Draw(Mage, new Rectangle(420, 140, 80, 80), Color.White); }
                    if (DpsObj.curHealth > 0) { spriteBatch.Draw(Dps, new Rectangle(420, 230, 80, 80), Color.White); }
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
                    //tank
                    spriteBatch.DrawString(font, String.Format("HP {0}/{1} ", TankObj.Health, TankObj.curHealth), new Vector2(100, 36), Color.Black);
                    spriteBatch.DrawString(font, String.Format("MP {0}/{1} ", TankObj.Stamina, TankObj.curStamina), new Vector2(100, 64), Color.Black);
                    //mage
                    spriteBatch.DrawString(font, String.Format("HP {0}/{1} ", MageObj.Health, MageObj.curHealth), new Vector2(100, 144), Color.Black);
                    spriteBatch.DrawString(font, String.Format("MP {0}/{1} ", MageObj.Stamina, MageObj.curStamina), new Vector2(100, 172), Color.Black);
                    //warrior
                    spriteBatch.DrawString(font, String.Format("HP {0}/{1} ", DpsObj.Health, DpsObj.curHealth), new Vector2(100, 258), Color.Black);
                    spriteBatch.DrawString(font, String.Format("MP {0}/{1} ", DpsObj.Stamina, DpsObj.curStamina), new Vector2(100, 286), Color.Black);
                    //healer
                    spriteBatch.DrawString(font, String.Format("HP {0}/{1} ", HealerObj.Health, HealerObj.curHealth), new Vector2(100, 372), Color.Black);
                    spriteBatch.DrawString(font, String.Format("MP {0}/{1} ", HealerObj.Stamina, HealerObj.curStamina), new Vector2(100, 400), Color.Black);
                    //empty?
                    //spriteBatch.DrawString(font, String.Format("HP {0}/{1} ", 100, 100), new Vector2(100, 485), Color.Black);
                    //spriteBatch.DrawString(font, String.Format("MP {0}/{1} ", 100, 100), new Vector2(100, 510), Color.Black);

                    spriteBatch.DrawString(font, String.Format(" Buy \nStuff"), new Vector2(245, 460), Color.Black);
                    spriteBatch.DrawString(font, String.Format(" Buy \nMore \nStuff"), new Vector2(310, 453), Color.Black);



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
            campfiretestb = new Button(279, 500, 162, 64, campfiretest);

        }

        protected void MainButtonClick(MouseState mouse)
        {
            if (startB.Click == true) { currentstate = GameState.Battle; startB.Click = false; }
            startB.ClickUpdate(mouse);
            if (exitB.Click == true) { Exit(); }
            exitB.ClickUpdate(mouse);
            if (howPlayB.Click == true) { currentstate = GameState.HowtoPlay; howPlayB.Click = false; }
            howPlayB.ClickUpdate(mouse);
            if (mainMenuB.Click == true) { currentstate = GameState.Menu; mainMenuB.Click = false; }
            mainMenuB.ClickUpdate(mouse);
            if (campfiretestb.Click == true) { currentstate = GameState.Campfire; campfiretestb.Click = false; }
            campfiretestb.ClickUpdate(mouse);
        }

        protected void SpellButtonClick(MouseState mouse)
        {
            //Check if each button and mouse intersect
            foreach (Button b in spells)
            {
                b.ClickUpdate(mouse);
            }
            //Insert spell action/logic in brackets
            if (spells[0].Click == true && turn == 1 && HealerObj.curStamina >= 50) { PlayerMove(HealerObj, testHeal, GenericEnemy); turn = 2; }
            if (spells[1].Click == true && turn == 1) { turn = 2; spells[1].Click = false; }
            if (spells[2].Click == true && turn == 1) { turn = 2; spells[2].Click = false; }
            if (spells[3].Click == true && turn == 1) { turn = 2; spells[3].Click = false; }
            if (spells[4].Click == true && turn == 1) { turn = 2; spells[4].Click = false; }
            if (spells[5].Click == true && turn == 1) { turn = 2; spells[5].Click = false; }
            if (spells[6].Click == true && turn == 1) { turn = 2; spells[6].Click = false; }

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

        private void PlayerMove(Actor User, Move moveName, Actor Enemy)
        {
            if (User.curStamina >= moveName.StaminaCost)
            {
                User.curStamina -= moveName.StaminaCost;
                int damageDealt;
                Random rand = new Random();
                if (moveName.Type == "Physical")
                {
                    damageDealt = (User.Attack * moveName.Attack) / 100;
                    if (rand.Next(0, 100) + Enemy.Dodge >= moveName.Accuracy)
                    {
                        damageDealt = 0;
                    }
                    Enemy.curHealth -= damageDealt;
                }
                else if (moveName.Type == "Magical")
                {
                    damageDealt = User.Magic * moveName.Attack / 100;
                    if (rand.Next(0, 100) + Enemy.Dodge >= moveName.Accuracy)
                    {
                        damageDealt = 0;
                    }
                    Enemy.curHealth -= damageDealt;
                }
                else
                {
                    damageDealt = moveName.Attack;
                    if (rand.Next(0, 100) < moveName.Accuracy)
                    {
                        damageDealt = 0;
                    }
                    HealerObj.curHealth -= damageDealt;
                    if (TankObj.curHealth > 0)
                    {
                        TankObj.curHealth -= damageDealt;
                    }
                    if (MageObj.curHealth > 0)
                    {
                        MageObj.curHealth -= damageDealt;
                    }
                    if (DpsObj.curHealth > 0)
                    {
                        DpsObj.curHealth -= damageDealt;
                    }
                }
            }
            if (User.curStamina > User.Stamina)
            {
                User.curStamina = User.Stamina;
            }
        }

        private void EnemyMove(Actor User, Move moveName)
        {
            int damageDealt;
            Random rand = new Random();
            damageDealt = (User.Attack * moveName.Attack) / 100;
            if (User.curStamina >= moveName.StaminaCost)
            {
                if (moveName.Aoe)
                {
                    //Check if it hits
                    if ((rand.Next(0, 100) - HealerObj.Dodge < moveName.Accuracy))
                    {
                        HealerObj.curHealth -= damageDealt;
                    }
                    if ((rand.Next(0, 100) - TankObj.Dodge < moveName.Accuracy))
                    {
                        TankObj.curHealth -= damageDealt;
                    }
                    if ((rand.Next(0, 100) - MageObj.Dodge < moveName.Accuracy))
                    {
                        MageObj.curHealth -= damageDealt;
                    }
                    if ((rand.Next(0, 100) - DpsObj.Dodge < moveName.Accuracy))
                    {
                        DpsObj.curHealth -= damageDealt;
                    }
                }
                else
                {
                    switch (rand.Next(0, 4))
                    {
                        case 0:
                            if ((rand.Next(0, 100) - HealerObj.Dodge < moveName.Accuracy))
                            {
                                HealerObj.curHealth -= damageDealt;
                            }
                            break;
                        case 1:
                            if ((rand.Next(0, 100) - TankObj.Dodge < moveName.Accuracy))
                            {
                                TankObj.curHealth -= damageDealt;
                            }
                            break;
                        case 2:
                            if ((rand.Next(0, 100) - MageObj.Dodge < moveName.Accuracy))
                            {
                                MageObj.curHealth -= damageDealt;
                            }
                            break;
                        case 3:
                            if ((rand.Next(0, 100) - DpsObj.Dodge < moveName.Accuracy))
                            {
                                DpsObj.curHealth -= damageDealt;
                            }
                            break;
                    }
                }
            }
            if ((User.curStamina - moveName.StaminaCost) <= 0)
            {
                User.curStamina = 0;
            }
            if (User.curStamina > User.Stamina)
            {
                User.curStamina = User.Stamina;
            }
        }
    }
}