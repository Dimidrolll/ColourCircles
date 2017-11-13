using System;
using System.Threading;
using System.Drawing;

namespace ColourCircles
{
    class CircleDrawer
    {
        public CircleTemlate _circleTemplate;

        public string Name {
            set { _thread.Name = value; }
            get
            {
                return _circleTemplate.Colour.ToString();
            }
        }

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
            _circleTemplate = circleTemplate;
            _pauseInt = pauseInt;
            _event = new ManualResetEvent(true);
            _thread = new Thread(() =>
            {
                while (_run)
                {
                    for (int i = 0; i < 50; i++)
                    {
                        _circleTemplate.Draw(_random.Next(130, 800), _random.Next(0, 530), graphics);
                    }

                    Thread.Sleep(_pauseInt);
                    _event.WaitOne();
                }
            });
        }

        public void ChangeRadius(int radius)
        {
            _circleTemplate.Radius = radius;
        }
        public int GetRadius()
        {
            return _circleTemplate.Radius; 
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
            //Name = _circleTemplate.Colour.ToString();
            _circleTemplate._brush.Dispose();
            _circleTemplate.Colour = color;
            _circleTemplate._brush = new SolidBrush(color);

        }
        public Color GetColor()
        {
            return _circleTemplate.Colour;
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