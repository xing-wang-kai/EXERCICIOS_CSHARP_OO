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
