namespace M02S05
{
    public abstract class Pessoa
    {
        public Pessoa(string nome, string endereco, string telefone)
        {
            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;
        }
        public Pessoa() { }

        public string Nome { get; private set; }
        public string Endereco { get; private set; }
        public string Telefone { get; private set; }

    }
}