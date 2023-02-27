Console.Write("Введите целое число: ");
int NamA = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите целое число: ");
int NamB = int.Parse(Console.ReadLine() ?? "");

if (NamA==NamB*NamB)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
//int result = (int)Math.Pow(userNamber, 2);// открыли математическую функцию, выбрали Pow и после написали в какую степень возводить

//Console.WriteLine($"{userNamber} -> {result}");