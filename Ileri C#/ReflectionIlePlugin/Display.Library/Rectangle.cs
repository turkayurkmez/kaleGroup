using Display.SDK;
using System.Drawing;

namespace Display.Library
{
    public class Rectangle : IPlug
    {
        public string Name => "Dörtgen";

        public void Draw(Graphics graphic, SolidBrush solidBrush, int x, int y, int width, int height)
        {
           graphic.FillRectangle(solidBrush, x, y, width, height);
        }

    }
}