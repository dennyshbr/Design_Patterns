namespace Design_Patterns.ChainOfResponsibility
{
    public class DescontoPorCincoItens : Desconto
    {
        public Desconto Proximo { get; set; }

        public DescontoPorCincoItens(Desconto proximo)
        {
            Proximo = proximo;
        }

        public double Desconta(Orcamento orcamento)
        {
            if (orcamento.Itens.Count > 5)
            {
                return orcamento.Valor * 0.1;
            }

            return Proximo.Desconta(orcamento);
        }
    }
}
