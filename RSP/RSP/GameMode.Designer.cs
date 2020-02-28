namespace RSP
{
    partial class GameMode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameMode));
            this.panel2 = new System.Windows.Forms.Panel();
            this.SvernutGM = new System.Windows.Forms.Label();
            this.ExitGM = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.CompsAsk = new System.Windows.Forms.PictureBox();
            this.UsersAsk = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Поражений = new System.Windows.Forms.Label();
            this.L = new System.Windows.Forms.Label();
            this.D = new System.Windows.Forms.Label();
            this.Draw = new System.Windows.Forms.Label();
            this.W = new System.Windows.Forms.Label();
            this.Win = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.PlayMusic = new System.Windows.Forms.Button();
            this.StopMusic = new System.Windows.Forms.Button();
            this.Scissors = new System.Windows.Forms.Button();
            this.Paper = new System.Windows.Forms.Button();
            this.Rock = new System.Windows.Forms.Button();
            this.HelpGM = new System.Windows.Forms.Label();
            this.DataGM = new System.Windows.Forms.Label();
            this.TimeGM = new System.Windows.Forms.Label();
            this.CompsFrame = new System.Windows.Forms.PictureBox();
            this.UsersFrame = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompsAsk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersAsk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompsFrame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersFrame)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.SvernutGM);
            this.panel2.Controls.Add(this.ExitGM);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1069, 29);
            this.panel2.TabIndex = 0;
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // SvernutGM
            // 
            this.SvernutGM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SvernutGM.AutoSize = true;
            this.SvernutGM.BackColor = System.Drawing.Color.Transparent;
            this.SvernutGM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SvernutGM.Font = new System.Drawing.Font("PMingLiU-ExtB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SvernutGM.ForeColor = System.Drawing.Color.White;
            this.SvernutGM.Location = new System.Drawing.Point(997, 1);
            this.SvernutGM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SvernutGM.Name = "SvernutGM";
            this.SvernutGM.Size = new System.Drawing.Size(21, 27);
            this.SvernutGM.TabIndex = 0;
            this.SvernutGM.Text = "-";
            this.SvernutGM.Click += new System.EventHandler(this.SvernutGM_Click);
            this.SvernutGM.MouseEnter += new System.EventHandler(this.SvernutGM_MouseEnter);
            this.SvernutGM.MouseLeave += new System.EventHandler(this.SvernutGM_MouseLeave);
            // 
            // ExitGM
            // 
            this.ExitGM.AutoSize = true;
            this.ExitGM.BackColor = System.Drawing.Color.Transparent;
            this.ExitGM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitGM.Font = new System.Drawing.Font("PMingLiU-ExtB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitGM.ForeColor = System.Drawing.Color.White;
            this.ExitGM.Location = new System.Drawing.Point(1032, 4);
            this.ExitGM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ExitGM.Name = "ExitGM";
            this.ExitGM.Size = new System.Drawing.Size(23, 24);
            this.ExitGM.TabIndex = 0;
            this.ExitGM.Text = "Х\r\n";
            this.ExitGM.Click += new System.EventHandler(this.ExitGM_Click);
            this.ExitGM.MouseEnter += new System.EventHandler(this.ExitGM_MouseEnter);
            this.ExitGM.MouseLeave += new System.EventHandler(this.ExitGM_MouseLeave);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.CompsAsk);
            this.panel1.Controls.Add(this.UsersAsk);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Поражений);
            this.panel1.Controls.Add(this.L);
            this.panel1.Controls.Add(this.D);
            this.panel1.Controls.Add(this.Draw);
            this.panel1.Controls.Add(this.W);
            this.panel1.Controls.Add(this.Win);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.PlayMusic);
            this.panel1.Controls.Add(this.StopMusic);
            this.panel1.Controls.Add(this.Scissors);
            this.panel1.Controls.Add(this.Paper);
            this.panel1.Controls.Add(this.Rock);
            this.panel1.Controls.Add(this.HelpGM);
            this.panel1.Controls.Add(this.DataGM);
            this.panel1.Controls.Add(this.TimeGM);
            this.panel1.Controls.Add(this.CompsFrame);
            this.panel1.Controls.Add(this.UsersFrame);
            this.panel1.Location = new System.Drawing.Point(-13, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1083, 574);
            this.panel1.TabIndex = 0;
            // 
            // CompsAsk
            // 
            this.CompsAsk.Image = global::RSP.Properties.Resources.CompAsk1;
            this.CompsAsk.Location = new System.Drawing.Point(647, 197);
            this.CompsAsk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CompsAsk.Name = "CompsAsk";
            this.CompsAsk.Size = new System.Drawing.Size(159, 128);
            this.CompsAsk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CompsAsk.TabIndex = 13;
            this.CompsAsk.TabStop = false;
            // 
            // UsersAsk
            // 
            this.UsersAsk.ErrorImage = null;
            this.UsersAsk.Image = global::RSP.Properties.Resources.UserAsk1;
            this.UsersAsk.InitialImage = null;
            this.UsersAsk.Location = new System.Drawing.Point(365, 197);
            this.UsersAsk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UsersAsk.Name = "UsersAsk";
            this.UsersAsk.Size = new System.Drawing.Size(159, 128);
            this.UsersAsk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UsersAsk.TabIndex = 13;
            this.UsersAsk.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkRed;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(577, 134);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 31);
            this.label2.TabIndex = 11;
            this.label2.Text = "s Comp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkRed;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label1.Location = new System.Drawing.Point(480, 134);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "User v";
            // 
            // Поражений
            // 
            this.Поражений.AutoSize = true;
            this.Поражений.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Поражений.ForeColor = System.Drawing.Color.Red;
            this.Поражений.Location = new System.Drawing.Point(693, 423);
            this.Поражений.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Поражений.Name = "Поражений";
            this.Поражений.Size = new System.Drawing.Size(113, 40);
            this.Поражений.TabIndex = 12;
            this.Поражений.Text = "Losing:";
            // 
            // L
            // 
            this.L.AutoSize = true;
            this.L.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L.ForeColor = System.Drawing.Color.Red;
            this.L.Location = new System.Drawing.Point(803, 423);
            this.L.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.L.Name = "L";
            this.L.Size = new System.Drawing.Size(38, 40);
            this.L.TabIndex = 12;
            this.L.Text = "0";
            // 
            // D
            // 
            this.D.AutoSize = true;
            this.D.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D.ForeColor = System.Drawing.Color.Yellow;
            this.D.Location = new System.Drawing.Point(627, 423);
            this.D.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(38, 40);
            this.D.TabIndex = 12;
            this.D.Text = "0";
            // 
            // Draw
            // 
            this.Draw.AutoSize = true;
            this.Draw.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Draw.ForeColor = System.Drawing.Color.Yellow;
            this.Draw.Location = new System.Drawing.Point(523, 423);
            this.Draw.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Draw.Name = "Draw";
            this.Draw.Size = new System.Drawing.Size(111, 40);
            this.Draw.TabIndex = 12;
            this.Draw.Text = "Draws:";
            // 
            // W
            // 
            this.W.AutoSize = true;
            this.W.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.W.ForeColor = System.Drawing.Color.Lime;
            this.W.Location = new System.Drawing.Point(447, 423);
            this.W.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.W.Name = "W";
            this.W.Size = new System.Drawing.Size(38, 40);
            this.W.TabIndex = 12;
            this.W.Text = "0";
            // 
            // Win
            // 
            this.Win.AutoSize = true;
            this.Win.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Win.ForeColor = System.Drawing.Color.Lime;
            this.Win.Location = new System.Drawing.Point(313, 423);
            this.Win.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Win.Name = "Win";
            this.Win.Size = new System.Drawing.Size(137, 40);
            this.Win.TabIndex = 12;
            this.Win.Text = "Winning:";
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.ForeColor = System.Drawing.Color.Red;
            this.panel3.Location = new System.Drawing.Point(379, 22);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(124, 111);
            this.panel3.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.ForeColor = System.Drawing.SystemColors.Control;
            this.panel4.Location = new System.Drawing.Point(667, 22);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(124, 111);
            this.panel4.TabIndex = 10;
            // 
            // PlayMusic
            // 
            this.PlayMusic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayMusic.Location = new System.Drawing.Point(539, 501);
            this.PlayMusic.Margin = new System.Windows.Forms.Padding(4);
            this.PlayMusic.Name = "PlayMusic";
            this.PlayMusic.Size = new System.Drawing.Size(36, 30);
            this.PlayMusic.TabIndex = 9;
            this.PlayMusic.Text = "▶";
            this.PlayMusic.UseVisualStyleBackColor = true;
            this.PlayMusic.Click += new System.EventHandler(this.PlayMusic_Click);
            // 
            // StopMusic
            // 
            this.StopMusic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StopMusic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StopMusic.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StopMusic.Location = new System.Drawing.Point(583, 501);
            this.StopMusic.Margin = new System.Windows.Forms.Padding(4);
            this.StopMusic.Name = "StopMusic";
            this.StopMusic.Size = new System.Drawing.Size(35, 30);
            this.StopMusic.TabIndex = 8;
            this.StopMusic.Text = "II";
            this.StopMusic.UseVisualStyleBackColor = true;
            this.StopMusic.Click += new System.EventHandler(this.StopMusic_Click);
            // 
            // Scissors
            // 
            this.Scissors.Location = new System.Drawing.Point(24, 278);
            this.Scissors.Margin = new System.Windows.Forms.Padding(4);
            this.Scissors.Name = "Scissors";
            this.Scissors.Size = new System.Drawing.Size(100, 28);
            this.Scissors.TabIndex = 5;
            this.Scissors.Text = "Scissors";
            this.Scissors.UseVisualStyleBackColor = true;
            this.Scissors.Click += new System.EventHandler(this.Scissors_Click);
            // 
            // Paper
            // 
            this.Paper.Location = new System.Drawing.Point(24, 314);
            this.Paper.Margin = new System.Windows.Forms.Padding(4);
            this.Paper.Name = "Paper";
            this.Paper.Size = new System.Drawing.Size(100, 28);
            this.Paper.TabIndex = 4;
            this.Paper.Text = "Paper";
            this.Paper.UseVisualStyleBackColor = true;
            this.Paper.Click += new System.EventHandler(this.Paper_Click);
            // 
            // Rock
            // 
            this.Rock.Location = new System.Drawing.Point(24, 242);
            this.Rock.Margin = new System.Windows.Forms.Padding(4);
            this.Rock.Name = "Rock";
            this.Rock.Size = new System.Drawing.Size(100, 28);
            this.Rock.TabIndex = 3;
            this.Rock.Text = "Rock";
            this.Rock.UseVisualStyleBackColor = true;
            this.Rock.Click += new System.EventHandler(this.Rock_Click);
            // 
            // HelpGM
            // 
            this.HelpGM.AutoSize = true;
            this.HelpGM.BackColor = System.Drawing.Color.Transparent;
            this.HelpGM.Cursor = System.Windows.Forms.Cursors.Help;
            this.HelpGM.Font = new System.Drawing.Font("PMingLiU-ExtB", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpGM.ForeColor = System.Drawing.Color.Black;
            this.HelpGM.Location = new System.Drawing.Point(904, 502);
            this.HelpGM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HelpGM.Name = "HelpGM";
            this.HelpGM.Size = new System.Drawing.Size(152, 27);
            this.HelpGM.TabIndex = 2;
            this.HelpGM.Text = "Правила игры";
            this.HelpGM.Click += new System.EventHandler(this.HelpGM_Click);
            // 
            // DataGM
            // 
            this.DataGM.AutoSize = true;
            this.DataGM.BackColor = System.Drawing.Color.Transparent;
            this.DataGM.Font = new System.Drawing.Font("PMingLiU-ExtB", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGM.ForeColor = System.Drawing.Color.Black;
            this.DataGM.Location = new System.Drawing.Point(20, 513);
            this.DataGM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DataGM.Name = "DataGM";
            this.DataGM.Size = new System.Drawing.Size(43, 19);
            this.DataGM.TabIndex = 1;
            this.DataGM.Text = "Data";
            // 
            // TimeGM
            // 
            this.TimeGM.AutoSize = true;
            this.TimeGM.BackColor = System.Drawing.Color.Transparent;
            this.TimeGM.Font = new System.Drawing.Font("PMingLiU-ExtB", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeGM.ForeColor = System.Drawing.Color.Black;
            this.TimeGM.Location = new System.Drawing.Point(20, 495);
            this.TimeGM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TimeGM.Name = "TimeGM";
            this.TimeGM.Size = new System.Drawing.Size(47, 19);
            this.TimeGM.TabIndex = 0;
            this.TimeGM.Text = "Time";
            // 
            // CompsFrame
            // 
            this.CompsFrame.Image = ((System.Drawing.Image)(resources.GetObject("CompsFrame.Image")));
            this.CompsFrame.Location = new System.Drawing.Point(635, 185);
            this.CompsFrame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CompsFrame.Name = "CompsFrame";
            this.CompsFrame.Size = new System.Drawing.Size(181, 158);
            this.CompsFrame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CompsFrame.TabIndex = 14;
            this.CompsFrame.TabStop = false;
            // 
            // UsersFrame
            // 
            this.UsersFrame.Image = ((System.Drawing.Image)(resources.GetObject("UsersFrame.Image")));
            this.UsersFrame.Location = new System.Drawing.Point(355, 185);
            this.UsersFrame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UsersFrame.Name = "UsersFrame";
            this.UsersFrame.Size = new System.Drawing.Size(181, 158);
            this.UsersFrame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UsersFrame.TabIndex = 14;
            this.UsersFrame.TabStop = false;
            // 
            // GameMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GameMode";
            this.Text = "oi";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompsAsk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersAsk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompsFrame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersFrame)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label ExitGM;
        private System.Windows.Forms.Label SvernutGM;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label TimeGM;
        private System.Windows.Forms.Label DataGM;
        private System.Windows.Forms.Label HelpGM;
        public System.Windows.Forms.Button Rock;
        public System.Windows.Forms.Button Paper;
        public System.Windows.Forms.Button Scissors;
        public System.Windows.Forms.Button StopMusic;
        public System.Windows.Forms.Button PlayMusic;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Win;
        private System.Windows.Forms.Label Draw;
        private System.Windows.Forms.Label Поражений;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox UsersAsk;
        private System.Windows.Forms.PictureBox CompsAsk;
        private System.Windows.Forms.PictureBox CompsFrame;
        private System.Windows.Forms.PictureBox UsersFrame;
        public System.Windows.Forms.Label W;
        public System.Windows.Forms.Label D;
        public System.Windows.Forms.Label L;
    }
}