using System;
using System.Collections.Generic;

namespace Design_Patterns.Flyweight
{
    public class Piano
    {
        public void Tocar(IList<INotaMusical> musica)
        {
            foreach (var nota in musica)
            {
                Console.Beep(nota.Frequencia, 300);
            }
        }
    }
}
