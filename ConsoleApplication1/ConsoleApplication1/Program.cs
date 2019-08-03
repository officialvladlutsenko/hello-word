using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, num_1; 
            Console.WriteLine("Enter first num: 2");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter second num:");
            num_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The result is:" + (num + num_1).ToString ());
            Console.ReadKey ();
        }
    }
}
