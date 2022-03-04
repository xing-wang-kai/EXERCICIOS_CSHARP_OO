using System;
using System.Text;
using System.Threading.Tasks;

namespace _PROJETO05_bitBank
{
    internal class Diretor: Funcionario, Autenticavel
    {
        public Diretor(string Nome, string Cpf, double Salario) : base(Nome, Cpf, Salario)
        {
        }
        public string Senha { get; set; }
        public override double GetBonificacao()
        {
            return this.Salario + 1;
        }
        public override void AumentarSalario()
        {
           this.Salario *= 1.15;
        }
        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }

    }
}