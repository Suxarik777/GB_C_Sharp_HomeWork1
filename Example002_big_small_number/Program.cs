Console.WriteLine("Введите два числа и мы покажем какое число больше, а какое меньше");

Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine("Больше первое число " + num1);
    Console.WriteLine("А меньше второе число " + num2);
}
else
{
    Console.WriteLine("Первое число меньше " + num1);
    Console.WriteLine("А второе число больше " + num2);
}
Console.WriteLine("Спасибо!");
Console.WriteLine("Для перезапуска программы введите команду dotnet run");