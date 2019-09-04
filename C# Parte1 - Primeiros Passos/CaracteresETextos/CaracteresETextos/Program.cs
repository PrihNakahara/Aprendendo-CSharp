using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            char letra = 'a';
            Console.WriteLine(letra);

            //Caractere tabela ASCII
            char valor = (char)65;  
            Console.WriteLine(valor);

            // Não compila!
            //valor = valor + 1;         
            //Console.WriteLine(valor);

            //Soma a letra seguinte na tabela 
            valor = (char)(valor + 1);         
            Console.WriteLine(valor);

            string palavra = "alura cursos online de tecnologia";
            Console.WriteLine(palavra);

            palavra = palavra + 2020;
            Console.WriteLine(palavra);

            Console.ReadLine();
        }
    }
}
