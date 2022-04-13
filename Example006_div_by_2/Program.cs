Console.WriteLine("Введите число и мы проверим является ли оно четным");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine("Число " + number + " является четным");
}
else
{
    Console.WriteLine("Число " + number + " нечетное число");
}