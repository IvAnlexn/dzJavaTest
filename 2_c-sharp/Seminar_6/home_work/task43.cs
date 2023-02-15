float[] GetLinesIntersection(float[] arrCoeaf){
    // Method gets answer
    if (arrCoeaf[0] == arrCoeaf[2]){
        Console.WriteLine("k1 не должно равняться k2");
        return null;
    }
    float x = (arrCoeaf[3] - arrCoeaf[1])/(arrCoeaf[0]-arrCoeaf[2]);
    float y = arrCoeaf[0]*x + arrCoeaf[1];
    float[] answerArray = {x, y};

    return answerArray;
}

float[] StringToIntArray(string stringElements)
{ string[] stringArray = stringElements.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    float[] res = new float[stringArray.Length];
    for(int i = 0; i < res.Length; i++)
    { res[i] = float.Parse(stringArray[i]);
    } return res; }

string Prompt(string message){
    // Promt for user input
    Console.Write(message);
    string input = Console.ReadLine();
    return input;
}

Console.Clear();
string userInput = Prompt("Введите коэффициенты k1, b1, k2, b2 через пробел: ");
float[] inputArray = StringToIntArray(userInput);
float[] answer = CalculateIntersection(inputArray);
Console.WriteLine($"Пересечение линий на x = {answer[0]} y = {answer[1]}");
