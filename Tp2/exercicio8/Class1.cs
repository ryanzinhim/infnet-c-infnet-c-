using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infnet_c_.Tp2.exercicio8
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
            matricula.NomeDoAluno = "João";
            matricula.Curso = "Engenharia";
            matricula.Situacao = "Ativa";
            matricula.DataInicial = "01/03/2025";
            matricula.ExibirInformacoes();
        }
    }
}
