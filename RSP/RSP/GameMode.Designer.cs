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
            this.panel1 = new System.Windows.Forms.Panel();
            this.PlayMusic = new System.Windows.Forms.Button();
            this.StopMusic = new System.Windows.Forms.Button();
            this.Scissors = new System.Windows.Forms.Button();
            this.Paper = new System.Windows.Forms.Button();
            this.Rock = new System.Windows.Forms.Button();
            this.HelpGM = new System.Windows.Forms.Label();
            this.DataGM = new System.Windows.Forms.Label();
            this.TimeGM = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SvernutGM = new System.Windows.Forms.Label();
            this.ExitGM = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BackgroundImage = global::RSP.Properties.Resources.каменная_стена;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.PlayMusic);
            this.panel1.Controls.Add(this.StopMusic);
            this.panel1.Controls.Add(this.Scissors);
            this.panel1.Controls.Add(this.Paper);
            this.panel1.Controls.Add(this.Rock);
            this.panel1.Controls.Add(this.HelpGM);
            this.panel1.Controls.Add(this.DataGM);
            this.panel1.Controls.Add(this.TimeGM);
            this.panel1.Location = new System.Drawing.Point(-3, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(817, 504);
            this.panel1.TabIndex = 0;
            // 
            // PlayMusic
            // 
            this.PlayMusic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayMusic.Location = new System.Drawing.Point(369, 408);
            this.PlayMusic.Name = "PlayMusic";
            this.PlayMusic.Size = new System.Drawing.Size(27, 24);
            this.PlayMusic.TabIndex = 9;
            this.PlayMusic.Text = "▶";
            this.PlayMusic.UseVisualStyleBackColor = true;
            this.PlayMusic.Click += new System.EventHandler(this.PlayMusic_Click);
            // 
            // StopMusic
            // 
            this.StopMusic.BackgroundImage = global::RSP.Properties.Resources.pause;
            this.StopMusic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.StopMusic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StopMusic.Location = new System.Drawing.Point(402, 408);
            this.StopMusic.Name = "StopMusic";
            this.StopMusic.Size = new System.Drawing.Size(27, 24);
            this.StopMusic.TabIndex = 8;
            this.StopMusic.UseVisualStyleBackColor = true;
            this.StopMusic.Click += new System.EventHandler(this.StopMusic_Click);
            // 
            // Scissors
            // 
            this.Scissors.Location = new System.Drawing.Point(15, 201);
            this.Scissors.Name = "Scissors";
            this.Scissors.Size = new System.Drawing.Size(75, 23);
            this.Scissors.TabIndex = 5;
            this.Scissors.Text = "Ножницы";
            this.Scissors.UseVisualStyleBackColor = true;
            // 
            // Paper
            // 
            this.Paper.Location = new System.Drawing.Point(15, 230);
            this.Paper.Name = "Paper";
            this.Paper.Size = new System.Drawing.Size(75, 23);
            this.Paper.TabIndex = 4;
            this.Paper.Text = "Бумага";
            this.Paper.UseVisualStyleBackColor = true;
            // 
            // Rock
            // 
            this.Rock.Location = new System.Drawing.Point(15, 172);
            this.Rock.Name = "Rock";
            this.Rock.Size = new System.Drawing.Size(75, 23);
            this.Rock.TabIndex = 3;
            this.Rock.Text = "Камень";
            this.Rock.UseVisualStyleBackColor = true;
            // 
            // HelpGM
            // 
            this.HelpGM.AutoSize = true;
            this.HelpGM.BackColor = System.Drawing.Color.Transparent;
            this.HelpGM.Cursor = System.Windows.Forms.Cursors.Help;
            this.HelpGM.Font = new System.Drawing.Font("PMingLiU-ExtB", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpGM.ForeColor = System.Drawing.Color.Red;
            this.HelpGM.Location = new System.Drawing.Point(678, 408);
            this.HelpGM.Name = "HelpGM";
            this.HelpGM.Size = new System.Drawing.Size(118, 21);
            this.HelpGM.TabIndex = 2;
            this.HelpGM.Text = "Правила игры";
            this.HelpGM.Click += new System.EventHandler(this.HelpGM_Click);
            // 
            // DataGM
            // 
            this.DataGM.AutoSize = true;
            this.DataGM.BackColor = System.Drawing.Color.Transparent;
            this.DataGM.Font = new System.Drawing.Font("PMingLiU-ExtB", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGM.ForeColor = System.Drawing.Color.Red;
            this.DataGM.Location = new System.Drawing.Point(15, 414);
            this.DataGM.Name = "DataGM";
            this.DataGM.Size = new System.Drawing.Size(33, 15);
            this.DataGM.TabIndex = 1;
            this.DataGM.Text = "Data";
            // 
            // TimeGM
            // 
            this.TimeGM.AutoSize = true;
            this.TimeGM.BackColor = System.Drawing.Color.Transparent;
            this.TimeGM.Font = new System.Drawing.Font("PMingLiU-ExtB", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeGM.ForeColor = System.Drawing.Color.Red;
            this.TimeGM.Location = new System.Drawing.Point(15, 397);
            this.TimeGM.Name = "TimeGM";
            this.TimeGM.Size = new System.Drawing.Size(37, 15);
            this.TimeGM.TabIndex = 0;
            this.TimeGM.Text = "Time";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.SvernutGM);
            this.panel2.Controls.Add(this.ExitGM);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(802, 22);
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
            this.SvernutGM.Location = new System.Drawing.Point(748, 1);
            this.SvernutGM.Name = "SvernutGM";
            this.SvernutGM.Size = new System.Drawing.Size(18, 21);
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
            this.ExitGM.Location = new System.Drawing.Point(774, 3);
            this.ExitGM.Name = "ExitGM";
            this.ExitGM.Size = new System.Drawing.Size(19, 19);
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
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(279, 66);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(93, 90);
            this.panel3.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.ForeColor = System.Drawing.SystemColors.Control;
            this.panel4.Location = new System.Drawing.Point(430, 66);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(93, 90);
            this.panel4.TabIndex = 10;
            // 
            // GameMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameMode";
            this.Text = "GameMode";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label ExitGM;
        private System.Windows.Forms.Label SvernutGM;
        private System.Windows.Forms.Label DataGM;
        private System.Windows.Forms.Label TimeGM;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label HelpGM;
        private System.Windows.Forms.Button Scissors;
        private System.Windows.Forms.Button Paper;
        private System.Windows.Forms.Button Rock;
        public System.Windows.Forms.Button StopMusic;
        public System.Windows.Forms.Button PlayMusic;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
    }
}