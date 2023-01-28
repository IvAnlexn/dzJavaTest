using System;

public class Task
{
    public static void Main(string[] args)
    {

Console.Clear();

Console.Write("Напишите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Напишите второе число: ");
int number2 = int.Parse(Console.ReadLine());
Console.Write("Напишите третье число: ");
int number3 = int.Parse(Console.ReadLine());
int max = number1;
if (number2 > max) {
    max = number2;
}
if (number3 > max) {
    max = number3;
}
Console.WriteLine($"Максимальное из трех чисел это {max}");

    }
}
