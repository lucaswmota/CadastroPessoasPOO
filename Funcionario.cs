using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoasPOO
{
    internal class Funcionario
    {
        int id { get; set; }
        string nome { get; set; }
        string funcao { get; set; }
        double salario { get; set; }


        public void cadastrar()
        {
            id = new Random().Next(1, 100);

            Console.WriteLine($"ID Automático {id}");

            Console.WriteLine("Insira um Nome");
            nome = Console.ReadLine();

            Console.WriteLine("Insira a Função");
            funcao = Console.ReadLine();

            Console.WriteLine("Insira o Salario");
            salario = double.Parse(Console.ReadLine());
        }

        public void exibir()
        {
            Console.WriteLine($"Cadastro de Funcionario" +
                $"\nID {id}" +
                $"\n{nome}" +
                $"\n{funcao}" +
                $"\n{salario.ToString("C")}");
        }
    }
}
