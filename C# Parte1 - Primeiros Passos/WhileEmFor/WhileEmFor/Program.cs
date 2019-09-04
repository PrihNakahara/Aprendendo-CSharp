using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileEmFor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Em While
            int contador = 1;
            while (contador <= 10)
            {
                Console.WriteLine(contador);
                contador++;
            }

            //Em For
            for (int contador2 = 1; contador2 <= 10; contador2++)
            {
                Console.WriteLine(contador2);
            }
        }
    }
}
