using System;

namespace Design_Patterns.Bridge
{
    public class EnvioPorEmail : IEnviador
    {
        public void Enviar(IMensagem mensagem)
        {
            string texto = mensagem.ObterFormatoTexto();

            Console.WriteLine("Enviando e-mail...");
            Console.WriteLine(texto);
        }
    }
}
