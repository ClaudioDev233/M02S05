using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M02S05
{
    public class Vendedor : Empregado
    {
        public Vendedor(string nome, string endereco, string telefone, int codigoSetor, decimal salarioBruto, decimal impostoSobreSalario, decimal valorVendas, decimal comissao) : base(nome, endereco, telefone, codigoSetor, salarioBruto, impostoSobreSalario)
        {
            ValorVendas = valorVendas;
            Comissao = comissao;
        }

        public decimal ValorVendas { get; private set; }
        public decimal Comissao { get; private set; }

        public override decimal CalculaSalarioLiquido()
        {
            return base.CalculaSalarioLiquido() + (ValorVendas*Comissao);
        }

    }

}
