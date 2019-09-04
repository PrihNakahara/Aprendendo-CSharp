using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LacoFor
{
    class Program
    {
        static void Main(string[] args)
        {
            //tabuada com for 

            for (int mult = 1; mult <= 10; mult++)
            {
                Console.WriteLine("Tabuada do " + mult);

                for (int cont = 0; cont <= 10; cont++)
                {
                    Console.Write(mult + " X " + cont + " = " + mult * cont);
                    Console.WriteLine();//para alinhar codigo
                }
                Console.WriteLine();
            }
            Console.ReadLine(); 
        }
    }
}
