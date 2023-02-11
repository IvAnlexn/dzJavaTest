double[] GetArray(int size, double minValue, double maxValue){
    // Method for creating an array of double
    double[] res = new double[size];
    for (int i = 0; i < size; i++){
        res[i] = new Random().NextDouble() * (maxValue - minValue) + minValue;
    }
    return res;
}

double FindDiffBeetwenMaxMin(double[] array){
    // Method for finding difference beetwen max and min elements in array
    double minN = array[0];
    double maxN = array[0];
    foreach (double n in array){
        if (n < minN){
            minN = n;
        }
        if (n > maxN){
            maxN = n;
        }
    }
    double difference = maxN - minN;
    return difference;
}

double Prompt(string message){
    // Promt for user input
    Console.Write(message);
    double input = double.Parse(Console.ReadLine());
    return input;
}

int PromptSize(string message){
    // Promt for user input for array size. Need to be integer
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

bool ValidateMaxIsGreaterThanMin(double min, double max){
    // Method for checking if inputed min and max value is valid.
    if (min > max){
        Console.WriteLine("Минимальное значение должно быть меньше или равно максимального.");
        return false;
    }
    else{
        return true;
    }
}

string PrintArray(double[] array){
    // Method for printing given array of doubles with round up to .01
    string writenArray = "";
    string doubleAsString = "";
    foreach (double n in array){
        doubleAsString = $"{n:f2}, ";
        writenArray = writenArray + doubleAsString;
    }
    return writenArray;
}

Console.Clear();
int arrSize = PromptSize("Введите размер массива: ");
double arrMin = Prompt("Введите минимальное значение в массиве: ");
double arrMax = Prompt("Введите максимальное значение в массиве: ");
bool validSize = ValidateArraySize(arrSize);
bool validMinMax = ValidateMaxIsGreaterThanMin(arrMin, arrMax);

if (validSize && validMinMax){
    double[] arr = GetArray(arrSize, arrMin, arrMax);
    Console.WriteLine(PrintArray(arr));
    Console.WriteLine($"Разница между максимальным и минимальным значениями массива равна {FindDiffBeetwenMaxMin(arr):f2}");
}
