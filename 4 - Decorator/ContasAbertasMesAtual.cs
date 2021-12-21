using Design_Patterns.TemplateMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Decorator
{
    public class ContasAbertasMesAtual : Filtro
    {
        public ContasAbertasMesAtual() : base() { }

        public ContasAbertasMesAtual(Filtro proximoFiltro) : base(proximoFiltro) { }

        public override IList<Conta> Filtra(IList<Conta> contas)
        {
            List<Conta> contasFiltradas = new List<Conta>();

            int mesAtual = DateTime.Now.Month;
            int anoAtual = DateTime.Now.Year;

            foreach (Conta conta in contas)
            {
                if (conta.DataAbertura.Month == mesAtual && conta.DataAbertura.Year == anoAtual)
                {
                    contasFiltradas.Add(conta);
                }
            }

            ObterProximoFiltro(contas, contasFiltradas);

            return contasFiltradas;
        }
    }
}
