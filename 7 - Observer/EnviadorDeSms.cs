using Design_Patterns.Builder;
using System;

namespace Design_Patterns.Observer
{
    public class EnviadorDeSms : AcaoAposGerarNotaFiscal
    {
        public void Executa(NotaFiscal notaFiscal)
        {
            Console.WriteLine("Simulação envio por sms");
        }
    }
}
