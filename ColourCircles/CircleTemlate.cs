using System.Drawing;

namespace ColourCircles
{
    class CircleTemlate
    {
        public Color Colour { get; set; }
        public int Radius { get; set; }

        public Brush _brush;

        public CircleTemlate(Color colour, int radius)
        {
            Colour = colour;
            Radius = radius;
            _brush = new SolidBrush(colour);
        }

        public void Draw(int x, int y, Graphics graphics)
        {
            graphics.FillEllipse(_brush, x, y, Radius, Radius);
        }

    }
}