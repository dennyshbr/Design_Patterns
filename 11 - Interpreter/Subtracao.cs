using Design_Patterns.Visitor;
using System;

namespace Design_Patterns.Interpreter
{
    public class Subtracao : IExpressao
    {
        public IExpressao Esquerda { get; private set; }
        public IExpressao Direita { get; private set; }

        public Subtracao(IExpressao esquerda, IExpressao direita)
        {
            Esquerda = esquerda;
            Direita = direita;
        }

        public void Imprimir(IImpressaoVisitor impressora)
        {
            impressora.ImprimeSubtracao(this);
        }

        public int Avaliar()
        {
            int valorEsquerda = Esquerda.Avaliar();
            int valorDireita = Direita.Avaliar();

            return valorEsquerda - valorDireita;
        }
    }
}
