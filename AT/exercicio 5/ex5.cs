using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infnet_c_.AT
{
    public class ex5
    {
        static void Main(string[] args)
        {
            // Peguei a data atual do sistema
            DateTime dataAtual = DateTime.Today;
            Console.Write("Digite a data da sua formatura (dd/MM/yyyy): ");
            DateTime dataFormatura;
            while (!DateTime.TryParse(Console.ReadLine(), out dataFormatura))
            {
                Console.Write("Data errada! Digite de novo (dd/MM/yyyy): ");
            }

            // Verifiquei se a formatura já passou
            if (dataAtual > dataFormatura)
            {
                Console.WriteLine("Parabéns! Você já deveria estar formado!");
            }
            else
            {
                // diferença entre as datas
                TimeSpan diferenca = dataFormatura - dataAtual;

                // Transformei os dias totais em anos, meses e dias
                int totalDias = diferenca.Days;
                int anos = totalDias / 365; // Aproximação pros anos
                int diasRestantes = totalDias % 365;
                int meses = diasRestantes / 30; // Aproximação pros meses
                int dias = diasRestantes % 30;

                // Mostrei o resultado
                string mensagem = $"Faltam {anos} anos, {meses} meses e {dias} dias para sua formatura!";
                Console.WriteLine(mensagem);

                // vi se falta menos de 6 meses (180 dias)
                if (totalDias < 180)
                {
                    Console.WriteLine("A reta final chegou! Prepare-se para a formatura!");
                }
            }
        }
    }
}
