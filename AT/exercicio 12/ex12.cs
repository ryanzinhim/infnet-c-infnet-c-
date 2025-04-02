using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infnet_c_.AT.exercicio_12
{
    internal class ex12
    {
        class Contato
        {
            public string Nome;
            public string Telefone;
            public string Email;

            public Contato(string nome, string telefone, string email)
            {
                Nome = nome;
                Telefone = telefone;
                Email = email;
            }

            public string ToFileString()
            {
                return Nome + "," + Telefone + "," + Email;
            }

            public static Contato FromFileString(string linha)
            {
                string[] partes = linha.Split(',');
                if (partes.Length != 3)
                {
                    Console.WriteLine("Erro no formato da linha!");
                    return null;
                }
                return new Contato(partes[0], partes[1], partes[2]);
            }
        }

        abstract class ContatoFormatter
        {
            public abstract void ExibirContatos(List<Contato> contatos);
        }

        class MarkdownFormatter : ContatoFormatter
        {
            public override void ExibirContatos(List<Contato> contatos)
            {
                Console.WriteLine("\n## Lista de Contatos\n");
                for (int i = 0; i < contatos.Count; i++)
                {
                    Console.WriteLine("- **Nome:** " + contatos[i].Nome);
                    Console.WriteLine("- 📞 Telefone: " + contatos[i].Telefone);
                    Console.WriteLine("- 📧 Email: " + contatos[i].Email + "\n");
                }
            }
        }

        class TabelaFormatter : ContatoFormatter
        {
            public override void ExibirContatos(List<Contato> contatos)
            {
                Console.WriteLine("\n----------------------------------------");
                Console.WriteLine("| Nome           | Telefone      | Email          |");
                Console.WriteLine("----------------------------------------");
                for (int i = 0; i < contatos.Count; i++)
                {
                    Console.WriteLine("| " + contatos[i].Nome + "         | " + contatos[i].Telefone + "    | " + contatos[i].Email + "      |");
                }
                Console.WriteLine("----------------------------------------");
            }
        }

        class RawTextFormatter : ContatoFormatter
        {
            public override void ExibirContatos(List<Contato> contatos)
            {
                for (int i = 0; i < contatos.Count; i++)
                {
                    Console.WriteLine("Nome: " + contatos[i].Nome + " | Telefone: " + contatos[i].Telefone + " | Email: " + contatos[i].Email);
                }
            }
        }

        class Program
        {
            static string caminhoArquivo = "contatos.txt";

            static void Main(string[] args)
            {
                while (true)
                {
                    Console.WriteLine("\n=== Gerenciador de Contatos ===");
                    Console.WriteLine("1 - Adicionar novo contato");
                    Console.WriteLine("2 - Listar contatos cadastrados");
                    Console.WriteLine("3 - Sair");
                    Console.Write("Escolha uma opção: ");
                    string opcao = Console.ReadLine();

                    if (opcao == "1")
                    {
                        AdicionarContato();
                    }
                    else if (opcao == "2")
                    {
                        ListarContatos();
                    }
                    else if (opcao == "3")
                    {
                        Console.WriteLine("Encerrando programa...");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Opção errada!");
                    }
                }
            }

            static void AdicionarContato()
            {
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Telefone: ");
                string telefone = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();

                Contato contato = new Contato(nome, telefone, email);
                StreamWriter sw = File.AppendText(caminhoArquivo);
                sw.WriteLine(contato.ToFileString());
                sw.Close();
                Console.WriteLine("Contato adicionado!");
            }

            static List<Contato> LerContatosDoArquivo()
            {
                List<Contato> contatos = new List<Contato>();
                if (!File.Exists(caminhoArquivo))
                {
                    return contatos;
                }

                StreamReader sr = new StreamReader(caminhoArquivo);
                string linha;
                while ((linha = sr.ReadLine()) != null)
                {
                    Contato contato = Contato.FromFileString(linha);
                    if (contato != null)
                    {
                        contatos.Add(contato);
                    }
                }
                sr.Close();
                return contatos;
            }

            static void ListarContatos()
            {
                List<Contato> contatos = LerContatosDoArquivo();
                if (contatos.Count == 0)
                {
                    Console.WriteLine("Nenhum contato cadastrado.");
                    return;
                }

                Console.WriteLine("\nEscolha o formato:");
                Console.WriteLine("1 - Markdown");
                Console.WriteLine("2 - Tabela");
                Console.WriteLine("3 - Texto Puro");
                Console.Write("Opção: ");
                string formato = Console.ReadLine();

                ContatoFormatter formatter;
                if (formato == "1")
                {
                    formatter = new MarkdownFormatter();
                }
                else if (formato == "2")
                {
                    formatter = new TabelaFormatter();
                }
                else if (formato == "3")
                {
                    formatter = new RawTextFormatter();
                }
                else
                {
                    Console.WriteLine("Formato inválido! Usando texto puro.");
                    formatter = new RawTextFormatter();
                }

                formatter.ExibirContatos(contatos);
            }
        }
    }
}
