namespace Kode.WF
{
    partial class frmMain
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
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripLabel();
            this.tsBtnDropDown = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPlayPause = new System.Windows.Forms.Button();
            this.lblYamahaVolume = new System.Windows.Forms.Label();
            this.tbYamahaVolume = new System.Windows.Forms.TrackBar();
            this.btnVaux = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnHdmi4 = new System.Windows.Forms.Button();
            this.btnHdmi3 = new System.Windows.Forms.Button();
            this.btnHdmi2 = new System.Windows.Forms.Button();
            this.btnHdmi1 = new System.Windows.Forms.Button();
            this.btnYamahaPower = new System.Windows.Forms.Button();
            this.btnOptions = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.tbKodiVolume = new System.Windows.Forms.TrackBar();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tsSpaceLabel = new System.Windows.Forms.ToolStripLabel();
            this.tsMain.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbYamahaVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbKodiVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tsMain
            // 
            this.tsMain.AutoSize = false;
            this.tsMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tsMain.Dock = System.Windows.Forms.DockStyle.None;
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripLabel1,
            this.tsSpaceLabel,
            this.toolStripButton2,
            this.toolStripTextBox1,
            this.tsBtnDropDown});
            this.tsMain.Location = new System.Drawing.Point(0, 0);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(442, 21);
            this.tsMain.TabIndex = 21;
            this.tsMain.Text = "toolStrip1";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::Kode.WF.Properties.Resources.arrow_move;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 18);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(58, 18);
            this.toolStripLabel1.Text = "Kode v1.0";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::Kode.WF.Properties.Resources.close;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 18);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripTextBox1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(0, 18);
            // 
            // tsBtnDropDown
            // 
            this.tsBtnDropDown.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsBtnDropDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnDropDown.Image = global::Kode.WF.Properties.Resources.down;
            this.tsBtnDropDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnDropDown.Name = "tsBtnDropDown";
            this.tsBtnDropDown.Size = new System.Drawing.Size(23, 18);
            this.tsBtnDropDown.Text = "toolStripButton1";
            this.tsBtnDropDown.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.btnPlayPause);
            this.panel1.Controls.Add(this.lblYamahaVolume);
            this.panel1.Controls.Add(this.tbYamahaVolume);
            this.panel1.Controls.Add(this.btnVaux);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnHdmi4);
            this.panel1.Controls.Add(this.btnHdmi3);
            this.panel1.Controls.Add(this.btnHdmi2);
            this.panel1.Controls.Add(this.btnHdmi1);
            this.panel1.Controls.Add(this.btnYamahaPower);
            this.panel1.Controls.Add(this.btnOptions);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.tbKodiVolume);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnSelect);
            this.panel1.Controls.Add(this.btnUp);
            this.panel1.Controls.Add(this.btnRight);
            this.panel1.Controls.Add(this.btnDown);
            this.panel1.Controls.Add(this.btnLeft);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(4, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 320);
            this.panel1.TabIndex = 22;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnPlayPause
            // 
            this.btnPlayPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayPause.Image = global::Kode.WF.Properties.Resources.media_play_pause_resume__1_;
            this.btnPlayPause.Location = new System.Drawing.Point(124, 17);
            this.btnPlayPause.Name = "btnPlayPause";
            this.btnPlayPause.Size = new System.Drawing.Size(50, 50);
            this.btnPlayPause.TabIndex = 40;
            this.btnPlayPause.UseVisualStyleBackColor = true;
            this.btnPlayPause.Click += new System.EventHandler(this.btnPlayPause_Click_1);
            // 
            // lblYamahaVolume
            // 
            this.lblYamahaVolume.AutoSize = true;
            this.lblYamahaVolume.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblYamahaVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYamahaVolume.ForeColor = System.Drawing.Color.Coral;
            this.lblYamahaVolume.Location = new System.Drawing.Point(357, 213);
            this.lblYamahaVolume.Name = "lblYamahaVolume";
            this.lblYamahaVolume.Size = new System.Drawing.Size(46, 17);
            this.lblYamahaVolume.TabIndex = 39;
            this.lblYamahaVolume.Text = "label1";
            // 
            // tbYamahaVolume
            // 
            this.tbYamahaVolume.LargeChange = 10;
            this.tbYamahaVolume.Location = new System.Drawing.Point(246, 181);
            this.tbYamahaVolume.Maximum = 5;
            this.tbYamahaVolume.Minimum = -80;
            this.tbYamahaVolume.Name = "tbYamahaVolume";
            this.tbYamahaVolume.Size = new System.Drawing.Size(170, 45);
            this.tbYamahaVolume.SmallChange = 5;
            this.tbYamahaVolume.TabIndex = 38;
            this.tbYamahaVolume.TickFrequency = 10;
            this.tbYamahaVolume.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tbYamahaVolume_MouseUp);
            // 
            // btnVaux
            // 
            this.btnVaux.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVaux.Location = new System.Drawing.Point(293, 141);
            this.btnVaux.Name = "btnVaux";
            this.btnVaux.Size = new System.Drawing.Size(110, 25);
            this.btnVaux.TabIndex = 37;
            this.btnVaux.UseVisualStyleBackColor = true;
            this.btnVaux.Click += new System.EventHandler(this.btnVaux_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Kode.WF.Properties.Resources.logo_yamaha4;
            this.pictureBox2.Location = new System.Drawing.Point(246, 232);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(162, 69);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            // 
            // btnHdmi4
            // 
            this.btnHdmi4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHdmi4.Location = new System.Drawing.Point(293, 110);
            this.btnHdmi4.Name = "btnHdmi4";
            this.btnHdmi4.Size = new System.Drawing.Size(110, 25);
            this.btnHdmi4.TabIndex = 34;
            this.btnHdmi4.UseVisualStyleBackColor = true;
            this.btnHdmi4.Click += new System.EventHandler(this.btnHdmi4_Click);
            // 
            // btnHdmi3
            // 
            this.btnHdmi3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHdmi3.Location = new System.Drawing.Point(293, 79);
            this.btnHdmi3.Name = "btnHdmi3";
            this.btnHdmi3.Size = new System.Drawing.Size(110, 25);
            this.btnHdmi3.TabIndex = 33;
            this.btnHdmi3.UseVisualStyleBackColor = true;
            this.btnHdmi3.Click += new System.EventHandler(this.btnHdmi3_Click);
            // 
            // btnHdmi2
            // 
            this.btnHdmi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHdmi2.Location = new System.Drawing.Point(293, 48);
            this.btnHdmi2.Name = "btnHdmi2";
            this.btnHdmi2.Size = new System.Drawing.Size(110, 25);
            this.btnHdmi2.TabIndex = 32;
            this.btnHdmi2.UseVisualStyleBackColor = true;
            this.btnHdmi2.Click += new System.EventHandler(this.btnHdmi2_Click);
            // 
            // btnHdmi1
            // 
            this.btnHdmi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHdmi1.Location = new System.Drawing.Point(293, 17);
            this.btnHdmi1.Name = "btnHdmi1";
            this.btnHdmi1.Size = new System.Drawing.Size(110, 25);
            this.btnHdmi1.TabIndex = 31;
            this.btnHdmi1.UseVisualStyleBackColor = true;
            this.btnHdmi1.Click += new System.EventHandler(this.btnHdmi1_Click);
            // 
            // btnYamahaPower
            // 
            this.btnYamahaPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYamahaPower.Image = global::Kode.WF.Properties.Resources.power__2_;
            this.btnYamahaPower.Location = new System.Drawing.Point(237, 17);
            this.btnYamahaPower.Name = "btnYamahaPower";
            this.btnYamahaPower.Size = new System.Drawing.Size(50, 50);
            this.btnYamahaPower.TabIndex = 30;
            this.btnYamahaPower.UseVisualStyleBackColor = true;
            this.btnYamahaPower.Click += new System.EventHandler(this.btnYamahaPower_Click);
            // 
            // btnOptions
            // 
            this.btnOptions.Image = global::Kode.WF.Properties.Resources.gear;
            this.btnOptions.Location = new System.Drawing.Point(409, 19);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(23, 23);
            this.btnOptions.TabIndex = 29;
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Image = global::Kode.WF.Properties.Resources.toolbar_home;
            this.btnHome.Location = new System.Drawing.Point(12, 17);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(50, 50);
            this.btnHome.TabIndex = 28;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // tbKodiVolume
            // 
            this.tbKodiVolume.LargeChange = 50;
            this.tbKodiVolume.Location = new System.Drawing.Point(10, 185);
            this.tbKodiVolume.Maximum = 100;
            this.tbKodiVolume.Name = "tbKodiVolume";
            this.tbKodiVolume.Size = new System.Drawing.Size(170, 45);
            this.tbKodiVolume.SmallChange = 10;
            this.tbKodiVolume.TabIndex = 27;
            this.tbKodiVolume.TickFrequency = 10;
            this.tbKodiVolume.Scroll += new System.EventHandler(this.tbKodiVolume_Scroll);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Image = global::Kode.WF.Properties.Resources.undo;
            this.btnBack.Location = new System.Drawing.Point(10, 129);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(50, 50);
            this.btnBack.TabIndex = 26;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Image = global::Kode.WF.Properties.Resources.circle;
            this.btnSelect.Location = new System.Drawing.Point(68, 73);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(50, 50);
            this.btnSelect.TabIndex = 25;
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnUp
            // 
            this.btnUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUp.Image = global::Kode.WF.Properties.Resources.up;
            this.btnUp.Location = new System.Drawing.Point(68, 17);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(50, 50);
            this.btnUp.TabIndex = 24;
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnRight
            // 
            this.btnRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRight.Image = global::Kode.WF.Properties.Resources.right;
            this.btnRight.Location = new System.Drawing.Point(124, 73);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(50, 50);
            this.btnRight.TabIndex = 23;
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnDown
            // 
            this.btnDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDown.Image = global::Kode.WF.Properties.Resources.down;
            this.btnDown.Location = new System.Drawing.Point(68, 129);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(50, 50);
            this.btnDown.TabIndex = 22;
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeft.Image = global::Kode.WF.Properties.Resources.back;
            this.btnLeft.Location = new System.Drawing.Point(12, 73);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(50, 50);
            this.btnLeft.TabIndex = 21;
            this.btnLeft.Text = "<";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kode.WF.Properties.Resources._300px_Side_by_side_dark_transparent;
            this.pictureBox1.Location = new System.Drawing.Point(12, 232);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // tsSpaceLabel
            // 
            this.tsSpaceLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tsSpaceLabel.Name = "tsSpaceLabel";
            this.tsSpaceLabel.Size = new System.Drawing.Size(287, 18);
            this.tsSpaceLabel.Text = "===================================";
            this.tsSpaceLabel.Click += new System.EventHandler(this.toolStripLabel2_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(446, 348);
            this.Controls.Add(this.tsMain);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Kode";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbYamahaVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbKodiVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton tsBtnDropDown;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripLabel toolStripTextBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPlayPause;
        private System.Windows.Forms.Label lblYamahaVolume;
        private System.Windows.Forms.TrackBar tbYamahaVolume;
        private System.Windows.Forms.Button btnVaux;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnHdmi4;
        private System.Windows.Forms.Button btnHdmi3;
        private System.Windows.Forms.Button btnHdmi2;
        private System.Windows.Forms.Button btnHdmi1;
        private System.Windows.Forms.Button btnYamahaPower;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.TrackBar tbKodiVolume;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripLabel tsSpaceLabel;
    }
}

