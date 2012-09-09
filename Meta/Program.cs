using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meta
{
    class Program
    {
        static void Main(string[] args)
        {
            var display1 = new Display();
            var display2 = new Display();
            var algorithm = new Algorithm();

            algorithm.Execute(new [] { display1, display2 });
            Console.ReadLine();
        }
    }
}
