// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//
// Пример:
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите по 2 точки, для двух прямых и мы покажем их пересечение");
double b1 = InputNumber("Введите точку b1: ");
double b2 = InputNumber("Введите точку b2: ");
double k1 = InputNumber("Введите точку k1: ");
double k2 = InputNumber("Введите точку k2: ");

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;
Console.WriteLine("Точка пересечения по оси X: " + x);
Console.WriteLine("Точка пересечения по оси Y: " + y);


double InputNumber(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}