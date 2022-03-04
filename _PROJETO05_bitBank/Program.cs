using System;

namespace _PROJETO05_bitBank
{
    public class Program
    {
        static void Main(string[] args)
        {
            Diretor Fernanda = new Diretor("Fernanda Figuereido", "222.222.222-22", 1500.00);
            Fernanda.Senha = "12345";
            Designer Jose = new Designer("Jose Antonio da Silva", "333.333.333-33", 1000.00);
            GerenteContas Angelica = new GerenteContas("Angelica dos Santos", "444.444.444-44", 1000.00);
            Auxiliar Lucilene = new Auxiliar("lucilene Costa e costa", "555.555.555-55", 1000.00);


            Console.WriteLine("DIRETOR: ");
            Console.WriteLine("NOME: " + Fernanda.Nome);
            Console.WriteLine("SALARIO: " + Fernanda.Salario);
            Console.WriteLine("CPF: " + Fernanda.getCpf());
            Console.WriteLine("BONIFICAÇÂO: " + Fernanda.GetBonificacao());
            Fernanda.AumentarSalario();
            Console.WriteLine("NOVO SALARIO DE FERNANDA: " + Fernanda.Salario);
            Console.WriteLine();

            Console.WriteLine("DESIGNER: ");
            Console.WriteLine("NOME: " + Jose.Nome);
            Console.WriteLine("SALARIO: " + Jose.Salario);
            Console.WriteLine("CPF: " + Jose.getCpf());
            Console.WriteLine("BONIFICAÇÂO: " + Jose.GetBonificacao());
            Jose.AumentarSalario();
            Console.WriteLine("NOVO SALARIO DE FERNANDA: " + Jose.Salario);
            Console.WriteLine();

            Console.WriteLine("GERENTE DE CONTAS: ");
            Console.WriteLine("NOME: " + Angelica.Nome);
            Console.WriteLine("SALARIO: " + Angelica.Salario);
            Console.WriteLine("CPF: " + Angelica.getCpf());
            Console.WriteLine("BONIFICAÇÂO: " + Angelica.GetBonificacao());
            Angelica.AumentarSalario();
            Console.WriteLine("NOVO SALARIO DE FERNANDA: " + Angelica.Salario);
            Console.WriteLine();

            Console.WriteLine("AUXILIAR: ");
            Console.WriteLine("NOME: " + Lucilene.Nome);
            Console.WriteLine("SALARIO: " + Lucilene.Salario);
            Console.WriteLine("CPF: " + Lucilene.getCpf());
            Console.WriteLine("BONIFICAÇÂO: " + Lucilene.GetBonificacao());
            Lucilene.AumentarSalario();
            Console.WriteLine("NOVO SALARIO DE FERNANDA: " + Lucilene.Salario);
            Console.ReadLine();
            
            SistemaInterno SistemaInterno  = new SistemaInterno();

            SistemaInterno.Logar(Fernanda, "12345");
            SistemaInterno.Logar(Fernanda, "boolitas");
            
            
        }
    }

}

