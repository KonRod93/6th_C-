// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями. 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите значене b1");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значене b2");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значене k1");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значене k2");
double k2 = Convert.ToDouble(Console.ReadLine());

// Приравниваем правые части данных равенств:
// k1 * x + b1 = k2 * x + b2
// выразим отсюда x:

double x = (b2 - b1) / (k1 - k2);

// затем подставим полученное значение х в выражение для у (как пример, для первого):

double y = k1 * (b2 - b1) / (k1 - k2) + b1;

Console.WriteLine($"Координаты точки пересечения: X={x}, Y={y}");