using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M02S05
{
    public class Adminstrador : Empregado 
    {
        public Adminstrador(string nome, string endereco, string telefone, int codigoSetor, decimal salarioBruto, decimal impostoSobreSalario, decimal ajudaDeCusto) : base(nome, endereco, telefone, codigoSetor, salarioBruto, impostoSobreSalario)
        {
            AjudaDeCusto = ajudaDeCusto;
        }

        public decimal AjudaDeCusto { get; private set; }

        public override decimal CalculaSalarioLiquido()
        {
            return base.CalculaSalarioLiquido() + AjudaDeCusto;
        }
    }
}
