using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaPriscila = new ContaCorrente();
            contaDaPriscila.titular = "Priscila";
            contaDaPriscila.agencia = 410;
            contaDaPriscila.numero = 708840;

            ContaCorrente contaDaPriscilaNakahara = new ContaCorrente();
            contaDaPriscilaNakahara.titular = "Priscila";
            contaDaPriscilaNakahara.agencia = 410;
            contaDaPriscilaNakahara.numero = 708840;

            Console.WriteLine("Igualdade de tipo de referência:" + (contaDaPriscila == contaDaPriscilaNakahara));

            int idade = 27;
            int idadeMaisUmaVez = 27;

            Console.WriteLine("Igualdade de tipo de valor: " + (idade == idadeMaisUmaVez));


            contaDaPriscila = contaDaPriscilaNakahara;
            Console.WriteLine(contaDaPriscila == contaDaPriscilaNakahara);


            contaDaPriscila.saldo = 300;
            Console.WriteLine(contaDaPriscila.saldo);
            Console.WriteLine(contaDaPriscilaNakahara.saldo);

            //Mão na Massa
            ContaCorrente contaDoJonathan = new ContaCorrente();
            
            contaDaPriscila.Depositar(300.00);
            contaDaPriscilaNakahara.Sacar(50.00);
            contaDaPriscila.Transferir(100.00, contaDoJonathan);

            Console.ReadLine();
        }
    }
}
