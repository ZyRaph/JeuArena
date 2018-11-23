using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using Arena;
using System;

namespace Arena.Core
{
    public class Entree
    {
        public char touche;
        public Entree()
        {
            touche = '0';
        }
        public char recup_touche()
        {
            var kstate = Keyboard.GetState();
            if (kstate.IsKeyDown(Keys.Z))
                touche='Z';
            else if (kstate.IsKeyDown(Keys.Q))
                touche = 'Q';
            else if (kstate.IsKeyDown(Keys.S))
                touche = 'S';
            else if (kstate.IsKeyDown(Keys.D))
                touche = 'D';
            return touche;
        }
    }

}
