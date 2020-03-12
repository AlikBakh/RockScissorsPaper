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
using System.Media;
/// </summary>

namespace RSP
{
    public partial class RSPstart : Form
    {
        SoundPlayer music = new SoundPlayer();
        public RSPstart()
        {
            InitializeComponent();
            music.Stream = Properties.Resources.music01;
        }


        //музло     
        public void PlayMusic_Click(object sender, EventArgs e)//запуск музыки
        {
            music.Play();
        }
        public void StopMusic_Click(object sender, EventArgs e)//пауза
        {
            music.Stop();
        }


        private void timer1_Tick(object sender, EventArgs e)//дата ; время ;
        {
            timer1.Start();
            Data.Text = DateTime.Now.ToLongDateString();
            Time.Text = DateTime.Now.ToLongTimeString();
        }
      
      
        private void Exit_Click(object sender, EventArgs e)//Выход из игры с последующим подтверждением.
        {
            MessageBox.Show("Всего хорошего!\nДля выхода нажмите <ok>", "Exit.",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }
        private void Exit_MouseEnter(object sender, EventArgs e)//регулировка цвета при наведении на кнопку "выход"
        {
            Exit.ForeColor = Color.Red;
        }
        private void Exit_MouseLeave(object sender, EventArgs e)//возврат исходного цвета
        {
            Exit.ForeColor = Color.White;
        }

        
        private void Svernut_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }//свернуть окно 
        private void Svernut_MouseEnter(object sender, EventArgs e)
        {
            Svernut.ForeColor = Color.Red;
        }//регулировка цвета при наведении на кнопку "свернуть"
        private void Svernut_MouseLeave(object sender, EventArgs e)
        {
            Svernut.ForeColor = Color.White;
        }//возврат исходного цвета


        Point lastPoint;//передвижение формы зажав левую кнопку мышки
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) 
                lastPoint = e.Location;
            Location = new Point((Size)Location - (Size)lastPoint + (Size)e.Location);
        }


        private void Help_Click(object sender, EventArgs e)//Вывод правил игры.
        {
            MessageBox.Show("     Победитель определяется по следующим 3 правилам:\n" +
            "-Бумага побеждает камень(«бумага кроет камень»);\n" +
            "-Камень побеждает ножницы(«камень ломает ножницы»);\n" +
            "-Ножницы побеждают бумагу(«ножницы режут бумагу»).\n\n" +
            "Если игроки показали одинаковый знак, то засчитывается ничья и счёт остаётся всё тем же.", "Правила игры",
             MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }


        private void PlayTheGame_Click(object sender, EventArgs e)//кнопка выбора режима и начала игры;
        {
            this.Hide();
            new Select().ShowDialog();
            

        }

    }
}