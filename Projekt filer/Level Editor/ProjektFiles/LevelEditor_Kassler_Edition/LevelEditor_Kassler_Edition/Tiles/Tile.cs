using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LevelEditor_Kassler_Edition
{
    public class Tile
    {
        protected Rectangle recHit;
        protected ETextures textureType;
        protected Texture2D texture;
        public Tile(Vector2 position)
        {
            recHit = new Rectangle((int)position.X, (int)position.Y, 32, 32);
            setTexture(ETextures.GRAY);
        }

        public void setRectangle(int? x, int? y, int? width, int? height)
        {
            if (x != null)
                recHit.X = (int)x;
            if (y != null)
                recHit.Y = (int)y;
            if (width != null)
                recHit.Width = (int)width;
            if (height != null)
                recHit.Height = (int)height;
        }

        public virtual void setTexture(ETextures type)
        {
            textureType = type;
            switch (type)
            {
                case ETextures.GRAY: texture = ResManager.GRAY;
                    break;
                case ETextures.RED: texture = ResManager.RED;
                    break;
                case ETextures.GREEN: texture = ResManager.GREEN;
                    break;
                case ETextures.FAN: texture = ResManager.pixel;
                    break;
                case ETextures.HOUSE: texture = ResManager.HOUSE;
                    break;
                case ETextures.HOUSE_BROKEN: texture = ResManager.HOUSE_BROKEN;
                    break;
            }
        }

        public ETextures getTextureType() { return textureType; }

        public virtual void render(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, recHit, Color.White);
        }

        public Rectangle getRecHit() { return recHit; }
    }
}
