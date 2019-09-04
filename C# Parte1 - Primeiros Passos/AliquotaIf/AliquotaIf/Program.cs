using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliquotaIf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculo da Aliquota com Ifs");


            double salario = 4700.0;
            double calculoAq;

            if (salario >= 1900.0 && salario <= 2800.0)
            {
                Console.WriteLine("A sua aliquota é de 7.5%");
                calculoAq = salario * 0.075;
                Console.WriteLine("Você pode deduzir até R$ " + calculoAq);
            }
            else if (salario >= 2800.01 && salario <= 3751.0)
            {
                Console.WriteLine("A sua aliquota é de 15%");
                calculoAq = salario * 0.15;
                Console.WriteLine("Você pode deduzir até R$ " + calculoAq);
            }
            else if (salario >= 3751.01 && salario <= 4664.0)
            {
                Console.WriteLine("A sua aliquota é de 22.5%");
                calculoAq = salario * 0.225;
                Console.WriteLine("Você pode deduzir até R$ " + calculoAq);
            } 
            else
            {
                Console.WriteLine("Entre com um valor menor que 4664.00 reais!!!");
            }
            
            Console.WriteLine("Tecle Enter para sair!");
            Console.ReadLine();
        }
    }
}
