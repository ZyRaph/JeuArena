using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using Arena.Core;
using System;
//Lib de base
namespace Arena
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch; // Les deux variables obligatoires
        public static int WINDOWS_HEIGHT = 640; // Taille de la fenêtre de la caméra (changeable via le menu)
        public static int WINDOWS_WIDTH = 1240;
        Joueur player;
        private Camera _camera;
        SpriteFont hud;
        char key;
        Entree touche;

        public Game1() //Constructeur 
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content"; // Création de la zone graphique 
            graphics.PreferredBackBufferHeight = WINDOWS_HEIGHT;
            graphics.PreferredBackBufferWidth = WINDOWS_WIDTH;
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
            player = new Joueur();
            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            player.Apparence_h = Content.Load<Texture2D>("PERSO_haut");
            player.Apparence_b = Content.Load<Texture2D>("PERSO_bas");
            player.Apparence_d = Content.Load<Texture2D>("PERSO_droite");
            player.Apparence_g = Content.Load<Texture2D>("PERSO_gauche");
            hud = Content.Load<SpriteFont>("Texte");
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            _camera = new Camera();

            // TODO: use this.Content to load your game content here
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
            _camera.Follow(player);
            // TODO: Add your update logic here
            player.Mouvement_joueur(gameTime);
            touche = new Entree();
            key = touche.recup_touche();
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            spriteBatch.Begin(transformMatrix: _camera.Transform);
            player.Draw_joueur(spriteBatch);
            spriteBatch.DrawString(hud, "Touche : " + key, new Vector2(player.Position.X - 300, player.Position.Y - 2), Color.White);
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
