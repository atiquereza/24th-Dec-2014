using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleConsole
{
    class Clrcle
    {
        public int radius;

        public void ShowArea(Clrcle aClrcle)
        {
            double area = aClrcle.radius * aClrcle.radius * 3.14;
            Console.WriteLine("Area is: " + area);
        }

        public void ShowPerimeter(Clrcle aClrcle)
        {
            double area = 2 * aClrcle.radius * 3.14;
            Console.WriteLine("Perimeter is: " + area);
        }

        public void ShowDiameter(Clrcle aClrcle)
        {
            double area = 2 * aClrcle.radius;
            Console.WriteLine("Diameter is: " + area);
        }
    }
}
