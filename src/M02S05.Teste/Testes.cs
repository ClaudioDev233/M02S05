using Xunit;

namespace M02S05.Teste
{
    public class Testes
    {
        private readonly Fornecedor _fornecedor;
        private readonly Empregado _empregado;
        private readonly Adminstrador _adminstrador;
        private readonly Operario _operario;
        private readonly Vendedor _vendedor;


        public Testes()
        {
            _fornecedor =  new Fornecedor("Claudio", "aa", "aaa", 2000, 2000);
            _empregado = new Empregado("Claudio", "aa", "aaa", 1, 1000, 0.1M);
            _adminstrador = new Adminstrador("Claudio", "aa", "aaa", 1, 1000, 0.1M, 1000);
            _operario = new Operario("Claudio", "aa", "aaa", 1, 1000, 0.1M, 1000, 0.1m);
            _vendedor = new Vendedor("Claudio", "aa", "aaa", 1, 1000, 0.1M, 1000, 0.1m);
        }

        [Fact]

        public void RetornaValorTeste()
        { 
            Assert.Equal(0, _fornecedor.ObterSaldo());
        }

       
        [Fact]

        public void CalculaSalarioLiquidoEmpregado()
        {
            var salarioEstimado = 900;
            
            Assert.Equal(salarioEstimado, _empregado.CalculaSalarioLiquido());
        }
        [Fact]
        public void CalculaSalarioLiquidoAdministrador()
        {
            var salarioEstimado = 1900;
            
            Assert.Equal(salarioEstimado, _adminstrador.CalculaSalarioLiquido());
        }
        [Fact]
        public void CalculaSalarioLiquidoOperario()
        {
           
            var salarioEstimado = 1000;
            Assert.Equal(salarioEstimado, _operario.CalculaSalarioLiquido());
        }
        [Fact]
        public void CalculaSalarioLiquidoVendedor()
        {
            var salarioEstimado = 1000;
            Assert.Equal(salarioEstimado, _vendedor.CalculaSalarioLiquido());
        }
    }
}