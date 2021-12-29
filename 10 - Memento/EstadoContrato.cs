namespace Design_Patterns.Memento
{
    public class EstadoContrato
    {
        public EstadoContrato(Contrato contrato)
        {
            Contrato = contrato;
        }

        public Contrato Contrato { get; private set; }
    }
}
