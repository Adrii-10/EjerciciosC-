using System;
public class Rectangulo
{
    public static void Main()
    {
        int x = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("{0}{0}{0}", x);
        }
    }
}