using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M02S05
{
    public class Empregado : Pessoa
    {
        public Empregado(string nome, string endereco, string telefone, int codigoSetor, decimal salarioBruto, decimal impostoSobreSalario) : base(nome, endereco, telefone)
        {
            CodigoSetor = codigoSetor;
            SalarioBruto = salarioBruto;
            ImpostoSobreSalario = impostoSobreSalario;
        }

        public int CodigoSetor { get; private set; }
        public decimal SalarioBruto { get; private set; }
        public decimal ImpostoSobreSalario { get; private set; }

        public virtual decimal CalculaSalarioLiquido()
        {
            return SalarioBruto - (SalarioBruto * ImpostoSobreSalario);

        }
    }
}
