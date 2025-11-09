using System;

class URI
{

    static void Main(string[] args)
    {

        int dtp;
        double tcg, tdcg;

        dtp = int.Parse(Console.ReadLine());
        tcg = double.Parse(Console.ReadLine());

        tdcg = dtp / tcg;

        Console.WriteLine(tdcg.ToString("F3") + " km/l");

        

    }

}
