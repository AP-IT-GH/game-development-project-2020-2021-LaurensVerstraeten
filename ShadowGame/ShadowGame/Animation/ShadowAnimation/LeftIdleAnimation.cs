﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ShadowGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShadowGame.Animation.ShadowAnimation
{
    class LeftIdleAnimation : IAnimation
    {
        private Animatie _animatie;
        public Texture2D texture;
        public Vector2 position;
        public Animatie animatie { get { return _animatie; } set { _animatie = value; } }

        public LeftIdleAnimation(Texture2D texture, Vector2 Position)
        {
            this.position = Position;
            this.texture = texture;
            _animatie = new Animatie();
            _animatie.AddFrame(new AnimationFrame(new Rectangle(0, 41, 42, 37)));
        }

        public void draw(SpriteBatch spriteBatch, Vector2 _position)
        {
            this.position = _position;
            spriteBatch.Draw(this.texture, new Rectangle((int)position.X, (int)position.Y, 55, 55), _animatie.currentFrame.SourceRectangle, Color.White, 0, new Vector2(0, 0), SpriteEffects.FlipHorizontally, 0);
        }
        public void update(GameTime gameTime)
        {
            animatie.Update(gameTime);
        }
    }
}
