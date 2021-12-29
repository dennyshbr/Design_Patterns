namespace Design_Patterns.Interpreter
{
    public class Soma : IExpressao
    {
        private IExpressao _esquerda;
        private IExpressao _direita;

        public Soma(IExpressao esquerda, IExpressao direita)
        {
            _esquerda = esquerda;
            _direita = direita;
        }

        public int Avaliar()
        {
            int valorEsquerda = _esquerda.Avaliar();
            int valorDireita = _direita.Avaliar();

            return valorEsquerda + valorDireita;
        }
    }
}
