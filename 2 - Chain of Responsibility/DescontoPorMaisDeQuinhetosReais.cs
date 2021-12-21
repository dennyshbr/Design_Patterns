namespace Design_Patterns.ChainOfResponsibility
{
    public class DescontoPorMaisDeQuinhetosReais : Desconto
    {
        public Desconto Proximo { get; set; }

        public DescontoPorMaisDeQuinhetosReais(Desconto proximo)
        {
            Proximo = proximo;
        }

        public double Desconta(Orcamento orcamento)
        {
            if (orcamento.Valor > 500.0)
            {
                return orcamento.Valor * 0.07;
            }

            return Proximo.Desconta(orcamento);
        }
    }
}
