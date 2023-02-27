Console.Write("Введите целое число: ");


int userNamber = int.Parse(Console.ReadLine() ?? "");

int result = (int)Math.Pow(userNamber, 2);// открыли математическую функцию, выбрали Pow и после написали в какую степень возводить

Console.WriteLine($"{userNamber} -> {result}");// красивый вывод