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
using Janles1.Actions;

namespace Janles1.Object
{
    class Balletje
    {
        public Vector2 balPos = new Vector2(0, 0);
        Texture2D balletjeTexure;
        SpriteBatch sp;
        Movement movement = new Movement();
        public Balletje(SpriteBatch sp){
            this.sp = sp;
        }
        public void LoadContent(ContentManager content)
        {
            // TODO: use this.Content to load your game content here
            balletjeTexure = content.Load<Texture2D>("bork");
        }

        public void Draw(){

            sp.Draw(balletjeTexure, movement.position, Color.White);

        }
    }
}
