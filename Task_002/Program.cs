// Напишите программу, которая принимает на вход координаты точки (X и Y),
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости,
// в которой находится эта точка.

Console.WriteLine("Введите координату X: ");
int XNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y: ");
int YNumber = Convert.ToInt32(Console.ReadLine());

if (XNumber >0 && YNumber > 0) 
{
    System.Console.WriteLine($"{XNumber}, {YNumber} => 1 четверть");
}
else if (XNumber < 0 && YNumber > 0) 
{
    System.Console.WriteLine($"{XNumber}, {YNumber} => 2 четверть");
}
else if (XNumber < 0 && YNumber < 0) 
{
    System.Console.WriteLine($"{XNumber}, {YNumber} => 3 четверть");
}
else
{
    System.Console.WriteLine($"{XNumber}, {YNumber} => 4 четверть");
}

