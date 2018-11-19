using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LevelEditor_Kassler_Edition
{
    public class FanTile : TileNoScale
    {
        EDirection direction;
        int power, time;
        public FanTile(Vector2 position) : base(position)
        {
            setRectangle(1, EDirection.UP);
            texture = ResManager.pixel;
            power = 70;
            time = 0;
        }

        public void setRectangle(int amount, EDirection direction)
        {
            this.direction = direction;
            switch (direction)
            {
                case EDirection.UP:
                    this.setRectangle(null, null, 50 * amount, 20);
                    break;
                case EDirection.LEFT:
                    this.setRectangle(null, null, 20, 50 * amount);
                    break;
                case EDirection.RIGHT:
                    this.setRectangle(null, null, 20, 50 * amount);
                    break;
                case EDirection.DOWN:
                    this.setRectangle(null, null, 50 * amount, 20);
                    break;
            }
        }

        public void setDirection(EDirection direction) { this.direction = direction; }
        public EDirection getDirection() { return direction; }
        public void setTime(int time) { this.time = time; }
        public int getTime() { return time; }
        public void setPower(int power) { this.power = power; }
        public int getPower() { return power; }
    }
}
