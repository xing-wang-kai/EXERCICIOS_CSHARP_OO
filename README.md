# C# do Básico ao Avançado:
----------------------------------------------------------------------------
PARTE 001 – ORIENTAÇÃO A OBJETOS;
----------------------------------------------------------------------------

## 1) CRIANDO OBJETOS EM CSHAP;
-Para criar objetos em C# vamos primeiro no projeto desejado e criamos um 
item do tipo Class e então definimos o objeto com no exemplo abaixo.


                                public class Conta
                                {
                                    public string titular;
                                    public int numero;
                                    public double saldo;
                                    public double limite;
                                }


----------------------------------------------------------------------------

## 2) ACESSANDO OBJTOS DENTRO DO PROJETO:
-Para acessar o objeto dentro do projeto precisamos definir o mesmo namespace
para todos
namespace _PROJETO01
{
 
//DEFINA A CLASS DO SEU OBJETO AQUI
}
-O namespace ajuda a definir a interação entre objetos dentro do projeto e 
executar o mesmo dentro de uma solução; caso tenhamos um objeto conta que 
precisa de uma class titular, se ambos estiverem no mesmo namespace basta 
executar:


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
                                    }
                                }


- Desta forma conseguimos colocar a classe Pessoa dentro de Conta e invocar a mesma sem problemas;

----------------------------------------------------------------------------

## 3) ENVOCANDO NOVOS OBJTOS COM CLASS;

-Uma vez incluídos no mesmo Namespace podemos invocar os objetos e construir sua sintase com o seguinte comando;


                      +--------------------------------------------------+
                      |      Conta Conta1 = new Conta();                 |
                      |          Conta1.saldo = 100.00;                  |
                      |          Conta1.limite = 300.00;                 |
                      |                                                  |
                      |          Conta1.titular = new Pessoa();          |
                      |          Conta1.titular.nome = "Francisco";      |
                      |          Conta1.titular.cpf = "111.111.111-11";  |
                      +--------------------------------------------------+


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


    PRIVATE: significa que o METHOD ou ATRIBUTO só podem ser envocados dentro da CLASS
    PROTECTED: O METHOD ou ATRIBUTOS podem ser envocados dentro da CLASS CHILD e CLASS PARENTS
    PUBLIC: O METHOD podem ser alterados fora das CLASS;


### 5.1) usando Getters e setters 
    -Para acessar uma instancia protegida e editar ou ver seus valores precisamos usar 
    os métodos settes e Gettes que são construídos da seguinte maneira.


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


-É orientado que construa um para cada instancia que deseja proteger, encapsulando assim
o mesmo. Desta forma não podemos mais atribuir valores fora da class a não ser que 
seja envocado como Getters ou Setters;


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
                                        }
                                    }
                                }


-Desta maneira o method get continua publico e o setters foi privado e não poderá ser estanciado, 
o sistema cria automaticamente o método e para invocar o mesmo no objeto basta somente:
Conta Conta1 = new Conta();
            Conta1.Numero = 1111;
----------------------------------------------------------------------------

## 6 ) FORMANDO UM CONSTRUCTOR PARA FACILITAR O TRABALHO:
	- É possível fazer um construtor dentro da class o que facilita muito quando vamos iniciar 
    uma nova class. os CONSTRUCTOR defimen que aquele atributo é obrigátorio ser passado para 
    instanciar uma nova CLASS daquele tipo;



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
- Caso desejemos criar uma maneira de contar quantas contas foram criadas, 
também podemos usar modos static para definir que determinadas ações acontecem
dentro da class e fazem parte da class não dos objetos, como exemplo contar
quantas contas foram chamadas pela class.


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


Observer que o methods static tem seu setter privado, para proteger que o mesmo seja alterado fora da class,
ele será somente alterado quando uma nova conta for criada, e seu valor será salvo na receita ou CLASS;
-----------------------------------------------------------------------------------------------------------------

