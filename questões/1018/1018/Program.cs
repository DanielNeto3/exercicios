using System;

class URI
{

    static void Main(string[] args)
    {

       int N, var1, var2, var3, var4, var5, var6, var7;

        N = int.Parse(Console.ReadLine());

        var1 = N / 100;

        var2 = (N % 100) / 50;

        var3 = ((N % 100)%50) / 20;

        var4 = (((N % 100) % 50) % 20) / 10;

        var5 = ((((N % 100) % 50) % 20) % 10) / 5;

        var6 = (((((N % 100) % 50) % 20) % 10) % 5) / 2;
        var7 = ((((((N % 100) % 50) % 20) % 10) % 5)%2) / 1;

        Console.WriteLine(N);
        Console.WriteLine(var1 + " nota(s) de R$ 100,00");
        Console.WriteLine(var2 + " nota(s) de R$ 50,00");
        Console.WriteLine(var3 + " nota(s) de R$ 20,00");
        Console.WriteLine(var4 + " nota(s) de R$ 10,00");
        Console.WriteLine(var5 + " nota(s) de R$ 5,00");
        Console.WriteLine(var6 + " nota(s) de R$ 2,00");
        Console.WriteLine(var7 + " nota(s) de R$ 1,00");




       

    }
    
}
