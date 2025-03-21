using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infnet_c_.Tp2.exercicio6
{

    class Ingresso
    {
        public string NomeDoShow;
        public double Preco;
        public int QuantidadeDisponivel;
        public Ingresso(string nome, double preco, int quantidade)
        {
            NomeDoShow = nome;
            Preco = preco;
            QuantidadeDisponivel = quantidade;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Show: {NomeDoShow}, Preço: R${Preco}, Quantidade Disponível: {QuantidadeDisponivel}");
        }
    }

    class Program
    {
        static void Main()
        {
            Ingresso ingresso = new Ingresso("Rock in Rio", 150.00, 100);
            ingresso.ExibirInformacoes();  
        }
    }
}
