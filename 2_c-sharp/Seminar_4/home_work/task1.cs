Console.Clear();
int PowCalc(int a, int b){
    int mult = 1;
    for(int i = 1; i <= b; i++){
        mult *= a;
    }
    return mult;
}

Console.Write("Введите число основание степени: ");
int osnovanie = int.Parse(Console.ReadLine());
Console.Write("Введите число значение степени: ");
int znachenie = int.Parse(Console.ReadLine());

Console.WriteLine($"{osnovanie}^{znachenie}={PowCalc(a: osnovanie, b: znachenie)}");
