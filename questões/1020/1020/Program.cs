using System;

class URI
{

    static void Main(string[] args)
    {

        int N, resto, ano, mes, dias;
        N = int.Parse(Console.ReadLine());
     
        ano = N / 365;
        resto = N % 365;
        Console.WriteLine(ano + " ano(s)");

        mes = resto / 30;
        Console.WriteLine(mes + " mes(es)");
        resto = resto % 30;

        dias = resto / 1;
        Console.WriteLine(dias + " dia(s)");




    }

}
