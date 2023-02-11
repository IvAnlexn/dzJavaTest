int[] GetArray(int size, int minValue, int maxValue){
    // Function create array of integers
    int[] res = new int[size];
    for (int i = 0; i < size; i++){
        res[i] = new Random().Next(minValue, maxValue+1);
    }
    return res;
}

int FindHowManyElementsInRange(int[] array){
    // Method for finding quantity of numbers in 10-99 value range
    int i = 0;
    foreach (int n in array){
        if (n >= 10 && n <= 99){
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

string PrintArray(int[] array){
    // Method for printing given array
    string writenArray = String.Join(", ", array);
    return writenArray;
}


Console.Clear();
int[] arr = GetArray(123, 0, 1000);
Console.WriteLine("Создан следующий массив размером 123, со значениями элементов от 0 до 1000.");
Console.WriteLine(PrintArray(arr));
Console.WriteLine($"Колличество чисел в массиве которые больше или равны 10 и меньше или равны 99: {FindHowManyElementsInRange(arr)}");
