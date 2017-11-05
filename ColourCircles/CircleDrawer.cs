using System;
using System.Threading;
using System.Drawing;

namespace ColourCircles
{
    class CircleDrawer
    {
        private readonly CircleTemlate _circleTemplate;

        public string Name => _circleTemplate.Colour.ToString();

        public ThreadPriority Priority
        {
            get { return _thread.Priority; }
            set { _thread.Priority = value; }
        }


        private readonly ManualResetEvent _event;
        private readonly Thread _thread;
        private bool _run = true;
        private readonly Random _random = new Random();

        public CircleDrawer(CircleTemlate circleTemplate, int pauseInt, Graphics graphics)
        {
            _circleTemplate = circleTemplate;
            _event = new ManualResetEvent(true);
            _thread = new Thread(() =>
            {
                while (_run)
                {
                    for (int i = 0; i < 50; i++)
                    {
                        circleTemplate.Draw(_random.Next(130, 800), _random.Next(0, 530), graphics);
                    }

                    Thread.Sleep(pauseInt);
                    _event.WaitOne();
                }
            });
        }

        public void Start()
        {
            _thread.Start();
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
            _run = false;
        }

        public void WaitEnd()
        {
            _thread.Join();
        }
    }
}