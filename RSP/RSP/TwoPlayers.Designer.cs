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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
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
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // SvernutTP
            // 
            resources.ApplyResources(this.SvernutTP, "SvernutTP");
            this.SvernutTP.BackColor = System.Drawing.Color.Transparent;
            this.SvernutTP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SvernutTP.ForeColor = System.Drawing.Color.White;
            this.SvernutTP.Name = "SvernutTP";
            this.SvernutTP.Click += new System.EventHandler(this.SvernutTP_Click);
            this.SvernutTP.MouseEnter += new System.EventHandler(this.SvernutTP_MouseEnter);
            this.SvernutTP.MouseLeave += new System.EventHandler(this.SvernutTP_MouseLeave);
            // 
            // ExitTP
            // 
            resources.ApplyResources(this.ExitTP, "ExitTP");
            this.ExitTP.BackColor = System.Drawing.Color.Transparent;
            this.ExitTP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitTP.ForeColor = System.Drawing.Color.White;
            this.ExitTP.Name = "ExitTP";
            this.ExitTP.Click += new System.EventHandler(this.ExitTP_Click);
            this.ExitTP.MouseEnter += new System.EventHandler(this.ExitTP_MouseEnter);
            this.ExitTP.MouseHover += new System.EventHandler(this.ExitTP_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.panel1, "panel1");
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
            this.panel1.Name = "panel1";
            // 
            // User2Ask
            // 
            this.User2Ask.Image = global::RSP.Properties.Resources.CompAsk1;
            resources.ApplyResources(this.User2Ask, "User2Ask");
            this.User2Ask.Name = "User2Ask";
            this.User2Ask.TabStop = false;
            // 
            // User1Ask
            // 
            resources.ApplyResources(this.User1Ask, "User1Ask");
            this.User1Ask.Image = global::RSP.Properties.Resources.UserAsk1;
            this.User1Ask.Name = "User1Ask";
            this.User1Ask.TabStop = false;
            // 
            // Поражений
            // 
            resources.ApplyResources(this.Поражений, "Поражений");
            this.Поражений.ForeColor = System.Drawing.Color.Red;
            this.Поражений.Name = "Поражений";
            // 
            // L
            // 
            resources.ApplyResources(this.L, "L");
            this.L.ForeColor = System.Drawing.Color.Red;
            this.L.Name = "L";
            // 
            // D
            // 
            resources.ApplyResources(this.D, "D");
            this.D.ForeColor = System.Drawing.Color.Yellow;
            this.D.Name = "D";
            // 
            // Draw
            // 
            resources.ApplyResources(this.Draw, "Draw");
            this.Draw.ForeColor = System.Drawing.Color.Yellow;
            this.Draw.Name = "Draw";
            // 
            // W
            // 
            resources.ApplyResources(this.W, "W");
            this.W.ForeColor = System.Drawing.Color.Lime;
            this.W.Name = "W";
            // 
            // Win
            // 
            resources.ApplyResources(this.Win, "Win");
            this.Win.ForeColor = System.Drawing.Color.Lime;
            this.Win.Name = "Win";
            // 
            // User1
            // 
            resources.ApplyResources(this.User1, "User1");
            this.User1.BackColor = System.Drawing.Color.Transparent;
            this.User1.BackgroundImage = global::RSP.Properties.Resources.FirstUser;
            this.User1.ForeColor = System.Drawing.Color.Red;
            this.User1.Name = "User1";
            // 
            // User2
            // 
            resources.ApplyResources(this.User2, "User2");
            this.User2.BackColor = System.Drawing.Color.Transparent;
            this.User2.BackgroundImage = global::RSP.Properties.Resources.SecUser;
            this.User2.ForeColor = System.Drawing.SystemColors.Control;
            this.User2.Name = "User2";
            // 
            // PlayMusicTP
            // 
            this.PlayMusicTP.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.PlayMusicTP, "PlayMusicTP");
            this.PlayMusicTP.Name = "PlayMusicTP";
            this.PlayMusicTP.UseVisualStyleBackColor = true;
            this.PlayMusicTP.Click += new System.EventHandler(this.PlayMusic_Click);
            // 
            // StopMusicTP
            // 
            resources.ApplyResources(this.StopMusicTP, "StopMusicTP");
            this.StopMusicTP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StopMusicTP.Name = "StopMusicTP";
            this.StopMusicTP.UseVisualStyleBackColor = true;
            this.StopMusicTP.Click += new System.EventHandler(this.StopMusic_Click);
            // 
            // ScissorsU2
            // 
            resources.ApplyResources(this.ScissorsU2, "ScissorsU2");
            this.ScissorsU2.Name = "ScissorsU2";
            this.ScissorsU2.UseVisualStyleBackColor = true;
            this.ScissorsU2.Click += new System.EventHandler(this.ScissorsU2_Click);
            // 
            // ScissorsU1
            // 
            resources.ApplyResources(this.ScissorsU1, "ScissorsU1");
            this.ScissorsU1.Name = "ScissorsU1";
            this.ScissorsU1.UseVisualStyleBackColor = true;
            this.ScissorsU1.Click += new System.EventHandler(this.ScissorsU1_Click);
            this.ScissorsU1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HotKeys_KeyDown);
            // 
            // PaperU2
            // 
            resources.ApplyResources(this.PaperU2, "PaperU2");
            this.PaperU2.Name = "PaperU2";
            this.PaperU2.UseVisualStyleBackColor = true;
            this.PaperU2.Click += new System.EventHandler(this.PaperU2_Click);
            // 
            // PaperU1
            // 
            resources.ApplyResources(this.PaperU1, "PaperU1");
            this.PaperU1.Name = "PaperU1";
            this.PaperU1.UseVisualStyleBackColor = true;
            this.PaperU1.Click += new System.EventHandler(this.PaperU1_Click);
            this.PaperU1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HotKeys_KeyDown);
            // 
            // RockU2
            // 
            resources.ApplyResources(this.RockU2, "RockU2");
            this.RockU2.Name = "RockU2";
            this.RockU2.UseVisualStyleBackColor = true;
            this.RockU2.Click += new System.EventHandler(this.RockU2_Click);
            // 
            // RockU1
            // 
            resources.ApplyResources(this.RockU1, "RockU1");
            this.RockU1.Name = "RockU1";
            this.RockU1.UseVisualStyleBackColor = true;
            this.RockU1.Click += new System.EventHandler(this.RockU1_Click);
            this.RockU1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HotKeys_KeyDown);
            // 
            // HelpTP
            // 
            resources.ApplyResources(this.HelpTP, "HelpTP");
            this.HelpTP.BackColor = System.Drawing.Color.Transparent;
            this.HelpTP.Cursor = System.Windows.Forms.Cursors.Help;
            this.HelpTP.ForeColor = System.Drawing.Color.Black;
            this.HelpTP.Name = "HelpTP";
            this.HelpTP.Click += new System.EventHandler(this.HelpGM_Click);
            // 
            // DataTP
            // 
            resources.ApplyResources(this.DataTP, "DataTP");
            this.DataTP.BackColor = System.Drawing.Color.Transparent;
            this.DataTP.ForeColor = System.Drawing.Color.Black;
            this.DataTP.Name = "DataTP";
            // 
            // TimeTP
            // 
            resources.ApplyResources(this.TimeTP, "TimeTP");
            this.TimeTP.BackColor = System.Drawing.Color.Transparent;
            this.TimeTP.ForeColor = System.Drawing.Color.Black;
            this.TimeTP.Name = "TimeTP";
            // 
            // User2Frame
            // 
            resources.ApplyResources(this.User2Frame, "User2Frame");
            this.User2Frame.Name = "User2Frame";
            this.User2Frame.TabStop = false;
            // 
            // User1Frame
            // 
            resources.ApplyResources(this.User1Frame, "User1Frame");
            this.User1Frame.Name = "User1Frame";
            this.User1Frame.TabStop = false;
            // 
            // TwoPlayers
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TwoPlayers";
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