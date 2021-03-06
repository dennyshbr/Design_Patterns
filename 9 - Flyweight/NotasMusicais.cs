using System.Collections.Generic;

namespace Design_Patterns.Flyweight
{
    public class NotasMusicais
    {
        private static IDictionary<string, INotaMusical> notas = new Dictionary<string, INotaMusical>()
        {
            { "do", new Do()},
            { "re", new Re()},
            { "mi", new Mi()},
            { "fa", new Fa()},
            { "sol", new Sol()},
            { "la", new La()},
            { "si", new Si()},
        };

        public INotaMusical Get(string nota)
        {
            return notas[nota];
        }
    }
}
