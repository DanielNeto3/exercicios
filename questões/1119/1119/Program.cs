using System;

class URI
{

    static void Main(string[] args)
    {
        int H, hora, minuto, segundo;
            H = int.Parse(Console.ReadLine());

        hora = H / 3600;
        minuto = (H % 3600) / 60;
        segundo = H % 60 ;

      Console.WriteLine(hora+":"+minuto+":"+segundo);
    }
       
} 