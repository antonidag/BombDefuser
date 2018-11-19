using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LevelEditor_Kassler_Edition
{
    public partial class PropertyForm : Form
    {
        Game1 game;
        Tile tile;
        ETextures defaultTexture;
        public PropertyForm(Game1 game, Tile tile)
        { 
            InitializeComponent();
            this.game = game;
            this.tile = tile;

            nrX.Value = tile.getRecHit().X;
            nrY.Value = tile.getRecHit().Y;
            nrWidth.Value = tile.getRecHit().Width;
            nrHeight.Value = tile.getRecHit().Height;

            cbType.Text = tile.getTextureType().ToString();
            defaultTexture = tile.getTextureType();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            tile.setTexture(defaultTexture);
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            tile.setRectangle((int)nrX.Value, (int)nrY.Value, (int)nrWidth.Value, (int)nrHeight.Value);
            Game1.selector.setDragRecs();
            this.Close();
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbType.Text)
            {
                case "GRAY": tile.setTexture(ETextures.GRAY);
                    break;
                case "RED": tile.setTexture(ETextures.RED);
                    break;
                case "GREEN": tile.setTexture(ETextures.GREEN);
                    break;
                case "HOUSE": tile.setTexture(ETextures.HOUSE);
                    break;
                case "HOUSE_BROKEN": tile.setTexture(ETextures.HOUSE_BROKEN);
                    break;
            }
        }
    }
}
