using System;

class URI
{

    static void Main(string[] args)
    {

        int cod1, quant1, cod2, quant2;
        double preco1, preco2, total;
        string[] vet1;

        vet1 = Console.ReadLine().Split(" ");
        cod1 = int.Parse(vet1[0]);
        quant1 = int.Parse(vet1[1]);
        preco1 = double.Parse(vet1[2]);

        vet1 = Console.ReadLine().Split(" ");
        cod2 = int.Parse(vet1[0]);
        quant2 = int.Parse(vet1[1]);
        preco2 = double.Parse(vet1[2]);
        
        total = (preco1 * quant1) + (preco2 * quant2);

        Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2"));

    }

}  
