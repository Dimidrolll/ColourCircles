using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ColourCircles
{
    class CircleTemlate
    {
        public Color color { get; }
        public int radius;

        public CircleTemlate(Color color, int radius) {
            this.color = color;
            this.radius = radius;
        }

        public Brush GetBrush()
        {
            return new SolidBrush(color);
        }
    }
}
