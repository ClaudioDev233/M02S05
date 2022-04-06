using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M02S05
{
    public class Operario : Empregado
    {
        public Operario(string nome, string endereco, string telefone, int codigoSetor, decimal salarioBruto, decimal impostoSobreSalario, decimal valorProducao, decimal comissao) : base(nome, endereco, telefone, codigoSetor, salarioBruto, impostoSobreSalario)
        {
            ValorProducao = valorProducao;
            Comissao = comissao;
        }

        public decimal ValorProducao { get; private set; }
        public decimal Comissao { get; private set; }

        public override decimal CalculaSalarioLiquido()
        {
            return base.CalculaSalarioLiquido() + (ValorProducao*Comissao);
        }

    }
}
