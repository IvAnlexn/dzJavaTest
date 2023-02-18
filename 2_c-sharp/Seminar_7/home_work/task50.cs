// Задача 50.
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

using System;
using static System.Console;

Clear();
int[] tableSize = GetTableSize();
int[] tableMinMax = GetMinMaxValue();
if (ValidateUserInput(tableSize, tableMinMax)){
    int[] elementIndex = GetElementIndex();
    int[,] randomValuesTable = CreateRandomValuesTable(tableSize, tableMinMax);
    FindValueByIndexInTable(randomValuesTable, elementIndex);
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

int[] GetElementIndex(){
    string userInput = UserPrompt("Введите через пробел строку и столбец на пересечении которых находится элемент: ");
    int[] RowColumn = ConvertStringToIntArray(userInput);
    int[] elIndex = ConvertToIndex(RowColumn);
    return elIndex;
}

int[] ConvertToIndex(int[] rowColCross){
    rowColCross[0] = rowColCross[0] - 1;
    rowColCross[1] = rowColCross[1] - 1;
    return rowColCross;
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

void FindValueByIndexInTable(int[,] tableWithValues, int[] elementIndex){
    if (ValidateIndex(tableWithValues, elementIndex)){
        OutputMessage(tableWithValues, tableWithValues[elementIndex[0], elementIndex[1]], elementIndex);
    }
    else{ WriteLine($"Элемента в строке {elementIndex[0] + 1} и столбце {elementIndex[1] + 1} нет в таблице");
    }
}

bool ValidateIndex(int[,] tableWithValues, int[] elementIndex){
    if (elementIndex[0] > tableWithValues.GetLength(0) - 1 ||
        elementIndex[1] > tableWithValues.GetLength(1) - 1) return false;
    return true;
}

void OutputMessage(int[,] table, int elementValue, int[] elementIndex){
    WriteLine("Была создана следующая таблица:");
    PrintTable(table);
    WriteLine($"Значение элемента таблицы в строке {elementIndex[0] + 1} и столбце {elementIndex[1] + 1} равно {elementValue}");
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
