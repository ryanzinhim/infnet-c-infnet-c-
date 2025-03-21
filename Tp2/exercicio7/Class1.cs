using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infnet_c_.Tp2.exercicio7
{
   
class Matricula
    {
        public string NomeDoAluno;     
        public string Curso;           
        public int NumeroMatricula;    
        public string Situacao;       
        public string DataInicial;    
    }

    class Program
    {
        static void Main()
        {
            Matricula matricula = new Matricula();
            matricula.NomeDoAluno = "João";
            matricula.Curso = "Engenharia";
            matricula.NumeroMatricula = 12345;
            matricula.Situacao = "Ativa";
            matricula.DataInicial = "01/03/2025";
            Console.WriteLine($"{matricula.NomeDoAluno}, {matricula.Curso}, {matricula.Situacao}");
        }
    }
}
