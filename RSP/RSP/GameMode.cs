using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;              //for Sleep
using System.Windows.Forms;
using WMPLib;           //for WindowsMediaPlayer

namespace RSP
{
    public partial class GameMode : Form
    {
        public WindowsMediaPlayer music = new WindowsMediaPlayer(); 
        public GameMode()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;//начальная позиция экрана
            music.URL = "C:/Users/RadeON-SC/Desktop/запуск.mp3";
            music.settings.balance = music.settings.volume / 2;
        }

        public void PlayMusic_Click(object sender, EventArgs e)//запуск музыки
        {
            music.URL = "C:/Users/RadeON-SC/Desktop/Tones and I - Dance Monkey.mp3";
            music.controls.play();
        }
        public void StopMusic_Click(object sender, EventArgs e)//пауза
        {
            music.controls.pause();
        }



        private void timer1_Tick(object sender, EventArgs e)//дата ; время
        {
            timer1.Start();
            DataGM.Text = DateTime.Now.ToLongDateString();
            TimeGM.Text = DateTime.Now.ToLongTimeString();
        }



        private void ExitGM_Click(object sender, EventArgs e)//Выход из игры с последующим подтверждением.
        {
            DialogResult ChooseToExit = MessageBox.Show("Вы действительно хотите выйти?", "Stop!",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (ChooseToExit == DialogResult.Yes)
            {
                Thread.Sleep(500);
                MessageBox.Show("Всего хорошего!\nДля выхода нажмите <ok>", "Exit.",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                this.Close();
            }
        }
        private void ExitGM_MouseEnter(object sender, EventArgs e)//регулировка цвета при наведении на кнопку "выход"
        {
            ExitGM.ForeColor = Color.Red;
        }
        private void ExitGM_MouseLeave(object sender, EventArgs e)//возврат исходного цвета
        {
            ExitGM.ForeColor = Color.White;
        }



        private void SvernutGM_Click(object sender, EventArgs e)//свернуть окно
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void SvernutGM_MouseEnter(object sender, EventArgs e)//регулировка цвета при наведении на кнопку "свернуть"
        {
            SvernutGM.ForeColor = Color.Red;
        }
        private void SvernutGM_MouseLeave(object sender, EventArgs e)//возврат исходного цвета
        {
            SvernutGM.ForeColor = Color.White;
        }

        
        
        private void HelpGM_Click(object sender, EventArgs e)//Вывод правил игры.
        {
            MessageBox.Show("     Победитель определяется по следующим 3 правилам:\n" +
            "-Бумага побеждает камень(«бумага кроет камень»);\n" +
            "-Камень побеждает ножницы(«камень ломает ножницы»);\n" +
            "-Ножницы побеждают бумагу(«ножницы режут бумагу»).\n\n" +
            "Если игроки показали одинаковый знак, то засчитывается ничья и счёт остаётся всё тем же.", "Правила игры",
             MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
               


        Point lastPoint;//передвижение формы зажав левую кнопку мышки
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                lastPoint = e.Location;
            Location = new Point((Size)Location - (Size)lastPoint + (Size)e.Location);
        }

        
        

    }
}
