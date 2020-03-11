namespace RSP
{
    partial class TwoPlayers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TwoPlayers));
            this.panel2 = new System.Windows.Forms.Panel();
            this.SvernutTP = new System.Windows.Forms.Label();
            this.ExitTP = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.User2Ask = new System.Windows.Forms.PictureBox();
            this.User1Ask = new System.Windows.Forms.PictureBox();
            this.Поражений = new System.Windows.Forms.Label();
            this.L = new System.Windows.Forms.Label();
            this.D = new System.Windows.Forms.Label();
            this.Draw = new System.Windows.Forms.Label();
            this.W = new System.Windows.Forms.Label();
            this.Win = new System.Windows.Forms.Label();
            this.User1 = new System.Windows.Forms.Panel();
            this.User2 = new System.Windows.Forms.Panel();
            this.PlayMusicTP = new System.Windows.Forms.Button();
            this.StopMusicTP = new System.Windows.Forms.Button();
            this.ScissorsU2 = new System.Windows.Forms.Button();
            this.ScissorsU1 = new System.Windows.Forms.Button();
            this.PaperU2 = new System.Windows.Forms.Button();
            this.PaperU1 = new System.Windows.Forms.Button();
            this.RockU2 = new System.Windows.Forms.Button();
            this.RockU1 = new System.Windows.Forms.Button();
            this.HelpTP = new System.Windows.Forms.Label();
            this.DataTP = new System.Windows.Forms.Label();
            this.TimeTP = new System.Windows.Forms.Label();
            this.User2Frame = new System.Windows.Forms.PictureBox();
            this.User1Frame = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.User2Ask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.User1Ask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.User2Frame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.User1Frame)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.SvernutTP);
            this.panel2.Controls.Add(this.ExitTP);
            this.panel2.Location = new System.Drawing.Point(-6, -1);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1082, 29);
            this.panel2.TabIndex = 2;
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // SvernutTP
            // 
            this.SvernutTP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SvernutTP.AutoSize = true;
            this.SvernutTP.BackColor = System.Drawing.Color.Transparent;
            this.SvernutTP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SvernutTP.Font = new System.Drawing.Font("PMingLiU-ExtB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SvernutTP.ForeColor = System.Drawing.Color.White;
            this.SvernutTP.Location = new System.Drawing.Point(1027, 1);
            this.SvernutTP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SvernutTP.Name = "SvernutTP";
            this.SvernutTP.Size = new System.Drawing.Size(21, 27);
            this.SvernutTP.TabIndex = 0;
            this.SvernutTP.Text = "-";
            this.SvernutTP.Click += new System.EventHandler(this.SvernutTP_Click);
            this.SvernutTP.MouseEnter += new System.EventHandler(this.SvernutTP_MouseEnter);
            this.SvernutTP.MouseLeave += new System.EventHandler(this.SvernutTP_MouseLeave);
            // 
            // ExitTP
            // 
            this.ExitTP.AutoSize = true;
            this.ExitTP.BackColor = System.Drawing.Color.Transparent;
            this.ExitTP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitTP.Font = new System.Drawing.Font("PMingLiU-ExtB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitTP.ForeColor = System.Drawing.Color.White;
            this.ExitTP.Location = new System.Drawing.Point(1049, 4);
            this.ExitTP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ExitTP.Name = "ExitTP";
            this.ExitTP.Size = new System.Drawing.Size(23, 24);
            this.ExitTP.TabIndex = 0;
            this.ExitTP.Text = "Х\r\n";
            this.ExitTP.Click += new System.EventHandler(this.ExitTP_Click);
            this.ExitTP.MouseEnter += new System.EventHandler(this.ExitTP_MouseEnter);
            this.ExitTP.MouseHover += new System.EventHandler(this.ExitTP_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.User2Ask);
            this.panel1.Controls.Add(this.User1Ask);
            this.panel1.Controls.Add(this.Поражений);
            this.panel1.Controls.Add(this.L);
            this.panel1.Controls.Add(this.D);
            this.panel1.Controls.Add(this.Draw);
            this.panel1.Controls.Add(this.W);
            this.panel1.Controls.Add(this.Win);
            this.panel1.Controls.Add(this.User1);
            this.panel1.Controls.Add(this.User2);
            this.panel1.Controls.Add(this.PlayMusicTP);
            this.panel1.Controls.Add(this.StopMusicTP);
            this.panel1.Controls.Add(this.ScissorsU2);
            this.panel1.Controls.Add(this.ScissorsU1);
            this.panel1.Controls.Add(this.PaperU2);
            this.panel1.Controls.Add(this.PaperU1);
            this.panel1.Controls.Add(this.RockU2);
            this.panel1.Controls.Add(this.RockU1);
            this.panel1.Controls.Add(this.HelpTP);
            this.panel1.Controls.Add(this.DataTP);
            this.panel1.Controls.Add(this.TimeTP);
            this.panel1.Controls.Add(this.User2Frame);
            this.panel1.Controls.Add(this.User1Frame);
            this.panel1.Location = new System.Drawing.Point(-10, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1114, 582);
            this.panel1.TabIndex = 1;
            // 
            // User2Ask
            // 
            this.User2Ask.Image = global::RSP.Properties.Resources.CompAsk1;
            this.User2Ask.Location = new System.Drawing.Point(641, 194);
            this.User2Ask.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.User2Ask.Name = "User2Ask";
            this.User2Ask.Size = new System.Drawing.Size(161, 128);
            this.User2Ask.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.User2Ask.TabIndex = 13;
            this.User2Ask.TabStop = false;
            // 
            // User1Ask
            // 
            this.User1Ask.ErrorImage = null;
            this.User1Ask.Image = global::RSP.Properties.Resources.UserAsk1;
            this.User1Ask.InitialImage = null;
            this.User1Ask.Location = new System.Drawing.Point(361, 194);
            this.User1Ask.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.User1Ask.Name = "User1Ask";
            this.User1Ask.Size = new System.Drawing.Size(161, 126);
            this.User1Ask.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.User1Ask.TabIndex = 13;
            this.User1Ask.TabStop = false;
            // 
            // Поражений
            // 
            this.Поражений.AutoSize = true;
            this.Поражений.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Поражений.ForeColor = System.Drawing.Color.Red;
            this.Поражений.Location = new System.Drawing.Point(689, 418);
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
            this.L.Location = new System.Drawing.Point(799, 418);
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
            this.D.Location = new System.Drawing.Point(623, 418);
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
            this.Draw.Location = new System.Drawing.Point(519, 418);
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
            this.W.Location = new System.Drawing.Point(443, 418);
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
            this.Win.Location = new System.Drawing.Point(309, 418);
            this.Win.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Win.Name = "Win";
            this.Win.Size = new System.Drawing.Size(137, 40);
            this.Win.TabIndex = 12;
            this.Win.Text = "Winning:";
            // 
            // User1
            // 
            this.User1.AutoSize = true;
            this.User1.BackColor = System.Drawing.Color.Transparent;
            this.User1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("User1.BackgroundImage")));
            this.User1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.User1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.User1.ForeColor = System.Drawing.Color.Red;
            this.User1.Location = new System.Drawing.Point(375, 17);
            this.User1.Margin = new System.Windows.Forms.Padding(4);
            this.User1.Name = "User1";
            this.User1.Size = new System.Drawing.Size(124, 111);
            this.User1.TabIndex = 10;
            // 
            // User2
            // 
            this.User2.AutoSize = true;
            this.User2.BackColor = System.Drawing.Color.Transparent;
            this.User2.BackgroundImage = global::RSP.Properties.Resources.user21;
            this.User2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.User2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.User2.ForeColor = System.Drawing.SystemColors.Control;
            this.User2.Location = new System.Drawing.Point(663, 17);
            this.User2.Margin = new System.Windows.Forms.Padding(4);
            this.User2.Name = "User2";
            this.User2.Size = new System.Drawing.Size(124, 111);
            this.User2.TabIndex = 10;
            // 
            // PlayMusicTP
            // 
            this.PlayMusicTP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayMusicTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayMusicTP.Location = new System.Drawing.Point(543, 502);
            this.PlayMusicTP.Margin = new System.Windows.Forms.Padding(4);
            this.PlayMusicTP.Name = "PlayMusicTP";
            this.PlayMusicTP.Size = new System.Drawing.Size(36, 30);
            this.PlayMusicTP.TabIndex = 9;
            this.PlayMusicTP.Text = "▶";
            this.PlayMusicTP.UseVisualStyleBackColor = true;
            this.PlayMusicTP.Click += new System.EventHandler(this.PlayMusic_Click);
            // 
            // StopMusicTP
            // 
            this.StopMusicTP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StopMusicTP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StopMusicTP.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StopMusicTP.Location = new System.Drawing.Point(587, 502);
            this.StopMusicTP.Margin = new System.Windows.Forms.Padding(4);
            this.StopMusicTP.Name = "StopMusicTP";
            this.StopMusicTP.Size = new System.Drawing.Size(35, 30);
            this.StopMusicTP.TabIndex = 8;
            this.StopMusicTP.Text = "II";
            this.StopMusicTP.UseVisualStyleBackColor = true;
            this.StopMusicTP.Click += new System.EventHandler(this.StopMusic_Click);
            // 
            // ScissorsU2
            // 
            this.ScissorsU2.Location = new System.Drawing.Point(977, 273);
            this.ScissorsU2.Margin = new System.Windows.Forms.Padding(4);
            this.ScissorsU2.Name = "ScissorsU2";
            this.ScissorsU2.Size = new System.Drawing.Size(100, 28);
            this.ScissorsU2.TabIndex = 5;
            this.ScissorsU2.Text = "Scissors";
            this.ScissorsU2.UseVisualStyleBackColor = true;
            this.ScissorsU2.Click += new System.EventHandler(this.ScissorsU2_Click);
            // 
            // ScissorsU1
            // 
            this.ScissorsU1.Location = new System.Drawing.Point(20, 273);
            this.ScissorsU1.Margin = new System.Windows.Forms.Padding(4);
            this.ScissorsU1.Name = "ScissorsU1";
            this.ScissorsU1.Size = new System.Drawing.Size(100, 28);
            this.ScissorsU1.TabIndex = 5;
            this.ScissorsU1.Text = "Scissors";
            this.ScissorsU1.UseVisualStyleBackColor = true;
            this.ScissorsU1.Click += new System.EventHandler(this.ScissorsU1_Click);
            // 
            // PaperU2
            // 
            this.PaperU2.Location = new System.Drawing.Point(977, 309);
            this.PaperU2.Margin = new System.Windows.Forms.Padding(4);
            this.PaperU2.Name = "PaperU2";
            this.PaperU2.Size = new System.Drawing.Size(100, 28);
            this.PaperU2.TabIndex = 4;
            this.PaperU2.Text = "Paper";
            this.PaperU2.UseVisualStyleBackColor = true;
            this.PaperU2.Click += new System.EventHandler(this.PaperU2_Click);
            // 
            // PaperU1
            // 
            this.PaperU1.Location = new System.Drawing.Point(20, 309);
            this.PaperU1.Margin = new System.Windows.Forms.Padding(4);
            this.PaperU1.Name = "PaperU1";
            this.PaperU1.Size = new System.Drawing.Size(100, 28);
            this.PaperU1.TabIndex = 4;
            this.PaperU1.Text = "Paper";
            this.PaperU1.UseVisualStyleBackColor = true;
            this.PaperU1.Click += new System.EventHandler(this.PaperU1_Click);
            // 
            // RockU2
            // 
            this.RockU2.Location = new System.Drawing.Point(977, 237);
            this.RockU2.Margin = new System.Windows.Forms.Padding(4);
            this.RockU2.Name = "RockU2";
            this.RockU2.Size = new System.Drawing.Size(100, 28);
            this.RockU2.TabIndex = 3;
            this.RockU2.Text = "Rock";
            this.RockU2.UseVisualStyleBackColor = true;
            this.RockU2.Click += new System.EventHandler(this.RockU2_Click);
            // 
            // RockU1
            // 
            this.RockU1.Location = new System.Drawing.Point(20, 237);
            this.RockU1.Margin = new System.Windows.Forms.Padding(4);
            this.RockU1.Name = "RockU1";
            this.RockU1.Size = new System.Drawing.Size(100, 28);
            this.RockU1.TabIndex = 3;
            this.RockU1.Text = "Rock";
            this.RockU1.UseVisualStyleBackColor = true;
            this.RockU1.Click += new System.EventHandler(this.RockU1_Click);
            // 
            // HelpTP
            // 
            this.HelpTP.AutoSize = true;
            this.HelpTP.BackColor = System.Drawing.Color.Transparent;
            this.HelpTP.Cursor = System.Windows.Forms.Cursors.Help;
            this.HelpTP.Font = new System.Drawing.Font("PMingLiU-ExtB", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpTP.ForeColor = System.Drawing.Color.Black;
            this.HelpTP.Location = new System.Drawing.Point(934, 496);
            this.HelpTP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HelpTP.Name = "HelpTP";
            this.HelpTP.Size = new System.Drawing.Size(143, 27);
            this.HelpTP.TabIndex = 2;
            this.HelpTP.Text = "Game\'s rules";
            this.HelpTP.Click += new System.EventHandler(this.HelpGM_Click);
            // 
            // DataTP
            // 
            this.DataTP.AutoSize = true;
            this.DataTP.BackColor = System.Drawing.Color.Transparent;
            this.DataTP.Font = new System.Drawing.Font("PMingLiU-ExtB", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataTP.ForeColor = System.Drawing.Color.Black;
            this.DataTP.Location = new System.Drawing.Point(24, 514);
            this.DataTP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DataTP.Name = "DataTP";
            this.DataTP.Size = new System.Drawing.Size(43, 19);
            this.DataTP.TabIndex = 1;
            this.DataTP.Text = "Data";
            // 
            // TimeTP
            // 
            this.TimeTP.AutoSize = true;
            this.TimeTP.BackColor = System.Drawing.Color.Transparent;
            this.TimeTP.Font = new System.Drawing.Font("PMingLiU-ExtB", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeTP.ForeColor = System.Drawing.Color.Black;
            this.TimeTP.Location = new System.Drawing.Point(24, 496);
            this.TimeTP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TimeTP.Name = "TimeTP";
            this.TimeTP.Size = new System.Drawing.Size(47, 19);
            this.TimeTP.TabIndex = 0;
            this.TimeTP.Text = "Time";
            // 
            // User2Frame
            // 
            this.User2Frame.Image = ((System.Drawing.Image)(resources.GetObject("User2Frame.Image")));
            this.User2Frame.Location = new System.Drawing.Point(631, 180);
            this.User2Frame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.User2Frame.Name = "User2Frame";
            this.User2Frame.Size = new System.Drawing.Size(181, 158);
            this.User2Frame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.User2Frame.TabIndex = 14;
            this.User2Frame.TabStop = false;
            // 
            // User1Frame
            // 
            this.User1Frame.Image = ((System.Drawing.Image)(resources.GetObject("User1Frame.Image")));
            this.User1Frame.Location = new System.Drawing.Point(351, 180);
            this.User1Frame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.User1Frame.Name = "User1Frame";
            this.User1Frame.Size = new System.Drawing.Size(181, 158);
            this.User1Frame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.User1Frame.TabIndex = 14;
            this.User1Frame.TabStop = false;
            // 
            // TwoPlayers
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
            this.Name = "TwoPlayers";
            this.Text = "GameMode";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.User2Ask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.User1Ask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.User2Frame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.User1Frame)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox User2Ask;
        private System.Windows.Forms.PictureBox User1Ask;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Поражений;
        public System.Windows.Forms.Label L;
        public System.Windows.Forms.Label D;
        private System.Windows.Forms.Label Draw;
        public System.Windows.Forms.Label W;
        private System.Windows.Forms.Label Win;
        private System.Windows.Forms.Panel User1;
        private System.Windows.Forms.Panel User2;
        public System.Windows.Forms.Button PlayMusicTP;
        public System.Windows.Forms.Button StopMusicTP;
        public System.Windows.Forms.Button ScissorsU1;
        public System.Windows.Forms.Button PaperU1;
        public System.Windows.Forms.Button RockU1;
        private System.Windows.Forms.Label HelpTP;
        private System.Windows.Forms.Label DataTP;
        private System.Windows.Forms.Label TimeTP;
        private System.Windows.Forms.PictureBox User2Frame;
        private System.Windows.Forms.PictureBox User1Frame;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label SvernutTP;
        private System.Windows.Forms.Label ExitTP;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Button ScissorsU2;
        public System.Windows.Forms.Button PaperU2;
        public System.Windows.Forms.Button RockU2;
    }
}