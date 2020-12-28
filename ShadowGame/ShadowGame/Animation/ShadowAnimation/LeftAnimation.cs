﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ShadowGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShadowGame.Animation.ShadowAnimation
{
    class LeftAnimation : IAnimation
    {
        private Animatie _animatie;
        public Texture2D texture;
        public ITransform transform;
        public Animatie animatie { get { return _animatie; } set { _animatie = value; } }

        public LeftAnimation(Texture2D texture, ITransform transform)
        {
            this.transform = transform;
            this.texture = texture;
            _animatie = new Animatie();
            for (int i = 0; i < 1260; i += 126)
            {
                _animatie.AddFrame(new AnimationFrame(new Rectangle(i, 0, 126, 111)));
            }
        }

        public void draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(this.texture, new Rectangle((int)transform.Position.X, (int)transform.Position.Y, 55, 55), _animatie.currentFrame.SourceRectangle, Color.White, 0, new Vector2(0,0), SpriteEffects.FlipHorizontally, 0);
        }

        public void update(GameTime gameTime)
        {
            _animatie.Update(gameTime);
        }
    }
}