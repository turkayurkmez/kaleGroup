using Display.SDK;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Display.Library
{
    public class Circle : IPlug
    {
        public string Name =>"Daire";

        public void Draw(Graphics graphic, SolidBrush solidBrush, int x, int y, int width, int height)
        {
          graphic.FillEllipse(solidBrush, x, y, width, width);
        }
    }
}
