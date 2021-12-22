using Design_Patterns.Builder;
using System;

namespace Design_Patterns.Observer
{
    public class ImpressaoNotaFiscal : AcaoAposGerarNotaFiscal
    {
        public void Executa(NotaFiscal notaFiscal)
        {
            Console.WriteLine("Simulação para imprimir nota fiscal");
        }
    }
}
