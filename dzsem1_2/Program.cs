Console.Write("Введите целое число: ");
int NamA = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите целое число: ");
int NamB = int.Parse(Console.ReadLine() ?? "");

if (NamA > NamB)
{
    Console.WriteLine(NamA);
}
else 
{
    Console.WriteLine($" -> {NamB}");
}
