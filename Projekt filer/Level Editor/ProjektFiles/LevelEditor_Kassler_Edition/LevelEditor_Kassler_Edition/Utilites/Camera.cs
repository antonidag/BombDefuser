using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LevelEditor_Kassler_Edition
{
    public class Camera
    {
        public static int CAMERASPEED = 5;
        public Matrix transForm { get; set; }
        public Viewport view { get; set; }
        public bool active { get; set; }
        private Vector2 position, center;
        private float zoomAmount;

        private int scroll;
        private MouseState mouseState;
        public Camera(Viewport view)
        {
            this.view = view;
            active = false;
            zoomAmount = 1;
            center = new Vector2(-view.Width/2, -view.Height/2);
        }
        public void Update()
        {

            transForm = Matrix.CreateTranslation(new Vector3(-position.X, -position.Y, 0)) *
                Matrix.CreateScale(new Vector3(zoomAmount, zoomAmount, 1)) *
                Matrix.CreateTranslation(new Vector3(-center.X, -center.Y, 0));
            moveCamera();
            zoom();
            reset();
        }
        private void moveCamera()
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Right))
                position.X += CAMERASPEED;
            if (Keyboard.GetState().IsKeyDown(Keys.Left))
                position.X -= CAMERASPEED;
            if (Keyboard.GetState().IsKeyDown(Keys.Up))
                position.Y -= CAMERASPEED;
            if (Keyboard.GetState().IsKeyDown(Keys.Down))
                position.Y += CAMERASPEED;
        }
        private void zoom()
        {
            mouseState = Mouse.GetState();
            if (zoomAmount < 0)
                zoomAmount = 0;

            if (mouseState.ScrollWheelValue > scroll)
                zoomAmount += 0.1f;
            else if (mouseState.ScrollWheelValue < scroll)
                zoomAmount -= 0.1f;

            scroll = mouseState.ScrollWheelValue;
        }
        public Vector2 getCenterPos()
        {
            return new Vector2(position.X, position.Y);
        }
        public void reset()
        {
            if (Keyboard.GetState().IsKeyDown(Keys.C))
            {
                position = Vector2.Zero;
                zoomAmount = 1f;
            }
        }
        //Insert "Screen position" and get the "World position", used when click on screen and spawn tile in world and not on screen!
        public Point unProject(Point vector)
        {
            Vector2 temp = Vector2.Transform(new Vector2(vector.X, vector.Y), Matrix.Invert(transForm));
            return new Point((int)temp.X, (int)temp.Y);
        }
    }
}
