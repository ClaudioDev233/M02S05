namespace M02S05
{
    public class Fornecedor: Pessoa
    {
        public Fornecedor(string nome, string endereco, string telefone, decimal valorCredito, decimal valorDivida) : base(nome, endereco, telefone)
        {
            ValorCredito = valorCredito;
            ValorDivida = valorDivida;
        }

        public decimal ValorCredito { get; private set; }
        public decimal ValorDivida { get; private set; }

        public decimal ObterSaldo()
        {
            return ValorDivida - ValorCredito;
        }
    }
}