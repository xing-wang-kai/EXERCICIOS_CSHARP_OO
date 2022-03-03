using System;

namespace _PROJETO05_bitBank
{
    public class Program
    {
        static void Main(string[] args)
        {
            Funcionario Carlos = new Funcionario("Carlos Costa e costa", "111.111.111-11", 2000.00);
            Funcionario Fernanda = new Funcionario("Fernanda Figuereido", "222.222.222-22", 1500.00);
            Funcionario Jose = new Funcionario("Jose Antonio da Silva", "333.333.333-33", 3000.00);
            Diretor Angelica = new Diretor("Angelica dos Santos", "444.444.444-44", 8000.00);

            Console.WriteLine("FUNCIONÁRIO: ");
            Console.WriteLine("NOME: " + Fernanda.Nome);
            Console.WriteLine("SALARIO: " + Fernanda.Salario);
            Console.WriteLine("CPF: " + Fernanda.getCpf());
            Console.WriteLine("BONIFICAÇÂO: " + Fernanda.GetBonificacao());
            Console.WriteLine();

            Console.WriteLine("FUNCIONÁRIO: ");
            Console.WriteLine("NOME: " + Jose.Nome);
            Console.WriteLine("SALARIO: " + Jose.Salario);
            Console.WriteLine("CPF: " + Jose.getCpf());
            Console.WriteLine("BONIFICAÇÂO: " + Jose.GetBonificacao());
            Console.WriteLine();

            Console.WriteLine("FUNCIONÁRIO: ");
            Console.WriteLine("NOME: " + Carlos.Nome);
            Console.WriteLine("SALARIO: " + Carlos.Salario);
            Console.WriteLine("CPF: " + Carlos.getCpf());
            Console.WriteLine("BONIFICAÇÂO: " + Carlos.GetBonificacao());
            Console.WriteLine("TOTAL FUNCIONÁRIOS: " + Funcionario.TotalFUncionario);
            Console.WriteLine();

            Console.WriteLine("DIRETOR: ");
            Console.WriteLine("NOME: " + Angelica.Nome);
            Console.WriteLine("SALARIO: " + Angelica.Salario);
            Console.WriteLine("CPF: " + Angelica.getCpf());
            Console.WriteLine("BONIFICAÇÂO: " + Angelica.GetBonificacao());

            Console.ReadLine();
            
        }
    }
}

