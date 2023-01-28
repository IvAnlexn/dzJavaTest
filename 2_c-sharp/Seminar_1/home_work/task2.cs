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
if (number1 > number2) {
    Console.WriteLine($"Число {number1} больше чем число {number2}");
}
else if (number1 == number2) {
    Console.WriteLine($"Число {number1} равно числу {number2}");
}
else {
    Console.WriteLine($"Число {number2} больше чем число {number1}");
}

    }
}
