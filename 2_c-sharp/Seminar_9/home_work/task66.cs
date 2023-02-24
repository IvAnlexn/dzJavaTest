// Задача 66: Задайте значения M и N.
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
using System;
using static System.Console;

Clear();
int startNum = GetNumber("Введите начальное значение: ");
int endNum = GetNumber("Введите конечное значение: ");
if (ValidateUserInput(startNum, endNum)){
    int sumNum = GetSumBetween(startNum, endNum);
    WriteLine($"Сумма чисел от {startNum} до {endNum} равна {sumNum}");
}
else WriteLine("Введенные данные не допустимы");

int GetNumber(string message){
    string userInput = UserPrompt(message);
    int n = int.Parse(userInput);
    return n;
}

string UserPrompt(string message){
    Write(message);
    string userInput = ReadLine();
    return userInput;
}

bool ValidateUserInput(int start, int end){
    return ValidateNatural(start)
        && ValidateNatural(end)
        && ValidateOrder(start, end);
}

bool ValidateNatural(int N){
    if (N <= 0){
        Console.WriteLine("Число должно быть натуральным");
        return false;
    }
    return true;
}

bool ValidateOrder(int start, int end){
    if (start >= end){
        Console.WriteLine("Начальное значение должно быть меньше конечного");
        return false;
    }
    return true;
}

int GetSumBetween(int start, int end){
    if (start == end) return end;
    return start + GetSumBetween(start + 1, end);
}
