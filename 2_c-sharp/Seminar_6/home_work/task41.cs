int GetNumberPositive(int[] arr){
    // Method gets answer
    int i = 0;
    foreach(int n in arr){
        if (n > 0) i++;
    }
    return i;
}

int[] StringToIntArray(string stringElements)
{ string[] stringArray = stringElements.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] res = new int[stringArray.Length];
    for(int i = 0; i < res.Length; i++)
    { res[i] = int.Parse(stringArray[i]);
    } return res; }

string Prompt(string message){
    // Promt for user input
    Console.Write(message);
    string input = Console.ReadLine();
    return input;
}

Console.Clear();
string userInput = Prompt("Введите элементы массива через пробел: ");
int[] inputArray = StringToIntArray(userInput);
int answer = GetNumberPositive(inputArray);
Console.WriteLine($"Количество чисел больше нуля {answer}");
