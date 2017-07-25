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

namespace ButtonRuns
{
    delegate void MoveDel(Button button);

    public partial class Form1 : Form
    {
        // создадим три потока, в котором будут выполняться наши "бегущие кнопки"
        Thread t1;
        Thread t2;
        Thread t3;

        Random r;

        MoveDel move;

        public Form1()
        {
            move = new MoveDel(Moution);
            r = new Random();
            InitializeComponent();
        }

        void Moution(Button button)
        {
            button.Location = new Point(button.Location.X + r.Next(0,10), button.Location.Y);
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

        private void start_btn_Click(object sender, EventArgs e)
        {
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
            if (t1 != null)
            {
                t1.Suspend();
                t2.Suspend();
                t3.Suspend();

                start_btn.Enabled = true;
            }
        }

        private void stop_btn_Click(object sender, EventArgs e)
        {
            pause_btn_Click(sender, e);

            Reset();

        }

        private void Reset()
        {
            first_btn.Location = new Point(31, first_btn.Location.Y);
            second_btn.Location = new Point(31, second_btn.Location.Y);
            third_btn.Location = new Point(31, third_btn.Location.Y);
        }
    }
}
