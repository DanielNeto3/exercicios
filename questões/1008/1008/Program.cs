using System;

class URI
{

    static void Main(string[] args)
    {
        int fun, hora;
        double sal, salt;

        fun = int.Parse(Console.ReadLine());
        hora = int.Parse(Console.ReadLine());
        sal = double.Parse(Console.ReadLine());

        salt = hora * sal;

        Console.WriteLine("NUMBER = " + fun);
        Console.WriteLine("SALARY = U$ " + salt.ToString("f2"));







    }

}
