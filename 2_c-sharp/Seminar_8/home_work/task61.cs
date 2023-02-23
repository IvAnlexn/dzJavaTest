// Задача 61: Вывести первые N строк треугольника Паскаля.
// Сделать вывод в виде равнобедренного треугольника
using System;
using static System.Console;

Clear();
int PascalSize = GetSize();
if (ValidateSize(PascalSize)){
    int[,] PascaleTriangle = CreatePascalTriangle(PascalSize);
    OutputMessage(PascaleTriangle, "Был создан следующий треугольние Паскаля");
}
else WriteLine("Введенные данные не допустимы");


int GetSize(){
    string userInput = UserPrompt("Введите число строк треугольника Паскаля: ");
    int size = int.Parse(userInput);
    return size;
}

string UserPrompt(string message){
    Write(message);
    string userInput = ReadLine();
    return userInput;
}

bool ValidateSize(int size){
    if (size <= 0){
        Console.WriteLine("Число строк в треугольнике Паскаля должно быть больше 0");
        return false;
    }
    return true;
}

int[,] CreatePascalTriangle(int numberOfRows)
{
    int[,] newTriangle = new int[numberOfRows, numberOfRows];
    FillTriangle(newTriangle);
    return newTriangle;
}

void FillTriangle(int[,] triangle){
    for (int i = 0; i < triangle.GetLength(0); i++)
    {
        for (int j = 0; j < triangle.GetLength(1); j++)
        {
            if(j > i){
                break;
            }
            if (i == 0
                || i == 1
                || j == 0
                || j == i) triangle[i,j] = 1;
            else triangle[i,j] = triangle[i-1, j] + triangle[i-1, j-1];
        }
    }
}

void OutputMessage(int[,] triangle, string message){
    WriteLine(message);
    PrintTriangle(triangle);
}

void PrintTriangle(int[,] inArray)
{
    const int cellWidth = 3;
    int col = cellWidth * inArray.GetLength(0)+6;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            SetCursorPosition(col, i+3);
            if (inArray[i,j] != 0) Write($"{inArray[i,j], cellWidth}");
            col += cellWidth * 2;
        }
        col = cellWidth * inArray.GetLength(0) - cellWidth * (i - 1);
    }
}
