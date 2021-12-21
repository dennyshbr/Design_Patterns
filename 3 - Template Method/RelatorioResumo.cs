using System;
using System.Collections.Generic;

namespace Design_Patterns.TemplateMethod
{
    public class RelatorioResumo : TemplateRelatorio
    {
        protected override void Cabecalho()
        {
            Console.WriteLine("------------- Cabeçalho -------------");

            Console.WriteLine($"Banco: Bradesco - Telefone: 1199999999");
        }

        protected override void Corpo(IList<Conta> contas)
        {
            Console.WriteLine("------------- Corpo -------------");

            foreach (Conta c in contas)
            {
                Console.WriteLine(c.Titular + " - " + c.Saldo);
            }
        }
        protected override void Rodape()
        {
            Console.WriteLine("------------- Rodapé -------------");

            Console.WriteLine($"Banco: Bradesco - Telefone: 1199999999");

            Console.WriteLine();
        }
    }
}
