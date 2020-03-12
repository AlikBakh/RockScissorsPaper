using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSP
{
    public partial class Select : Form
    {
        public Select()
        {
            InitializeComponent();
        }

        private void CompButton_Click(object sender, EventArgs e)
        {

            new GameMode().ShowDialog();
            Close();
        }//против бота
        private void UserButton_Click(object sender, EventArgs e)
        {
            new TwoPlayers().ShowDialog();
            Close();
        }//2 пользователя


        private void ExitS_Click(object sender, EventArgs e)//Выход из игры с последующим подтверждением.
        {
            MessageBox.Show("Всего хорошего!\nДля выхода нажмите <ok>", "Exit.",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
            RSPstart rspStart = new RSPstart();
            rspStart.Show();
        }
        private void ExitS_MouseEnter(object sender, EventArgs e)//регулировка цвета при наведении на кнопку "выход"
        {
            ExitS.ForeColor = Color.Red;
        }
        private void ExitS_MouseLeave(object sender, EventArgs e)//возврат исходного цвета
        {
            ExitS.ForeColor = Color.White;
        }

        private void SvernutS_Click(object sender, EventArgs e)//свернуть окно
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void SvernutS_MouseEnter(object sender, EventArgs e)//регулировка цвета при наведении на кнопку "свернуть"
        {
            SvernutS.ForeColor = Color.Red;
        }
        private void SvernutS_MouseLeave(object sender, EventArgs e)//возврат исходного цвета
        {
            SvernutS.ForeColor = Color.White;
        }
    }
}
