// Задача 13
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// Пример: 645 -> 5     78 -> третьей цифры нет     32679 -> 6


Console.WriteLine("Введите число и мы покажем третью цифру этого числа");
string number = Console.ReadLine();

if(number.Length == 1 || number.Length == 2)
{
    Console.WriteLine($"В числе {number} третьей цифры нет :/");
}
else
{
    Console.WriteLine($"В числе {number} третья цифра: {number[2]}");
}
