using Design_Patterns.Builder;
using System;

namespace Design_Patterns.Observer
{
    public class NotaFiscalDao : AcaoAposGerarNotaFiscal
    {
        public void Executa(NotaFiscal notaFiscal)
        {
            Console.WriteLine("Simuçação gravação no banco");
        }
    }
}
