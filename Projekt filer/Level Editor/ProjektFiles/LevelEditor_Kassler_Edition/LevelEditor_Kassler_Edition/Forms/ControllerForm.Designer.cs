namespace LevelEditor_Kassler_Edition
{
    partial class ControllerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLow = new System.Windows.Forms.Button();
            this.btnMiddle = new System.Windows.Forms.Button();
            this.btnTop = new System.Windows.Forms.Button();
            this.cbGrid = new System.Windows.Forms.CheckBox();
            this.nrGrid = new System.Windows.Forms.NumericUpDown();
            this.btnTile = new System.Windows.Forms.Button();
            this.grpSelected = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnProperties = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.nrBomb = new System.Windows.Forms.NumericUpDown();
            this.btnEnemy = new System.Windows.Forms.Button();
            this.btnProp = new System.Windows.Forms.Button();
            this.btnFan = new System.Windows.Forms.Button();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nrGrid)).BeginInit();
            this.grpSelected.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrBomb)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLow
            // 
            this.btnLow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLow.Location = new System.Drawing.Point(6, 77);
            this.btnLow.Name = "btnLow";
            this.btnLow.Size = new System.Drawing.Size(138, 23);
            this.btnLow.TabIndex = 0;
            this.btnLow.Text = "Lower Layer";
            this.btnLow.UseVisualStyleBackColor = false;
            this.btnLow.Click += new System.EventHandler(this.btnLow_Click);
            // 
            // btnMiddle
            // 
            this.btnMiddle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnMiddle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMiddle.Location = new System.Drawing.Point(6, 48);
            this.btnMiddle.Name = "btnMiddle";
            this.btnMiddle.Size = new System.Drawing.Size(138, 23);
            this.btnMiddle.TabIndex = 1;
            this.btnMiddle.Text = "Collision Layer";
            this.btnMiddle.UseVisualStyleBackColor = false;
            this.btnMiddle.Click += new System.EventHandler(this.btnMiddle_Click);
            // 
            // btnTop
            // 
            this.btnTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTop.Location = new System.Drawing.Point(6, 19);
            this.btnTop.Name = "btnTop";
            this.btnTop.Size = new System.Drawing.Size(138, 23);
            this.btnTop.TabIndex = 2;
            this.btnTop.Text = "Top Layer";
            this.btnTop.UseVisualStyleBackColor = false;
            this.btnTop.Click += new System.EventHandler(this.btnTop_Click);
            // 
            // cbGrid
            // 
            this.cbGrid.AutoSize = true;
            this.cbGrid.Location = new System.Drawing.Point(11, 17);
            this.cbGrid.Name = "cbGrid";
            this.cbGrid.Size = new System.Drawing.Size(87, 17);
            this.cbGrid.TabIndex = 3;
            this.cbGrid.Text = "Grid Enabled";
            this.cbGrid.UseVisualStyleBackColor = true;
            this.cbGrid.CheckedChanged += new System.EventHandler(this.cbGrid_CheckedChanged);
            // 
            // nrGrid
            // 
            this.nrGrid.Enabled = false;
            this.nrGrid.Location = new System.Drawing.Point(11, 40);
            this.nrGrid.Name = "nrGrid";
            this.nrGrid.Size = new System.Drawing.Size(87, 20);
            this.nrGrid.TabIndex = 4;
            this.nrGrid.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nrGrid.ValueChanged += new System.EventHandler(this.nrGrid_ValueChanged);
            // 
            // btnTile
            // 
            this.btnTile.BackColor = System.Drawing.Color.Turquoise;
            this.btnTile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTile.Location = new System.Drawing.Point(6, 23);
            this.btnTile.Name = "btnTile";
            this.btnTile.Size = new System.Drawing.Size(138, 23);
            this.btnTile.TabIndex = 5;
            this.btnTile.Text = "Add Tile";
            this.btnTile.UseVisualStyleBackColor = false;
            this.btnTile.Click += new System.EventHandler(this.btnTile_Click);
            // 
            // grpSelected
            // 
            this.grpSelected.Controls.Add(this.btnProperties);
            this.grpSelected.Controls.Add(this.btnDelete);
            this.grpSelected.Enabled = false;
            this.grpSelected.Location = new System.Drawing.Point(5, 265);
            this.grpSelected.Name = "grpSelected";
            this.grpSelected.Size = new System.Drawing.Size(152, 81);
            this.grpSelected.TabIndex = 6;
            this.grpSelected.TabStop = false;
            this.grpSelected.Text = "Selected Tile";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Location = new System.Drawing.Point(5, 48);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(139, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnProperties
            // 
            this.btnProperties.BackColor = System.Drawing.Color.Cornsilk;
            this.btnProperties.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProperties.Location = new System.Drawing.Point(5, 19);
            this.btnProperties.Name = "btnProperties";
            this.btnProperties.Size = new System.Drawing.Size(139, 23);
            this.btnProperties.TabIndex = 7;
            this.btnProperties.Text = "Properties";
            this.btnProperties.UseVisualStyleBackColor = false;
            this.btnProperties.Click += new System.EventHandler(this.btnProperties_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTop);
            this.groupBox1.Controls.Add(this.btnLow);
            this.groupBox1.Controls.Add(this.btnMiddle);
            this.groupBox1.Location = new System.Drawing.Point(5, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(151, 109);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleced Layer";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nrGrid);
            this.groupBox2.Controls.Add(this.cbGrid);
            this.groupBox2.Location = new System.Drawing.Point(195, 399);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(113, 75);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grid";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.btnPlay);
            this.groupBox3.Location = new System.Drawing.Point(124, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(188, 107);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Debug";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(6, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 26);
            this.button1.TabIndex = 11;
            this.button1.Text = "Setup";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Lime;
            this.btnPlay.Enabled = false;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(6, 19);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(178, 50);
            this.btnPlay.TabIndex = 9;
            this.btnPlay.Text = "PLAY";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnNew);
            this.groupBox4.Controls.Add(this.btnLoad);
            this.groupBox4.Controls.Add(this.btnSave);
            this.groupBox4.Location = new System.Drawing.Point(11, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(107, 107);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Save and Load";
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNew.Location = new System.Drawing.Point(7, 75);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(94, 22);
            this.btnNew.TabIndex = 11;
            this.btnNew.Text = "New Map";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoad.Location = new System.Drawing.Point(7, 47);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(94, 22);
            this.btnLoad.TabIndex = 10;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Location = new System.Drawing.Point(7, 19);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 22);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = "INFO:\r\nJump Height = 110 ";
            // 
            // fileDialog
            // 
            this.fileDialog.FileName = "openFileDialog1";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.nrBomb);
            this.groupBox5.Location = new System.Drawing.Point(195, 344);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(113, 49);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Bomb Time";
            // 
            // nrBomb
            // 
            this.nrBomb.Location = new System.Drawing.Point(13, 19);
            this.nrBomb.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nrBomb.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nrBomb.Name = "nrBomb";
            this.nrBomb.Size = new System.Drawing.Size(85, 20);
            this.nrBomb.TabIndex = 0;
            this.nrBomb.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // btnEnemy
            // 
            this.btnEnemy.BackColor = System.Drawing.Color.Turquoise;
            this.btnEnemy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnemy.Location = new System.Drawing.Point(6, 52);
            this.btnEnemy.Name = "btnEnemy";
            this.btnEnemy.Size = new System.Drawing.Size(138, 23);
            this.btnEnemy.TabIndex = 13;
            this.btnEnemy.Text = "Add Enemy";
            this.btnEnemy.UseVisualStyleBackColor = false;
            this.btnEnemy.Click += new System.EventHandler(this.btnEnemy_Click);
            // 
            // btnProp
            // 
            this.btnProp.BackColor = System.Drawing.Color.Turquoise;
            this.btnProp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProp.Location = new System.Drawing.Point(6, 81);
            this.btnProp.Name = "btnProp";
            this.btnProp.Size = new System.Drawing.Size(138, 23);
            this.btnProp.TabIndex = 14;
            this.btnProp.Text = "Add Prop";
            this.btnProp.UseVisualStyleBackColor = false;
            this.btnProp.Click += new System.EventHandler(this.btnProp_Click);
            // 
            // btnFan
            // 
            this.btnFan.BackColor = System.Drawing.Color.Turquoise;
            this.btnFan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFan.Location = new System.Drawing.Point(6, 110);
            this.btnFan.Name = "btnFan";
            this.btnFan.Size = new System.Drawing.Size(138, 23);
            this.btnFan.TabIndex = 15;
            this.btnFan.Text = "Add Fan";
            this.btnFan.UseVisualStyleBackColor = false;
            this.btnFan.Click += new System.EventHandler(this.btnFan_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnTile);
            this.groupBox6.Controls.Add(this.btnFan);
            this.groupBox6.Controls.Add(this.btnEnemy);
            this.groupBox6.Controls.Add(this.btnProp);
            this.groupBox6.Location = new System.Drawing.Point(163, 150);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(149, 138);
            this.groupBox6.TabIndex = 16;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Add Objects";
            // 
            // ControllerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 493);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpSelected);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ControllerForm";
            this.ShowIcon = false;
            this.Text = "Tools and Settings";
            ((System.ComponentModel.ISupportInitialize)(this.nrGrid)).EndInit();
            this.grpSelected.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nrBomb)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLow;
        private System.Windows.Forms.Button btnMiddle;
        private System.Windows.Forms.Button btnTop;
        private System.Windows.Forms.CheckBox cbGrid;
        private System.Windows.Forms.NumericUpDown nrGrid;
        private System.Windows.Forms.Button btnTile;
        private System.Windows.Forms.Button btnProperties;
        public System.Windows.Forms.GroupBox grpSelected;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog fileDialog;
        private System.Windows.Forms.GroupBox groupBox5;
        public System.Windows.Forms.NumericUpDown nrBomb;
        private System.Windows.Forms.Button btnEnemy;
        private System.Windows.Forms.Button btnProp;
        private System.Windows.Forms.Button btnFan;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.GroupBox groupBox6;
    }
}