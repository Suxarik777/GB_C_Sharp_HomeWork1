//  Задача 36
//  Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//  Пример:  [3, 7, 23, 12] -> 19       [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите длину будущего массива (количества чисел в нём) и мы покажем сумму элементов стоящих на нечётных позициях");
int length = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[length];

FillArray(numbers);
Console.WriteLine("Сгенерированный массив выглядит так: ");
PrintArray(numbers);

int example = Target(numbers);
Console.WriteLine("Сумма элементов на нечетной позиции " + example);



void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-99, 100);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int Target(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(i % 2 != 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}