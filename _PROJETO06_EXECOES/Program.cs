using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _PROJETO06_EXECOES
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Metodo();
            }
            catch (DivideByZeroException erro)
            {
                Console.WriteLine("não é possivel dividir por 0");
                Console.WriteLine(erro.StackTrace);
                Console.WriteLine(erro.Message);
                Console.ReadLine();
            }
            catch (Exception erro)
            {
                Console.WriteLine("Ocorreu um erro do tipo genérico");
                 Console.WriteLine(erro.Message);
            }
            
            Console.ReadLine();
        }
        private static void Metodo()
        {
            TestaDivisao(0);
            TestaDivisao(2);
        }
        private static void TestaDivisao(int divisor)
        {
            
            int resultado = Dividir(10, divisor);
            Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);        
        }
        private static int Dividir(int numero, int divisor)
        {
            try
            {
                return numero / divisor;
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine('Excesão com numero divido por Zero')
                throw;
            }
        }
    }
}