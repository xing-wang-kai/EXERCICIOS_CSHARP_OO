namespace _PROJETO05_bitBank
{
    internal class Auxiliar : Funcionario
    {
        public Auxiliar(string Nome, string Cpf, double Salario) : base(Nome, Cpf, Salario)
        {

        }
        public override double GetBonificacao()
        {
            return this.Salario * 0.20;
        }
        public override void AumentarSalario()
        {
            this.Salario *= 1.1;
        }
    }
}