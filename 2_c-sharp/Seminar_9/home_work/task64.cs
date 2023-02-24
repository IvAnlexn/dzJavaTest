// Задача 64: Задайте значение N.
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
using System;
using static System.Console;

Clear();
int startNum = GetNumber();
if (ValidateUserInput(startNum)){
    List<int> listOfNumbers = GetNumbersFromNToOne(startNum);
    OutputMessage(listOfNumbers, $"Вывод чисел от {startNum} до 1:");
}
else WriteLine("Введенные данные не допустимы");


int GetNumber(){
    string userInput = UserPrompt("Введите число начала отсчета: ");
    int n = int.Parse(userInput);
    return n;
}

string UserPrompt(string message){
    Write(message);
    string userInput = ReadLine();
    return userInput;
}

bool ValidateUserInput(int N){
    if (N <= 0){
        Console.WriteLine("Число должно быть натуральным");
        return false;
    }
    return true;
}

List<int> GetNumbersFromNToOne(int N){
    List<int> listOfNumbers = new List<int>();
    FillList(N, listOfNumbers);
    return listOfNumbers;
}

void FillList(int N, List<int> list){
    if (N == 1) list.Add(N);
    else {
    list.Add(N);
    FillList(N-1, list);
    }
}

void OutputMessage(List<int> list, string message){
    WriteLine(message);
    foreach (int n in list) Write($"{n} ");
}
