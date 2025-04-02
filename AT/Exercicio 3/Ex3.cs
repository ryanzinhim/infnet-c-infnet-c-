using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infnet_c_.AT
{
    class Ex3
    {
        static void Main()
        {
            // pega os números
            Console.Write("Primeiro número: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Segundo número: ");
            double num2 = double.Parse(Console.ReadLine());

            // escolhe a operação
            Console.Write("Operação (1-soma, 2-sub, 3-mult, 4-div): ");
            int escolha = int.Parse(Console.ReadLine());

            // faz o cálculo
            if (escolha == 1) Console.WriteLine(num1 + num2);
            else if (escolha == 2) Console.WriteLine(num1 - num2);
            else if (escolha == 3) Console.WriteLine(num1 * num2);
            else if (escolha == 4)
            {
                if (num2 == 0) Console.WriteLine("Não dá pra dividir por zero!");
                else Console.WriteLine(num1 / num2);
            }
            else Console.WriteLine("Opção errada!");
        }
    }
}
