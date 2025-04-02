using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infnet_c_.AT.exercico_9._9._2
{
	public class ex9
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

			public string ToFileString()
			{
				return $"{Nome},{Quantidade},{Preco:F2}";
			}

			public static Produto FromFileString(string linha)
			{
				string[] partes = linha.Split(',');
				if (partes.Length != 3) throw new FormatException("Formato de linha inválido");
				return new Produto(
					partes[0],
					int.Parse(partes[1]),
					double.Parse(partes[2])
				);
			}
		}

		class Program
		{
			static readonly string caminhoArquivo = "estoque.txt";

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
				Console.Write("Nome do produto: ");
				string nome = Console.ReadLine();
				Console.Write("Quantidade: ");
				int quantidade = int.Parse(Console.ReadLine());
				Console.Write("Preço unitário: R$ ");
				double preco = double.Parse(Console.ReadLine());

				Produto produto = new Produto(nome, quantidade, preco);

				try
				{
					using (StreamWriter sw = File.AppendText(caminhoArquivo))
					{
						sw.WriteLine(produto.ToFileString());
					}
					Console.WriteLine("Produto cadastrado com sucesso!");
				}
				catch (Exception e)
				{
					Console.WriteLine($"Erro ao salvar produto: {e.Message}");
				}
			}

			static void ListarProdutos()
			{
				if (!File.Exists(caminhoArquivo) || new FileInfo(caminhoArquivo).Length == 0)
				{
					Console.WriteLine("Nenhum produto cadastrado.");
					return;
				}

				try
				{
					using (StreamReader sr = new StreamReader(caminhoArquivo))
					{
						string linha;
						while ((linha = sr.ReadLine()) != null)
						{
							try
							{
								Produto p = Produto.FromFileString(linha);
								Console.WriteLine($"Produto: {p.Nome} | Quantidade: {p.Quantidade} | Preço: R$ {p.Preco:F2}");
							}
							catch (Exception)
							{
								Console.WriteLine($"Erro ao ler linha: {linha} - Formato inválido");
							}
						}
					}
				}
				catch (Exception e)
				{
					Console.WriteLine($"Erro ao ler arquivo: {e.Message}");
				}
			}
		}

	}
}