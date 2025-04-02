using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infnet_c_.AT.exercicio_6
{
    class ex6
        {
            class Aluno
            {
                public string Nome;
                public string Matricula;
                public string Curso;
                public double MediaNotas;

                // Construtor pra facilitar criar o objeto
                public Aluno(string nome, string matricula, string curso, double media)
                {
                    Nome = nome;
                    Matricula = matricula;
                    Curso = curso;
                    MediaNotas = media;
                }

                // Método pra mostrar os dados do aluno
                public void ExibirDados()
                {
                    Console.WriteLine("Nome: " + Nome);
                    Console.WriteLine("Matrícula: " + Matricula);
                    Console.WriteLine("Curso: " + Curso);
                    Console.WriteLine("Média das Notas: " + MediaNotas);
                    Console.WriteLine("Situação: " + VerificarAprovacao());
                }

                // Método pra ver se o aluno passou ou não
                public string VerificarAprovacao()
                {
                    if (MediaNotas >= 7)
                        return "Aprovado";
                    else
                        return "Reprovado";
                }
            }

            class Program
            {
                static void Main(string[] args)
                {
                    // Criei um objeto com meus dados
                    Aluno eu = new Aluno("Ryan", "2023001", "Engenharia de Software", 8.5);

                    // Chamei o método pra mostrar tudo
                    Console.WriteLine("Meus dados como aluno:");
                    eu.ExibirDados();
                }
            }
        }
}
