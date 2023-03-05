// циклический ввод переменной, для инт просто поменять тип
//int 
double varA;
while (true)
{
    Console.Write("Введите А: ");
       //int    
    if (double.TryParse(Console.ReadLine(), out varA))
        break;
        Console.WriteLine("Ошибка Ввода!");
}
Console.WriteLine($"A={varA}");