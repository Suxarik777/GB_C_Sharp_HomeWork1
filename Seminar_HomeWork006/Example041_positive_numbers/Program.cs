// SЗадача 41 
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// Пример:  
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Укажите, сколько чисел вы хотите ввести");
int userlength = Convert.ToInt32(Console.ReadLine());

int[] numbersArray = GetArray(userlength);

Console.WriteLine("Вы ввели следующие числа: ");
PrintArray(numbersArray);

Console.WriteLine("");

int positiveNumbersArray = CheckPositiveNumbers(numbersArray);
Console.WriteLine($"Кол-во введёных чисел больше 0: {positiveNumbersArray}");



int[] GetArray(int length)
{
    int[] newArray = new int[length];
    FillArrayUser(newArray);
    return newArray;
}

void FillArrayUser(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("Введите число № " + (i + 1));
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array [i] + " ");
    }
    Console.WriteLine();
}

int CheckPositiveNumbers(int[] array)
{
    int countCheck = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            countCheck++;
        }
    }
    return countCheck;
}