// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

Console.Write("Введите координаты точки X не равной 0: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки Y не равной 0: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
    Console.WriteLine($"{x},{y} => 1");
if (x < 0 && y > 0)
    Console.WriteLine($"{x},{y} => 2");
if (x < 0 && y < 0)
    Console.WriteLine($"{x},{y} => 3");
if (x > 0 && y < 0)
    Console.WriteLine($"{x},{y} => 4");
else
    Console.WriteLine("Вы ввели некорректные числа, повторите ввод");
