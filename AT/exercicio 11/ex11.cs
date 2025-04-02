using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infnet_c_.AT.exercicio_11
{
    public class ex11
    {
        class Contato
        {
            public string Nome { get; set; }
            public string Telefone { get; set; }
            public string Email { get; set; }

            public Contato(string nome, string telefone, string email)
            {
                Nome = nome;
                Telefone = telefone;
                Email = email;
            }

            public string ToFileString()
            {
                return $"{Nome},{Telefone},{Email}";
            }

            public static Contato FromFileString(string linha)
            {
                string[] partes = linha.Split(',');
                if (partes.Length != 3) throw new FormatException("Formato de linha inválido");
                return new Contato(partes[0], partes[1], partes[2]);
            }

            public void Exibir()
            {
                Console.WriteLine($"Nome: {Nome} | Telefone: {Telefone} | Email: {Email}");
            }
        }

        class Program
        {
            static readonly string caminhoArquivo = "contatos.txt";

            static void Main(string[] args)
            {
                while (true)
                {
                    ExibirMenu();
                    string opcao = Console.ReadLine();

                    switch (opcao)
                    {
                        case "1":
                            AdicionarContato();
                            break;
                        case "2":
                            ListarContatos();
                            break;
                        case "3":
                            Console.WriteLine("Encerrando programa...");
                            return;
                        default:
                            Console.WriteLine("Opção inválida! Tente novamente.");
                            break;
                    }
                }
            }

            static void ExibirMenu()
            {
                Console.WriteLine("\n=== Gerenciador de Contatos ===");
                Console.WriteLine("1 - Adicionar novo contato");
                Console.WriteLine("2 - Listar contatos cadastrados");
                Console.WriteLine("3 - Sair");
                Console.Write("Escolha uma opção: ");
            }

            static void AdicionarContato()
            {
                try
                {
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Telefone: ");
                    string telefone = Console.ReadLine();
                    Console.Write("Email: ");
                    string email = Console.ReadLine();

                    Contato contato = new Contato(nome, telefone, email);

                    using (StreamWriter sw = File.AppendText(caminhoArquivo))
                    {
                        sw.WriteLine(contato.ToFileString());
                    }

                    Console.WriteLine("Contato cadastrado com sucesso!");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Erro ao cadastrar contato: {e.Message}");
                }
            }

            static void ListarContatos()
            {
                if (!File.Exists(caminhoArquivo) || new FileInfo(caminhoArquivo).Length == 0)
                {
                    Console.WriteLine("Nenhum contato cadastrado.");
                    return;
                }

                try
                {
                    Console.WriteLine("\nContatos cadastrados:");
                    using (StreamReader sr = new StreamReader(caminhoArquivo))
                    {
                        string linha;
                        while ((linha = sr.ReadLine()) != null)
                        {
                            try
                            {
                                Contato contato = Contato.FromFileString(linha);
                                contato.Exibir();
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine($"Erro ao ler linha: {linha} - Formato inválido");
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Erro ao listar contatos: {e.Message}");
                }
            }
        }
    }
}
