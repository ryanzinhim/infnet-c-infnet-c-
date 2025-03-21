namespace Infnet_c_.Tp2.exercicio1
{
    // Classe: Molde que define características (campos) e comportamentos (métodos)
    class Carro
    {
        // Campos (atributos): Variáveis que armazenam as propriedades do objeto
        public string Cor;         // Atributo que define a cor do carro
        public int Velocidade;     // Atributo que define a velocidade atual

        public void Acelerar(int incremento)
        {
            Velocidade += incremento;
            Console.WriteLine($"O carro {Cor} está agora a {Velocidade} km/h.");
        }
    }

    class Program
    {
        static void Main()
        {
            // Objeto: Instância concreta criada a partir da classe Carro
            Carro meuCarro = new Carro();
            meuCarro.Cor = "Vermelho";    // Definindo o valor do campo Cor
            meuCarro.Velocidade = 0;      // Definindo o valor inicial do campo Velocidade

            // Chamando o método Acelerar para demonstrar o comportamento
            meuCarro.Acelerar(50);
        }
    }
}
