using Design_Patterns.Interpreter;

namespace Design_Patterns.Visitor
{
    public interface IImpressaoVisitor
    {
        void ImprimeSoma(Soma soma);

        void ImprimeSubtracao(Subtracao subtracao);

        void ImprimeNumero(Numero numero);
    }
}
