// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
using System;
using static System.Console;

Clear();
int[] tableSize = GetTableSize();
int[] tableMinMax = GetMinMaxValue();
if (ValidateUserInput(tableSize, tableMinMax)){
    int[,] randomValuesTable = CreateRandomValuesTable(tableSize, tableMinMax);
    OutputMessage(randomValuesTable, "Была создана следующая таблица");
    int rowNumber = FindRowWithMinSumOfElements(randomValuesTable);
    OutputResultMessage(rowNumber);
}
else WriteLine("Введенные данные не допустимы");


int[] GetTableSize(){
    string userInput = UserPrompt("Введите через пробел число строк и столбцов в таблице, число строк не должно равняться числу столбцов: ");
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
   if (ValidateArraySize(arraySizeInput)
       && ValidateMinMaxInput(arrayMinMaxInput)
       && ValidateRectangleShape(arraySizeInput)) return true;
   return false;
}

bool ValidateArraySize(int[] arraySize){
    if (arraySize[0] <= 0 || arraySize[1] <= 0){
        Console.WriteLine("Размер массива должен быть больше нуля");
        return false;
    }
    return true;
}

bool ValidateMinMaxInput(int[] arrayMinMax){
    if (arrayMinMax[0] >= arrayMinMax[1]){
        Console.WriteLine("Минимальное значение должно быть меньше максимального.");
        return false;
    }
    return true;
}

bool ValidateRectangleShape(int[] arraySize){
    if (arraySize[0] == arraySize[1]){
        Console.WriteLine("Массив должен быть прямоугольным");
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

int FindRowWithMinSumOfElements(int[,] table){
    int minSumRowIndex = 0;
    int minSumRowValue= getSumForRow(table, minSumRowIndex);
    for (int rowIndex=1; rowIndex<table.GetLength(0); rowIndex++){
        int SumCurrentRowValue = getSumForRow(table, rowIndex);
        if (SumCurrentRowValue < minSumRowValue){
            minSumRowValue = SumCurrentRowValue;
            minSumRowIndex = rowIndex;
        }
    }
    return minSumRowIndex+1;
}

int getSumForRow(int[,] table, int rowIndex){
    int sum = 0;
    for (int i=0; i<table.GetLength(1); i++){
        sum += table[rowIndex, i];
    }
    return sum;
}

void OutputMessage(int[,] table, string message){
    WriteLine(message);
    PrintTable(table);
    WriteLine("");
}

void OutputResultMessage(int result){
    WriteLine($"Номер строки с минимальной суммой элементов {result}");
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
