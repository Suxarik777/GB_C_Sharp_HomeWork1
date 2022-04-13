Console.WriteLine("Введите три числа и мы покажем какое число из них больше");

Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int num3 = Convert.ToInt32(Console.ReadLine());

int nummax = num1;

if(num2 > nummax) nummax = num2;
if(num3 > nummax) nummax = num3;

Console.WriteLine("Наибольшее число " + nummax);