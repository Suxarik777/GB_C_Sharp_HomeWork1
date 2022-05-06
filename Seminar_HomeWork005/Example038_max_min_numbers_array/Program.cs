//  Задача 38: 
//  Задайте массив вещественных чисел. 
//  Найдите разницу между максимальным и минимальным элементов массива.
//  Пример:     [3 7 22 2 78] -> 76

Console.WriteLine("Введите длину будущего массива");
int length = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[length];

FillArray(numbers);
Console.WriteLine("Сгенерированный массив выглядит так: ");
PrintArray(numbers);

int maxNumber = MaxNumberArray(numbers);
int minNumber = MinNumberArray(numbers);

int result = maxNumber - minNumber;
Console.WriteLine("Разница между максимльным и минимальным элементом массива " + result);




void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
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

int MaxNumberArray(int[] array)
{
    int maxNumber = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxNumber)
        {
            maxNumber = array[i];
        }
    }
    return maxNumber;
}

int MinNumberArray(int[] array)
{
    int minNumber = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minNumber)
        {
            minNumber = array[i];
        }
    }
    return minNumber;
}