// Задача 23: 
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число N и мы выдадим кубы чисел от 1 до N");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ваши числа " + number + " в кубе");

int index = 1;


if (number <= 0)
{
    Console.WriteLine("Некорректный ввод!");
}

while (number >= index)
{
    double result = Square(index); //это функция по возведению в квадрат смотри ниже
    Console.WriteLine(result + " ");
    index++;
}

double Square(int number)
{
    return Math.Pow(number,3); //команда возведение в степень
    // number * number * number; можно ещё так но выше красивше выглядит
}
