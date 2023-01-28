using System;

public class Task
{
    public static void Main(string[] args)
    {

Console.Clear();

Console.Write("Напишите число: ");
int N = int.Parse(Console.ReadLine());
for (int i = 2; i <= N; i+=2) {
    Console.Write($"{i} ");
}

    }
}
