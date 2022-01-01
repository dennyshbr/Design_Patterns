using System;

namespace Design_Patterns.Bridge
{
    class EnvioPorSms : IEnviador
    {
        public void Enviar(IMensagem mensagem)
        {
            string texto = mensagem.ObterFormatoTexto();

            Console.WriteLine("Enviando sms...");
            Console.WriteLine(texto);
        }
    }
}
