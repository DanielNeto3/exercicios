using System;

class URI
{

    static void Main(string[] args)
    {
       
        double quantlitros, tempogv, vm;

        tempogv = int.Parse(Console.ReadLine());

        vm = int.Parse(Console.ReadLine());

        quantlitros = (tempogv * vm) / 12;

        Console.WriteLine(quantlitros.ToString("f3"));


    }

}
