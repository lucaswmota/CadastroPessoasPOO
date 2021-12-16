namespace CadastroPessoasPOO
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cadastro de Pessoas" +
                "\n1 - Cadastro de Professor" +
                "\n2 - Cadastro de Aluno" +
                "\n3 - Cadastro de Funcionario" +
                "\n4 - Encerrar");
            int decisao = int.Parse(Console.ReadLine());

            while (decisao == 1)
            {
                Professor professor = new Professor();

                professor.cadastrar();

                professor.exibir();

                Console.WriteLine("Cadastro de Pessoas" +
                "\n1 - Cadastro de Professor" +
                "\n2 - Cadastro de Aluno" +
                "\n3 - Cadastro de Funcionario" +
                "\n4 - Encerrar");
                decisao = int.Parse(Console.ReadLine());
            }

            while (decisao == 2)
            {
                Aluno aluno = new Aluno();

                aluno.cadastrar();

                aluno.exibir();

                Console.WriteLine("Cadastro de Pessoas" +
                "\n1 - Cadastro de Professor" +
                "\n2 - Cadastro de Aluno" +
                "\n3 - Cadastro de Funcionario" +
                "\n4 - Encerrar");
                decisao = int.Parse(Console.ReadLine());
            }

            while (decisao == 3)
            {
                Funcionario funcionario = new Funcionario();

                funcionario.cadastrar();

                funcionario.exibir();

                Console.WriteLine("Cadastro de Pessoas" +
                "\n1 - Cadastro de Professor" +
                "\n2 - Cadastro de Aluno" +
                "\n3 - Cadastro de Funcionario" +
                "\n4 - Encerrar");
                decisao = int.Parse(Console.ReadLine());
            }

            while (decisao == 4)
            {
                Console.WriteLine("Pressione Qualquer tecla para encerrar...");
                Console.ReadKey(); 
                Environment.Exit(0);
            }


        }
    }
}