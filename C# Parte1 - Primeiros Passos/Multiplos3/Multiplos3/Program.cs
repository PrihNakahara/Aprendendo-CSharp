using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplos3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numeros Multiplos de 3 - do 1 ao 1000");
            int numero;

            Console.WriteLine("Digite um numero de 1 a 1000: ");
            numero = Convert.ToInt16(Console.ReadLine());

            if (numero % 3 == 0)
            {
                Console.WriteLine("Numero Multiplo de 3!");
            }
            else
            {
                Console.WriteLine("Não é um Multiplo de 3!");
            }
            Console.ReadLine();
        }
    }
}
