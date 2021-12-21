using System;

namespace Design_Patterns.State
{
    public class Aprovado : EstadoDeUmOrcamento
    {
        private bool descontoAplicado = false;

        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            if (!descontoAplicado)
            {
                orcamento.Valor = orcamento.Valor - (orcamento.Valor * 0.02);
                descontoAplicado = true;
                Console.WriteLine($"Status aprovado - Desconto aplicado");
                Console.WriteLine($"Valor atual orçamento: {orcamento.Valor}");
            }
            else
            {
                throw new Exception("Desconto já aplicado");
            }
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está aprovado");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já aprovado não pode ser reprovado.");
        }
    }
}
