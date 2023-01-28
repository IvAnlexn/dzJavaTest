using System;

public class Task
{
    public static void Main(string[] args)
    {

Console.Clear();

Console.Write("Напишите число: ");
int number = int.Parse(Console.ReadLine());
if (number % 2 == 0) {
    Console.WriteLine($"Введенное число {number} четное");
}
else {
    Console.WriteLine($"Введенное число {number} нечетное");
}

    }
}