## 8 ) SOBREESCREVENDO METHODS:
    -Para informar a CLASS que um METHOD pode ser sobreescrito pelo seu filho precisamos usar a palavra
    reservada VIRTUAL desta forma definimos que aquele METHOD será reenscrito, caso não usamos esta palavra
    o METHOD será somente instaciado novamente como novo METHOD dentro da CLASS filha



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
                                public double Salario { get; set; };

                                public virtual double GetBonificacao()
                                {
                                    return Salario * 0.10;
                                }
                            }
                        }


NA CLASSE CHILD para recebe o METHOD e sobreescrever o mesmo colocamos a palavra reservada OVERRIDE
que indica que o METHOD PARENT será reenscrito pela CLASS CHILD.


                    namespace _PROJETO05_bitBank
                        {
                            internal class Diretor: Funcionario
                            {
                                public Diretor(string Nome, string Cpf, double Salario) : base(Nome, Cpf, Salario)
                                {
                                }

                                public override double GetBonificacao()
                                {
                                    return Salario;
                                }
                            }
                        }


-----------------------------------------------------------------------------------------------------------------

## 8) HENRANÇA DEFININDO CONSTRUTORES HERDADOS;

    A CLASS CHILD pode herdar os construtores da CLASS PARENTS para que isso ocorra então criamos o construtor
    e ates da abertura das {} e fechamento da mesma preenchemos com a palavra reservada " :BASE" após a palavra
    abrimos e fechamos parentes e informamos quais sao os atributos obrigatórios que serão usadas da PARENT...
    Esses mesmos atributos precisam estar definidos dentro do CONSTRUCTOR da CLASS CHILD e informados o TYPE da mesma
    já na CLASS PARENTS extendida pela BASE não precisa informar o TYPE.
    

    A palavra reservada BASE também sere para evitar STACKOERFLOW quando envocamos o METHOD de uma PARENT dentro de uma 
    CLASS CHILD que já foi reenscrito, nesse caso usamos a palavra base.METHOD para chamar novamente o METHOD da CLASS PARENT


                Return salario + getBOnificação da Class Funcionário.

    Usaremos.

                public override double GetBonificacao()
                                    {
                                        return Salario + base.getBonificacao();
                                    }
                        
    Desta forma a formula chamada para getBOnificação em Diretor envoca noamente o metthod getBonificacao de FUNCIONARIO
    fazendo um return de GetBonificacao de diretor + GetBonificacao de funcionário.

-----------------------------------------------------------------------------------------------------------------

## 9) Sobreescrevendo methods dentro de Class:
    Como no exemplo acima podemos dizer que o method que está na class Pai é do tipo " VIRTUAL "  
    e desta maneira pode ser sobreescrito pelos class filhso usando a palavra "OVERRIDE" o 
    method terá um comportamento diferente;

-----------------------------------------------------------------------------------------------------------------

## 10 ) ABSTRAÇÂO:

    Quando tornamos uma CLASS ABSTRACT ela não pode ser envocada e é usada unicamente como formula
    para que outras CLASS possam Herdar sua caracteristicas, a CLASS ABSTRACT não pode ser isntanciadas.

    para adicionar ABSTRACT na frente do nome CLASS EX.:
        
                        public abstract class Funcionario
                            {
                            }

### 10.1 ) ABSTRACT METHODS:

    Podemos definir alguns METHODS da CLASS PARENT como ABSTRACT dessa forma é preciso implementar obrigatóriamente
    o METHOD nas CLASS CHILD;

                         public abstract void AumentarSalario();
    
    O METHOD ABSTRACT não pode ser instanciado, somente as CLASS CHILD podem reescrever o mesmo com OVERRIDE;


 -----------------------------------------------------------------------------------------------------------------
## 11 ) INTERFACE

    uma CLASS não pode herdar mais de 1 CLASS para contornar este problema de herança podemos criar Interfaces
    em vez de CLASS e usar seus METHODS para demais CLASS, interfaces são contratos que devem ser inclementados por seus assinantes

        
 -----------------------------------------------------------------------------------------------------------------

## PALAVRAS PARA OO;
    - BASE. ou :BASE
    - STATIC
    - VIRTUAL
    - OVERRIDE
    - ABSTRACT
    - INTERFACE
    - readonly


    - PUBLIC
    - PRIVATE
    - PROTECTED

    - USING
    - USENAME
    - CLASS

    - {GET; SET;}
 
