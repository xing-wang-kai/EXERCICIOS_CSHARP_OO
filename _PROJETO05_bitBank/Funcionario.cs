using System;
using System.Text;
using System.Threading.Tasks;

namespace _PROJETO05_bitBank
{
    public class Funcionario
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
        public double Salario;

        public string getCpf()
        {
            return this.Cpf;
        }
        public void setCpf(string value)
        {
            this.Cpf = value;
        }
        //public double Salario
        //{
        //    get { return this.Salario; }
        //    set { this.Salario = value; }
        //}

        public virtual double GetBonificacao()
        {
            return Salario * 0.10;
        }
    }
}