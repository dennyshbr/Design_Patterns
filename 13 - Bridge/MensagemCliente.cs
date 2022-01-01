namespace Design_Patterns.Bridge
{
    public class MensagemCliente : IMensagem
    {
        private string _nomeCliente;
        private readonly IEnviador _enviador;

        public MensagemCliente(string nomeCliente, IEnviador enviador)
        {
            _nomeCliente = nomeCliente;
            _enviador = enviador;
        }

        public void Enviar()
        {
            _enviador.Enviar(this);
        }

        public string ObterFormatoTexto()
        {
            return $"Olá cliente {_nomeCliente}, seja bem vindo!";
        }
    }
}
