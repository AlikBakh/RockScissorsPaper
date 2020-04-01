using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;



namespace ChatClient
{
    public partial class ClientTCP : Form 
    {
        public ClientTCP()
        {
            InitializeComponent();
        }

        // Объект содержащий рабочий сокет клиентского приложения
        TcpClient tcpСlient = new TcpClient();

        // Объект сетевого потока для приема и отправки сообщений
        NetworkStream ns;

        // Флаг для остановки потоков и завершения сетевой работы приложения
        bool stopNetwork;

        #region Управление клиентским приложением

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            Connect();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            SendMessage();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseClient();
        }

        #endregion


        #region Функциональная часть Сетевая работа

        // Попытка подключения к серверу
        void Connect()
        {
            try
            {
                tcpСlient.Connect(textBoxIP.Text, int.Parse(textBoxPort.Text));
                ns = tcpСlient.GetStream();
                listBox1.Items.Add("Добро пожаловать!");
                listBox1.Items.Add("==================================");

                Thread th = new Thread(ReceiveRun);
                th.Start();

                Random random = new Random();
                // Рандомное цветовое оповещение о подключении.
                BackColor = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
            }
            catch
            {
                ErrorSound();
            }
        }

        void CloseClient()
        {
            if (ns != null) ns.Close();
            if (tcpСlient != null) tcpСlient.Close();
            stopNetwork = true;
            // Цветовое оповещение об отключении.
            BackColor = Color.FromName("White");
        }


        void SendMessage()
        {
            if (ns != null)
            {
                byte[] buffer = Encoding.Default.GetBytes(textBoxSend.Text);
                ns.Write(buffer, 0, buffer.Length);
            }
        }


        // Цикл извлечения сообщений, запускается в отдельном потоке.
        void ReceiveRun()
        {
            while (true)
            {
                try
                {
                    string s = null;
                    while (ns.DataAvailable == true)
                    {
                        // Определение необходимого размера буфера приема.
                        byte[] buffer = new byte[tcpСlient.Available];

                        ns.Read(buffer, 0, buffer.Length);
                        s += Encoding.Default.GetString(buffer);
                    }

                    if (s != null)
                    {
                        ShowReceiveMessage(s);
                        s = String.Empty;
                    }
                    
                    Thread.Sleep(100);
                }
                catch
                {
                    ErrorSound();
                }

                if (stopNetwork == true) break;

            }
        }
        #endregion


        #region Информации о сетевой работе

        // Код доступа к свойствам объектов главной формы  из других потоков
        delegate void UpdateReceiveDisplayDelegate(string message);
        void ShowReceiveMessage(string message)
        {
            if (listBox1.InvokeRequired == true)
            {
                UpdateReceiveDisplayDelegate rdd = new UpdateReceiveDisplayDelegate(ShowReceiveMessage);

                // Данный метод вызывается в дочернем потоке,  ищет основной поток и
                //выполняет делегат указанный в качестве параметра в главном потоке, безопасно обновляя интерфейс формы.
                Invoke(rdd, new object[] { message });
            }
            else
            {
                // Если не требуется вызывать метод Invoke, обратимся напрямую к элементу формы.
                listBox1.Items.Add(message);

            }
        }

        // Звуковое оповещение о перехваченной ошибке.
        void ErrorSound()
        {
            Console.Beep(2000, 80);
            Console.Beep(3000, 120);
        }

        private void listBox1_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = (int)e.Graphics.MeasureString(listBox1.Items[e.Index].ToString(), listBox1.Font, listBox1.Width).Height;
        }

        #endregion
    }
}