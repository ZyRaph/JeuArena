using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using Arena;
using System;

namespace Arena.Core
{
    public class Joueur
    {
        //Variables publiques
        public Vector2 Position;
        public Texture2D Apparence_h, Apparence_b, Apparence_g, Apparence_d;
        public int taille_height,taille_width;
        //Variables privées
        private Entree touche;
        private char derniereTouche = '0';
        private char key;
        private float vitesse = 100f;
        //Constructeur par défaut
        public Joueur(GraphicsDevice dvc)
        {
            this.Position = new Vector2(1240 / 2, 640 / 2);
            this.taille_height = 100;
            this.taille_width = 100;
        }
        public void Mouvement_joueur(GameTime gt)
        {
            touche = new Entree();
            key = touche.recup_touche();
            switch (key)
            {
                case 'Z':
                    this.Position.Y += vitesse * (float)gt.ElapsedGameTime.TotalSeconds;
                    //System.Console.WriteLine("Z");
                break;
                case 'Q':
                    this.Position.X += vitesse * (float)gt.ElapsedGameTime.TotalSeconds;
                    //System.Console.WriteLine("Q");
                    break;
                case 'S':
                    this.Position.Y -= vitesse * (float)gt.ElapsedGameTime.TotalSeconds;
                    //System.Console.WriteLine("S");
                    break;
                case 'D':
                    this.Position.X -= vitesse * (float)gt.ElapsedGameTime.TotalSeconds;
                    //System.Console.WriteLine("D");
                    break;
            }
        }

        public void Draw_joueur(SpriteBatch spriteBatch)
        {
            if(derniereTouche=='0')
                spriteBatch.Draw(Apparence_b, Position, Color.White);

            switch (key)
            {
                case 'Z':
                    //System.Console.WriteLine("Z");
                    derniereTouche = 'Z';
                    break;
                case 'Q':
                    //System.Console.WriteLine("Q");
                    derniereTouche = 'Q';
                    break;
                case 'S':
                    //System.Console.WriteLine("S");
                    derniereTouche = 'S';
                    break;
                case 'D':
                    //System.Console.WriteLine("D");
                    derniereTouche = 'D';
                    
                    break;
            }
            switch (derniereTouche)
            {
                case 'Z':
                    spriteBatch.Draw(Apparence_h, Position, Color.White);
                    break;
                case 'Q':
                    spriteBatch.Draw(Apparence_g, Position, Color.White);
                    break;
                case 'S':
                    spriteBatch.Draw(Apparence_b, Position, Color.White);
                    break;
                case 'D':
                    spriteBatch.Draw(Apparence_d, Position, Color.White);
                    break;

            }
        }
    }
}
