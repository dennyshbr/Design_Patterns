﻿using Design_Patterns.ChainOfResponsibility;
using Design_Patterns.Decorator;
using Design_Patterns.Strategy;
using Design_Patterns.TemplateMethod;
using System;
using System.Collections.Generic;

namespace Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            State();

            Console.ReadKey();
        }

        static void Strategy()
        {
            CalculadorDeImpostos calculador = new CalculadorDeImpostos();

            Orcamento product = new Orcamento(50);

            Strategy.Imposto icms = new ICMS();

            calculador.RealizaCalculo(product, icms);
        }

        static void ChainOfResponsability()
        {
            CalculadorDeDescontos calculador = new CalculadorDeDescontos();

            Orcamento orcamento = new Orcamento(510);

            orcamento.AdicionaItem(new Item("Guarda Caneta", 10));
            orcamento.AdicionaItem(new Item("Cadeira", 100));
            orcamento.AdicionaItem(new Item("Mesa", 400));
            orcamento.AdicionaItem(new Item("LAPIS", 1.50));
            orcamento.AdicionaItem(new Item("CANETA", 1.50));

            double totalDesconto = calculador.Calcula(orcamento);

            Console.WriteLine($"Total de descontos: {totalDesconto}");
        }

        static void TemplateMethod()
        {
            TemplateRelatorio templateRelatorio = new RelatorioDetalhe();

            IList<Conta> contas = new List<Conta>()
            {
                new Conta(){ Titular = "João", Numero = "000", Agencia = "000", Saldo = 50 },
                new Conta(){ Titular = "Maria", Numero = "000", Agencia = "000", Saldo = 100 },
            };

            templateRelatorio.Imprime(contas);

            templateRelatorio = new RelatorioResumo();

            templateRelatorio.Imprime(contas);
        }

        static void Decorator()
        {
            ImpostoMuitoAlto impostoMuitoAlto = new ImpostoMuitoAlto();
            ImpostoDeImportacao impostoImportacao = new ImpostoDeImportacao(outroImposto: impostoMuitoAlto);
            ImpostoDeExportacao impostoExportacao = new ImpostoDeExportacao(outroImposto: impostoImportacao);

            Orcamento carro = new Orcamento(50000);

            double imposto = impostoExportacao.Calcula(carro);

            Console.WriteLine($"Valor do imposto: {imposto}");

        }

        static void State()
        {
            try
            {
                Orcamento reforma = new Orcamento(20000);

                Console.WriteLine(reforma.Valor);

                reforma.AplicaDescontoExtra();

                reforma.Aprova();

                reforma.AplicaDescontoExtra();

                reforma.Finaliza();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}