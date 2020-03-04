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
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void CompButton_Click(object sender, EventArgs e)
        {
            GameMode gameModeForm = new GameMode();
            gameModeForm.ShowDialog();
            Close();
        }//против бота
        private void UserButton_Click(object sender, EventArgs e)
        {
            TwoPlayers tpForm = new TwoPlayers();
            tpForm.ShowDialog();
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
    }
}
