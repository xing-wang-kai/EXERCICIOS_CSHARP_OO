# C# do Básico ao Avançado:
----------------------------------------------------------------------------
PARTE 001 – ORIENTAÇÃO A OBJETOS;
----------------------------------------------------------------------------

## 1) CRIANDO OBJETOS EM CSHAP;
-Para criar objetos em C# vamos primeiro no projeto desejado e criamos um item do tipo Class e então definimos o objeto com no exemplo abaixo.
public class Conta
{
    public string titular;
    public int numero;
    public double saldo;
    public double limite;
}
----------------------------------------------------------------------------

## 2) ACESSANDO OBJTOS DENTRO DO PROJETO:
-Para acessar o objeto dentro do projeto precisamos definir o mesmo namespace para todos
namespace _PROJETO01
{
 
//DEFINA A CLASS DO SEU OBJETO AQUI
}
-O namespace ajuda a definir a interação entre objetos dentro do projeto e executar o mesmo dentro de uma solução; caso tenhamos um objeto conta que precisa de uma class titular, se ambos estiverem no mesmo namespace basta executar:
	namespace _PROJETO01
{
    public class Conta
    {
        public Pessoa titular;
        public int numero;
        public double saldo;
        public double limite;
    }
}

namespace _PROJETO01
{
    public class Pessoa
    {
        public string nome;
        public string cpf;
    }}

- Desta forma conseguimos colocar a classe Pessoa dentro de Conta e invocar a mesma sem problemas;

----------------------------------------------------------------------------

## 3) ENVOCANDO NOVOS OBJTOS COM CLASS;

-Uma vez incluídos no mesmo Namespace podemos invocar os objetos e construir sua sintase com o seguinte comando;

Conta Conta1 = new Conta();
            Conta1.saldo = 100.00;
            Conta1.limite = 300.00;

            Conta1.titular = new Pessoa();
            Conta1.titular.nome = "Francisco";
            Conta1.titular.cpf = "111.111.111-11";
OBS:: Este método tem que ser invocado dentro da static void Main(string[] args){} para funcionar:
----------------------------------------------------------------------------
## 4) METHODS EM OBJTOS
- Objetos podem ser ações, que são definidas por verbos, nesse caso chamados de Methods:
namespace _PROJETO01
{
    public class Conta
    {
        public Pessoa titular;
        public int numero;
        public double saldo;
        public double limite;

        public void sacar(double valor)
        {
            this.saldo -= valor;
        }
    }
}
----------------------------------------------------------------------------
## 5) PRIVATES PUBLIC E PROTECTED – USANDO GETTES E SETTES
-Podemos manter uma instancia da class como privada, isso protege que ela seja estanciada fora da class, os métodos privados permitem o uso da propriedade na class ou em suas filhas e o protegido a instancia jamais poderá ser iniciada.
### 5.1) usando Getters e setters 
-Para acessar uma instancia protegida e editar ou ver seus valores precisamos usar os métodos settes e Gettes que são construídos da seguinte maneira.
namespace _PROJETO01
{
    public class Conta
    {
        public Pessoa titular;
        private int numero;
        private double saldo;
        private double limite;

        public int getNumero()
        {
            return numero;
        }
        public void setNumero(int valor)
        {
            this.numero = valor;
        }
        public void sacar(double valor)
        {
            this.saldo -= valor;
        }
    }
}
-É orientado que construa um para cada instancia que deseja proteger, encapsulando assim o mesmo. Desta forma não podemos mais atribuir valores fora da class a não ser que seja envocado como Getters ou Setters;
### 5.2 ) Outra forma de usar os métodos Getters e Setters;
-Também podemos chamar estes métodos de forma mais simples;
namespace _PROJETO01
{
    public class Conta
    {
        public Pessoa titular;
        private int numero;
        private double saldo;
        private double limite;

        public int Numero
        {
            get
            {
                return numero;
            }
            set
            {
                this.numero = value;
            }
        }
        public void sacar(double valor)
        {
            this.saldo -= valor;
        }
    }
}
-Nesta abordagem facilita criar os methods Getter e Setter, mesmo não estanciando o valor o method SETTERS pode ser chamado value.
### 5.3 ) Simplificando ainda mais como envocar os methods Setters e Getters;
namespace _PROJETO01
{
    public class Conta
    {
        public Pessoa titular;
        private int numero;
        private double saldo;
        private double limite;

        public int Numero { get; private set; }
        
        public void sacar(double valor)
        {
            this.saldo -= valor;
        }}}

-Desta maneira o method get continua publico e o setters foi privado e não poderá ser estanciado, o sistema cria automaticamente o método e para invocar o mesmo no objeto basta somente:
Conta Conta1 = new Conta();
            Conta1.Numero = 1111;
----------------------------------------------------------------------------

## 6 ) FORMANDO UM COSNTRUTOR PARA FACILITAR O TRABALHO:
	- É possível fazer um construtor dentro da class o que facilita muito quando vamos iniciar uma nova class.
public class Conta
    {
        public Conta(int numero, double saldo)
        {
            setNumero(numero);
            setSaldo(saldo);
            this.limite = 1000;
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
-Como o EXEMPLO acima podemos então chamar uma nova Conta da seguinte forma:
Conta Conta1 = new Conta(1111, 2000);
Desta maneira o código está muito mais simples e fácil de invocar novas contas.
----------------------------------------------------------------------------

## 7 ) – DEFINIR METHODS STATICS
- Caso desejemos criar uma maneira de contar quantas contas foram criadas, também podemos usar modos static para definir que determinadas ações acontecem dentro da class e fazem parte da class não dos objetos, como exemplo contar quantas contas foram chamadas pela class.
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
Observer que o methods static tem seu setter privado, para proteger que o mesmo seja alterado fora da class, ele será somente alterado quando uma nova conta for criada, e seu valor será salvo na receita ou CLASS;
