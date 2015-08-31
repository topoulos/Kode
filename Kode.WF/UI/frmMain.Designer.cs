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
            this.tbVolume = new System.Windows.Forms.TrackBar();
            this.btnHdmi1 = new System.Windows.Forms.Button();
            this.btnHdmi2 = new System.Windows.Forms.Button();
            this.btnHdmi3 = new System.Windows.Forms.Button();
            this.btnHdmi4 = new System.Windows.Forms.Button();
            this.btnYamahaPower = new System.Windows.Forms.Button();
            this.btnOptions = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnVaux = new System.Windows.Forms.Button();
            this.btnLowerVolume = new System.Windows.Forms.Button();
            this.btnRaiseVolume = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tbVolume
            // 
            this.tbVolume.LargeChange = 50;
            this.tbVolume.Location = new System.Drawing.Point(12, 180);
            this.tbVolume.Maximum = 100;
            this.tbVolume.Name = "tbVolume";
            this.tbVolume.Size = new System.Drawing.Size(170, 45);
            this.tbVolume.SmallChange = 10;
            this.tbVolume.TabIndex = 6;
            this.tbVolume.TickFrequency = 10;
            this.tbVolume.Scroll += new System.EventHandler(this.tbVolume_Scroll);
            // 
            // btnHdmi1
            // 
            this.btnHdmi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHdmi1.Location = new System.Drawing.Point(295, 12);
            this.btnHdmi1.Name = "btnHdmi1";
            this.btnHdmi1.Size = new System.Drawing.Size(110, 25);
            this.btnHdmi1.TabIndex = 10;
            this.btnHdmi1.UseVisualStyleBackColor = true;
            this.btnHdmi1.Click += new System.EventHandler(this.btnHdmi1_Click);
            // 
            // btnHdmi2
            // 
            this.btnHdmi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHdmi2.Location = new System.Drawing.Point(295, 43);
            this.btnHdmi2.Name = "btnHdmi2";
            this.btnHdmi2.Size = new System.Drawing.Size(110, 25);
            this.btnHdmi2.TabIndex = 11;
            this.btnHdmi2.UseVisualStyleBackColor = true;
            this.btnHdmi2.Click += new System.EventHandler(this.btnHdmi2_Click);
            // 
            // btnHdmi3
            // 
            this.btnHdmi3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHdmi3.Location = new System.Drawing.Point(295, 74);
            this.btnHdmi3.Name = "btnHdmi3";
            this.btnHdmi3.Size = new System.Drawing.Size(110, 25);
            this.btnHdmi3.TabIndex = 12;
            this.btnHdmi3.UseVisualStyleBackColor = true;
            this.btnHdmi3.Click += new System.EventHandler(this.btnHdmi3_Click);
            // 
            // btnHdmi4
            // 
            this.btnHdmi4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHdmi4.Location = new System.Drawing.Point(295, 105);
            this.btnHdmi4.Name = "btnHdmi4";
            this.btnHdmi4.Size = new System.Drawing.Size(110, 25);
            this.btnHdmi4.TabIndex = 13;
            this.btnHdmi4.UseVisualStyleBackColor = true;
            this.btnHdmi4.Click += new System.EventHandler(this.btnHdmi4_Click);
            // 
            // btnYamahaPower
            // 
            this.btnYamahaPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYamahaPower.Image = global::Kode.WF.Properties.Resources.power__2_;
            this.btnYamahaPower.Location = new System.Drawing.Point(239, 12);
            this.btnYamahaPower.Name = "btnYamahaPower";
            this.btnYamahaPower.Size = new System.Drawing.Size(50, 50);
            this.btnYamahaPower.TabIndex = 9;
            this.btnYamahaPower.UseVisualStyleBackColor = true;
            this.btnYamahaPower.Click += new System.EventHandler(this.btnYamahaPower_Click);
            // 
            // btnOptions
            // 
            this.btnOptions.Image = global::Kode.WF.Properties.Resources.gear;
            this.btnOptions.Location = new System.Drawing.Point(411, 14);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(23, 23);
            this.btnOptions.TabIndex = 8;
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Image = global::Kode.WF.Properties.Resources.toolbar_home;
            this.btnHome.Location = new System.Drawing.Point(14, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(50, 50);
            this.btnHome.TabIndex = 7;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Image = global::Kode.WF.Properties.Resources.undo;
            this.btnBack.Location = new System.Drawing.Point(12, 124);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(50, 50);
            this.btnBack.TabIndex = 5;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Image = global::Kode.WF.Properties.Resources.circle;
            this.btnSelect.Location = new System.Drawing.Point(70, 68);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(50, 50);
            this.btnSelect.TabIndex = 4;
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnUp
            // 
            this.btnUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUp.Image = global::Kode.WF.Properties.Resources.up;
            this.btnUp.Location = new System.Drawing.Point(70, 12);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(50, 50);
            this.btnUp.TabIndex = 3;
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnRight
            // 
            this.btnRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRight.Image = global::Kode.WF.Properties.Resources.right;
            this.btnRight.Location = new System.Drawing.Point(126, 70);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(50, 50);
            this.btnRight.TabIndex = 2;
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnDown
            // 
            this.btnDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDown.Image = global::Kode.WF.Properties.Resources.down;
            this.btnDown.Location = new System.Drawing.Point(70, 124);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(50, 50);
            this.btnDown.TabIndex = 1;
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeft.Image = global::Kode.WF.Properties.Resources.back;
            this.btnLeft.Location = new System.Drawing.Point(14, 68);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(50, 50);
            this.btnLeft.TabIndex = 0;
            this.btnLeft.Text = "<";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kode.WF.Properties.Resources._300px_Side_by_side_dark_transparent;
            this.pictureBox1.Location = new System.Drawing.Point(14, 227);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Kode.WF.Properties.Resources.logo_yamaha4;
            this.pictureBox2.Location = new System.Drawing.Point(248, 227);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(162, 69);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // btnVaux
            // 
            this.btnVaux.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVaux.Location = new System.Drawing.Point(295, 136);
            this.btnVaux.Name = "btnVaux";
            this.btnVaux.Size = new System.Drawing.Size(110, 25);
            this.btnVaux.TabIndex = 17;
            this.btnVaux.UseVisualStyleBackColor = true;
            this.btnVaux.Click += new System.EventHandler(this.btnVaux_Click);
            // 
            // btnLowerVolume
            // 
            this.btnLowerVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLowerVolume.Image = global::Kode.WF.Properties.Resources.back;
            this.btnLowerVolume.Location = new System.Drawing.Point(295, 167);
            this.btnLowerVolume.Name = "btnLowerVolume";
            this.btnLowerVolume.Size = new System.Drawing.Size(51, 38);
            this.btnLowerVolume.TabIndex = 18;
            this.btnLowerVolume.UseVisualStyleBackColor = true;
            this.btnLowerVolume.Click += new System.EventHandler(this.btnLowerVolume_Click);
            // 
            // btnRaiseVolume
            // 
            this.btnRaiseVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaiseVolume.Image = global::Kode.WF.Properties.Resources.right;
            this.btnRaiseVolume.Location = new System.Drawing.Point(352, 167);
            this.btnRaiseVolume.Name = "btnRaiseVolume";
            this.btnRaiseVolume.Size = new System.Drawing.Size(51, 38);
            this.btnRaiseVolume.TabIndex = 19;
            this.btnRaiseVolume.UseVisualStyleBackColor = true;
            this.btnRaiseVolume.Click += new System.EventHandler(this.btnRaiseVolume_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(446, 308);
            this.Controls.Add(this.btnRaiseVolume);
            this.Controls.Add(this.btnLowerVolume);
            this.Controls.Add(this.btnVaux);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnHdmi4);
            this.Controls.Add(this.btnHdmi3);
            this.Controls.Add(this.btnHdmi2);
            this.Controls.Add(this.btnHdmi1);
            this.Controls.Add(this.btnYamahaPower);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.tbVolume);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmMain";
            this.Text = "Kode";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TrackBar tbVolume;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Button btnYamahaPower;
        private System.Windows.Forms.Button btnHdmi1;
        private System.Windows.Forms.Button btnHdmi2;
        private System.Windows.Forms.Button btnHdmi3;
        private System.Windows.Forms.Button btnHdmi4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnVaux;
        private System.Windows.Forms.Button btnLowerVolume;
        private System.Windows.Forms.Button btnRaiseVolume;
    }
}

