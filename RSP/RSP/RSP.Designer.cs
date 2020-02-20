namespace RSP
{
    partial class RSP
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.KNB = new System.Windows.Forms.Label();
            this.StopMusic = new System.Windows.Forms.Button();
            this.PlayMusic = new System.Windows.Forms.Button();
            this.PlayTheGame = new System.Windows.Forms.Button();
            this.Data = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.Help = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Svernut = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.KNB);
            this.panel1.Controls.Add(this.StopMusic);
            this.panel1.Controls.Add(this.Help);
            this.panel1.Controls.Add(this.PlayMusic);
            this.panel1.Controls.Add(this.PlayTheGame);
            this.panel1.Controls.Add(this.Data);
            this.panel1.Controls.Add(this.Time);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Location = new System.Drawing.Point(-4, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 411);
            this.panel1.TabIndex = 0;
            // 
            // KNB
            // 
            this.KNB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.KNB.BackColor = System.Drawing.Color.Transparent;
            this.KNB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KNB.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KNB.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.KNB.Location = new System.Drawing.Point(-1, 21);
            this.KNB.Name = "KNB";
            this.KNB.Size = new System.Drawing.Size(575, 64);
            this.KNB.TabIndex = 0;
            this.KNB.Text = "Камень, ножницы , бумага";
            this.KNB.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // StopMusic
            // 
            this.StopMusic.BackgroundImage = global::RSP.Properties.Resources.pause;
            this.StopMusic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.StopMusic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StopMusic.Location = new System.Drawing.Point(274, 367);
            this.StopMusic.Name = "StopMusic";
            this.StopMusic.Size = new System.Drawing.Size(27, 24);
            this.StopMusic.TabIndex = 7;
            this.StopMusic.UseVisualStyleBackColor = true;
            this.StopMusic.Click += new System.EventHandler(this.StopMusic_Click);
            // 
            // PlayMusic
            // 
            this.PlayMusic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayMusic.Location = new System.Drawing.Point(241, 367);
            this.PlayMusic.Name = "PlayMusic";
            this.PlayMusic.Size = new System.Drawing.Size(27, 24);
            this.PlayMusic.TabIndex = 6;
            this.PlayMusic.Text = "▶";
            this.PlayMusic.UseVisualStyleBackColor = true;
            this.PlayMusic.Click += new System.EventHandler(this.PlayMusic_Click);
            // 
            // PlayTheGame
            // 
            this.PlayTheGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayTheGame.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.PlayTheGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.PlayTheGame.Font = new System.Drawing.Font("Cambria", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayTheGame.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PlayTheGame.Location = new System.Drawing.Point(173, 225);
            this.PlayTheGame.Name = "PlayTheGame";
            this.PlayTheGame.Size = new System.Drawing.Size(230, 80);
            this.PlayTheGame.TabIndex = 5;
            this.PlayTheGame.TabStop = false;
            this.PlayTheGame.Text = "Играть";
            this.PlayTheGame.UseCompatibleTextRendering = true;
            this.PlayTheGame.UseVisualStyleBackColor = true;
            this.PlayTheGame.Click += new System.EventHandler(this.PlayTheGame_Click);
            // 
            // Data
            // 
            this.Data.AutoSize = true;
            this.Data.BackColor = System.Drawing.Color.Transparent;
            this.Data.Font = new System.Drawing.Font("PMingLiU-ExtB", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data.ForeColor = System.Drawing.Color.DarkRed;
            this.Data.Location = new System.Drawing.Point(3, 380);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(29, 13);
            this.Data.TabIndex = 4;
            this.Data.Text = "Data";
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.BackColor = System.Drawing.Color.Transparent;
            this.Time.Font = new System.Drawing.Font("PMingLiU-ExtB", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time.ForeColor = System.Drawing.Color.DarkRed;
            this.Time.Location = new System.Drawing.Point(3, 367);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(32, 13);
            this.Time.TabIndex = 3;
            this.Time.Text = "Time";
            // 
            // Help
            // 
            this.Help.AutoSize = true;
            this.Help.Cursor = System.Windows.Forms.Cursors.Help;
            this.Help.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Help.ForeColor = System.Drawing.Color.DarkRed;
            this.Help.Location = new System.Drawing.Point(453, 367);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(121, 26);
            this.Help.TabIndex = 1;
            this.Help.Text = "Правила игры.";
            this.Help.Click += new System.EventHandler(this.Help_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Svernut);
            this.panel2.Controls.Add(this.Exit);
            this.panel2.Location = new System.Drawing.Point(-22, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(596, 33);
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
            this.Svernut.Location = new System.Drawing.Point(554, 0);
            this.Svernut.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.Svernut.Name = "Svernut";
            this.Svernut.Size = new System.Drawing.Size(18, 21);
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
            this.Exit.Location = new System.Drawing.Point(571, 3);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(19, 19);
            this.Exit.TabIndex = 8;
            this.Exit.Text = "Х";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            this.Exit.MouseEnter += new System.EventHandler(this.Exit_MouseEnter);
            this.Exit.MouseLeave += new System.EventHandler(this.Exit_MouseLeave);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // RSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 402);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RSP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RSP";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Help;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label Data;
        private System.Windows.Forms.Label KNB;
        private System.Windows.Forms.Button PlayTheGame;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Svernut;
        private System.Windows.Forms.Label Exit;
        public System.Windows.Forms.Button StopMusic;
        public System.Windows.Forms.Button PlayMusic;
    }
}
