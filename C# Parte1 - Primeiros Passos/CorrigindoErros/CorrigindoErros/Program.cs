using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrigindoErros
{
    class Program
    {
        static void Main(string[] args)
        {
            //loop infinito
            //while (contador <= 10)
            //{
            //    int contador = 1;
            //    Console.WriteLine(contador);
            //    contador++;
            //}

            int contador = 1;
            while (contador <= 10)
            {
                Console.WriteLine(contador);
                contador++;
            }
            Console.ReadLine();
        }
    }
}
