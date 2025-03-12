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


using System;

public class Usht2
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Fut 3 numra per maximumin: ");
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());
        int n3 = int.Parse(Console.ReadLine());

        int max = Math.Max(n1, Math.Max(n2, n3));

        Console.WriteLine("Maksimumi eshte: " + max);
    }
}


using System;

public class Usht3
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


using System;

public class Usht4
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Fut viti nese eshte i brishte apo jo i brishte: ");
        int viti = int.Parse(Console.ReadLine());

        if (viti % 4 == 0 && viti % 100 != 0 || viti % 400 == 0)
        {
            Console.WriteLine("Viti eshte i brishte: " + viti);
        }
        else
        {
            Console.WriteLine("Viti nuk eshte i brishte: " + viti);
        }
    }
}


using System;

public class Usht5
{
    public static void Main(String[] args)
    {
        Console.Write("Shkruaj nje fjale nese jane te barabarte karaktere: ");
        string n = Console.ReadLine();
        bool result = true;

        for (int i = 1; i < n.Length; i++)
        {
            if (n[i] != n[0])
            {
                result = false;
                break;
            }
        }

        Console.WriteLine(result);
    }
}


using System;

public class Usht6
{
    public static void Main(String[] args)
    {
        Console.Write("Shkruaj nje numer: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Numrat cift jane: ");

        for (int i = 1; i <= n; i++)
        {
            if (i % 2 == 0) Console.WriteLine(i);
        }
    }
}


using System;

public class Usht7
{
    public static void Main(String[] args)
    {
        Console.Write("Shkruaj nje numer: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                Console.WriteLine(i + " * " + j + " = " + i * j + "\t");
            }
            Console.WriteLine(" ");
        }
    }
}