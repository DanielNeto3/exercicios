using System;


class URI
{

    static void Main(string[] args)
    {

        double a, b, c, delta, r1, r2;
        string[] vet = Console.ReadLine().Split();
        a = double.Parse(vet[0]);
        b = double.Parse(vet[1]);
        c = double.Parse(vet[2]);

        delta = (b * b) - 4 * a * c;

        if (delta < 0 || a == 0) {

            Console.WriteLine("Impossivel calcular");

        }
        else
        {
            r2 = (-b - Math.Sqrt(delta)) / (2 * a);
            r1 = (-b + Math.Sqrt(delta)) / (2 * a);
            

            Console.WriteLine("R1 = " + r1.ToString("f5"));
            Console.WriteLine("R2 = " + r2.ToString("f5"));

            
        }



    }

}