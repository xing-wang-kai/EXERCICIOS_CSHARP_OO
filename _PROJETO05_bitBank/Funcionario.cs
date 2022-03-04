using System;
using System.Text;
using System.Threading.Tasks;

namespace _PROJETO05_bitBank
{
    public abstract class Funcionario
    {
        public static int TotalFUncionario { get; private set; }
        public Funcionario(string Nome, string Cpf, double Salario)
        {
            this.Nome = Nome;
            setCpf(Cpf);
            this.Salario = Salario;
            TotalFUncionario++;
        }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public double Salario { get; protected set; }

        public string getCpf()
        {
            return this.Cpf;
        }
        public void setCpf(string value)
        {
            this.Cpf = value;
        }
       
        public abstract double GetBonificacao();
        public abstract void AumentarSalario();
       
    }
}