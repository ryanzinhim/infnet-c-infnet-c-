using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infnet_c_.AT.exercico_9
{
    class Produto
    {
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }

        public Produto(string nome, int quantidade, double preco)
        {
            Nome = nome;
            Quantidade = quantidade;
            Preco = preco;
        }
    }

    class Program
    {
        static Produto[] estoque = new Produto[5];
        static int contador = 0;

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n=== Sistema de Estoque ===");
                Console.WriteLine("1. Inserir Produto");
                Console.WriteLine("2. Listar Produtos");
                Console.WriteLine("3. Sair");
                Console.Write("Escolha uma opção: ");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        InserirProduto();
                        break;
                    case "2":
                        ListarProdutos();
                        break;
                    case "3":
                        Console.WriteLine("Encerrando o programa...");
                        return;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }

        static void InserirProduto()
        {
            if (contador >= 5)
            {
                Console.WriteLine("Limite de produtos atingido!");
                return;
            }

            Console.Write("Nome do produto: ");
            string nome = Console.ReadLine();
            Console.Write("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());
            Console.Write("Preço unitário: R$ ");
            double preco = double.Parse(Console.ReadLine());

            estoque[contador] = new Produto(nome, quantidade, preco);
            contador++;
            Console.WriteLine("Produto cadastrado com sucesso!");
        }

        static void ListarProdutos()
        {
            if (contador == 0)
            {
                Console.WriteLine("Nenhum produto cadastrado.");
                return;
            }

            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine($"Produto: {estoque[i].Nome} | Quantidade: {estoque[i].Quantidade} | Preço: R$ {estoque[i].Preco:F2}");
            }
        }
    }
}

