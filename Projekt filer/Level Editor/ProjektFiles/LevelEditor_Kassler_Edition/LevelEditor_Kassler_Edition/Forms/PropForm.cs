using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LevelEditor_Kassler_Edition
{
    public partial class PropForm : Form
    {
        Game1 game;
        PropTile tile;
        public PropForm(Game1 game, PropTile tile)
        {
            this.game = game;
            this.tile = tile;
            InitializeComponent();
        }

        private void PropForm_Load(object sender, EventArgs e)
        {
            MemoryStream mem = new MemoryStream();
            ResManager.props.SaveAsPng(mem, ResManager.props.Width, ResManager.props.Height);
            Image winFormsImage = Image.FromStream(mem);
            pictureBox1.Image = winFormsImage;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var mouseEventArgs = e as MouseEventArgs;
            if (mouseEventArgs != null)
            {
                int x = mouseEventArgs.X;
                int y = mouseEventArgs.Y;

                int xTex = x / 36;
                int yTex = y / 36;
                if (yTex == 1 && xTex >= 8)
                    return;

                tile.setPropTexture(xTex, yTex);
                this.Close();          
            }
            
        }
    }
}
