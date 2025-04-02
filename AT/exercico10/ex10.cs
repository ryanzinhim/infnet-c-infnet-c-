using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infnet_c_.AT.exercico10
{
    public class ex10
    {

        static void Main(string[] args)
        {
            Random random = new Random();
            int numeroSecreto = random.Next(1, 51); // Gera número aleatório entre 1 e 50
            int tentativasRestantes = 5;

            Console.WriteLine("Bem-vindo ao Jogo de Adivinhação!");
            Console.WriteLine("Tente adivinhar o número entre 1 e 50. Você tem 5 tentativas.");

            while (tentativasRestantes > 0)
            {
                Console.Write($"\nTentativas restantes: {tentativasRestantes}. Digite seu palpite: ");

                try
                {
                    int palpite = int.Parse(Console.ReadLine());

                    // Verifica se o palpite está no intervalo válido
                    if (palpite < 1 || palpite > 50)
                    {
                        Console.WriteLine("Erro: Por favor, digite um número entre 1 e 50!");
                        continue; // Não desconta tentativa por erro de intervalo
                    }
                    if (palpite == numeroSecreto)
                    {
                        Console.WriteLine("Parabéns! Você acertou o número!");
                        return;
                    }
                    else if (palpite < numeroSecreto)
                    {
                        Console.WriteLine("O número é maior que o seu palpite.");
                    }
                    else
                    {
                        Console.WriteLine("O número é menor que o seu palpite.");
                    }

                    tentativasRestantes--;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Erro: Por favor, digite um número válido!");
                    continue; // Não desconta tentativa por erro de formato
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Erro inesperado: {e.Message}");
                    continue;
                }
            }

            Console.WriteLine($"\nGame Over! O número era {numeroSecreto}.");
        }
    }
}

