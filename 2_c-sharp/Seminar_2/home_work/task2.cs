Console.Clear();

Console.Write("Введите число: ");
string a = Console.ReadLine();
if (a.Length < 3){
    Console.WriteLine("В этом числе нет третьей цифры");
}
else {
    char second_num = a[2];
    Console.WriteLine($"третья цифра числа {a} равна {second_num}");
    }
