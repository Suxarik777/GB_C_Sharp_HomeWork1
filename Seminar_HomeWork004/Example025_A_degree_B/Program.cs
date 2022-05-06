// Задача 25 
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Пример:  3, 5 -> 243 (3⁵)        2, 4 -> 16


Console.WriteLine("Введите два числа и мы возведём первое число в натуральную степень второго");
Console.WriteLine("Введите первое число A");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число B");
int numberB = Convert.ToInt32(Console.ReadLine());

int result = Exponentiation(numberA, numberB);

Console.WriteLine($"A возведённое в число B = {result}");


int Exponentiation(int A, int B) //функция для возведения числа A в степень B
{
    int help = A;               // вспомогательная переменная для корректного возведения в степень изначально введёной цифры
    for(int i = 1; i < B; i++)
    {
        A = A * help;
    }
    return A;
}
