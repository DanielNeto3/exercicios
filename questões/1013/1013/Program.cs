using System;

class URI
{

    static void Main(string[] args)
    {

        int a, b, c, MaiorAB;
        string[] vet = Console.ReadLine().Split(' ');
        a = int.Parse(vet[0]);
        b = int.Parse(vet[1]);
        c = int.Parse(vet[2]);

        MaiorAB = (a + b + Math.Abs(a - b))/2 ;

        if (MaiorAB == a && a > b && a > c)
        {
            Console.WriteLine(a + " eh o maior");
        }
        else if (MaiorAB == b && b > a && b > c)
        {
            Console.WriteLine(b + " eh o maior");
        } else
        {
            Console.WriteLine(c + " eh o maior");
        }




    }

}

