// Доп. задача
// Игра угадайка. Программа загадывает случайное число. Пользователь его угадывает. 
// Если пользователь дает неправильный ответ, то программа сообщает, 
// больше загаданное число или меньше.

// Доп. задача с усложнением: на отгадывание дается 3 попытки.
// По возможности использовать функции.



int hiddenNumber = new Random().Next(0, 9); //загаданное число
int count = 2;                              // счётчик попыток +1

Console.WriteLine($"Компьютер загадал число от 0 до 9, попробуй отгадать у тебя {count + 1} попытки");
int userNumber = Convert.ToInt32(Console.ReadLine());


while(count >= 0)
{
    if(hiddenNumber == userNumber)
    {
        Console.WriteLine($"Поздравляю! Ведь компьютер загадал именно {hiddenNumber}");
        break;
    }
    else if (count > 0)
    {
        Console.WriteLine($"К сожалению нет. Попробуй ещё. У тебя осталось {count} попыток");
        userNumber = Convert.ToInt32(Console.ReadLine());
        count --;
    }
    else
    {
        Console.WriteLine($"На этом всё. У тебя {count} попыток. Компьютер загадал {hiddenNumber}");
        break;
    }
}