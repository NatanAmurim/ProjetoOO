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

            // CalcularBonificacao();
            UsarSistema();
            Console.ReadLine();
        }

        public static void UsarSistema() 
        {
            SistemaInterno sistemaInterno = new SistemaInterno();
            
            Diretor robertooo = new Diretor("123.456.789.01");
            robertooo.Nome = "Robertooo";
            robertooo.Senha = "123";

            GerenteConta jennifer = new GerenteConta("123.456.789.01");
            jennifer.Nome = "Jennifer";
            jennifer.Senha = "456";

            ParceiroComercial parceiroComercial = new ParceiroComercial();
            parceiroComercial.Senha = "123";

            sistemaInterno.Logar(robertooo, "123");
            sistemaInterno.Logar(jennifer, "456");
            sistemaInterno.Logar(parceiroComercial, "123");


        }

        public static void CalcularBonificacao() 
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();
            
            Designer pedrinho = new Designer("123.456.789.01");
            pedrinho.Nome = "Pedrinho";

            Diretor robertooo = new Diretor("123.456.789.01");
            robertooo.Nome = "Robertoooo";

            Auxiliar igor = new Auxiliar("123.456.789.01");
            igor.Nome = "Cigano";

            GerenteConta camila = new GerenteConta("123.456.789.01");
            camila.Nome = "Camila";

            gerenciadorBonificacao.RegistrarFuncionario(pedrinho);
            gerenciadorBonificacao.RegistrarFuncionario(robertooo);
            gerenciadorBonificacao.RegistrarFuncionario(igor);
            gerenciadorBonificacao.RegistrarFuncionario(camila);

            Console.WriteLine("Total de bonificações do mês: "+gerenciadorBonificacao.GetBonificacao());
        }
    }
}
