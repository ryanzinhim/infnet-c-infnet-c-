using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infnet_c_.Tp2.exercicio9
{
    class Matricula
    {
        public string NomeDoAluno;
        public string Curso;
        public int NumeroMatricula;
        public string Situacao;
        public string DataInicial;

        public void Trancar()
        {
            Situacao = "Trancada";
        }

        public void Reativar()
        {
            Situacao = "Ativa";
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Aluno: {NomeDoAluno}, Curso: {Curso}, Situação: {Situacao}, Data Inicial: {DataInicial}");
        }
    }

    class Program
    {
        static void Main()
        {
            Matricula matricula = new Matricula();
            matricula.NomeDoAluno = "João Silva";
            matricula.Curso = "Engenharia";
            matricula.NumeroMatricula = 12345;
            matricula.Situacao = "Ativa";
            matricula.DataInicial = "01/03/2025";

            matricula.ExibirInformacoes();  // Mostra estado inicial
            matricula.Trancar();            // Tranca a matrícula
            matricula.ExibirInformacoes();  // Mostra após trancar
            matricula.Reativar();           // Reativa a matrícula
            matricula.ExibirInformacoes();  // Mostra após reativar
        }
    }
}
