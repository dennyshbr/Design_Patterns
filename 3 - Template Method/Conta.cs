using Design_Patterns.State;
using System;

namespace Design_Patterns.TemplateMethod
{
    public class Conta
    {
        public Conta()
        {
            EstadoAtual = new ContaSemSaldo();
        }

        public EstadoContaBancaria EstadoAtual { get; private set; }

        public string Titular { get; set; }
        public string Agencia { get; set; }
        public string Numero { get; set; }
        public double Saldo { get; set; }

        public DateTime DataAbertura { get; set; }

        public void Sacar(double valor)
        {
            EstadoAtual.Sacar(this, valor);
        }

        public void Depositar(double valor)
        {
            EstadoAtual.Depositar(this, valor);
        }

        public void MostrarEstadoAtual()
        {
            EstadoAtual.MostrarEstadoAtual();
        }

        class ContaComSaldo : EstadoContaBancaria
        {
            public void Depositar(Conta conta, double valor)
            {
                conta.Saldo += valor * 0.98;
            }

            public void MostrarEstadoAtual()
            {
                Console.WriteLine("Conta com saldo");
            }

            public void Sacar(Conta conta, double valor)
            {
                if (conta.Saldo >= valor)
                {
                    conta.Saldo -= valor;

                    if (conta.Saldo == 0)
                    {
                        conta.EstadoAtual = new ContaSemSaldo();
                    }
                }
                else
                {
                    throw new Exception("Valor do saque é maior que o saldo.");
                }
            }
        }
        class ContaSemSaldo : EstadoContaBancaria
        {
            public void Depositar(Conta conta, double valor)
            {
                conta.Saldo += valor * 0.95;
                conta.EstadoAtual = new ContaComSaldo();
            }

            public void MostrarEstadoAtual()
            {
                Console.WriteLine("Conta sem saldo");
            }

            public void Sacar(Conta conta, double valor)
            {
                throw new Exception("A conta está negativa, por isso não aceita saque.");
            }
        }
    }
}
