using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace ButtonRuns
{
    delegate void MoveDel(Button button);

    public partial class Form1 : Form
    {
        // создадим три потока, в котором будут выполняться наши "бегущие кнопки"
        Thread t1;
        Thread t2;
        Thread t3;

        SoundPlayer runningSound, backgraund; //мелодия движущейся кнопки

        static Random r;

        MoveDel move;

        ButtonCompare [] buttonsMassiv; // массив кнопок

#region Конструктор
        public Form1()
        {
            runningSound = new SoundPlayer(Properties.Resources._94_Truck_snd_run03);
            backgraund = new SoundPlayer(Properties.Resources.Final__iz_filma_Usatyi_njan_);
            backgraund.Play();
            Thread.Sleep(500);

            move = new MoveDel(Moution);

            runningSound = new SoundPlayer(Properties.Resources._94_Truck_snd_run03);
            backgraund = new SoundPlayer(Properties.Resources.Final__iz_filma_Usatyi_njan_);
            r = new Random();
            InitializeComponent();

            buttonsMassiv = new ButtonCompare[] {first_btn, second_btn, third_btn};
            backgraund.Play();
        }
# endregion

        /// <summary>
        /// Двигает конкретную кнопку, получаемую в качестве параметра
        /// </summary>
        /// <param name="button"></param>
        void Moution(Button button)
        {
            button.Location = new Point(button.Location.X + r.Next(0,10), button.Location.Y);
            Lider();

            Finish(button);
        }

        /// <summary>
        /// Определяет победителя забега и окно с именем победителя
        /// </summary>
        /// <param name="button"></param>
        private void Finish(Button button)
        {
            if (button.Location.X > (pictureBox1.Location.X-button.Width))
            {
                pause_btn_Click(new object(), new EventArgs());
                start_btn.Enabled = false;
                backgraund.Play();
                MessageBox.Show($"Выиграл игрок {button.Text}");
            }
        }

        /// <summary>
        /// Одевает желтую майку лидера, для участника забега находящегося ближе всех к финишу
        /// </summary>
        private void Lider()
        {
            Array.Sort(buttonsMassiv);
            buttonsMassiv[0].BackColor = Color.Yellow;

            for (int i = 1; i < buttonsMassiv.Length; i++)
                buttonsMassiv[i].BackColor = SystemColors.Control;
        }


        void MovingButton1()
        {
            while (true)
            {
                Thread.Sleep(r.Next(50, 100));
                Invoke(move, first_btn);
            }
        }

        void MovingButton2()
        {
            while (true)
            {
                Thread.Sleep(r.Next(50, 100));
                Invoke(move, second_btn);
            }
        }

        void MovingButton3()
        {
            while (true)
            {
                Thread.Sleep(r.Next(50, 100));
                Invoke(move, third_btn);
            }
        }
        /// <summary>
        /// Метод вызывается при нажатии кнопки Start
        /// Создает и запускает потоки, если они не были созданы
        /// Возобновляет потоки, если они были приостановлены
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void start_btn_Click(object sender, EventArgs e)
        {
            runningSound.Play();
            stop_btn.Enabled = true;
            pause_btn.Enabled = true;
            start_btn.Enabled = false;

            if (t1 != null)
            {
                t1.Resume();
                t2.Resume();
                t3.Resume();
                
                return;
            }
            t1 = new Thread(MovingButton1);
            t2 = new Thread(MovingButton2);
            t3 = new Thread(MovingButton3);

            t1.IsBackground = t2.IsBackground = t3.IsBackground = true;

            t1.Start();
            t2.Start();
            t3.Start();
        }

        private void pause_btn_Click(object sender, EventArgs e)
        {
            pause_btn.Enabled = false;

            if (t1 != null)
            {
                t1.Suspend();
                t2.Suspend();
                t3.Suspend();
            }

            start_btn.Enabled = true;
            backgraund.Play();
        }

        private void stop_btn_Click(object sender, EventArgs e)
        {
            stop_btn.Enabled = pause_btn.Enabled = false;

            pause_btn_Click(sender, e);

            Reset();

        }

        private void Reset()
        {
            first_btn.Location = new Point(31, first_btn.Location.Y);
            second_btn.Location = new Point(31, second_btn.Location.Y);
            third_btn.Location = new Point(31, third_btn.Location.Y);

            foreach (ButtonCompare x in buttonsMassiv)
                x.BackColor = SystemColors.Control;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            stop_btn_Click(new object(), e);
        }

        void StopPlayer()
        {
            runningSound.Stop();
        }
    }
}
