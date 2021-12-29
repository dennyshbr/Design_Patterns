namespace Design_Patterns.Interpreter
{
    public class Numero : IExpressao
    {
        public int _valor;

        public Numero(int valor)
        {
            _valor = valor;
        }

        public int Avaliar()
        {
            return _valor;
        }
    }
}
