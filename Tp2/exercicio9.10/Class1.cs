


namespace Infnet_c_.Tp2.exercicio_10
{
    class Circulo
    {
        public double Raio;
    }
    class Esfera
    {
        public double Raio;
    }

    class Program
    {
        static void Main()
        {
            Circulo circulo = new Circulo();
            circulo.Raio = 3.0;
            Esfera esfera = new Esfera();
            esfera.Raio = 5.0;
            Console.WriteLine($"Círculo Raio: {circulo.Raio}, Esfera Raio: {esfera.Raio}");
        }
    }
}
