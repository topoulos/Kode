namespace Kode.WF
{
    partial class frmOptions
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKodiIP = new System.Windows.Forms.TextBox();
            this.txtKodiPort = new System.Windows.Forms.TextBox();
            this.txtYamahaIP = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kodi IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kodi Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yamaha IP";
            // 
            // txtKodiIP
            // 
            this.txtKodiIP.Location = new System.Drawing.Point(98, 32);
            this.txtKodiIP.Name = "txtKodiIP";
            this.txtKodiIP.Size = new System.Drawing.Size(133, 20);
            this.txtKodiIP.TabIndex = 3;
            this.txtKodiIP.Text = "txtKodiIP";
            // 
            // txtKodiPort
            // 
            this.txtKodiPort.Location = new System.Drawing.Point(98, 65);
            this.txtKodiPort.Name = "txtKodiPort";
            this.txtKodiPort.Size = new System.Drawing.Size(133, 20);
            this.txtKodiPort.TabIndex = 4;
            this.txtKodiPort.Text = "txtKodiPort";
            // 
            // txtYamahaIP
            // 
            this.txtYamahaIP.Location = new System.Drawing.Point(98, 97);
            this.txtYamahaIP.Name = "txtYamahaIP";
            this.txtYamahaIP.Size = new System.Drawing.Size(133, 20);
            this.txtYamahaIP.TabIndex = 5;
            this.txtYamahaIP.Text = "txtYamahaIP";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(149, 226);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtYamahaIP);
            this.Controls.Add(this.txtKodiPort);
            this.Controls.Add(this.txtKodiIP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmOptions";
            this.Text = "Options";
            this.Load += new System.EventHandler(this.frmOptions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKodiIP;
        private System.Windows.Forms.TextBox txtKodiPort;
        private System.Windows.Forms.TextBox txtYamahaIP;
        private System.Windows.Forms.Button btnSave;
    }
}