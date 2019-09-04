using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestaPontoFlutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Criando variaveis com Ponto Flutuante");

            double salario;
            salario = 1200.70;

            Console.WriteLine(salario);
            Console.WriteLine("meu salario é " + salario);

            // não compila.
            //int valor = 12.5;   

            int divisao = 5 / 2;
            Console.WriteLine(divisao);

            //divisão com ponto flutuante no denominador ou numerador
            double idade;
            idade = 15 / 2.0;
            Console.WriteLine(idade);

            idade = 15.0 / 3;
            Console.WriteLine("15.0 / 3 = " + idade);

            Console.ReadLine();
        }
    }
}
