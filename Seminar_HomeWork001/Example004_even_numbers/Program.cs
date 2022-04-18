void FillArrayMethod(int[] collection) //(Функция раскрывается) этой функцией заполняем массив числами от одного до N подряд
{
    int length = collection.Length;
    int index = 0;
    int number = 1;    //создаём отдельную переменную для последовательного заполнения массива от 1 

    while (index < length)
    {
        collection[index] = number;
        index++;
        number++;
    }
}

void PrintEvenArrayMethod(int[] data) // (Функция раскрывается) этим методом печатаем в консоль четные числа
{
    int length = data.Length;
    int index = 0;

    while (index < length)
    {
        if (data[index] % 2 == 0)
        {
            Console.WriteLine(data[index]);
            index++;
        }
        else 
        {
        index++;
        }
    }
}


Console.WriteLine("Введите число и мы покажем все четные числа до этого числа");
int last_number = Convert.ToInt32(Console.ReadLine());

int[] array_number = new int[last_number]; //cоздаю массив длиною введёного числа пользователем

FillArrayMethod(array_number);
Console.WriteLine("=============");
PrintEvenArrayMethod(array_number);