using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Djalma_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //circulo, triangulo, trapezio.

            double a, b, c, num;
            string figura = null;
            var area = Convert.ToDouble(null);


            Console.WriteLine("Programa para calculo da area de figuras geometricas");
            Console.WriteLine("Digite o numero correspondende a figura desejada");
            Console.WriteLine();
            Console.WriteLine("1. Triangulo");
            Console.WriteLine("2. losango");
            Console.WriteLine("3. Trapezio");

            switch (num)
            {
                case 1:
                    figura = ("Triangulo");
                    Console.WriteLine("Digite o valor da base");
                    b = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digiteo valor da altura");
                    a = double.Parse(Console.ReadLine());

                    area = b * a / 2;

                    break;

                case 2:
                    figura = ("Losango");
                    Console.WriteLine("Digite o valor da diagonal maior");
                    b = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digiteo valor da diagonal menor");
                    a = double.Parse(Console.ReadLine());

                    area = b * a / 2;

                    break;

                case 3:
                    figura = ("TRapezio");
                    Console.WriteLine("Digite o valor da base maior");
                    b = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digiteo valor da base menor");
                    c = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o valor da altura");
                    a = double.Parse(Console.ReadLine());

                    area = (b + c) * a / 2;
                    break;

                    

                    break;



            }
            Console.WriteLine();
            Console.WriteLine("Seu" + figura + "Tem area total de " + area + "cm");

            Console.ReadKey();

        }
    }
}
