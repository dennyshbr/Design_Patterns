using System;
using System.Collections.Generic;

namespace Design_Patterns.TemplateMethod
{
    public class RelatorioDetalhe : TemplateRelatorio
    {
        protected override void Cabecalho()
        {
            Console.WriteLine("------------- Cabeçalho -------------");

            Console.WriteLine("Banco XYZ");
            Console.WriteLine("Avenida Paulista, 1234");
            Console.WriteLine("(11) 1234-5678");
        }

        protected override void Corpo(IList<Conta> contas)
        {
            Console.WriteLine("------------- Corpo -------------");

            foreach (Conta c in contas)
            {
                Console.WriteLine(c.Titular + " - " + c.Numero + " - " + c.Agencia + " - " + c.Saldo);
            }
        }

        protected override void Rodape()
        {
            Console.WriteLine("------------- Rodapé -------------");

            Console.WriteLine("banco@xyz.com.br");
            Console.WriteLine(DateTime.Now);

            Console.WriteLine();
        }
    }
}
