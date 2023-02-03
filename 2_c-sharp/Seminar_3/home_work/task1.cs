Console.Clear();

Console.Write("Введите пятизначное число: ");
string N = Console.ReadLine();
bool is_pal = true;
for (int i = 0; i <= N.Length/2; i++){
    if (N[i] != N[N.Length-1-i]){
        Console.WriteLine("Число не палиндром");
        is_pal = false;
        break;
    }
}
if (is_pal){
    Console.WriteLine("Число палиндром");
}
