// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
using System;
using static System.Console;

Clear();
int firstNum = GetNumber("Введите первое неотрицательное целое число: ");
int secondNum = GetNumber("Введите второе неотрицательное целое число : ");
if (ValidateUserInput(firstNum, secondNum)){
    int akkermanNum = GetAkkerman(firstNum, secondNum);
    WriteLine($"Функция Аккермана для чисел {firstNum} и {secondNum} равна A({firstNum},{secondNum})={akkermanNum}");
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

bool ValidateUserInput(int first, int second){
    return ValidateNotNegative(first)
        && ValidateNotNegative(second);
}

bool ValidateNotNegative(int N){
    if (N < 0){
        Console.WriteLine("Число должно быть неотрицательным");
        return false;
    }
    return true;
}

int GetAkkerman(int m, int n){
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return GetAkkerman(m-1, 1);
    else return GetAkkerman(m-1, GetAkkerman(m, n-1));
    }
