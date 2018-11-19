using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using System.IO;

namespace LevelEditor_Kassler_Edition
{
    public class SaveAlgorithm
    {
        private static float DIVID = 2.0f;

        public static void SaveToFile(Game1 game, String path)
        {
            List<string> lines = new List<string>();
            // Write the string to a file.
            StreamWriter file = new StreamWriter(path);

            addTiles(lines);
            addHeroBomb(lines);
            addProp(lines);
            addEnemy(lines);
            addFans(lines);

            foreach (string s in lines)
            {
                string correct = s.Replace(',', '.');
                file.WriteLine(correct);
            }

            file.Close();
        }

        private static void addTiles(List<string> list)
        {
            list.Add("[Tiles]");
            foreach(Tile t in Game1.lower)
            {
                Rectangle rec = t.getRecHit();
                list.Add("L:" + rec.X / DIVID + ":" + ((rec.Y * -1) - rec.Height) / DIVID + ":" + rec.Width / DIVID + ":" + rec.Height / DIVID + ":" + t.getTextureType().ToString());
            }
            foreach (Tile t in Game1.middle)
            {
                if (t is TileNoScale)
                    continue;
                Rectangle rec = t.getRecHit();
                list.Add("M:" + rec.X / DIVID + ":" + ((rec.Y * -1) - rec.Height) / DIVID + ":" + rec.Width / DIVID + ":" + rec.Height / DIVID + ":" + t.getTextureType().ToString());
            }
            foreach (Tile t in Game1.top)
            {
                Rectangle rec = t.getRecHit();
                list.Add("T:" + rec.X / DIVID + ":" + ((rec.Y * -1) - rec.Height) / DIVID + ":" + rec.Width / DIVID + ":" + rec.Height / DIVID + ":" + t.getTextureType().ToString());
            }
        }

        private static void addHeroBomb(List<string> list)
        {
            foreach (Tile t in Game1.middle)
            {
                Rectangle rec = t.getRecHit();
                if (t is HeroTile)
                {
                    list.Add("[Hero]");
                    list.Add(rec.X / DIVID + ":" + ((rec.Y * -1) - rec.Height) / DIVID);
                    continue;
                }
                else if (t is BombTile)
                {
                    list.Add("[Bomb]");
                    list.Add(rec.X / DIVID + ":" + ((rec.Y * -1) - rec.Height) / DIVID + ":" + ((int)Game1.controller.nrBomb.Value));
                    continue;
                }
            }
        }
        private static void addProp(List<string> list)
        {
            list.Add("[Props]");
            foreach (Tile t in Game1.middle)
            {
                if (t is PropTile)
                {
                    Rectangle rec = t.getRecHit();
                    PropTile tile = (PropTile) t;
                    list.Add(tile.getX() + ":" + tile.getY() + ":" + rec.X / DIVID + ":" + ((rec.Y * -1) - rec.Height) / DIVID + ":" + rec.Height / DIVID);
                }
            }
        }
        private static void addEnemy(List<string> list)
        {
            list.Add("[Enemys]");
            foreach (Tile t in Game1.middle)
            {
                if (t is EnemyTile)
                {
                    Rectangle rec = t.getRecHit();
                    list.Add(rec.X / DIVID + ":" + ((rec.Y * -1) - rec.Height) / DIVID);
                }
            }
        }
        private static void addFans(List<string> list)
        {
            list.Add("[Fans]");
            foreach (Tile t in Game1.middle)
            {
                if (t is FanTile)
                {
                    FanTile tile = (FanTile) t;
                    Rectangle rec = t.getRecHit();
                    String s = rec.X / DIVID + ":" + ((rec.Y * -1) - rec.Height) / DIVID + ":" + rec.Width / DIVID + ":" + rec.Height / DIVID + ":" + tile.getPower() + ":" + tile.getDirection().ToString();
                    if (tile.getTime() != 0)
                        s += ":" + tile.getTime();
                    list.Add(s);
                }
            }
        }
    }
}
