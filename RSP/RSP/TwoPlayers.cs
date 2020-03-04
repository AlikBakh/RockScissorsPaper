using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;              //for Sleep
using System.Windows.Forms;
using System.Media;

namespace RSP
{
    public partial class TwoPlayers : Form
    {
        SoundPlayer music = new SoundPlayer();
        public TwoPlayers()
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
            DataTP.Text = DateTime.Now.ToLongDateString();
            TimeTP.Text = DateTime.Now.ToLongTimeString();
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


        private void ExitTP_Click(object sender, EventArgs e)//Выход из игры с последующим подтверждением.
        {
            DialogResult ChooseToExit = MessageBox.Show("Вы действительно хотите выйти?", "Stop!",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (ChooseToExit == DialogResult.Yes)
            {

                MessageBox.Show("Всего хорошего!\nДля выхода нажмите <ok>", "Exit.",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                RSPstart rspStart = new RSPstart();
                rspStart.Show(); 
                this.Close();
            }
        }
        private void ExitTP_MouseEnter(object sender, EventArgs e)//регулировка цвета при наведении на кнопку "выход"
        {
            ExitTP.ForeColor = Color.Red;
        }
        private void ExitTP_MouseLeave(object sender, EventArgs e)//возврат исходного цвета
        {
            ExitTP.ForeColor = Color.White;
        }


        private void SvernutTP_Click(object sender, EventArgs e)//свернуть окно
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void SvernutTP_MouseEnter(object sender, EventArgs e)//регулировка цвета при наведении на кнопку "свернуть"
        {
            SvernutTP.ForeColor = Color.Red;
        }
        private void SvernutTP_MouseLeave(object sender, EventArgs e)//возврат исходного цвета
        {
            SvernutTP.ForeColor = Color.White;
        }



        public int User1Win;
        public int User2Win;
        public int U12Draw;

        public int cpuChoose;
        Random rnd = new Random();
        //выбор компа
        public int cpuRndChoose()//выбор компа
        {
            cpuChoose = rnd.Next(1, 4);
            if (cpuChoose == 1)
                User2Ask.Image = Properties.Resources.crock;
            if (cpuChoose == 2)
                User2Ask.Image = Properties.Resources.csccissors;
            if (cpuChoose == 3)
                User2Ask.Image = Properties.Resources.cpaper;
            return cpuChoose;
        }


        public int MyChoose = 0;//дальнейшее значение предмета будет записан в майчуз
        public void Rock_Click(object sender, EventArgs e)//камень
        {
            MyChoose = 1;
            User1Ask.Image = Properties.Resources.urock;
            Score(MyChoose, cpuRndChoose());
        }
        public void Scissors_Click(object sender, EventArgs e)//ножницы
        {
            MyChoose = 2;
            User1Ask.Image = Properties.Resources.uscissors;
            Score(MyChoose, cpuRndChoose());
        }
        public void Paper_Click(object sender, EventArgs e)//бумага
        {
            MyChoose = 3;
            User1Ask.Image = Properties.Resources.upaper;
            Score(MyChoose, cpuRndChoose());
        }


        public void Score(int user1, int user2)
        {
            if (((user1 == 1) && (user2 == 2)) || ((user1 == 2) && (user2 == 3)) || ((user1 == 3) && (user2 == 1)))
            {
                User1Win++;
                W.Text = Convert.ToString(User1Win);
            }
            if (((user1 == 2) && (user2 == 1)) || ((user1 == 3) && (user2 == 2)) || ((user1 == 1) && (user2 == 3)))
            {
                User2Win++;
                L.Text = Convert.ToString(User2Win);
            }

            if (user1 == user2)
            {
                U12Draw++;
                D.Text = Convert.ToString(U12Draw);
            }


        }
    }
}