using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using Arena;

namespace Arena.Core
{
    public class Camera
    {
        public Matrix Transform { get; private set; }
        public void Follow(Joueur target)
        {
            var Position = Matrix.CreateTranslation(
                -target.Position.X - (target.Apparence_h.Width / 2),
                -target.Position.Y - (target.Apparence_h.Height / 2), 0);
            var offset = Matrix.CreateTranslation(Game1.WINDOWS_WIDTH / 2, Game1.WINDOWS_HEIGHT / 2, 0);
            //Transform = Position * offset * Matrix.CreateScale(new Vector3(0.5f, 0.5f, 1));
            Transform = Position * offset;
        }
        public void Follow_Texture(Texture2D target)
        {
            Transform = Matrix.CreateTranslation(
                (float)(-target.Width / 0.9),
                (float)(-target.Height / 1.8), 0) * Matrix.CreateTranslation(Game1.WINDOWS_WIDTH / 2, Game1.WINDOWS_HEIGHT / 2, 0);
        }
    }
}
