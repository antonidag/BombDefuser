using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LevelEditor_Kassler_Edition
{
    public class Selector
    {
        private const int SIZE = 5, MINSIZE = 15;
        private Tile selected;
        int grid = 1;
        Game1 game;

        Rectangle DR, UL, recBefore;
        bool ULDrag, DRDrag, Move;
        Point pressPoint;
        public Selector(Game1 game)
        {
            this.game = game;
            MouseEvents.OnMousePress += MouseEvents_OnMousePress;
            MouseEvents.OnMouseRelease += MouseEvents_OnMouseRelease;
            MouseEvents.OnMouseMoved += MouseEvents_OnMouseMoved;
        }

        public void render(SpriteBatch spriteBatch)
        {
            if(selected != null)
            {
                if (!(selected is TileNoScale))
                {
                    spriteBatch.Draw(ResManager.pixel, DR, Color.Yellow);
                    spriteBatch.Draw(ResManager.pixel, UL, Color.Yellow);
                }
                spriteBatch.Draw(ResManager.pixel, selected.getRecHit(), Color.FromNonPremultiplied(new Vector4(0, 1, 0, 0.2f)));
            }
        }

        private void MouseEvents_OnMousePress(Point p)
        {
            foreach (Tile t in Game1.getCurrentList())
            {
                if (t.getRecHit().Contains(MouseEvents.getMousePos()))
                {
                    setSelected(t);
                }
            }
            if (selected == null)
                return;

            if (UL.Contains(p))
            {
                ULDrag = true;
                pressPoint = p;
                recBefore = selected.getRecHit();
            }
            else if (DR.Contains(p))
            {
                DRDrag = true;
                pressPoint = p;
                recBefore = selected.getRecHit();
            }
            else if (selected.getRecHit().Contains(p))
            {
                Move = true;
                pressPoint = p;
                recBefore = selected.getRecHit();
            }
        }
        void MouseEvents_OnMouseMoved(Point p)
        {
            if (ULDrag && !(selected is TileNoScale))
            {
                int moveAmountX = pressPoint.X - p.X - ((pressPoint.X - p.X) % grid) + (recBefore.X % grid);
                int moveAmountY = pressPoint.Y - p.Y - ((pressPoint.Y - p.Y) % grid) + (recBefore.Y % grid);

                int newWidth = recBefore.Width + moveAmountX;
                int newX = recBefore.X - moveAmountX;
                int newHeight = recBefore.Height + moveAmountY;
                int newY = recBefore.Y - moveAmountY;

                if (newWidth > MINSIZE)
                    selected.setRectangle(newX, null, newWidth, null);
                if (newHeight > MINSIZE)
                    selected.setRectangle(null, newY, null, newHeight);
                setDragRecs();
            }
            else if (DRDrag && !(selected is TileNoScale))
            {
                int moveAmountX = pressPoint.X - p.X - ((pressPoint.X - p.X) % grid) + ((recBefore.X + recBefore.Width) % grid);
                int moveAmountY = pressPoint.Y - p.Y - ((pressPoint.Y - p.Y) % grid) + ((recBefore.Y + recBefore.Height) % grid);

                int newWidth = recBefore.Width - moveAmountX;
                int newHeight = recBefore.Height - moveAmountY;

                if (newWidth > MINSIZE)
                    selected.setRectangle(null, null, newWidth, null);
                if (newHeight > MINSIZE)
                    selected.setRectangle(null, null, null, newHeight);
                setDragRecs();
            }
            else if (Move)
            {
                int moveAmountX = pressPoint.X - p.X - ((pressPoint.X - p.X) % grid) + (recBefore.X % grid);
                int moveAmountY = pressPoint.Y - p.Y - ((pressPoint.Y - p.Y) % grid) + (recBefore.Y % grid);

                int newX = recBefore.X - moveAmountX;
                int newY = recBefore.Y - moveAmountY;

                selected.setRectangle(newX, newY, null, null);
                setDragRecs();
            }
        }
        void MouseEvents_OnMouseRelease(Point p)
        {
            ULDrag = false;
            DRDrag = false;
            Move = false;
        }

        public void setDragRecs()
        {
            if (selected != null)
            {
                UL = new Rectangle(selected.getRecHit().X, selected.getRecHit().Y, SIZE, SIZE);
                DR = new Rectangle(selected.getRecHit().X + selected.getRecHit().Width - SIZE, selected.getRecHit().Y + selected.getRecHit().Height - SIZE, SIZE, SIZE);
            }
        }

        public void setSelected(Tile tile) { 
            this.selected = tile;
            setDragRecs();
            if (tile == null || selected is HeroTile || selected is BombTile)
                Game1.controller.setSelected(false);
            else
                Game1.controller.setSelected(true);
        }

        public Tile getSelected()
        {
            return selected;
        }

        public void setGrid(int i) { grid = i; }
    }
}
