using Design_Patterns.Visitor;
using System;

namespace Design_Patterns.Interpreter
{
    public class Soma : IExpressao
    {
        public IExpressao Esquerda { get; private set; }
        public IExpressao Direita { get; private set; }

        public Soma(IExpressao esquerda, IExpressao direita)
        {
            Esquerda = esquerda;
            Direita = direita;
        }

        public int Avaliar()
        {
            int valorEsquerda = Esquerda.Avaliar();
            int valorDireita = Direita.Avaliar();

            return valorEsquerda + valorDireita;
        }

        public void Imprimir(IImpressaoVisitor impressora)
        {
            impressora.ImprimeSoma(this);
        }
    }
}
