using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Drawing;

namespace ColourCircles
{
    class CircleDrawer
    {
        private CircleTemlate circleTemplate;
        private int pauseInt;


        private ManualResetEvent _event;
        public Thread thread;
        private Graphics g;
        private bool run = true;

        public CircleDrawer(CircleTemlate circleTemplate, int pauseInt, Graphics g) {
            this.circleTemplate = circleTemplate;
            this.pauseInt = pauseInt;
            this.g = g;
            Brush brush = circleTemplate.GetBrush(); 
            Random rand = new Random();
            _event = new ManualResetEvent(true);
            thread = new Thread(()=> {
                

                while (run)
                {
                    DrawRandCircle(brush, rand, circleTemplate.radius);
                    Thread.Sleep(pauseInt);
                    _event.WaitOne();
                }

            });
        }
        public void DrawRandCircle(Brush p, Random rand, int radius) {
            g.FillEllipse(p, rand.Next(130, 760), rand.Next(10, 515), radius, radius);
        }
        public void Start()
        {
            thread.Start();
        }
        public void Stop()
        {
            _event.Reset();
        }
        public void Resume()
        {
            _event.Set();
        }
        public void End()
        {
            Resume();
            run = false;
        }
        public void waitEnd()
        {
            thread.Join();

        }
    }
}
