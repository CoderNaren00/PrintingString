using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingString
{
    internal class Program
    {
        //Printing String as it is...
        static void Main(string[] args)
        {
            Console.Write("Enter String to be printed :");
            string name = Console.ReadLine();
            Console.WriteLine("The string you entered is :" + name);
            Console.ReadKey();
        }
    }
}
