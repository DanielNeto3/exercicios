using System; 

class URI
{

    static void Main(string[] args)
    {
        double raio, pi, area;
        raio = double.Parse(Console.ReadLine());
        pi = 3.14159;
        area = pi * (raio * raio);

        Console.WriteLine("A=" + area.ToString("f4"));


    }

}
