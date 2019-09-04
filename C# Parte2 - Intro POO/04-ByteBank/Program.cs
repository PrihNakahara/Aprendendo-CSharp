using _05_ByteBank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoBruno = new ContaCorrente();
            
            contaDoBruno.titular.nome = "Bruno";
            
            Console.WriteLine(contaDoBruno.saldo);
            
            bool resultadoSaque = contaDoBruno.Sacar(500);
            
            Console.WriteLine(resultadoSaque);
            Console.WriteLine(contaDoBruno.saldo);
             
            contaDoBruno.Depositar(500); 
            Console.WriteLine(contaDoBruno.saldo);
            
            ContaCorrente contaDaGabriela = new ContaCorrente();
            
            contaDaGabriela.titular.nome = "Gabriela";
            
            Console.WriteLine("Saldo do Bruno: " + contaDoBruno.saldo);
            Console.WriteLine("Saldo do Gabriela: " + contaDaGabriela.saldo);
            
            bool resultadoTransferencia = contaDoBruno.Transferir(2000, contaDaGabriela);
            
            Console.WriteLine("Saldo do Bruno: " + contaDoBruno.saldo);
            Console.WriteLine("Saldo do Gabriela: " + contaDaGabriela.saldo);

            Console.WriteLine("Resultado transferência: " + resultadoTransferencia);

            contaDaGabriela.Transferir(100, contaDoBruno);

            Console.WriteLine("Saldo do Bruno: " + contaDoBruno.saldo);
            Console.WriteLine("Saldo do Gabriela: " + contaDaGabriela.saldo);

            //Mão na Massa
            ContaCorrente contaDaCamila = new ContaCorrente();
            contaDaCamila.titular = new Cliente();

        Console.ReadLine();
        }
    }
}
