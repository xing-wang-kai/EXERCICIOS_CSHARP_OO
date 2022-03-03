using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _PROJETO04_CONTA_CORRENTEBYTEBANK
{
    public class Cliente
    {  public Cliente(string nome, string cpf, string profissao)
        {
            this.Nome = nome;
            this.Cpf = cpf;
            this.Profisao = profissao;
        }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Profisao { get; set; }
    }
}



namespace _PROJETO04_CONTA_CORRENTEBYTEBANK
{
    public class Conta
    {
        public static int TotalContas { get; private set; }
        public Conta(int numero, double saldo)
        {
            setNumero(numero);
            setSaldo(saldo);
            this.limite = 1000;
            Conta.TotalContas++;
        }
        public Pessoa titular;
        private int numero;
        private double saldo;
        private double limite;

        public int getNumero()
        {
            return numero;
        }
        public void setNumero(int value)
        {
            this.numero = value;
        }
        public double getSaldo()
        {
            return saldo;
        }
        public void setSaldo(double value)
        {
            this.saldo = value;
        }
        
        public void sacar(double valor)
        {
            this.saldo -= valor;
        }
    }
}

namespace _PROJETO04_CONTA_CORRENTEBYTEBANK
{
    public class Pessoa
    {
        public string nome;
        public string cpf;
    }
}

