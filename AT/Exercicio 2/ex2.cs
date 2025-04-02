using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT.exercicio_1
{
    class Program
    {
        static string CipherName(string name)
        {
            // criei o alfabeto 
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            char[] result = new char[name.Length];
            // deixei tudo minusculo pra deixar mais facil
            name = name.ToLower();

            // loop pra passar por cada letra do nome
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] == ' ')
                    result[i] = ' '; // se for espaço, deixa espaço
                else
                {
                    // achei a posição da letra no alfabeto
                    int pos = Array.IndexOf(alphabet, name[i]);
                    // somei 2 e usei % pra voltar pro começo se passar do z
                    result[i] = alphabet[(pos + 2) % 26];
                }
            }

            // transformei o array em string pra retornar
            return new string(result);
        }

        static void Main()
        {
            // testei com o exemplo que deram
            string padrao = "Carlos Silva";
            Console.WriteLine(CipherName(padrao));

            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();
            //nome cifrado
            Console.WriteLine(CipherName(nome));
        }
    }
}
