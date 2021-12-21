using Design_Patterns.TemplateMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Decorator
{
    public class ContaSaldoMenorQue100Reais : Filtro
    {
        public ContaSaldoMenorQue100Reais() : base() { }

        public ContaSaldoMenorQue100Reais(Filtro proximoFiltro) : base(proximoFiltro) { }

        public override IList<Conta> Filtra(IList<Conta> contas)
        {
            List<Conta> contasFiltradas = new List<Conta>();

            foreach (Conta conta in contas)
            {
                if (conta.Saldo < 100)
                {
                    contasFiltradas.Add(conta);
                }
            }

            ObterProximoFiltro(contas, contasFiltradas);

            return contasFiltradas;
        }
    }
}
