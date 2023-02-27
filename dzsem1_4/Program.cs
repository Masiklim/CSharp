Console.Write("Введите целое число 1: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите целое число 2: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите целое число 3: ");
int с = int.Parse(Console.ReadLine());

max = Math.Max(a, Math.Max(b, c));
Console.WriteLine(max);


