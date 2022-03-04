namespace _PROJETO05_bitBank
{
    internal class ParceiroComercial: Autenticavel
    {
        public string Senha { get; set; }
        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}