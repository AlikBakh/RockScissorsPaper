using System;
using System.Drawing;
using System.Media;
using System.Threading;              //for Sleep
using System.Windows.Forms;

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
            this.KeyPreview = true;

            RockU2.Enabled = false;
            ScissorsU2.Enabled = false;
            PaperU2.Enabled = false;

            User1Ask.Visible = false;
            User2Ask.Visible = false;

        }

        public void PlayMusic_Click(object sender, EventArgs e)//запуск музыки
        {
            music.Play();
        }
        public void StopMusic_Click(object sender, EventArgs e)//пауза
        {
            music.Stop();
        }



        void HotKeys_KeyDown(object sender, KeyEventArgs e)//горячме клавиши
        {
            if (e.KeyCode == Keys.Z)
            {
                RockU1.PerformClick();// имитируем нажатие button1
            }
            if (e.KeyCode == Keys.X)
            {
                ScissorsU1.PerformClick();// имитируем нажатие button1
            }
            if (e.KeyCode == Keys.C)
            {
                PaperU1.PerformClick();// имитируем нажатие button1
            }
        }


        private void timer1_Tick(object sender, EventArgs e)//дата ; время
        {
            timer1.Start();
            DataTP.Text = DateTime.Now.ToLongDateString();
            TimeTP.Text = DateTime.Now.ToLongTimeString();
        }


        private void HelpGM_Click(object sender, EventArgs e)//Вывод правил игры.
        {
            MessageBox.Show("Горячие клавиши для левого игрока:\n" +
            "Z-камень , X-ножницы , C - бумага\n\n" +
            "Победитель определяется по следующим 3 правилам:\n" +
            "-Бумага побеждает камень(«бумага кроет камень»);\n" +
            "-Камень побеждает ножницы(«камень ломает ножницы»);\n" +
            "-Ножницы побеждают бумагу(«ножницы режут бумагу»).\n" +
            "Если игроки показали одинаковый знак, то ничья и счёт остаётся всё тем же.", "Помощь",
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



        public int User1Choose = 0;//дальнейшее значение предмета будет записан в майчуз

        
        public void RockU1_Click(object sender, EventArgs e)//камень
        {
            User1Choose = 1;

            //User1Ask.Image = Properties.Resources.urock;
            Score(User1Choose, User2Choose);

            RockU1.Enabled = false;
            ScissorsU1.Enabled = false;
            PaperU1.Enabled = false;

            RockU2.Enabled = true;
            ScissorsU2.Enabled = true;
            PaperU2.Enabled = true;

            User1Ask.Visible = false;
            User2Ask.Visible = false;
        }
        public void ScissorsU1_Click(object sender, EventArgs e)//ножницы
        {
            User1Choose = 2;
            //User1Ask.Image = Properties.Resources.uscissors;
            Score(User1Choose, User2Choose);

            RockU1.Enabled = false;
            ScissorsU1.Enabled = false;
            PaperU1.Enabled = false;

            RockU2.Enabled = true;
            ScissorsU2.Enabled = true;
            PaperU2.Enabled = true;

            User1Ask.Visible = false;
            User2Ask.Visible = false;
        }
        public void PaperU1_Click(object sender, EventArgs e)//бумага
        {
            User1Choose = 3;
            //User1Ask.Image = Properties.Resources.upaper;
            Score(User1Choose, User2Choose);
            
            RockU1.Enabled = false;
            ScissorsU1.Enabled = false;
            PaperU1.Enabled = false;

            RockU2.Enabled = true;
            ScissorsU2.Enabled = true;
            PaperU2.Enabled = true;

            User1Ask.Visible = false;
            User2Ask.Visible = false;
        }



        public int User2Choose = 0;//дальнейшее значение предмета будет записан в майчуз
        public void RockU2_Click(object sender, EventArgs e)//камень
        {
            User2Choose = 1;
            //User2Ask.Image = Properties.Resources.crock;
            Score(User1Choose, User2Choose);

            RockU2.Enabled = false;
            ScissorsU2.Enabled = false;
            PaperU2.Enabled = false;
            
            RockU1.Enabled = true;
            ScissorsU1.Enabled = true;
            PaperU1.Enabled = true;

            User1Ask.Visible = true;
            User2Ask.Visible = true;
        }
        public void ScissorsU2_Click(object sender, EventArgs e)//ножницы
        {
            User2Choose = 2;
            //User2Ask.Image = Properties.Resources.csccissors;
            Score(User1Choose, User2Choose);

            RockU2.Enabled = false;
            ScissorsU2.Enabled = false;
            PaperU2.Enabled = false;
            
            RockU1.Enabled = true;
            ScissorsU1.Enabled = true;
            PaperU1.Enabled = true;

            User1Ask.Visible = true;
            User2Ask.Visible = true;
        }
        public void PaperU2_Click(object sender, EventArgs e)//бумага
        {
            User2Choose = 3;

            //User2Ask.Image = Properties.Resources.cpaper;
            Score(User1Choose, User2Choose);

            RockU2.Enabled = false;
            ScissorsU2.Enabled = false;
            PaperU2.Enabled = false;
            
            RockU1.Enabled = true;
            ScissorsU1.Enabled = true;
            PaperU1.Enabled = true;

            User1Ask.Visible = true;
            User2Ask.Visible = true;
        }



        public int User1Win;
        public int User2Win;
        public int U12Draw;
        public void Score(int user1, int user2)
        {
            if (User1Choose == 1)
                User1Ask.Image = Properties.Resources.urock;
            if (User1Choose == 2)
                User1Ask.Image = Properties.Resources.uscissors;
            if (User1Choose == 3)
                User1Ask.Image = Properties.Resources.upaper;

            if (User2Choose == 1)
                User2Ask.Image = Properties.Resources.crock;
            if (User2Choose == 2)
                User2Ask.Image = Properties.Resources.csccissors;
            if (User2Choose == 3)
                User2Ask.Image = Properties.Resources.cpaper;

            if (((user1 == 1) && (user2 == 2)) || ((user1 == 2) && (user2 == 3)) || ((user1 == 3) && (user2 == 1)))
            {
                User1Win++;
                W.Text = User1Win.ToString();
                User1Choose = 0;
                User2Choose = 0;

                RockU1.Enabled = true;
                ScissorsU1.Enabled = true;
                PaperU1.Enabled = true;

                RockU2.Enabled = true;
                ScissorsU2.Enabled = true;
                PaperU2.Enabled = true;


            }
            if (((user1 == 2) && (user2 == 1)) || ((user1 == 3) && (user2 == 2)) || ((user1 == 1) && (user2 == 3)))
            {
                User2Win++;
                L.Text = User2Win.ToString();
                User1Choose = 0;
                User2Choose = 0;

                RockU1.Enabled = true;
                ScissorsU1.Enabled = true;
                PaperU1.Enabled = true;

                RockU2.Enabled = true;
                ScissorsU2.Enabled = true;
                PaperU2.Enabled = true;
            }
            if (user1 == user2)
            {
                U12Draw++;
                D.Text = U12Draw.ToString();
                User1Choose = 0;
                User2Choose = 0;

            //    RockU1.Enabled = true;
            //    ScissorsU1.Enabled = true;
            //    PaperU1.Enabled = true;

            //    RockU2.Enabled = true;
            //    ScissorsU2.Enabled = true;
            //    PaperU2.Enabled = true;
            //
            }         
        }        

    }
}