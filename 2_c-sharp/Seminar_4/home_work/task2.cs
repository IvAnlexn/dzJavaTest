Console.Clear();
int SumCalc(int a){
    if (a < 0){
        a *= -1;
    }
    int summ = 0;
    for(; a > 0; a /= 10){
        summ += a%10;
    }
    return summ;
}

Console.Write("Введите число основание степени: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine($"Сумма цифр в числе {num}={SumCalc(a: num)}");
