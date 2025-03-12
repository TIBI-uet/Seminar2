using System;

public class Usht1
{
    public static void Main(string[] args)
    {
        Console.Write("Shkruaj nje numer per te afishuar: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.Write(i + " ");
        }
    }
}