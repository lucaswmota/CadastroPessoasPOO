using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoasPOO
{
    internal class Aluno
    {
        int id { get; set; }
        string nome { get; set; }
        string curso { get; set; }
        string cidade { get; set; }

        public void cadastrar()
        {
            id = new Random().Next(1, 100);

            Console.WriteLine($"ID Automático {id}");

            Console.WriteLine("Insira um Nome");
            nome = Console.ReadLine();

            Console.WriteLine("Insira o Curso");
            curso = Console.ReadLine();

            Console.WriteLine("Insira a Cidade");
            cidade = Console.ReadLine();
        }

        public void exibir()
        {
            Console.WriteLine($"Cadastro de Aluno" +
                $"\nID {id}" +
                $"\n{nome}" +
                $"\n{curso}" +
                $"\n{cidade}");
        }
    }
}
