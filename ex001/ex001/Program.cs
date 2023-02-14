using System;
using System.Globalization;

namespace Ex001 {
    internal class Program {
        static void Main(string[] args) {
            string produto1 = "Computador";
            string produto2 = "Mesa de Escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double media = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo o preço é {preco1.ToString("F2")}");
            Console.WriteLine($"{produto2}, cujo o preço é {preco2.ToString("F2")}");
            Console.WriteLine("Registro:");
            Console.WriteLine($"{idade} anos de idade, código {codigo} e gênero: {genero}");
            Console.WriteLine($"{media.ToString("F8")}");
            Console.WriteLine($"{media.ToString("F3")}");
            Console.WriteLine($"{media.ToString("F3", CultureInfo.InvariantCulture)}");
        }
    }
}


