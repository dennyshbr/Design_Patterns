using Design_Patterns.Observer;
using System;
using System.Collections.Generic;

namespace Design_Patterns.Builder
{
    public class NotaFiscalBuilder
    {
        public string RazaoSocial { get; private set; }
        public string Cnpj { get; private set; }
        public string Observacoes { get; private set; }
        public DateTime Data { get; private set; }

        private double valorTotal;
        private double impostos;
        private IList<ItemDaNota> todosItens = new List<ItemDaNota>();

        private IList<AcaoAposGerarNotaFiscal> todasAcoesASeremExecutadas;

        public NotaFiscalBuilder(IList<AcaoAposGerarNotaFiscal> acoesAposGerarNota)
        {
            this.todasAcoesASeremExecutadas = acoesAposGerarNota;
        }

        public NotaFiscalBuilder ParaEmpresa(string razaoSocial)
        {
            this.RazaoSocial = razaoSocial;
            return this;
        }

        public NotaFiscalBuilder ComCnpj(string cnpj)
        {
            this.Cnpj = cnpj;
            return this;
        }

        public NotaFiscalBuilder Com(ItemDaNota item)
        {
            todosItens.Add(item);
            valorTotal += item.Valor;
            impostos += item.Valor * 0.05;

            return this;
        }

        public NotaFiscalBuilder ComObservacoes(string observacao)
        {
            this.Observacoes = observacao;

            return this;
        }

        public NotaFiscalBuilder NaDataAtual()
        {
            this.Data = DateTime.Now;

            return this;
        }

        public NotaFiscal Constroi()
        {
            NotaFiscal nf = new NotaFiscal(RazaoSocial, Cnpj, Data, valorTotal, impostos, todosItens, Observacoes);

            if (todasAcoesASeremExecutadas != null && todasAcoesASeremExecutadas.Count > 0)
            {
                foreach (AcaoAposGerarNotaFiscal acao in todasAcoesASeremExecutadas)
                {
                    acao.Executa(nf);
                }
            }

            return nf;
        }
    }
}
