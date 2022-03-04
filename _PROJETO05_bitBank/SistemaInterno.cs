using System;


namespace _PROJETO05_bitBank
{
    internal class SistemaInterno
    {
        public bool Logar(Autenticavel funcionario, string senha)
        {
            bool usurioAutenticado = funcionario.Autenticar(senha);

            if (usurioAutenticado)
            {
                Console.WriteLine("Bem vindo ao Sistema!!");
                return true;
            }
            else
            {
                Console.WriteLine("SENHA INCORRETA!!!!");
                return false;
            }
        }
    }
}