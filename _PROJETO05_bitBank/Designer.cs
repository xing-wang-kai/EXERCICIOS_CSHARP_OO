using System;
using System.Text;
using System.Threading.Tasks;

namespace _PROJETO05_bitBank
{
    internal class Designer : Funcionario
    {
        public Designer(string Nome, string Cpf, double Salario) : base(Nome, Cpf, Salario)
        {

        }
        public override double GetBonificacao()
        {
            return this.Salario * 0.17;
        }
        public override void AumentarSalario()
        {
            this.Salario *= 1.11;
        }
    } 
}
