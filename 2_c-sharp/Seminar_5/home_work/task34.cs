int[] GetArray(int size, int minValue, int maxValue){
    // Method for creating array of random integers
    int[] res = new int[size];
    for (int i = 0; i < size; i++){
        res[i] = new Random().Next(minValue, maxValue+1);
    }
    return res;
}

int FindEvenNumber(int[] array){
    // Method for finding quantity of even numbers in array
    int i = 0;
    foreach(var el in array){
        if (el % 2 == 0){
            i++;
        }
    }
    return i;
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

string PrintArray(int[] array){
    // Method for printing given array
    string writenArray = String.Join(", ", array);
    return writenArray;
}

Console.Clear();
int arrSize = Prompt("Введите размер массива: ");
if (ValidateArraySize(arrSize)){
    int[] arr = GetArray(arrSize, 100, 1000);
    Console.WriteLine(PrintArray(arr));
    Console.WriteLine($"Колличество четных чисел в массиве равно {FindEvenNumber(arr)}");
}
