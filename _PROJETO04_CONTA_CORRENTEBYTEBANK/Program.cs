using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _PROJETO04_CONTA_CORRENTEBYTEBANK
{
    class Program
    {
        static void Main(string[] args)
        {

            string abertura = @"

       +-------------------------------------------------+
       |+-----------------------------------------------+|
       ||---PROJETO 02, executando váriaveis com o C#---||
       ||--------------MANIPULANDO OBJETOS--------------||
       |+-----------------------------------------------+|
       +-------------------------------------------------+";

            Console.WriteLine(abertura);
            
            ContaCorrente Conta01 = new ContaCorrente(123, 12301, 2000);

            Conta01.titular = new Cliente("Gabriela", "111.111.111-11", "desenvolvedora C#");

            Console.WriteLine(ContaCorrente.TotalContas);

            ContaCorrente Conta02 = new ContaCorrente(123, 12302, 3000);
            Conta02.titular = new Cliente("Pedro", "222.222.222-22", "desenvolvedor Python");

            Console.WriteLine(ContaCorrente.TotalContas);

            ContaCorrente Conta03 = new ContaCorrente(123, 12303, 3000);
            Conta02.titular = new Cliente("Hermano", "333.333.333-33", "desenvolvedor Java");

            Console.WriteLine(ContaCorrente.TotalContas);

            Conta01.Sacar(900);
            Conta01.Limite = 2000.00;

            Console.WriteLine("NOME: " + Conta01.titular.Nome);
            Console.WriteLine("AGENCIA: " + Conta01.getAgencia() );
            Console.WriteLine("NUMERO: " + Conta01.getNumero() );
            Console.WriteLine("SALDO: " + Conta01.getSaldo() );
            Console.WriteLine("LIMITE: " + Conta01.Limite );

            Console.ReadLine();
        }
    }

}