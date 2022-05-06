// Задача 27
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// Пример:  452 -> 11       82 -> 10    9012 -> 12

Console.WriteLine("Задайте число и мы посчитаем сумму цифр в этом числе");
int number = Convert.ToInt32(Console.ReadLine());
int saveNumber = number;
int sum = 0;

while(number > 0)              // и так пока не достигнем 0
{
    int help = number % 10; // выявление цифры
    sum = sum + help;       // сумирование в рамках цикла
    number = number / 10;   // делим на десять так как одно число уже выявили и просумировали
}

Console.WriteLine($"Cумму цифр в числе {saveNumber}, равна {sum}");
