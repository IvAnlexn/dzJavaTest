// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
using System;
using static System.Console;

Clear();
int[] tableSize = {4, 4};
int[,] spiralTable = CreateSpiralTable(tableSize);
OutputMessage(spiralTable, "Создан массив 4x4 заполненный по спирали: ");

int[,] CreateSpiralTable(int[] tableSize)
{
    int[,] newTable = new int[tableSize[0], tableSize[1]];
    FillTable(newTable);
    return newTable;
}

void FillTable(int[,] table){
    int i = 0;
    int j = 0;
    for (int count = 1; count <= 16; count++){
        switch(count){
            case < 4:
                table[i,j] = count;
                j++;
                break;
            case < 7:
                table[i,j] = count;
                i++;
                break;
            case < 10:
                table[i,j] = count;
                j--;
                break;
            case < 12:
                table[i,j] = count;
                i--;
                break;
            case < 14:
                table[i,j] = count;
                j++;
                break;
            case < 15:
                table[i,j] = count;
                i++;
                break;
            case < 16:
                table[i,j] = count;
                j--;
                break;
            case 16:
                table[i,j] = count;
                break;
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
    for (int i = 0; i < inArray.GetLength(0); i++){
        for (int j = 0; j < inArray.GetLength(1); j++){
            Write($"{inArray[i,j]:00.} ");
        }
        WriteLine();
    }
}
