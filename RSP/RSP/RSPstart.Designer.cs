namespace RSP
{
    partial class RSPstart
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Svernut = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PlayTheGame = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.StopMusic = new System.Windows.Forms.Button();
            this.Help = new System.Windows.Forms.Label();
            this.PlayMusic = new System.Windows.Forms.Button();
            this.Data = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BackgroundImage = global::RSP.Properties.Resources.каменная_стена1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.PlayTheGame);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.StopMusic);
            this.panel1.Controls.Add(this.Help);
            this.panel1.Controls.Add(this.PlayMusic);
            this.panel1.Controls.Add(this.Data);
            this.panel1.Controls.Add(this.Time);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Location = new System.Drawing.Point(-5, -3);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 503);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Svernut);
            this.panel2.Controls.Add(this.Exit);
            this.panel2.Location = new System.Drawing.Point(-29, -4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(789, 30);
            this.panel2.TabIndex = 0;
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // Svernut
            // 
            this.Svernut.AutoSize = true;
            this.Svernut.BackColor = System.Drawing.Color.Transparent;
            this.Svernut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Svernut.Font = new System.Drawing.Font("PMingLiU-ExtB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Svernut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Svernut.Location = new System.Drawing.Point(739, 0);
            this.Svernut.Margin = new System.Windows.Forms.Padding(13, 0, 13, 0);
            this.Svernut.Name = "Svernut";
            this.Svernut.Size = new System.Drawing.Size(21, 27);
            this.Svernut.TabIndex = 8;
            this.Svernut.Text = "-";
            this.Svernut.Click += new System.EventHandler(this.Svernut_Click);
            this.Svernut.MouseEnter += new System.EventHandler(this.Svernut_MouseEnter);
            this.Svernut.MouseLeave += new System.EventHandler(this.Svernut_MouseLeave);
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Font = new System.Drawing.Font("PMingLiU-ExtB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(761, 4);
            this.Exit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(23, 24);
            this.Exit.TabIndex = 8;
            this.Exit.Text = "Х";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            this.Exit.MouseEnter += new System.EventHandler(this.Exit_MouseEnter);
            this.Exit.MouseLeave += new System.EventHandler(this.Exit_MouseLeave);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = global::RSP.Properties.Resources.FirstUser;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Location = new System.Drawing.Point(257, 128);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(235, 214);
            this.panel4.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::RSP.Properties.Resources.наим;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(-25, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(836, 175);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // PlayTheGame
            // 
            this.PlayTheGame.BackColor = System.Drawing.Color.Transparent;
            this.PlayTheGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayTheGame.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.PlayTheGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.PlayTheGame.Font = new System.Drawing.Font("Cambria", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayTheGame.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PlayTheGame.Location = new System.Drawing.Point(214, 349);
            this.PlayTheGame.Margin = new System.Windows.Forms.Padding(4);
            this.PlayTheGame.Name = "PlayTheGame";
            this.PlayTheGame.Size = new System.Drawing.Size(307, 98);
            this.PlayTheGame.TabIndex = 5;
            this.PlayTheGame.TabStop = false;
            this.PlayTheGame.Text = "Играть";
            this.PlayTheGame.UseCompatibleTextRendering = true;
            this.PlayTheGame.UseVisualStyleBackColor = false;
            this.PlayTheGame.Click += new System.EventHandler(this.PlayTheGame_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BackgroundImage = global::RSP.Properties.Resources.UFO;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel5.Location = new System.Drawing.Point(498, 162);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(274, 253);
            this.panel5.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = global::RSP.Properties.Resources.SecUser;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(-12, 162);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(306, 253);
            this.panel3.TabIndex = 8;
            // 
            // StopMusic
            // 
            this.StopMusic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.StopMusic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StopMusic.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StopMusic.Location = new System.Drawing.Point(355, 452);
            this.StopMusic.Margin = new System.Windows.Forms.Padding(4);
            this.StopMusic.Name = "StopMusic";
            this.StopMusic.Size = new System.Drawing.Size(36, 30);
            this.StopMusic.TabIndex = 7;
            this.StopMusic.Text = "II";
            this.StopMusic.UseVisualStyleBackColor = true;
            this.StopMusic.Click += new System.EventHandler(this.StopMusic_Click);
            // 
            // Help
            // 
            this.Help.AutoSize = true;
            this.Help.BackColor = System.Drawing.Color.Transparent;
            this.Help.Cursor = System.Windows.Forms.Cursors.Help;
            this.Help.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Help.ForeColor = System.Drawing.Color.Black;
            this.Help.Location = new System.Drawing.Point(604, 461);
            this.Help.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(156, 32);
            this.Help.TabIndex = 1;
            this.Help.Text = "Правила игры.";
            this.Help.Click += new System.EventHandler(this.Help_Click);
            // 
            // PlayMusic
            // 
            this.PlayMusic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayMusic.Location = new System.Drawing.Point(311, 452);
            this.PlayMusic.Margin = new System.Windows.Forms.Padding(4);
            this.PlayMusic.Name = "PlayMusic";
            this.PlayMusic.Size = new System.Drawing.Size(36, 30);
            this.PlayMusic.TabIndex = 6;
            this.PlayMusic.Text = "▶";
            this.PlayMusic.UseVisualStyleBackColor = true;
            this.PlayMusic.Click += new System.EventHandler(this.PlayMusic_Click);
            // 
            // Data
            // 
            this.Data.AutoSize = true;
            this.Data.BackColor = System.Drawing.Color.Transparent;
            this.Data.Font = new System.Drawing.Font("PMingLiU-ExtB", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data.ForeColor = System.Drawing.Color.Black;
            this.Data.Location = new System.Drawing.Point(4, 468);
            this.Data.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(38, 17);
            this.Data.TabIndex = 4;
            this.Data.Text = "Data";
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.BackColor = System.Drawing.Color.Transparent;
            this.Time.Font = new System.Drawing.Font("PMingLiU-ExtB", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time.ForeColor = System.Drawing.Color.Black;
            this.Time.Location = new System.Drawing.Point(4, 452);
            this.Time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(41, 17);
            this.Time.TabIndex = 3;
            this.Time.Text = "Time";
            // 
            // RSPstart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 495);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RSPstart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RSP";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Help;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label Data;
        private System.Windows.Forms.Button PlayTheGame;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Svernut;
        private System.Windows.Forms.Label Exit;
        public System.Windows.Forms.Button StopMusic;
        public System.Windows.Forms.Button PlayMusic;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
