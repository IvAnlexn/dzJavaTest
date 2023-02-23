// Задача 58: Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.
using System;
using static System.Console;

Clear();
WriteLine("Введите данные для первой матрицы.");
int[] tableSize1 = GetTableSize();
int[] tableMinMax1 = GetMinMaxValue();
WriteLine("Введите данные для второй матрицы.");
int[] tableSize2 = GetTableSize();
int[] tableMinMax2 = GetMinMaxValue();

if (ValidateUserInput(tableSize1, tableMinMax1)
    && ValidateIfMultiplyPossible(tableSize1, tableSize2)){
    int[,] randomValuesTable1 = CreateRandomValuesTable(tableSize1, tableMinMax1);
    OutputMessage(randomValuesTable1, "Первая матрица: ");
    int[,] randomValuesTable2 = CreateRandomValuesTable(tableSize2, tableMinMax2);
    OutputMessage(randomValuesTable2, "Вторая матрица: ");
    int[,] multiMatrix = MultiplyTwoMatrix(randomValuesTable1, randomValuesTable2);
    OutputMessage(multiMatrix, "Произведение двух матриц: ");
}
else WriteLine("Введенные данные не допустимы");


int[] GetTableSize(){
    string userInput = UserPrompt("Введите через пробел число строк и столбцов в матрице: ");
    int[] tableSize = ConvertStringToIntArray(userInput);
    return tableSize;
}

int[] GetMinMaxValue(){
    string userInput = UserPrompt("Введите через пробел минимальное и максимальное значение в матрице: ");
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
   return ValidateArraySize(arraySizeInput) && ValidateMinMaxInput(arrayMinMaxInput);
}

bool ValidateIfMultiplyPossible(int[] FirstArraySizeInput, int[] SecondArraySizeInput){
   if (FirstArraySizeInput[1] != SecondArraySizeInput[0]){
       WriteLine("Количество столбцов первой матрицы должно быть равно количеству строк во второй.");
       return false;
   }
   return true;
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

int[,] MultiplyTwoMatrix(int[,] firstMatrix,
                         int[,] secondMatrix){
    int[,] multiMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
        for (int firstMatrixRow = 0; firstMatrixRow < firstMatrix.GetLength(0); firstMatrixRow++){
            MultiplyRowPerColumn(firstMatrix, secondMatrix, multiMatrix,firstMatrixRow);
        }
    return multiMatrix;
}

void MultiplyRowPerColumn(int[,] firstMatrix,
                          int[,] secondMatrix,
                          int[,] multiMatrix,
                          int firstMatrixRow){
    for (int secondMatrixColumn = 0; secondMatrixColumn < secondMatrix.GetLength(1); secondMatrixColumn++){

        int sum = 0;
        for (int firstMatrixColumn = 0; firstMatrixColumn < firstMatrix.GetLength(1); firstMatrixColumn++){
            sum += firstMatrix[firstMatrixRow, firstMatrixColumn] * secondMatrix[firstMatrixColumn, secondMatrixColumn];
        }
        multiMatrix[firstMatrixRow, secondMatrixColumn] = sum;
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
