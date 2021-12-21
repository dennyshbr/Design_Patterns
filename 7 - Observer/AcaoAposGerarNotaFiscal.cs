using Design_Patterns.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Observer
{
    public interface AcaoAposGerarNotaFiscal
    {
        void Executa(NotaFiscal notaFiscal);
    }
}
