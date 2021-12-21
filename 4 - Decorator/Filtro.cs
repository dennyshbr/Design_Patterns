using Design_Patterns.TemplateMethod;
using System.Collections.Generic;

namespace Design_Patterns.Decorator
{
    public abstract class Filtro
    {
        public Filtro ProximoFiltro { get; set; }

        public Filtro() { }

        public Filtro(Filtro proximoFiltro)
        {
            ProximoFiltro = proximoFiltro;
        }

        protected void ObterProximoFiltro(IList<Conta> contas, IList<Conta> contasFiltroAnterior)
        {
            if (ProximoFiltro != null)
            {
                IList<Conta> contasProximoFiltro = ProximoFiltro.Filtra(contas);

                if (contasProximoFiltro.Count > 0)
                {
                    foreach (var conta in contasProximoFiltro)
                    {
                        contasFiltroAnterior.Add(conta);
                    }
                }
            }
        }

        public abstract IList<Conta> Filtra(IList<Conta> contas);
    }
}
