using System.Linq;

namespace Design_Patterns.ChainOfResponsibility
{
    public class DescontoPorVendaCasada : Desconto
    {
        public Desconto Proximo { get; set; }

        public DescontoPorVendaCasada(Desconto proximo)
        {
            Proximo = proximo;
        }

        public double Desconta(Orcamento orcamento)
        {
            if (orcamento.Itens.Count >= 2)
            {
                Item lapis = orcamento.Itens.FirstOrDefault(i => i.Nome == "LAPIS");
                Item caneta = orcamento.Itens.FirstOrDefault(i => i.Nome == "CANETA");

                if (lapis != null && caneta != null)
                {
                    return orcamento.Valor * 0.05;
                }
            }

            return Proximo.Desconta(orcamento);
        }
    }
}
