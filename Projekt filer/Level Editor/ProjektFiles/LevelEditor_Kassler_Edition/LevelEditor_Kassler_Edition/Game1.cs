using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace LevelEditor_Kassler_Edition
{

    public class Game1 : Microsoft.Xna.Framework.Game
    {
        
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        public static Camera camera;
        public static List<Tile> lower, middle, top;
        public static Selector selector;
        public static ControllerForm controller;
        private static ELayer currentLayer;
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            graphics.PreferredBackBufferHeight = 720;
            graphics.PreferredBackBufferWidth = 1280;
            graphics.ApplyChanges();
            Content.RootDirectory = "Content";
        }
        public void loadNew()
        {
            clear();
            middle.Add(new HeroTile(new Vector2(-22, -32)));
            middle.Add(new BombTile(new Vector2(-31, 60)));
        }

        public void clear()
        {
            setLayer(ELayer.MIDDLE);
            lower.Clear();
            middle.Clear();
            top.Clear();
            camera.reset();
            controller.setLayer(ELayer.MIDDLE);
        }
        protected override void Initialize()
        {
            lower = new List<Tile>();
            middle = new List<Tile>();
            top = new List<Tile>();
            
            currentLayer = ELayer.MIDDLE;

            this.IsMouseVisible = true;
            base.Initialize();

            controller = new ControllerForm(this);
            controller.Show();

            selector = new Selector(this);

            loadNew();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            ResManager.Load(this);
            camera = new Camera(GraphicsDevice.Viewport);
            
        }
        protected override void UnloadContent()
        {
        }

        protected override void Update(GameTime gameTime)
        {
            MouseEvents.Update();
            camera.Update();
            if (Keyboard.GetState().IsKeyDown(Keys.Escape))
                this.Exit();

            base.Update(gameTime);
        }

        public void addTile()
        {
            Tile t = new Tile(camera.getCenterPos());
            getCurrentList().Add(t);
            selector.setSelected(t);
        }

        public void addEnemy()
        {
            if (currentLayer == ELayer.MIDDLE)
            {
                EnemyTile t = new EnemyTile(camera.getCenterPos());
                middle.Add(t);
                selector.setSelected(t);
            }
        }
        public void addFan()
        {
            if (currentLayer == ELayer.MIDDLE)
            {
                FanTile t = new FanTile(camera.getCenterPos());
                middle.Add(t);
                selector.setSelected(t);
            }
        }
        public void addProp()
        {
            if (currentLayer == ELayer.MIDDLE)
            {
                PropTile t = new PropTile(camera.getCenterPos());
                middle.Add(t);
                selector.setSelected(t);
            }
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend, null, null, null, null, camera.transForm);
            spriteBatch.Draw(ResManager.pixel, new Rectangle(-10000, -320, 20000, 1), Color.White);
            spriteBatch.Draw(ResManager.pixel, new Rectangle(-10000, 320, 20000, 1), Color.White);
            spriteBatch.Draw(ResManager.pixel, new Rectangle(-10000, 0, 20000, 1), Color.White);
            spriteBatch.Draw(ResManager.pixel, new Rectangle(0, -320, 1, 640), Color.White);
            foreach (Tile t in lower)
                t.render(spriteBatch);
            foreach (Tile t in middle)
                t.render(spriteBatch);
            foreach (Tile t in top)
                t.render(spriteBatch);
            selector.render(spriteBatch);
            spriteBatch.End();
            base.Draw(gameTime);
        }

        public static void setLayer(ELayer layer)
        {
            currentLayer = layer;
        }
        public static List<Tile> getCurrentList()
        {
            switch (currentLayer)
            {
                case ELayer.LOWER: return lower;
                case ELayer.MIDDLE: return middle;
                case ELayer.TOP: return top;
            }
            return null;
        }

        public void setGrid(int i) { selector.setGrid(i); }
    }
}
