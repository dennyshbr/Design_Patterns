using System.Collections.Generic;

namespace Design_Patterns.Memento
{
    public class HistoricoContrato
    {
        private IList<EstadoContrato> _estadoContratos = new List<EstadoContrato>();

        public void Adiciona(EstadoContrato estado)
        {
            _estadoContratos.Add(estado);
        }

        public EstadoContrato ObterEstado(int indice)
        {
            return _estadoContratos[indice];
        }
    }
}
