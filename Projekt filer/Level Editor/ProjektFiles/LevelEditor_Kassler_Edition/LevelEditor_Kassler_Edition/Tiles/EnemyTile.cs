using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LevelEditor_Kassler_Edition
{
    class EnemyTile : TileNoScale
    {
        public static int HEIGHT = 64;
        public EnemyTile(Vector2 position) : base(position)
        {
            this.setRectangle(null, null, 44, HEIGHT);
            texture = ResManager.enemy;
        }
    }
}
