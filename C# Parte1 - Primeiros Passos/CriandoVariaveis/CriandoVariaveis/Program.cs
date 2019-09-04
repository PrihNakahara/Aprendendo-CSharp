using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Segundo Projeto - Criação de Variáveis");

            //criação e atrbuicao de valor 
            int idade = 32;

            Console.WriteLine(idade);

            //Atribuindo novo valor a variavsel idade
            idade = 10;
            Console.WriteLine(idade);

            //soma
            idade = 10 + 2;
            Console.WriteLine(idade);

            //multiplicação
            idade = 10 * 2;
            Console.WriteLine(idade);

            //subtração
            idade = 10 - 2;
            Console.WriteLine(idade);   

            //divisão
            idade = 10 / 2;
            Console.WriteLine(idade);

            Console.WriteLine("Sua idade é " + idade + "! Parabéns!!!!!!");

            Console.ReadLine();
        }
    }
}
