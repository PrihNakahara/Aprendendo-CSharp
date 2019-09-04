using ByteBank.Funcionarios;
using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            UsarSistema();
            Console.ReadLine(); 
        }
        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor flavia = new Diretor("080.753.398-55");
            flavia.Nome = "Flávia";
            flavia.Senha = "123";

            GerenteDeConta carolina = new GerenteDeConta("234.985.628-76");
            carolina.Nome = "Carolina";
            carolina.Senha = "abc";

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "123ABC";

            sistemaInterno.Logar(flavia, "123"); 
            sistemaInterno.Logar(carolina, "abc");
            sistemaInterno.Logar(parceiro, "123456");
        }

        public static void CalcularBonificacao() 
        {
            //Instancia 
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Funcionario priscila = new Designer("410.714.998-36");
            priscila.Nome = "Priscila";

            Funcionario sheila = new Diretor("000.753.398-06");
            sheila.Nome = "Sheila";

            Funcionario aline = new Auxiliar("432.198.987-53");
            aline.Nome = "Aline";

            Funcionario bia = new GerenteDeConta("644.985.628-10");
            bia.Nome = "Beatriz";

            Desenvolvedor jonathan = new Desenvolvedor("311.175.468-26"); 
            jonathan.Nome = "Jonathan"; 

            gerenciadorBonificacao.Registrar(jonathan);
            gerenciadorBonificacao.Registrar(priscila);
            gerenciadorBonificacao.Registrar(sheila);
            gerenciadorBonificacao.Registrar(aline);
            gerenciadorBonificacao.Registrar(bia);

            Console.WriteLine("Total de bonificações do mês " +
                gerenciadorBonificacao.GetTotalBonificacao());
            Console.ReadLine();
        }
    }
}