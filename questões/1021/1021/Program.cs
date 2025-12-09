using System;
using System.Globalization;
class URI
{

    static void Main(string[] args)
    {

        double N, resto,quociente;
        N = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

        Console.WriteLine("NOTAS:");

        double a = 100.00;
        quociente = N / a;
        int notas = (int)Math.Floor(quociente);
        Console.WriteLine(notas.ToString("f0", CultureInfo.InvariantCulture) + " nota(s) de R$ 100.00");
        resto = N % 100.00;

        double b = 50.00;
        quociente = resto / b;
        notas = (int)Math.Floor(quociente);
        Console.WriteLine(notas.ToString("f0", CultureInfo.InvariantCulture) + " nota(s) de R$ 50.00");
        resto = resto % b;

        double c = 20.00;
        quociente = resto/ c;
        notas = (int)Math.Floor(quociente);
        Console.WriteLine(notas.ToString("f0", CultureInfo.InvariantCulture) + " nota(s) de R$ 20.00"); 
        resto = resto % c;

        double d = 10.00;
        quociente = resto/ d;
        notas = (int)Math.Floor(quociente);
        Console.WriteLine(notas.ToString("f0", CultureInfo.InvariantCulture) + " nota(s) de R$ 10.00");
        resto = resto % d;

        double e = 5.00;
        quociente = resto/ e;
        notas = (int)Math.Floor(quociente);
        Console.WriteLine(notas.ToString("f0", CultureInfo.InvariantCulture) + " nota(s) de R$ 5.00");
        resto = resto % e;

        double f = 2.00;
        quociente = resto/ f;
        notas = (int)Math.Floor(quociente);
        Console.WriteLine(notas.ToString("f0", CultureInfo.InvariantCulture) + " nota(s) de R$ 2.00");
        resto = resto % f;

        Console.WriteLine("MOEDAS:");

        double g = 1.00;
        quociente = resto/ g;
        notas = (int)Math.Floor(quociente);
        Console.WriteLine(notas.ToString("f0", CultureInfo.InvariantCulture) + " moeda(s) de R$ 1.00");
        resto = resto % g;

        double h = 0.50;
        quociente = resto/ h;
        notas = (int)Math.Floor(quociente);
        Console.WriteLine(notas.ToString("f0", CultureInfo.InvariantCulture) + " moeda(s) de R$ 0.50");
        resto = resto % h;

        double i = 0.25;
        quociente = resto/ i;
        notas = (int)Math.Floor(quociente);
        Console.WriteLine(notas.ToString("f0", CultureInfo.InvariantCulture) + " moeda(s) de R$ 0.25");
        resto = resto % i;

        double j = 0.10;
        quociente = resto/ j;
        notas = (int)Math.Floor(quociente);
        Console.WriteLine(notas.ToString("f0", CultureInfo.InvariantCulture) + " moeda(s) de R$ 0.10");
        resto = resto % j;

        double k = 0.05;
        quociente = resto/ k;
        notas = (int)Math.Floor(quociente);
        Console.WriteLine(notas.ToString("f0", CultureInfo.InvariantCulture) + " moeda(s) de R$ 0.05");
        resto = Math.Round(resto % k, 2);

        double l = 0.01;
        quociente = resto/ l;
        notas = (int)Math.Floor(quociente);
        Console.WriteLine(notas.ToString("f0", CultureInfo.InvariantCulture) + " moeda(s) de R$ 0.01");
        resto = resto % l;








    }

}
