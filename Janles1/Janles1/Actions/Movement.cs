using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace Janles1.Actions
{
    class Movement
    {
        KeyboardState m_currentState;
        KeyboardState m_previousState;

        public Vector2 position = Vector2.Zero;
        Vector2 velocity;
        KeyboardState key = new KeyboardState();

        public void Update()
        {
            if (key.IsKeyDown(Keys.Right))
            {

                position.X += velocity.X;

            }
            else if (key.IsKeyDown(Keys.Left))
            {
                position.X -= velocity.X;

            }
            else
            {
                position.X = position.X;
            }


        }
    }
}
