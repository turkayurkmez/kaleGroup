using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usingInterface
{

    public interface IZoomable
    {
        void Zoom();
    }
    public class Gun
    {
        public int HitPoint { get; set; }
    }

    public class Riffle : Gun
    {

    }

    public class KanasSniper : Gun, IZoomable
    {
        public void Zoom()
        {
            Console.WriteLine("Kanas ile zoom yapılıyor");
        }
    }

    public class LightMachine : IZoomable
    {
        public void Zoom()
        {
            Console.WriteLine("Hafif makineli ile zoom yapılıyor");
        }
    }
}
