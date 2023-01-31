Console.Clear();
bool number_is_right = false;
while (!number_is_right){
    Console.Write("Введите номер дня недели: ");
    int week_day = int.Parse(Console.ReadLine());
    if (week_day < 1 || week_day > 7){
        Console.WriteLine("Число должно быть от одного до семи");
    }
    else {
        number_is_right = true;
        if (week_day >= 6){
            Console.WriteLine("Это выходной день");
        }
        else{
            Console.WriteLine("Это будний день");
        }
    }
}
