using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infnet_c_.Tp2.exercicio5
{
    class Ingresso
    {
        public string NomeDoShow;
        public double Preco;
        public int QuantidadeDisponivel;
        public string GetNomeDoShow() { return NomeDoShow; }
        public double GetPreco() { return Preco; }
        public int GetQuantidadeDisponivel() { return QuantidadeDisponivel; }

        public void SetNomeDoShow(string novoNome) { NomeDoShow = novoNome; }
        public void SetPreco(double novoPreco) { Preco = novoPreco; }
        public void SetQuantidadeDisponivel(int novaQtd) { QuantidadeDisponivel = novaQtd; }
    }

    class Program
    {
        static void Main()
        {
            Ingresso ingresso = new Ingresso();
            ingresso.SetNomeDoShow("Rock in Rio");
            ingresso.SetPreco(150.00);
            ingresso.SetQuantidadeDisponivel(100);
            Console.WriteLine(ingresso.GetPreco());  
            ingresso.SetPreco(200.00);              
            Console.WriteLine(ingresso.GetPreco());  
        }
    }
}
