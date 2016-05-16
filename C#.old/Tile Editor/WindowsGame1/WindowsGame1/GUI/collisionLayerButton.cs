﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace WindowsGame1.GUI
{
    public class collisionLayerButton : Buttan
    {
        public bool clicked = false;

        public collisionLayerButton(Texture2D texure, Vector2 posititon)
            :base(texure, posititon)
        {

        }

        public override void Update()
        {
            clicked = base.clicked;           
            base.Update();

        }


        public override void Effect()
        {

            Game1.drawableLayer = 2;
            base.prevClicked = false;

            base.Effect();
        }
    }
}
