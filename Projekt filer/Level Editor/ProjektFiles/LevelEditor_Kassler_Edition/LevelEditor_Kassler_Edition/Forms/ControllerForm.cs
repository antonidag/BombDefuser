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
    public partial class ControllerForm : Form
    {
        String gameFile = "";
        Game1 game;
        public ControllerForm(Game1 game)
        {
            this.game = game;
            InitializeComponent();
            setLayer(ELayer.MIDDLE);
        }

        private void btnTop_Click(object sender, EventArgs e) { setLayer(ELayer.TOP); }
        private void btnMiddle_Click(object sender, EventArgs e) { setLayer(ELayer.MIDDLE); }
        private void btnLow_Click(object sender, EventArgs e) { setLayer(ELayer.LOWER); }

        public void setLayer(ELayer layer)
        {
            Game1.setLayer(layer);
            if(Game1.selector != null)
                Game1.selector.setSelected(null);
            switch(layer)
            {
                case ELayer.LOWER:
                    btnLow.BackColor = Color.Orange;
                    btnMiddle.BackColor = Color.LightSlateGray;
                    btnTop.BackColor = Color.LightSlateGray;
                    btnEnemy.Enabled = false;
                    btnProp.Enabled = false;
                    btnFan.Enabled = false;
                    break;
                case ELayer.MIDDLE:
                    btnLow.BackColor = Color.LightSlateGray;
                    btnMiddle.BackColor = Color.Orange;
                    btnTop.BackColor = Color.LightSlateGray;
                    btnEnemy.Enabled = true;
                    btnProp.Enabled = true;
                    btnFan.Enabled = true;
                    break;
                case ELayer.TOP:
                    btnLow.BackColor = Color.LightSlateGray;
                    btnMiddle.BackColor = Color.LightSlateGray;
                    btnTop.BackColor = Color.Orange;
                    btnEnemy.Enabled = false;
                    btnProp.Enabled = false;
                    btnFan.Enabled = false;
                    break;
            }
        }

        private void nrGrid_ValueChanged(object sender, EventArgs e)
        {
            game.setGrid((int)nrGrid.Value);
        }

        private void cbGrid_CheckedChanged(object sender, EventArgs e)
        {
            if(cbGrid.CheckState == CheckState.Checked)
            {
                nrGrid.Enabled = true;
                game.setGrid((int)nrGrid.Value);
            }
            else
            {
                nrGrid.Enabled = false;
                game.setGrid(1);
            }
        }

        private void btnTile_Click(object sender, EventArgs e)
        {
            game.addTile();
        }

        public void setSelected(bool b) { grpSelected.Enabled = b; }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Game1.getCurrentList().Remove(Game1.selector.getSelected());
            Game1.selector.setSelected(null);
        }

        private void btnProperties_Click(object sender, EventArgs e)
        {
            Tile selected = Game1.selector.getSelected();
            if (selected is EnemyTile)
            {
                MessageBox.Show("There is no property for enemys!");
                return;
            }
            else if (selected is PropTile)
            {
                PropTile prop = (PropTile)selected;
                PropForm pform = new PropForm(game, prop);
                pform.Show();
                return;
            }
            else if (selected is FanTile)
            {
                FanTile fan = (FanTile)selected;
                FanForm fanForm = new FanForm(game, fan);
                fanForm.Show();
                return;
            }
            PropertyForm form = new PropertyForm(game, selected);
            form.Show();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            SaveAlgorithm.SaveToFile(game, gameFile + @"\../temp.bdmap");

            string strCmdText = "/c cd " + gameFile + @"\..";

            String[] splits = gameFile.Split('\\');
            int arg = splits.Length - 1;
            strCmdText += " & java -jar " + splits[arg] + " Debug";
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFile.Filter = "BombDefuser Map (*.bdmap)|*.bdmap";
            DialogResult result = saveFile.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                if (saveFile.FileName != "")
                {
                    SaveAlgorithm.SaveToFile(game, saveFile.FileName);
                    MessageBox.Show("Saved!");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fileDialog.Filter = "BombDefuser Jar (*.jar)|*.jar";
            DialogResult result = fileDialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                gameFile = fileDialog.FileName;
                if(gameFile != "")
                    btnPlay.Enabled = true;
            }
        }

        private void btnEnemy_Click(object sender, EventArgs e)
        {
            game.addEnemy();
        }

        private void btnProp_Click(object sender, EventArgs e)
        {
            game.addProp();
        }

        private void btnFan_Click(object sender, EventArgs e)
        {
            game.addFan();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to create new map?\rMake sure to save your current map, or it will be lost :(", "Warning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                game.loadNew();
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            fileDialog.Filter = "BombDefuser Map (*.bdmap)|*.bdmap";
            DialogResult result = fileDialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                if (fileDialog.FileName != "")
                    LoadAlgorithm.Load(game, fileDialog.FileName);
            }
        }
    }
}
