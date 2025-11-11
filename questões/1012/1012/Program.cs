using System;


class URI
{

    static void Main(string[] args)
    {

        double a, b, c, cir, tri, ren, quad, trap;
        string[] vet = Console.ReadLine().Split(' ');
        a = double.Parse(vet[0]);
        b = double.Parse(vet[1]);
        c = double.Parse(vet[2]);

       

        tri = (a * c) / 2;
        cir = 3.14159 * (c * c);
        trap = ((a + b) * c) / 2;
        quad = b * b;
        ren = a * b;

        Console.WriteLine("TRIANGULO: " + tri.ToString("f3"));
        Console.WriteLine("CIRCULO: " + cir.ToString("f3"));
        Console.WriteLine("TRAPEZIO: " + trap.ToString("f3"));
        Console.WriteLine("QUADRADO: " + quad.ToString("f3"));
        Console.WriteLine("RETANGULO: " + ren.ToString("f3"));




    }

}
