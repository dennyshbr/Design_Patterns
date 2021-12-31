using Design_Patterns.Visitor;

namespace Design_Patterns.Interpreter
{
    public interface IExpressao
    {
        int Avaliar();

        void Imprimir(IImpressaoVisitor impressora);
    }
}
