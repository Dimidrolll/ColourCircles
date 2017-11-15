using System;
using System.Threading;
using System.Drawing;

using ColourCircles;

namespace ColourCircles
{
    
    class CircleDrawer
    {
        public CircleTemlate CircleTemplate;


        public string Name => "Thread)";

        public ThreadPriority Priority
        {
            get { return _thread.Priority; }
            set { _thread.Priority = value; }
        }


        private readonly ManualResetEvent _event;
        private readonly Thread _thread;
        private bool _run = true;
        private readonly Random _random = new Random();
        private int _pauseInt;

        public CircleDrawer(CircleTemlate circleTemplate, int pauseInt, Graphics graphics)
        {
            CircleTemplate = circleTemplate;
            _pauseInt = pauseInt;
            _event = new ManualResetEvent(true);
            _thread = new Thread(() =>
            {
                while (_run)
                {
                    for (int i = 0; i < 50; i++)
                    {
                        CircleTemplate.Draw(_random.Next(130, 800), _random.Next(0, 530), graphics);
                    }

                    Thread.Sleep(_pauseInt);
                    _event.WaitOne();
                }
            });
        }

        public void ChangeRadius(int radius)
        {
            CircleTemplate.Radius = radius;
        }
        public int GetRadius()
        {
            return CircleTemplate.Radius; 
        }

        public void ChangeRef(int pause)
        {
            _pauseInt = pause;
        }
        public int GetRef()
        {
            return _pauseInt;
        }

        public void ChangeColor(Color color)
        {
            CircleTemplate._brush.Dispose();
            CircleTemplate.Colour = color;
            CircleTemplate._brush = new SolidBrush(color);
        }
        public Color GetColor()
        {
            return CircleTemplate.Colour;
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