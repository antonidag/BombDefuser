using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace LevelEditor_Kassler_Edition
{
    class LoadAlgorithm
    {
        private static float MULTI = 2.0f;
        private static State current;
        public static void Load(Game1 game, String path)
        {
            game.clear();
            current = State.NONE;
            String[] lines = File.ReadAllLines(path);
            
            foreach(String s in lines)
            {
                switch (s)
                {
                    case "[Hero]": current = State.HERO;
                        continue;
                    case "[Bomb]": current = State.BOMB;
                        continue;
                    case "[Fans]": current = State.FAN;
                        continue;
                    case "[Enemys]": current = State.ENEMY;
                        continue;
                    case "[Props]": current = State.PROPS;
                        continue;
                    case "[Tiles]": current = State.TILES;
                        continue;
                }

                string fixedString = s.Replace('.', ',');
                switch (current)
                {
                    case State.FAN: loadFan(fixedString);
                        continue;
                    case State.ENEMY: loadEnemy(fixedString);
                        continue;
                    case State.HERO: loadHero(fixedString);
                        continue;
                    case State.PROPS: loadProp(fixedString);
                        continue;
                    case State.TILES: loadTile(fixedString);
                        continue;
                    case State.BOMB: loadBomb(fixedString);
                        continue;
                    case State.NONE:
                        continue;
                }
            }
        }

        private static void loadHero(String s)
        {
            string[] data = s.Split(':');
            float x = float.Parse(data[0]) * MULTI;
            float y = (float.Parse(data[1]) * MULTI * -1) - HeroTile.HEIGHT;
            Game1.middle.Add(new HeroTile(new Vector2(x, y)));
        }
        private static void loadBomb(String s)
        {
            string[] data = s.Split(':');
            float x = float.Parse(data[0]) * MULTI;
            float y = (float.Parse(data[1]) * MULTI * -1) - BombTile.HEIGHT;
            int time = int.Parse(data[2]);
            Game1.middle.Add(new BombTile(new Vector2(x, y)));
            Game1.controller.nrBomb.Value = time;
        }
        private static void loadTile(String s)
        {
            string[] data = s.Split(':');

            float x = float.Parse(data[1]) * MULTI;
            float width = float.Parse(data[3]) * MULTI;
            float height = float.Parse(data[4]) * MULTI;
            float y = (float.Parse(data[2]) * MULTI * -1) - (float)height;

            ETextures texture = ETextures.GRAY;
            switch (data[5])
	        {
		        case "GRAY": texture = ETextures.GRAY; break;
                case "RED": texture = ETextures.RED; break;
                case "GREEN": texture = ETextures.GREEN; break;
                case "HOUSE": texture = ETextures.HOUSE; break;
                case "HOUSE_BROKEN": texture = ETextures.HOUSE_BROKEN; break;
	        }
            
            Tile tile = new Tile(new Vector2(x, y));
            tile.setRectangle((int)x, (int)y, (int)width, (int)height);
            tile.setTexture(texture);

            if(data[0].Equals("L"))
                Game1.lower.Add(tile);
            else if (data[0].Equals("M"))
                Game1.middle.Add(tile);
            else if (data[0].Equals("T"))
                Game1.top.Add(tile);
        }
        private static void loadProp(String s)
        {
            string[] data = s.Split(':');
            int xTex = int.Parse(data[0]);
            int yTex = int.Parse(data[1]);
            float x = float.Parse(data[2]) * MULTI;
            float y = (float.Parse(data[3]) * MULTI * -1) - PropTile.HEIGHT;
            float height = float.Parse(data[4]) * MULTI;

            PropTile tile = new PropTile(new Vector2(x, y));
            tile.setRectangle((int)x, (int)y, (int)height, (int)height);
            tile.setPropTexture(xTex, yTex);
            Game1.middle.Add(tile);
        }
        private static void loadEnemy(String s)
        {
            string[] data = s.Split(':');
            float x = float.Parse(data[0]) * MULTI;
            float y = (float.Parse(data[1]) * MULTI * -1) - EnemyTile.HEIGHT;
            Game1.middle.Add(new EnemyTile(new Vector2(x, y)));
        }

        private static void loadFan(String s)
        {
            string[] data = s.Split(':');
            float width = float.Parse(data[2]) * MULTI;
            float height = float.Parse(data[3]) * MULTI;
            float x = float.Parse(data[0]) * MULTI;
            float y = (float.Parse(data[1]) * MULTI * -1) - height;

            int power = int.Parse(data[4]);
            EDirection direction = EDirection.UP;
            switch (data[5])
            {
                case "UP": direction = EDirection.UP; break;
                case "DOWN": direction = EDirection.DOWN; break;
                case "LEFT": direction = EDirection.LEFT; break;
                case "RIGHT": direction = EDirection.RIGHT; break;
            }

            FanTile tile = new FanTile(new Vector2(x, y));
            tile.setRectangle((int)x, (int)y, (int)width, (int)height);
            tile.setPower(power);
            tile.setDirection(direction);
            if(data.Length == 7)
            {
                int time = int.Parse(data[6]);
                tile.setTime(time);
            }

            Game1.middle.Add(tile);
        }
    }
    enum State
    {
        FAN, ENEMY, HERO, PROPS, TILES, BOMB, NONE
    }
}
