using Design_Patterns.Builder;
using System;

namespace Design_Patterns.Observer
{
    public class EnviadorDeEmail : AcaoAposGerarNotaFiscal
    {
        public void Executa(NotaFiscal notaFiscal)
        {
            Console.WriteLine("Simulação envio por e-mail");
        }
    }
}
