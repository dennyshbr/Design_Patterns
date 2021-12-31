using Design_Patterns.Visitor;

namespace Design_Patterns.Interpreter
{
    public class Numero : IExpressao
    {
        public int Valor { get; private set; }

        public Numero(int valor)
        {
            Valor = valor;
        }

        public int Avaliar()
        {
            return Valor;
        }

        public void Imprimir(IImpressaoVisitor impressora)
        {
            impressora.ImprimeNumero(this);
        }
    }
}
