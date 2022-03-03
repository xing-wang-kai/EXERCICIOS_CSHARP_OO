using System;
using System.Text;
using System.Threading.Tasks;

namespace _PROJETO05_bitbank
{
	public class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public double Salario { get; set; }

        public double GetBonificacao()
        {
            return salario * 0.10;
        }
    }
}

