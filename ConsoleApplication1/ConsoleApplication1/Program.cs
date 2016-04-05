using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var dog = new Soma();
            var dog2 = new Soma();
            dog.Somar(2, 2);
            dog2.Somar(5, 5);
            
            string strx = dog.Total.ToString();
            string stry = dog2.Total.ToString();

            Console.WriteLine(strx);
            Console.WriteLine(stry);
            Console.ReadLine();

        }
    }
}
