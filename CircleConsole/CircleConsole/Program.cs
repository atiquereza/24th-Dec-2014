using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Clrcle newClrcle=new Clrcle();
            Console.WriteLine("Enter Radius:");
            newClrcle.radius = Convert.ToInt32(Console.ReadLine());
            newClrcle.ShowArea(newClrcle);
            newClrcle.ShowDiameter(newClrcle);
            newClrcle.ShowPerimeter(newClrcle);
            Console.ReadKey();
        }
    }
}
