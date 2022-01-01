namespace Design_Patterns.Bridge
{
    public class MensagemAdministrativa : IMensagem
    {
        private string _nomeCliente;
        private readonly IEnviador _enviador;

        public MensagemAdministrativa(string nomeCliente, IEnviador enviador)
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
            return $"Mensagem para o administrador {_nomeCliente}.";
        }
    }
}
