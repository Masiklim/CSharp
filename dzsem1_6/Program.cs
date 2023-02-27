Console.Clear();
Console.WriteLine("Введите число я овечу чётное ли оно!");
Console.Write("Введите целое число: ");
int NamA = int.Parse(Console.ReadLine());

if (NamA%2==0)
{
    Console.WriteLine($" -> Да");
}
else 
{
   Console.WriteLine($"-> Нет"); 
}

//($-> "");
