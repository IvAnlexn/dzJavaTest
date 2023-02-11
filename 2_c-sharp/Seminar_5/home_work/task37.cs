int[] GetArray(int size, int minValue, int maxValue){
    // Method for creating an array of integers
    int[] res = new int[size];
    for (int i = 0; i < size; i++){
        res[i] = new Random().Next(minValue, maxValue+1);
    }
    return res;
}

int[] FindMultipleBeetweenElements(int[] array){
    // Method returns an array that consist of multiplications of original array pairs
    if (array.Length%2 == 0){
        // If array consist of even number of elements
        int[] arrFromMultiple = new int[array.Length/2];
        for (int i = 0; i < array.Length/2; i++){
            arrFromMultiple[i] = array[i] * array[array.Length - 1 - i];
        }
        return arrFromMultiple;
    }
    else{
        // If array consist of odd number of elements
        int[] arrFromMultiple = new int[array.Length/2+1];
        for (int i = 0; i <= array.Length/2; i++){
            if (i == array.Length/2){
                // For middle element multiplication is not needed
                arrFromMultiple[i]= array[i];
            }
            else{
                // For all elements exept the middle need multiplication
                int mult = array[i] * array[array.Length - 1 - i];
                arrFromMultiple[i] = mult;
            }
        }
        return arrFromMultiple;
    }
}
int Prompt(string message){
    // Promt for user input
    Console.Write(message);
    int input = int.Parse(Console.ReadLine());
    return input;
}

bool ValidateArraySize(int arraySize){
    // Method for checking if inputed array size is positive
    if (arraySize <= 0){
        Console.WriteLine("Размер массива должен быть больше нуля");
        return false;
    }
    else{
        return true;
    }
}

bool ValidateMaxIsGreaterThanMin(int min, int max){
    // Method for checking if inputed min and max value is valid.
    if (min > max){
        Console.WriteLine("Минимальное значение должно быть меньше максимального.");
        return false;
    }
    else{
        return true;
    }
}

string PrintArray(int[] array){
    // Method for printing given array
    string writenArray = String.Join(", ", array);
    return writenArray;
}

Console.Clear();
int arrSize = Prompt("Введите размер массива: ");
int arrMin = Prompt("Введите минимальное значение в массиве: ");
int arrMax = Prompt("Введите максимальное значение в массиве: ");
bool validSize = ValidateArraySize(arrSize);
bool validMinMax = ValidateMaxIsGreaterThanMin(arrMin, arrMax);
if (validSize && validMinMax){
    int[] arr = GetArray(arrSize, arrMin, arrMax);
    Console.WriteLine(PrintArray(arr));
    int[] newArray = FindMultipleBeetweenElements(arr);
    Console.WriteLine($"Массив из умножения пар элементов равен:");
    Console.WriteLine(PrintArray(newArray));
}
