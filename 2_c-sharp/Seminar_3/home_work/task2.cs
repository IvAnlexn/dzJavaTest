Console.Clear();

Console.Write("Введите координату Х затем Y затем Z первой точки: ");
double x1 = double.Parse(Console.ReadLine());
double y1 = double.Parse(Console.ReadLine());
double z1 = double.Parse(Console.ReadLine());

Console.Write("Введите координату Х затем Y затем Z второй точки: ");
double x2 = double.Parse(Console.ReadLine());
double y2 = double.Parse(Console.ReadLine());
double z2 = double.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(x1-x2, 2)+Math.Pow(y1-y2, 2)+Math.Pow(z1-z2, 2));
Console.WriteLine($"Расстояние между точками равно {result:f3}");
