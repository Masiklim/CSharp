Console.Write("Введите  число: ");
int week = int.Parse(Console.ReadLine() ?? "");

if ((week<1) | (week>7))
{
    Console.WriteLine("Неверное число");
}
else 
{
    if (week==1) {Console.Write(" - Понедельник ");}
    if (week==2) {Console.Write(" - Вторник ");}
    if (week==3) {Console.Write(" - Среда ");}
    if (week==4) {Console.Write(" - Четверг ");}
    if (week==5) {Console.Write(" - Пятница");}
    if (week==6) {Console.Write(" - Суббота ");}
    if (week==7) {Console.Write(" - Воскресенье ");}
    
}

