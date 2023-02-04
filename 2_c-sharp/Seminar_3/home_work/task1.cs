Console.Clear();
bool notPenta = true;
int N = 0;
while (notPenta){
    Console.Write("Введите пятизначное число: ");
    N = int.Parse(Console.ReadLine());
    if (N/10000 != 0 && N/100000 == 0) notPenta = false;
}
if (N/10000 == N%10 && (N%10000)/1000 == (N%100)/10) Console.WriteLine("Число палиндром");
else Console.WriteLine("Число не палиндром");
