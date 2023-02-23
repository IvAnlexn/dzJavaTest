// Задача 54: Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
using System;
using static System.Console;

Clear();
int[] tableSize = GetTableSize();
int[] tableMinMax = GetMinMaxValue();
if (ValidateUserInput(tableSize, tableMinMax)){
    int[,] randomValuesTable = CreateRandomValuesTable(tableSize, tableMinMax);
    OutputMessage(randomValuesTable, "Была создана следующая таблица");
    SortInsideRowsInArray(randomValuesTable);
    OutputMessage(randomValuesTable, "Вывод таблицы с упорядоченными по убыванию строками");
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
   if (ValidateArraySize(arraySizeInput)
       && ValidateMinMaxInput(arrayMinMaxInput)) return true;
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

void SortInsideRowsInArray(int[,] table){
    for (int i=0; i<table.GetLength(0); i++){
        SortOneRowDesc(table, i);
    }
}

void SortOneRowDesc(int[,] table, int rowIndex){
    int temp = 0;
    for (int k=0; k<table.GetLength(1)-1; k++){
        for (int j=0; j < table.GetLength(1) - 1 - k; j++){
            if (table[rowIndex, j] < table[rowIndex, j+1]){
                temp = table[rowIndex, j+1];
                table[rowIndex, j+1] = table[rowIndex, j];
                table[rowIndex, j] = temp;
            }
        }
    }
}

void OutputMessage(int[,] table, string message){
    WriteLine(message);
    PrintTable(table);
    WriteLine("");
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
