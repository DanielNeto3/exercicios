using System;

class URI
{

    static void Main(string[] args)
    {

        string nome;
        double salfixo, vendames,total;

        nome = Console.ReadLine();
        salfixo = double.Parse(Console.ReadLine());
        vendames = double.Parse(Console.ReadLine());

        total = salfixo + ((vendames * 15) / 100);

        Console.WriteLine("TOTAL = R$ " + total.ToString("f2"));



    }

}
