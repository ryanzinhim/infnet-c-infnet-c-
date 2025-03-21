using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infnet_c_.Tp2.exercicio3
{
    class Ingresso
    {
        public string NomeDoShow;
        public double Preco;
        public int QuantidadeDisponivel;

        public void AlterarPreco(double novoPreco)
        {
            Preco = novoPreco;
        }
        public void AlterarQuantidade(int novaQuantidade)
        {
            QuantidadeDisponivel = novaQuantidade;
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
            Ingresso ingresso = new Ingresso();
            ingresso.NomeDoShow = "Rock in Rio";
            ingresso.Preco = 150.00;
            ingresso.QuantidadeDisponivel = 100;
            ingresso.ExibirInformacoes();  // Teste inicial
        }
    }
}
