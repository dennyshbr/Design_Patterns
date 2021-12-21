using Design_Patterns.TemplateMethod;
using System.Collections.Generic;

namespace Design_Patterns.Decorator
{
    public class ContaSaldoMaiorQue50Mil : Filtro
    {
        public ContaSaldoMaiorQue50Mil() : base() { }

        public ContaSaldoMaiorQue50Mil(Filtro proximoFiltro) : base(proximoFiltro) { }

        public override IList<Conta> Filtra(IList<Conta> contas)
        {
            List<Conta> contasFiltradas = new List<Conta>();

            foreach (Conta conta in contas)
            {
                if (conta.Saldo > 50000)
                {
                    contasFiltradas.Add(conta);
                }
            }

            ObterProximoFiltro(contas, contasFiltradas);

            return contasFiltradas;
        }
    }
}
