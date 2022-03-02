using System;

namespace _projeto02_criandovariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("---PROJETO 02, executando váriaveis com o C#---");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("");

            /*Váriaveis assim como outras linguagens de programação podem ser
             * declaradas como inteiro, no caso int
             * 
             * SHORT: -  valor pequenos 16bits
             * 
             * INT: - valor médios 32bits
             * 
             * LONG: -  número maiores 64bits
             * 
             * DOUBLE: para efetuar operações com o DOUBLE é necessário colocar
             * então o .0 após o número para converter para double e ter este retornado
             * caso os dois números na operações
             * 
             * FLOAT: Precisão muito curta de casas decimais, para usar o float deve informar
             * ao número que é float colocando o suficixo f após o valor ex.: 1.40f;
             * 
             * usando o (int) para converter o número double para inteiro quando ele é
             * adicionado dentro de uma váriavel do tipo inteiro.
             * 
             * BYTE: armazena 1byte; true e false;
             * 
             * **/

            int idade;
            double salario;
            idade = 15;
            salario = 1200.40;

            int salariointeiro;

            salariointeiro = (int)salario;

            Console.WriteLine(salario);

            while(idade <= 50)
            {
                idade++;
                if(idade == 20)
                {
                    Console.WriteLine("Você é maior de idade");
                }
                Console.WriteLine(idade);
            }
           
            
           
            Console.ReadLine();
        }
    }

}
