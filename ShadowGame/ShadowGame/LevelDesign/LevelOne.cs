﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using ShadowGame.World;
using ShadowGame.Command;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShadowGame.LevelDesign
{
    class LevelOne
    {
        //platform classe maken, rectangle maken (verschillende platformen) met eigen draw functie
        //platformen zijn een array van tiles
        //in level heb je een list/array van uw platforms en hier roep je uw array aan om te draw
        //array roept rectangles aan
        private List<Block> collisionTiles = new List<Block>();
        public List<Block> CollisionTiles
        {
            get { return collisionTiles; }
        }

        private int width, height;
        public int Width
        {
            get { return width; }
        }
        public int Height
        {
            get { return height; }
        }              

        public byte[,] map = new byte[,]
        {
            {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
            {0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
            {1,1,1,1,0,0,0,0,0,0,1,1,0,0,0,0,0,0,0,0,0,0},

        };

        public LevelOne() { }

        //private Block[,]  = new Block[3, 1];

        //public LevelOne(ContentManager content)
        //{
        //    this.Content = content;
        //    InitializeContent();
        //}

        public void CreateWorld(int size)
        {
            for (int x = 0; x < map.GetLength(1); x++)
            {
                for (int y = 0; y < map.GetLength(0); y++)
                {
                    int number = map[y, x];
                    if (number == 1)
                    {
                        collisionTiles.Add(new Block(new Rectangle(x * size, y * size, size, size)));

                        width = (x + 1) * size;
                        height = (y + 1) * size;
                    }
                }

            }
        }

        public void DrawWorld(SpriteBatch spriteBatch)
        {
            foreach (Block tile in collisionTiles)
            {
                tile.Draw(spriteBatch);
            }
        }

    }
}
