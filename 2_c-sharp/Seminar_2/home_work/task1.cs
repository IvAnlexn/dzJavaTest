Console.Clear();
bool number_is_right = false;
string a = "null";
while (!number_is_right){
    Console.Write("Введите трехзначное число: ");
    a = Console.ReadLine();
    if (a.Length != 3){
        Console.WriteLine("Число должно быть трехзначным");
    }
    else {
        number_is_right = true;
    }
}
char second_num = a[1];
string answer = second_num.ToString();
Console.WriteLine($"Вторая цифра числа {a} равна {answer}");
