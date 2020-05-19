using System;

namespace Exercicio_nove
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, triangulo, circulo, trapezio, quadrado, retangulo;

            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());
            C = double.Parse(Console.ReadLine());

            triangulo = A * C / 2.0;
            circulo = 3.14159 * C * C;
            trapezio = (A + B) / 2.0 * C;
            quadrado = B * B;
            retangulo = A * B;

            Console.WriteLine("Triangulo: {0:F3}", triangulo);
            Console.WriteLine("Circulo: {0:F3}", circulo);
            Console.WriteLine("Trapezio: {0:F3}", trapezio);
            Console.WriteLine("Quadrado: {0:F3}", quadrado);
            Console.WriteLine("Retangulo: {0:F3}", retangulo);
        }
    }
}
