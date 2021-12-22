using System;
using System.Collections.Generic;

namespace Design_Patterns.Builder
{
    public class NotaFiscal
    {
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }

        public DateTime DataDeEmissao { get; set; }

        public double ValorBruto { get; set; }

        public double Impostos { get; set; }

        public IList<ItemDaNota> Itens { get; set; }
        public string Observacoes { get; set; }

        public NotaFiscal(string razaoSocial, string cnpj, DateTime dataEmissao, double valorBruto,
            double impostos, IList<ItemDaNota> itens, string observacoes)
        {
            this.RazaoSocial = razaoSocial;
            this.Cnpj = cnpj;
            this.DataDeEmissao = dataEmissao;
            this.ValorBruto = valorBruto;
            this.Impostos = impostos;
            this.Itens = itens;
            this.Observacoes = observacoes;
        }
    }
}
