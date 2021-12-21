namespace Design_Patterns.Decorator
{
    public abstract class Imposto
    {
        protected Imposto OutroImposto { get; set; }

        public Imposto() { }

        public Imposto(Imposto outroImposto)
        {
            OutroImposto = outroImposto;
        }

        public abstract double Calcula(Orcamento orcamento);

        protected double CalculoDoOutroImposto(Orcamento orcamento)
        {
            if (OutroImposto == null)
            {
                return 0;
            }
            else
            {
                return OutroImposto.Calcula(orcamento);
            }
        }
    }
}
