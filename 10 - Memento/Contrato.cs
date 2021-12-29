using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Memento
{
    public class Contrato
    {
        public Contrato(DateTime data, string cliente, TipoCotrato tipo)
        {
            Data = data;
            Cliente = cliente;
            Tipo = tipo;
        }

        public DateTime Data { get; private set; }

        public string Cliente { get; private set; }

        public TipoCotrato Tipo { get; private set; }

        public void Avanca()
        {
            if (Tipo == TipoCotrato.Novo)
            {
                Tipo = TipoCotrato.EmAndamento;
            }
            else if (Tipo == TipoCotrato.EmAndamento)
            {
                Tipo = TipoCotrato.Acertado;
            }
            else if (Tipo == TipoCotrato.Acertado)
            {
                Tipo = TipoCotrato.Concluido;
            }
        }

        public EstadoContrato SalvarEstado()
        {
            Contrato contrato = new Contrato(this.Data, this.Cliente, this.Tipo);

            return new EstadoContrato(contrato);
        }
    }
}
