using System;

class URI
{

    static void Main(string[] args)
    {
     double nota1, peso1, nota2, peso2, media;
        peso1 = 3.5;
        peso2 = 7.5;

        nota1 = double.Parse(Console.ReadLine());
        nota2 = double.Parse(Console.ReadLine());

        media = ((nota1 * peso1) + (nota2 * peso2))/ (peso1 + peso2);

        Console.WriteLine("MEDIA = " + media.ToString("f5"));



    }

}

