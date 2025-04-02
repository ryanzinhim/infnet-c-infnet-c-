using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infnet_c_.AT
{
    class ContaBancaria
    {
        // Atributos: Titular é público, Saldo é privado
        public string Titular;
        private decimal saldo;
        public ContaBancaria(string titular, decimal saldoInicial)
        {
            Titular = titular;
            saldo = saldoInicial; // Só pode ser mudado por métodos
        }

        // Método pra depositar dinheiro
        public void Depositar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor do depósito deve ser positivo!");
            }
            else
            {
                saldo += valor;
                Console.WriteLine($"Depósito de R$ {valor:F2} realizado com sucesso!");
            }
        }

        // Método pra sacar dinheiro
        public void Sacar(decimal valor)
        {
            if (valor > saldo)
            {
                Console.WriteLine("Saldo insuficiente para realizar o saque!");
            }
            else
            {
                saldo -= valor;
                Console.WriteLine($"Saque de R$ {valor:F2} realizado com sucesso!");
            }
        }

        // Método pra mostrar o saldo sem dar acesso direto
        public void ExibirSaldo()
        {
            Console.WriteLine($"Saldo atual: R$ {saldo:F2}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Criei uma conta pro João Silva com 0 de saldo inicial
            ContaBancaria conta = new ContaBancaria("João Silva", 0m);

            // Mostrei o titular
            Console.WriteLine("Titular: " + conta.Titular);

            // Testei algumas transações
            conta.Depositar(500m); // Depositei 500
            conta.ExibirSaldo();   // Mostrei o saldo

            Console.WriteLine("Tentativa de saque: R$ 700,00");
            conta.Sacar(700m);     // Tentei sacar mais do que tem
            conta.ExibirSaldo();   // Mostrei o saldo de novo

            conta.Sacar(200m);     // Saquei 200
            conta.ExibirSaldo();   // Mostrei o saldo final
        }
    }
}
