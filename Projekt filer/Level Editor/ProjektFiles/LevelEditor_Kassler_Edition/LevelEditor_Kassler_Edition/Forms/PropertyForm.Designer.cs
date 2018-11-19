namespace LevelEditor_Kassler_Edition
{
    partial class PropertyForm
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
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.nrX = new System.Windows.Forms.NumericUpDown();
            this.nrY = new System.Windows.Forms.NumericUpDown();
            this.nrWidth = new System.Windows.Forms.NumericUpDown();
            this.nrHeight = new System.Windows.Forms.NumericUpDown();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nrX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrHeight)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(37, 21);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(17, 13);
            this.lblX.TabIndex = 0;
            this.lblX.Text = "X:";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(37, 47);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(17, 13);
            this.lblY.TabIndex = 1;
            this.lblY.Text = "Y:";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(16, 73);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(38, 13);
            this.lblWidth.TabIndex = 2;
            this.lblWidth.Text = "Width:";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(13, 99);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(41, 13);
            this.lblHeight.TabIndex = 3;
            this.lblHeight.Text = "Height:";
            // 
            // nrX
            // 
            this.nrX.Location = new System.Drawing.Point(60, 19);
            this.nrX.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nrX.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.nrX.Name = "nrX";
            this.nrX.Size = new System.Drawing.Size(74, 20);
            this.nrX.TabIndex = 4;
            // 
            // nrY
            // 
            this.nrY.Location = new System.Drawing.Point(60, 45);
            this.nrY.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nrY.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.nrY.Name = "nrY";
            this.nrY.Size = new System.Drawing.Size(74, 20);
            this.nrY.TabIndex = 5;
            // 
            // nrWidth
            // 
            this.nrWidth.Location = new System.Drawing.Point(60, 71);
            this.nrWidth.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nrWidth.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.nrWidth.Name = "nrWidth";
            this.nrWidth.Size = new System.Drawing.Size(74, 20);
            this.nrWidth.TabIndex = 6;
            // 
            // nrHeight
            // 
            this.nrHeight.Location = new System.Drawing.Point(60, 97);
            this.nrHeight.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nrHeight.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.nrHeight.Name = "nrHeight";
            this.nrHeight.Size = new System.Drawing.Size(74, 20);
            this.nrHeight.TabIndex = 7;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Location = new System.Drawing.Point(163, 95);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Exit";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Location = new System.Drawing.Point(163, 66);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(134, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save and Exit";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nrX);
            this.groupBox1.Controls.Add(this.lblX);
            this.groupBox1.Controls.Add(this.lblY);
            this.groupBox1.Controls.Add(this.nrHeight);
            this.groupBox1.Controls.Add(this.lblWidth);
            this.groupBox1.Controls.Add(this.nrWidth);
            this.groupBox1.Controls.Add(this.lblHeight);
            this.groupBox1.Controls.Add(this.nrY);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(145, 124);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Size and position";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbType);
            this.groupBox2.Location = new System.Drawing.Point(163, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(134, 48);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Texture";
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "GRAY",
            "RED",
            "GREEN",
            "HOUSE",
            "HOUSE_BROKEN"});
            this.cbType.Location = new System.Drawing.Point(6, 19);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(119, 21);
            this.cbType.TabIndex = 0;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // PropertyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 141);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PropertyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tile Settings";
            ((System.ComponentModel.ISupportInitialize)(this.nrX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrHeight)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.NumericUpDown nrX;
        private System.Windows.Forms.NumericUpDown nrY;
        private System.Windows.Forms.NumericUpDown nrWidth;
        private System.Windows.Forms.NumericUpDown nrHeight;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbType;
    }
}