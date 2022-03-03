using System;
using System.Text;
using System.Threading.Tasks;

namespace _PROJETO05_bitBank
{
    internal class Diretor: Funcionario
    {
        public Diretor(string Nome, string Cpf, double Salario) : base(Nome, Cpf, Salario)
        {
        }

        public override double GetBonificacao()
        {
            return Salario + base.GetBonificacao();
        }
    }
}