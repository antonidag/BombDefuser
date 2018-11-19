using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LevelEditor_Kassler_Edition
{
    class BombTile : TileNoScale
    {
        public static int HEIGHT = 30;
        public BombTile(Vector2 position) : base(position)
        {
            this.setRectangle(null, null, 62, HEIGHT);
            texture = ResManager.bomb;
        }
    }
}
