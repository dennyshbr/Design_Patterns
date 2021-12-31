using Design_Patterns.Builder;
using Design_Patterns.ChainOfResponsibility;
using Design_Patterns.Decorator;
using Design_Patterns.Factory;
using Design_Patterns.Flyweight;
using Design_Patterns.Interpreter;
using Design_Patterns.Memento;
using Design_Patterns.Observer;
using Design_Patterns.Strategy;
using Design_Patterns.TemplateMethod;
using Design_Patterns.Visitor;
using System;
using System.Collections.Generic;
using System.Data;

namespace Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Visitor();

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

        static NotaFiscal Builder(IList<AcaoAposGerarNotaFiscal> acoesAposGerarNota)
        {
            NotaFiscalBuilder nfBuilder = new NotaFiscalBuilder(acoesAposGerarNota);

            nfBuilder
                .ParaEmpresa("Empresa XX")
                .ComCnpj("00000000000000")
                .Com(new ItemDaNota("computador", 2000))
                .NaDataAtual();

            NotaFiscal notaFiscal = nfBuilder.Constroi();

            Console.WriteLine($"Valor bruto da nota: {notaFiscal.ValorBruto}");

            return notaFiscal;
        }

        static void Observer()
        {
            IList<AcaoAposGerarNotaFiscal> acoesAposGerarNota = new List<AcaoAposGerarNotaFiscal>();

            acoesAposGerarNota.Add(new EnviadorDeEmail());
            acoesAposGerarNota.Add(new EnviadorDeSms());
            acoesAposGerarNota.Add(new ImpressaoNotaFiscal());
            acoesAposGerarNota.Add(new NotaFiscalDao());

            NotaFiscal notaFiscal = Builder(acoesAposGerarNota);
        }

        static void Factory()
        {
            IDbConnection connection = null;
            try
            {
                connection = new ConnectionFactory().GetConnection();

                IDbCommand command = connection.CreateCommand();
                command.CommandText = "select * from table";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);   
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        static void Flyweight()
        {
            NotasMusicais notas = new NotasMusicais();

            List<INotaMusical> listaNotas = new List<INotaMusical>();

            listaNotas.Add(notas.Get("do"));
            listaNotas.Add(notas.Get("do"));
            listaNotas.Add(notas.Get("re"));
            listaNotas.Add(notas.Get("mi"));
            listaNotas.Add(notas.Get("fa"));
            listaNotas.Add(notas.Get("fa"));

            Piano piano = new Piano();

            piano.Tocar(listaNotas);

            Console.WriteLine("Notas tocadas");
        }

        static void Memento()
        {
            HistoricoContrato historico = new HistoricoContrato();

            Contrato contrato = new Contrato(DateTime.Now, "Marcos", TipoCotrato.Novo);

            historico.Adiciona(contrato.SalvarEstado());

            Console.WriteLine(contrato.Tipo);

            contrato.Avanca();
            historico.Adiciona(contrato.SalvarEstado());

            Console.WriteLine(contrato.Tipo);

            contrato.Avanca();
            historico.Adiciona(contrato.SalvarEstado());

            Console.WriteLine(contrato.Tipo);


            Console.WriteLine(historico.ObterEstado(0).Contrato.Tipo);
        }

        static void Interpreter()
        {
            IExpressao esquerda = new Soma(new Numero(1), new Numero(10));

            IExpressao direita = new Subtracao(new Numero(20), new Numero(10));

            IExpressao soma = new Soma(esquerda, direita);

            Console.WriteLine(soma.Avaliar());
        }
       
        static void Visitor()
        {
            ImpressoraVisitora impressora = new ImpressoraVisitora();

            IExpressao esquerda = new Soma(new Numero(5), new Numero(5));

            IExpressao direita = new Subtracao(new Numero(15), new Numero(5));

            //((5 + 5) + (15 - 5))
            Soma soma = new Soma(esquerda, direita);
            Console.Write("Expressão da soma: ");
            soma.Imprimir(impressora);

            Console.WriteLine();

            //((5+5)-(15-5))
            Subtracao subtracao = new Subtracao(esquerda, direita);
            Console.Write("Expressão da subtração: ");
            subtracao.Imprimir(impressora);
        }
    }
}
