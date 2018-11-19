using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LevelEditor_Kassler_Edition
{
    public class PropTile : TileNoScale
    {
        public static int HEIGHT = 40;
        Rectangle recDraw;
        int x, y;
        public PropTile(Vector2 position) : base(position)
        {
            this.setRectangle(null, null, HEIGHT, HEIGHT);
            texture = ResManager.props;
            setPropTexture(0, 0);
        }

        public void setPropTexture(int x, int y)
        {
            this.x = x;
            this.y = y;
            recDraw = new Rectangle((x * (32 + 4)) + 2, (y * (32 + 4)) + 2, 32, 32);
        }

        public override void render(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, recHit, recDraw, Color.White);
        }
        public int getX() { return x; }
        public int getY() { return y; }

    }
}
