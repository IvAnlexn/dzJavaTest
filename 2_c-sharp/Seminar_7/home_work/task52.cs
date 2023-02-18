// Задача 52.
// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

using System;
using static System.Console;

Clear();
int[] tableSize = GetTableSize();
int[] tableMinMax = GetMinMaxValue();
if (ValidateUserInput(tableSize, tableMinMax)){
    int[,] randomValuesTable = CreateRandomValuesTable(tableSize, tableMinMax);
    double[] meanPerColumns = CalculateMeanPerColumn(randomValuesTable);
    OutputMessage(meanPerColumns, randomValuesTable);
}
else WriteLine("Введенные данные не допустимы");


int[] GetTableSize(){
    string userInput = UserPrompt("Введите через пробел число строк и столбцов в таблице: ");
    int[] tableSize = ConvertStringToIntArray(userInput);
    return tableSize;
}

int[] GetMinMaxValue(){
    string userInput = UserPrompt("Введите через пробел минимальное и максимальное значение в таблице: ");
    int[] tableMinMax = ConvertStringToIntArray(userInput);
    return tableMinMax;
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

bool ValidateUserInput(int[] arraySizeInput, int[] arrayMinMaxInput){
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

bool ValidateMinMaxInput(int[] arrayMinMax){
    // Method for checking if inputed min and max value is valid.
    if (arrayMinMax[0] >= arrayMinMax[1]){
        Console.WriteLine("Минимальное значение должно быть меньше максимального.");
        return false;
    }
    return true;
}

int[,] CreateRandomValuesTable(int[] tableSize, int[] tableMinMax)
{
    int[,] newTable = new int[tableSize[0], tableSize[1]];
    FillTable(newTable, tableMinMax);
    return newTable;
}

void FillTable(int[,] table, int[] tableMinMax){
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i, j] = new Random().Next(tableMinMax[0], tableMinMax[1]+1);
        }
    }
}

double[] CalculateMeanPerColumn(int[,] tableWithValues){
    double[] resultArray = new double[tableWithValues.GetLength(1)];
    for (int j = 0; j < tableWithValues.GetLength(1); j++)
    {
        int count = 0;
        for (int i = 0; i < tableWithValues.GetLength(0); i++)
        {
            count += tableWithValues[i, j];
        }
        double mean = Convert.ToDouble(count) / Convert.ToDouble(tableWithValues.GetLength(0));
        resultArray[j] = mean;
    }
    return resultArray;
}

void OutputMessage(double[] meanResult, int[,] table){
    WriteLine("Была создана следующая таблица:");
    PrintTable(table);
    WriteLine("Средние значения каждого столбца таблицы следующие: ");
    PrintArray(meanResult);
}

void PrintTable(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i,j]} ");
        }
        WriteLine();
    }
}

void PrintArray(double[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        Write($"{inArray[i]:f2} ");
    }
}
