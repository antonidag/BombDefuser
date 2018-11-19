using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LevelEditor_Kassler_Edition
{
    class MouseEvents
    {

        public static MouseState ms;

        private static ButtonState oldMouseLeftButtonState = ButtonState.Released;
        private static ButtonState oldMouseRightButtonState = ButtonState.Released;
        private static ButtonState oldMouseMiddleButtonState = ButtonState.Released;
        public delegate void PointDelegate(Point p);
        public static event PointDelegate OnMousePress, OnMouseRelease, OnMouseMoved, OnMouseRightPress, OnMouseMiddlePress, OnMouseMiddleMoved;

        public static Point getMousePos()
        {
            return Game1.camera.unProject(new Point(ms.X, ms.Y));
        }
        public static void Update()
        {
            ms = Mouse.GetState();
            Point point = Game1.camera.unProject(new Point(ms.X, ms.Y));
            if (oldMouseLeftButtonState == ButtonState.Released && ms.LeftButton == ButtonState.Pressed && OnMousePress != null)
                OnMousePress(point);
            else if (oldMouseLeftButtonState == ButtonState.Pressed && ms.LeftButton == ButtonState.Released && OnMouseRelease != null)
                OnMouseRelease(point);
            else if (oldMouseLeftButtonState == ButtonState.Pressed && ms.LeftButton == ButtonState.Pressed && OnMouseMoved != null)
                OnMouseMoved(point);
            //RightMouseButton
            else if (oldMouseRightButtonState == ButtonState.Released && ms.RightButton == ButtonState.Pressed && OnMouseRightPress != null)
                OnMouseRightPress(point);
            //MiddleMouseButton
            else if (oldMouseMiddleButtonState == ButtonState.Released && ms.MiddleButton == ButtonState.Pressed && OnMouseMiddlePress != null)
                OnMouseMiddlePress(point);
            else if (oldMouseMiddleButtonState == ButtonState.Pressed && ms.MiddleButton == ButtonState.Pressed && OnMouseMiddleMoved != null)
                OnMouseMiddleMoved(point);
            oldMouseRightButtonState = ms.RightButton;
            oldMouseMiddleButtonState = ms.MiddleButton;
            oldMouseLeftButtonState = ms.LeftButton;
        }
    }
}
