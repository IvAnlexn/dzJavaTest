// Задача 60.
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
using System;
using static System.Console;

Clear();
int[] cubeSize = GetCubeSize();
if (ValidateUserInput(cubeSize)){
    int[,,] randomValuesCube = CreateRandomValuesCube(cubeSize);
    OutputMessage(randomValuesCube, "Создан трехмерный массив: ");
}
else WriteLine("Введенные данные не допустимы");


int[] GetCubeSize(){
    string userInput = UserPrompt("Введите через пробел три размера трехмерного массива, их произведение не должно превышать 100: ");
    int[] cubeSize = ConvertStringToIntArray(userInput);
    return cubeSize;
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

bool ValidateUserInput(int[] arraySizeInput){
   return ValidateIsCube(arraySizeInput)
       && ValidateArraySize(arraySizeInput)
       && ValidateNumberOfElements(arraySizeInput);
}

bool ValidateIsCube(int[] arraySize){
    if (arraySize.Length != 3){
        Console.WriteLine("Массив должен иметь три размера");
        return false;
    }
    return true;
}

bool ValidateArraySize(int[] arraySize){
    if (arraySize[0] <= 0 || arraySize[1] <= 0 || arraySize[2] <= 0){
        Console.WriteLine("Размер массива должен быть больше нуля");
        return false;
    }
    return true;
}

bool ValidateNumberOfElements(int[] arraySize){
    if (arraySize[0] * arraySize[1] * arraySize[2] > 100){
        Console.WriteLine("Количество элементов в массиве не должно превышать 100");
        return false;
    }
    return true;
}

int[,,] CreateRandomValuesCube(int[] cubeSize)
{
    int[,,] newCube = new int[cubeSize[0], cubeSize[1], cubeSize[2]];
    FillCube(newCube);
    return newCube;
}

void FillCube(int[,,] cube){
    HashSet<int> elementsInCube = new HashSet<int>();
    int uniqueElement = 0;
    for (int i = 0; i < cube.GetLength(0); i++)
    {
        for (int j = 0; j < cube.GetLength(1); j++)
        {
            for (int k = 0; k < cube.GetLength(2); k++)
            {
                uniqueElement = WriteUniqueElement(elementsInCube);
                cube[i, j, k] = uniqueElement;
                elementsInCube.Add(uniqueElement);
            }
        }
    }
}

int WriteUniqueElement(HashSet<int> NotUniqueElements){
    Random rnd = new Random();
    int indexValue = rnd.Next(10, 100);
    while (NotUniqueElements.Contains(indexValue)){
        indexValue = rnd.Next(10, 100);
    }
    NotUniqueElements.Add(indexValue);
    return indexValue;
}

void OutputMessage(int[,,] cube, string message){
    WriteLine(message);
    PrintCube(cube);
    WriteLine("");
}

void PrintCube(int[,,] inArray)
{
    for (int k = 0; k < inArray.GetLength(2); k++){
        for (int i = 0; i < inArray.GetLength(0); i++){
            for (int j = 0; j < inArray.GetLength(1); j++){
                Write($"{inArray[i,j,k]}({i},{j},{k}) ");
            }
            WriteLine();
            }
    }
}
