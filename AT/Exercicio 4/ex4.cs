using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infnet_c_.AT.Exercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite sua data de nascimento (dd/mm/aaaa): ");
            DateTime nascimento;
            while (!DateTime.TryParse(Console.ReadLine(), out nascimento))
                Console.Write("Data errada, digite de novo (dd/mm/aaaa): ");

            // Peguei a data de hoje
            DateTime hoje = DateTime.Today;

            // Calculei o próximo aniversário
            DateTime proximoAniversario = new DateTime(hoje.Year, nascimento.Month, nascimento.Day);
            if (proximoAniversario < hoje)
                proximoAniversario = proximoAniversario.AddYears(1);

            // Calculei os dias que faltam
            int diasFaltam = (proximoAniversario - hoje).Days;

            Console.WriteLine("Faltam " + diasFaltam + " dias pro seu próximo aniversário!");
            if (diasFaltam < 7)
                Console.WriteLine("Falta menos de uma semana, que legal!");
        }
    }
}
