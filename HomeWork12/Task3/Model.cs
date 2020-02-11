using System;
using System.Windows.Threading;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Task3
{
    public delegate void TimerTick(object sender, EventArgs e);
    class Model
    {
        private uint second;

        public uint Second { get { return second; } }

        public event TimerTick TimerTick = null;

        public DispatcherTimer timer = null;

        public Model()
        {
            timer = new DispatcherTimer();
            timer.Tick += new EventHandler(timerTick);
            timer.Interval = new TimeSpan(0, 0, 0, 1);
        }
        

        public void TimerStart()
        {
           timer.Start();
        }

        public void TimerStop()
        {
            timer.Stop();
        }

        public void TimerReset()
        {
            second = 0;
        }

        public void timerTick(object sender, EventArgs e)
        {
            second++;
            TimerTick.Invoke(sender, e);
        }

       
    }
}
