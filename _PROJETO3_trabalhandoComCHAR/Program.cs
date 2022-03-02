using System;

namespace _PROJETO3_trabalhandoComCHAR
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * CHAR armazena alguns tipos de caracteres como char
             * STRING: adiciona uma fraze é esperando ""
             * **/
            string abertura = @"

       +-------------------------------------------------+
       |+-----------------------------------------------+|
       ||---PROJETO 02, executando váriaveis com o C#---||
       ||--------------MANIPULANDO STRINGS--------------||
       |+-----------------------------------------------+|
       +-------------------------------------------------+";


            Console.WriteLine(abertura);

            Console.WriteLine("");

            char primeiraLetra = 'a';

            Console.WriteLine(primeiraLetra);

            string segundaLetra = "Esta é uma string!";
            Console.WriteLine(segundaLetra);

            Console.ReadLine();
        }
    }
}
