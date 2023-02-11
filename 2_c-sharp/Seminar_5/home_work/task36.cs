int[] GetArray(int size, int minValue, int maxValue){
    // Method for creating array of random integers
    int[] res = new int[size];
    for (int i = 0; i < size; i++){
        res[i] = new Random().Next(minValue, maxValue+1);
    }
    return res;
}

int FindSumOfOddIndexes(int[] array){
    // Method for finding sum of elements with odd indexes
    int i = 0;
    int sum = 0;
    for (i = 1; i < array.Length; i+=2){
        sum += array[i];
    }
    return sum;
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
        Console.WriteLine("Минимальное значение должно быть меньше или равно максимальному.");
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
    // Checks if valid values are inputed
    int[] arr = GetArray(arrSize, arrMin, arrMax);
    Console.WriteLine(PrintArray(arr));
    Console.WriteLine($"Сумма чисел на нечетных индексах в массиве равна {FindSumOfOddIndexes(arr)}");
}
