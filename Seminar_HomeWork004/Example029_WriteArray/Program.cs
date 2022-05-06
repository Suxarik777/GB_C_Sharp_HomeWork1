// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine($"Напишите 8 чисел и мы выведим их на экран. Это будут числа в массиве");

int[] numbers = new int[8];
for (int i = 0; i < numbers.Length; i++)
{    
Console.WriteLine($"Введите число {i + 1}: ");    
numbers[i] = Convert.ToInt32(Console.ReadLine());
}

WriteArray(numbers);

void WriteArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine();
}