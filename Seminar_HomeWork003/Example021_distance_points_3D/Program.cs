// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// Пример:  
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int Coordinate(string coorName, string pointName)
{
    Console.WriteLine($"Введите координату {coorName} точки {pointName}: ");
    return Convert.ToInt16(Console.ReadLine());
}

int xA = Coordinate("x", "A");
int yA = Coordinate("y", "A");
int zA = Coordinate("z", "A");

int xB = Coordinate("x", "B");
int yB = Coordinate("y", "B");
int zB = Coordinate("z", "B");

int diffX = xB - xA; //вычесление длины первого катета
int diffY = yB - yA;
int diffZ = zB - zA;

double result = Math.Sqrt(Math.Pow(diffX, 2) + Math.Pow(diffY, 2) + Math.Pow(diffZ, 2));
Console.WriteLine($"Расстояние между точкой А ({xA}, {yA}, {zA}) и точкой B ({xB}, {yB}, {zB}) в 3D пространстве {result}");

//ищем гипотенузу //A = √(X²+Y²) - гипотинуза равна сумме квадратов катетов
//Math.Sqrt высчитывает корень
//Math.Pow возводит в квадрат (то что мы возводим, в какую степень возводим2)