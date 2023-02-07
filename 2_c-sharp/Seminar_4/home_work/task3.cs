Console.Clear();
int[] Massiv(){
    Console.Write("Введите длину массива: ");
    int N = int.Parse(Console.ReadLine());
    if (N < 0){
        N *= -1;
    }
    else if(N == 0){
        Console.WriteLine("Длина массива не может равняться 0");
    }
    int[] mass = new int[N];
    for (int i = 0; i < N; i++){
        Console.Write("Введите число для добавления его в массив: ");
        mass[i] = int.Parse(Console.ReadLine());
        // Console.WriteLine("");
    }
    return mass;
}

int[] vivod = Massiv();

Console.WriteLine($"{String.Join(", ", vivod)}");
