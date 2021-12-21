using Design_Patterns.TemplateMethod;

namespace Design_Patterns.State
{
    public interface EstadoContaBancaria
    {
        void Sacar(Conta conta, double valor);
        void Depositar(Conta conta, double valor);

        void MostrarEstadoAtual();
    }
}
