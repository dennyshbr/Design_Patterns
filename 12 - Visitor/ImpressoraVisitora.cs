using Design_Patterns.Interpreter;
using System;

namespace Design_Patterns.Visitor
{
    public class ImpressoraVisitora : IImpressaoVisitor
    {
        public void ImprimeSoma(Soma soma)
        {
            Console.Write("(");
            soma.Esquerda.Imprimir(this);

            Console.Write("+");

            soma.Direita.Imprimir(this);
            Console.Write(")");
        }

        public void ImprimeSubtracao(Subtracao subtracao)
        {
            Console.Write("(");
            subtracao.Esquerda.Imprimir(this);
            
            Console.Write("-");
            
            subtracao.Direita.Imprimir(this);
            Console.Write(")");
        }

        public void ImprimeNumero(Numero numero)
        {
            Console.Write(numero.Valor);
        }
    }
}
