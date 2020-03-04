namespace RSP
{
    partial class Select
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CompButton = new System.Windows.Forms.Button();
            this.ExitS = new System.Windows.Forms.Label();
            this.UserButton = new System.Windows.Forms.Button();
            this.Sopernik = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::RSP.Properties.Resources.каменная_стена;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.CompButton);
            this.panel1.Controls.Add(this.ExitS);
            this.panel1.Controls.Add(this.UserButton);
            this.panel1.Controls.Add(this.Sopernik);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 261);
            this.panel1.TabIndex = 0;
            // 
            // CompButton
            // 
            this.CompButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CompButton.Location = new System.Drawing.Point(305, 133);
            this.CompButton.Name = "CompButton";
            this.CompButton.Size = new System.Drawing.Size(175, 59);
            this.CompButton.TabIndex = 1;
            this.CompButton.Text = "Компьютер";
            this.CompButton.UseVisualStyleBackColor = true;
            this.CompButton.Click += new System.EventHandler(this.CompButton_Click);
            // 
            // ExitS
            // 
            this.ExitS.AutoSize = true;
            this.ExitS.BackColor = System.Drawing.Color.Transparent;
            this.ExitS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitS.Font = new System.Drawing.Font("PMingLiU-ExtB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitS.ForeColor = System.Drawing.Color.White;
            this.ExitS.Location = new System.Drawing.Point(516, 0);
            this.ExitS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ExitS.Name = "ExitS";
            this.ExitS.Size = new System.Drawing.Size(23, 24);
            this.ExitS.TabIndex = 8;
            this.ExitS.Text = "Х";
            this.ExitS.Click += new System.EventHandler(this.ExitS_Click);
            this.ExitS.MouseEnter += new System.EventHandler(this.ExitS_MouseEnter);
            this.ExitS.MouseLeave += new System.EventHandler(this.ExitS_MouseLeave);
            // 
            // UserButton
            // 
            this.UserButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UserButton.Location = new System.Drawing.Point(69, 133);
            this.UserButton.Name = "UserButton";
            this.UserButton.Size = new System.Drawing.Size(174, 59);
            this.UserButton.TabIndex = 1;
            this.UserButton.Text = "Человек\r\n(тест)\r\n";
            this.UserButton.UseVisualStyleBackColor = true;
            this.UserButton.Click += new System.EventHandler(this.UserButton_Click);
            // 
            // Sopernik
            // 
            this.Sopernik.AutoSize = true;
            this.Sopernik.BackColor = System.Drawing.Color.Transparent;
            this.Sopernik.Font = new System.Drawing.Font("Impact", 25.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sopernik.ForeColor = System.Drawing.Color.White;
            this.Sopernik.Location = new System.Drawing.Point(60, 9);
            this.Sopernik.Name = "Sopernik";
            this.Sopernik.Size = new System.Drawing.Size(420, 53);
            this.Sopernik.TabIndex = 0;
            this.Sopernik.Text = "Выберите соперника";
            // 
            // Select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(540, 225);
            this.Controls.Add(this.panel1);
            this.HelpButton = true;
            this.Name = "Select";
            this.Text = "Select";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CompButton;
        private System.Windows.Forms.Button UserButton;
        private System.Windows.Forms.Label Sopernik;
        private System.Windows.Forms.Label ExitS;
    }
}