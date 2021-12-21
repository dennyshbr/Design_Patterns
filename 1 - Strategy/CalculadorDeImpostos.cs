using System;

namespace Design_Patterns.Strategy
{
    public class CalculadorDeImpostos
    {
        public void RealizaCalculo(Orcamento orcamento, Imposto imposto)
        {
            double valorImposto = imposto.Calcula(orcamento);

            Console.WriteLine($"Valor do imposto: {valorImposto}");
        }
    }
}
