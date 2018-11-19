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
    public partial class FanForm : Form
    {
        Game1 game;
        FanTile tile;
        public FanForm(Game1 game, FanTile tile)
        {
            InitializeComponent();
            this.game = game;
            this.tile = tile;
            switch (tile.getDirection())
            {
                case EDirection.UP:
                case EDirection.DOWN:
                    nrAmount.Value = tile.getRecHit().Width / 50;
                    break;
                case EDirection.LEFT:
                case EDirection.RIGHT:
                    nrAmount.Value = tile.getRecHit().Height / 50;
                    break;
            }
            nrPower.Value = tile.getPower();
            nrTime.Value = tile.getTime();
            setDirection(tile.getDirection());
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUp_Click(object sender, EventArgs e){ setDirection(EDirection.UP); }
        private void btnDown_Click(object sender, EventArgs e) { setDirection(EDirection.DOWN); }
        private void btnLeft_Click(object sender, EventArgs e) { setDirection(EDirection.LEFT); }
        private void btnRight_Click(object sender, EventArgs e) { setDirection(EDirection.RIGHT); }

        public void setDirection(EDirection direction)
        {
            tile.setRectangle((int)nrAmount.Value, direction);
            switch (direction)
            {
                case EDirection.UP:
                    btnUp.BackColor = Color.Orange;
                    btnDown.BackColor = Color.LightSlateGray;
                    btnLeft.BackColor = Color.LightSlateGray;
                    btnRight.BackColor = Color.LightSlateGray;
                    break;
                case EDirection.LEFT:
                    btnUp.BackColor = Color.LightSlateGray;
                    btnDown.BackColor = Color.LightSlateGray;
                    btnLeft.BackColor = Color.Orange;
                    btnRight.BackColor = Color.LightSlateGray;
                    break;
                case EDirection.RIGHT:
                    btnUp.BackColor = Color.LightSlateGray;
                    btnDown.BackColor = Color.LightSlateGray;
                    btnLeft.BackColor = Color.LightSlateGray;
                    btnRight.BackColor = Color.Orange;
                    break;
                case EDirection.DOWN:
                    btnUp.BackColor = Color.LightSlateGray;
                    btnDown.BackColor = Color.Orange;
                    btnLeft.BackColor = Color.LightSlateGray;
                    btnRight.BackColor = Color.LightSlateGray;
                    break;
                default:
                    break;
            }
        }

        private void nrAmount_ValueChanged(object sender, EventArgs e)
        {
            tile.setRectangle((int)nrAmount.Value, tile.getDirection());
        }

        private void nrTime_ValueChanged(object sender, EventArgs e)
        {
            tile.setTime((int)nrTime.Value);
        }

        private void nrPower_ValueChanged(object sender, EventArgs e)
        {
            tile.setPower((int)nrPower.Value);
        }
    }
}
