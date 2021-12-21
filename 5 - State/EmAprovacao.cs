using System;

namespace Design_Patterns.State
{
    public class EmAprovacao : EstadoDeUmOrcamento
    {
        private bool descontoAplicado = false;

        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            if (!descontoAplicado)
            {
                orcamento.Valor = orcamento.Valor - (orcamento.Valor * 0.05);
                descontoAplicado = true;
                Console.WriteLine($"Status em aprovação - Desconto aplicado");
                Console.WriteLine($"Valor atual orçamento: {orcamento.Valor}");
            }
            else
            {
                throw new Exception("Desconto já aplicado");
            }
        }

        public void Aprova(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Aprovado();
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orçamento em aprovação não pode ser atualizado para finalizado.");
        }

        public void Reprova(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Reprovado();
        }
    }
}