using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infnet_c_.Tp2.exercicio2
{
    // Classe que representa um ingresso para um show
    class Ingresso
    {
        // Atributos: Características do ingresso
        public string NomeDoShow;         // Identifica o evento musical 
        public double Preco;              // Armazena o custo do ingresso, essencial para vendas
        public int QuantidadeDisponivel;  // Quantos ingressos ainda estão disponíveis, para controle de estoque
    }

    class Program
    {
        static void Main()
        {
            Ingresso ingresso = new Ingresso();
            ingresso.NomeDoShow = "Rock in Rio";
            ingresso.Preco = 150.00;
            ingresso.QuantidadeDisponivel = 100;
            Console.WriteLine($"{ingresso.NomeDoShow}, R${ingresso.Preco}, {ingresso.QuantidadeDisponivel} disponíveis");
        }
    }
}
