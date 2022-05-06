//   Задача 34 
//  Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//  Пример: [345, 897, 568, 234] -> 2


Console.WriteLine("Пожалуйста задайте количество элементов (чисел) в массиве");
int arrayLength = Convert.ToInt32(Console.ReadLine());

int[] numbersArray = new int [arrayLength];

FillArray(numbersArray);
Console.WriteLine("Так выглядит сгенерированный массив из трехзначных чисел, заданной вами длины");
WriteArray(numbersArray);

int countEvenNumbersArray = EvenNumbers(numbersArray);

Console.WriteLine($"В данном массиве {countEvenNumbersArray} чётных чисел");

void FillArray(int [] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array [i] = new Random().Next(100, 1000);
    }
}

void WriteArray(int [] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int EvenNumbers(int [] array)
{
    int countEvenNumbers = 0;               // переменная для подсчёта количества четных чисел в массиве
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
            countEvenNumbers++ ;
        } 
    }
    return countEvenNumbers;
}