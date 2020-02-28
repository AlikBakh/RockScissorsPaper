using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;              //for Sleep
using System.Windows.Forms;
using System.Media;                  //for SoundPlayer
namespace RSP
{
    public partial class GameMode : Form
    {
        //public WindowsMediaPlayer music = new WindowsMediaPlayer(); 
        SoundPlayer music = new SoundPlayer();
        public GameMode()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;//начальная позиция экрана

            music.Stream = Properties.Resources.music01;
        }

        public void PlayMusic_Click(object sender, EventArgs e)//запуск музыки
        {
            music.Play();
        }
        public void StopMusic_Click(object sender, EventArgs e)//пауза
        {
            music.Stop();
        }



        private void timer1_Tick(object sender, EventArgs e)//дата ; время
        {
            timer1.Start();
            DataGM.Text = DateTime.Now.ToLongDateString();
            TimeGM.Text = DateTime.Now.ToLongTimeString();
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



        public int UserWin;
        public int CompWin;
        public int UCDraw;

        public int cpuChoose;
        Random rnd = new Random();
        //выбор компа
        public int cpuRndChoose()//выбор компа
        {
            cpuChoose = rnd.Next(1, 4);
            if (cpuChoose == 1)
                CompsAsk.Image = Properties.Resources.crock;
            if (cpuChoose == 2)
                CompsAsk.Image = Properties.Resources.csccissors;
            if (cpuChoose == 3)
                CompsAsk.Image = Properties.Resources.cpaper;
            return cpuChoose;
        }


        public int MyChoose = 0;//дальнейшее значение предмета будет записан в майчуз
        public void Rock_Click(object sender, EventArgs e)//камень
        {
            MyChoose = 1;
            UsersAsk.Image = Properties.Resources.urock;
            Score(MyChoose, cpuRndChoose());
        }
        public void Scissors_Click(object sender, EventArgs e)//ножницы
        {
            MyChoose = 2;
            UsersAsk.Image = Properties.Resources.uscissors;
            Score(MyChoose, cpuRndChoose());
        }
        public void Paper_Click(object sender, EventArgs e)//бумага
        {
            MyChoose = 3;
            UsersAsk.Image = Properties.Resources.upaper;
            Score(MyChoose, cpuRndChoose());
        }


        public void Score(int my, int cpu)
        {
            if ( ((my == 1) && (cpu == 2)) || ( (my == 2) && (cpu == 3) ) || ( (my == 3) && (cpu == 1)) )
            {
                UserWin++;
                W.Text = Convert.ToString(UserWin);
            }
            if (((my == 2) && (cpu == 1)) || ((my == 3) && (cpu == 2)) || ((my == 1) && (cpu == 3)) )
            {
                CompWin++;
                L.Text = Convert.ToString(CompWin);
            }

            if (my == cpu)
            {
                UCDraw++;
                D.Text = Convert.ToString(UCDraw);
            }

            
           


        }

    }
}