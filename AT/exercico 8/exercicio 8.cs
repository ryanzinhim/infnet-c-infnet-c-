using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infnet_c_.AT
{
    public class exercicio_8
    {
        class Funcionario
        {
            // Propriedade
            public string Nome { get; set; }
            public string Cargo { get; set; }
            public double SalarioBase { get; set; }

            // Construtor
            public Funcionario(string nome, string cargo, double salarioBase)
            {
                Nome = nome;
                Cargo = cargo;
                SalarioBase = salarioBase;
            }

            // Método para calcular o salário (pode ser sobrescrito por subclasses)
            public virtual double CalcularSalario()
            {
                return SalarioBase;
            }

            // Método para mostrar os dados do funcionário
            public virtual void ExibirDados()
            {
                Console.WriteLine($"Nome: {Nome}");
                Console.WriteLine($"Cargo: {Cargo}");
                Console.WriteLine($"Salário Base: R$ {SalarioBase:F2}");
                Console.WriteLine($"Salário Final: R$ {CalcularSalario():F2}");
                Console.WriteLine();
            }
        }

        // Subclasse Gerente que herda de Funcionario
        class Gerente : Funcionario
        {
            // Propriedade para o percentual de bônus (20%)
            private const double PercentualBonus = 0.20;
            public Gerente(string nome, double salarioBase)
                : base(nome, "Gerente", salarioBase)
            {
            }
            public override double CalcularSalario()
            {
                return SalarioBase + (SalarioBase * PercentualBonus);
            }

            public override void ExibirDados()
            {
                base.ExibirDados();
                Console.WriteLine($"Bônus aplicado: {PercentualBonus * 100}%");
                Console.WriteLine();
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                // Criando um objeto da classe Funcionario
                Funcionario funcionario = new Funcionario("João Silva", "Analista", 3000.00);

                // Criando um objeto da classe Gerente
                Gerente gerente = new Gerente("Maria Souza", 5000.00);

                // Exibindo os dados dos funcionários
                Console.WriteLine("===== DADOS DOS FUNCIONÁRIOS =====");
                funcionario.ExibirDados();
                gerente.ExibirDados();

            }
        }
    }
}
