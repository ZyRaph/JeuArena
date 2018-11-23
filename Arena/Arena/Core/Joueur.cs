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
        public Rectangle taille;
        //Variables privées
        private Entree touche;
        private char key;
        //Constructeur par défaut
        public Joueur()
        {
            this.Position = new Vector2(1240 / 2, 640 / 2);
            this.taille = new Rectangle((int)Position.X,(int)Position.Y, 100, 100);
        }
        public void Mouvement_joueur(GameTime gt)
        {
            touche = new Entree();
            key = touche.recup_touche();
            switch (key)
            {
                case 'Z':
                    //System.Console.WriteLine("Z");
                break;
                case 'Q':
                    //System.Console.WriteLine("Q");
                break;
                case 'S':
                    //System.Console.WriteLine("S");
                break;
                case 'D':
                    //System.Console.WriteLine("D");
                break;
            }
        }

        public void Draw_joueur(SpriteBatch spriteBatch)
        {
            switch (key)
            {
                case 'Z':
                    //System.Console.WriteLine("Z");
                    spriteBatch.Draw(Apparence_h,taille,Color.White);
                    break;
                case 'Q':
                    //System.Console.WriteLine("Q");
                    spriteBatch.Draw(Apparence_g, taille, Color.White);
                    break;
                case 'S':
                    //System.Console.WriteLine("S");
                    spriteBatch.Draw(Apparence_b, taille, Color.White);
                    break;
                case 'D':
                    //System.Console.WriteLine("D");
                    spriteBatch.Draw(Apparence_d, taille, Color.White);
                    break;
            }
        }
    }
}
