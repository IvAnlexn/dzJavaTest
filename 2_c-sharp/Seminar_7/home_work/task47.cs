// Задача 47. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
using System;
using static System.Console;

Clear();
int[] tableSize = GetTableSize();
double[] tableMinMax = GetMinMaxValue();
if (ValidateUserInput(tableSize, tableMinMax)){
    double[,] randomValuesTable = CreateRandomValuesTable(tableSize, tableMinMax);
    OutputMessage(randomValuesTable);
}
else WriteLine("Введенные данные не допустимы");


int[] GetTableSize(){
    string userInput = UserPrompt("Введите через пробел число строк и столбцов в таблице: ");
    int[] tableSize = ConvertStringToIntArray(userInput);
    return tableSize;
}

string UserPrompt(string message){
    Write(message);
    string userInput = ReadLine();
    return userInput;
}

int[] ConvertStringToIntArray(string arrayAsString){
    string[] arrayString = arrayAsString.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] arrayInt = new int[arrayString.Length];
    for (int i=0; i < arrayString.Length; i++){
        arrayInt[i] = int.Parse(arrayString[i]);
    }
    return arrayInt;
}

double[] GetMinMaxValue(){
    string userInput = UserPrompt("Введите через пробел минимальное и максимальное значение в таблице: ");
    double[] tableMinMax = ConvertStringToDoubleArray(userInput);
    return tableMinMax;
}

double[] ConvertStringToDoubleArray(string arrayAsString){
    string[] arrayString = arrayAsString.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    double[] arrayDouble = new double[arrayString.Length];
    for (int i=0; i < arrayString.Length; i++){
        arrayDouble[i] = Convert.ToDouble(arrayString[i]);
    }
    return arrayDouble;
}

bool ValidateUserInput(int[] arraySizeInput, double[] arrayMinMaxInput){
   if (ValidateArraySize(arraySizeInput) ||
       ValidateMinMaxInput(arrayMinMaxInput)) return true;
   return false;
}

bool ValidateArraySize(int[] arraySize){
    // Method for checking if inputed array size is positive
    if (arraySize[0] <= 0 || arraySize[1] <= 0){
        Console.WriteLine("Размер массива должен быть больше нуля");
        return false;
    }
    return true;
}

bool ValidateMinMaxInput(double[] arrayMinMax){
    // Method for checking if inputed min and max value is valid.
    if (arrayMinMax[0] >= arrayMinMax[1]){
        Console.WriteLine("Минимальное значение должно быть меньше максимального.");
        return false;
    }
    return true;
}

double[,] CreateRandomValuesTable(int[] tableSize, double[] tableMinMax)
{
    double[,] newTable = new double[tableSize[0], tableSize[1]];
    FillTable(newTable, tableMinMax);
    return newTable;
}

void FillTable(double[,] table, double[] tableMinMax){
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i, j] = new Random().NextDouble()*(tableMinMax[1] - tableMinMax[0]) + tableMinMax[0];
        }
    }
}

void OutputMessage(double[,] finalResult){
    WriteLine("Была создана следующая таблица:");
    PrintTable(finalResult);
}

void PrintTable(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i,j]:f2} ");
        }
        WriteLine();
    }
}
