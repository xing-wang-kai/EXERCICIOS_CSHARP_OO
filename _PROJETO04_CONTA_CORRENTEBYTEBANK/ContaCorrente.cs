using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using _PROJETO04_CONTA_CORRENTEBYTEBANK;

namespace _PROJETO04_CONTA_CORRENTEBYTEBANK
{
    public class ContaCorrente
    {
        public static int TotalContas { get; private set; }
        public ContaCorrente(int agencia, int numero, double saldo)
        {
            if(agencia <= 0 || numero <= 0)
            {
                throw new ArgumentException("Agencia ou número negativos", nameof(agencia));
            }
            this.setSaldo(saldo);
            this.setAgencia(agencia);
            this.setNumero(numero);
            ContaCorrente.TotalContas++;
        }
        public Cliente titular;
        private int agencia;
        private readonly int numero;
        private double saldo;
        public double _limite = 1000;

        public double Limite {
            get
            {
                return _limite;
            }
            set
            {
                this._limite = value;
            }
        }

        public int getAgencia()
        {
            return this.agencia;
        }
        public void setAgencia( int valor)
        {
            this.agencia = valor;
        }
        public int getNumero()
        {
            return this.numero;
        }
        public void setNumero( int valor)
        {
            this.numero = valor;
        }

        public double getSaldo()
        {
            return this.saldo;
        }
        public void setSaldo(double valor)
        {
            if (valor < 0)
            {
                Console.WriteLine("O saldo informado é: " + valor + " não é possivel definir saldos negativos");
            }
            else
            {
                this.saldo = valor;
            }
        }
        public bool Sacar(double valor)
        {
            if (this.saldo < valor)
            {
          
                return false;
            }
            else
            {
                this.saldo -= valor;
                return true;
            }
        }
        
        public void Depositar(double valor)
        {
            this.saldo += valor;
        }
        public bool Transferir(double valor, ContaCorrente Destino)
        {
            if (this.saldo < valor)
            {
                return false;
            }
            else
            {
                this.Sacar(valor);
                Destino.Depositar(valor);
                return true;
            }
        }
    }

}









