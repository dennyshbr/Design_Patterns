namespace Design_Patterns.Decorator
{
    public class ImpostoDeExportacao : Imposto
    {
        public ImpostoDeExportacao(Imposto outroImposto) : base(outroImposto) { }

        public ImpostoDeExportacao() : base() { }

        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.08 + CalculoDoOutroImposto(orcamento);
        }
    }
}
