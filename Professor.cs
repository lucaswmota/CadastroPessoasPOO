using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoasPOO
{
    internal class Professor
    {

        int id { get; set; }
        string nome { get; set; }
        string disciplina { get; set; }
        string formacao { get; set; }

        public void cadastrar()
        {
            id = new Random().Next(1, 100);

            Console.WriteLine($"ID Automático: {id}");

            Console.WriteLine("Insira o Nome");
            nome = Console.ReadLine();

            Console.WriteLine("Insira a Disciplina");
            disciplina = Console.ReadLine();

            Console.WriteLine("Insira a Formação");
            formacao = Console.ReadLine();
        }

        public void exibir()
        {
            Console.WriteLine($"Cadastro de Professor(a)" +
                $"\nID {id}" +
                $"\n{nome}" +
                $"\n{disciplina}" +
                $"\n{formacao}");
        }
    }
}
