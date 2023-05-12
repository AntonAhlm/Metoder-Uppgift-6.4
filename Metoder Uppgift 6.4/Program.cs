using System;
class Program
{
    static void Potens(int tal1, int tal2)
    {
        Console.WriteLine(tal1 + "^" + tal2 + " = " + (tal1**tal2));
    }

    static void Main(string[] args)
    {
        Console.Write("Tal 1 : ");
        int tal1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Upphöjt i : ");
        int tal2 = Convert.ToInt32(Console.ReadLine());

        Potens(tal1, tal2);
    }
} 