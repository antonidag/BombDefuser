using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LevelEditor_Kassler_Edition
{
    class ResManager
    {
        public static Texture2D pixel, GRAY, GREEN, RED, HOUSE, HOUSE_BROKEN, start, bomb, enemy, props;
        public static void Load(Game1 game)
        {
            pixel = game.Content.Load<Texture2D>("pixel");
            GRAY = game.Content.Load<Texture2D>("tile_gray");
            RED = game.Content.Load<Texture2D>("tile_red");
            GREEN = game.Content.Load<Texture2D>("tile_green");
            HOUSE = game.Content.Load<Texture2D>("tile_house");
            HOUSE_BROKEN = game.Content.Load<Texture2D>("tile_house_broken");
            start = game.Content.Load<Texture2D>("StartPos");
            bomb = game.Content.Load<Texture2D>("case");
            enemy = game.Content.Load<Texture2D>("enemy");
            props = game.Content.Load<Texture2D>("prop_sheet");
        }
    }
}