-----------------------------------------------------------------------------------------------------------------
#PART 02 - APROFUNDADO NA LINGUAGEM CSharp;

## 1) Csharp part 4: Entendendo execções:

### 1.1) Primeiros Passos Com Exceções;
    
    Para lançar uma exceção para tratativa de erros usamos o código TRY com CATCH(TYPERROR), onde TYPERROR será 
    o tipo de erro;
                            
                                try{
                                    //comandos
                                }
                                catch(DivisorByZeroException){
                                    Console.log("não é possivel dividir por zero.")
                                }


-----------------------------------------------------------------------------------------------------------------
### 1.1.1) Trantando Exception de Private

      Podemos usar a palavra privada e torna-la soment e leitura, desta forma a váriavel so pode ser envocada dentro do constructor
      ao declarar numero colocar onlyread

      Private onlyread int _numero;

      Public int Numero: {
          get{
              return _numero;
          }
          set{
              this.numero = values;
          }
      }


-----------------------------------------------------------------------------------------------------------------
### 1.2 ) Tratamento de Exception

    CATCH lança caso o sistem retorne um erro, informado dentro do parents qual erro queremos retornar, 
    podemos usar também o THROW para informar que nossa aplicação deverá continuar após receber o erro
    e lançar para proxima tratativa;
    Podemos após o Exeption informar a mensagem erro que vai informar qual erro foi lançado com retorno erro.Message ou erro.stackTrace

    ex
                                 try{
                                    //comandos
                                }
                                catch(Exception erro){
                                    Console.log(erro.Message);
                                    Console.log(erro.stackTrace);
                                }

-----------------------------------------------------------------------------------------------------------------
### 1.3) ARGUMENTEXCEPTION PARAM NAME
        Podeos usar o Thown new Exception para laçar uma excessão ou definir uma nova excesão com a mensagem no constructor
        da Exception


                                if(agencia <= || numero <=0){
                                    Exception excesao = new Exception("Não é possivel criar uma conta com ag 0 e nun 0")
                                    throw excesao();
                                }


                                Try{
                                    ContaCorrente conta = (0, 0);
                                }
                                catch(Exception ex){
                                    Console.WriteLine(ex.Message);

                                }
        Porém o código acima pega qualquer erro e informa a mensagem setada, para corrigir isso
        usamos a palavaras ArgumentException
        --------------------------------------------------------------------------

                                if(agencia <= || numero <=0){

                                    string teste = nameof(agencia)
                                    throw new ArgumentException("Não é possivel criar uma conta com ag 0 e nun 0", nameof(agencia))
                                }

                                Try{
                                    ContaCorrente conta = (0, 0);
                                }
                                catch(ArgumentException ex){

                                    console.writeLine(ex.paramName);
                                    Console.WriteLine(ex.Message);

                                }


-----------------------------------------------------------------------------------------------------------------
### 1.4) Criando excesões Ricas:

    Podemos criar novas excesões fazendo uma CLASS com final Exception e depois extender com : as Exception e lançar um novo erro
    conforme desejado.

        ex.: 
            catch(SaldoInsuficienteException){

            }


            Public Class SaldoIsuficienteException: Exception{

                public SaldoInsuficienteException(){
                  
                }

                public SaldoInsuficienteException(string message){
                    :base(message)
                }

            }

-----------------------------------------------------------------------------------------------------------------
###1.5)Usando FINALLY
    O finally será sempre executado mesmo que a Exception ocorrer ou não ocorrer.
    try{
        //O sistema tentará executar este código
    }
    catch(){
        //Se dder erro executará este código
    }
    finally{
        //Este código sempre será exectutado
    }



-----------------------------------------------------------------------------------------------------------------

## PALAVRAS PARA TRATAMENTO DE EXECSÕES;
-TRY
-CATCH
-FINALLY
-THROW
-EXCEPTION
-ArgumentException
-paramName
-nameOf
-readonly