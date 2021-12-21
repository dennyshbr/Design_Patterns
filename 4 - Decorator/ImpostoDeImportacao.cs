namespace Design_Patterns.Decorator
{
    public class ImpostoDeImportacao : Imposto
    {
        public ImpostoDeImportacao(Imposto outroImposto) : base(outroImposto) { }

        public ImpostoDeImportacao() : base() { }

        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.09 + CalculoDoOutroImposto(orcamento);
        }
    }
}
