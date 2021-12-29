namespace Design_Patterns.Interpreter
{
    public class Subtracao : IExpressao
    {
        private IExpressao _esquerda;
        private IExpressao _direita;

        public Subtracao(IExpressao esquerda, IExpressao direita)
        {
            _esquerda = esquerda;
            _direita = direita;
        }

        public int Avaliar()
        {
            int valorEsquerda = _esquerda.Avaliar();
            int valorDireita = _direita.Avaliar();

            return valorEsquerda - valorDireita;
        }
    }
}
