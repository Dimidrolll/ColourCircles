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

        public string Name => circleTemplate.color.ToString();


        private ManualResetEvent _event;
        private Thread thread;
        private Graphics g;
        private bool run = true;
        private Random _random = new Random();


        public CircleDrawer(CircleTemlate circleTemplate, int pauseInt, Graphics g) {
            this.circleTemplate = circleTemplate;
            this.g = g;
            Brush brush = circleTemplate.GetBrush();
            _event = new ManualResetEvent(true);
            thread = new Thread(()=> {
                while (run)
                {
                    DrawRandCircle(brush, circleTemplate.radius);
                    Thread.Sleep(pauseInt);
                    _event.WaitOne();
                }

            });
        }
        public void DrawRandCircle(Brush p, int radius) {
            g.FillEllipse(p, _random.Next(130, 760), _random.Next(10, 515), radius, radius);
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

        public void SetPriority(ThreadPriority priority)
        {
            thread.Priority = priority;
        }
    }
}
