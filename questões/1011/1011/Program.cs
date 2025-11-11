using System;
using System.Threading.Channels;

class URI
{

    static void Main(string[] args)
    {

        double r, vol, pi;
        r = double.Parse(Console.ReadLine());

        pi = 3.14159;

        vol = (4.0 /3) * pi * (r * r * r);
        Console.WriteLine("Volume = " + vol.ToString("f3"));




    }

}