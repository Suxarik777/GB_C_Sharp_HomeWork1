// Задача 19  
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Пример:  14212 -> нет    23432 -> да    12821 -> да  

Console.WriteLine("Введите пятизначное число и мы проверим является ли оно палиндромом");
string userNumber = Console.ReadLine();
string corectNumber = CheckingNumber(userNumber); //дополнительная переменная создана для записи нового числа в функции в случае если первый раз пользователь ошибся
LookNumber(corectNumber);



string CheckingNumber(string userNumber)
{
    if(userNumber.Length == 5) return userNumber;
    else
    {
        Console.WriteLine("Вы ввели не корректное число, пожалуйста введите число состоящее из 5 цифр");
        userNumber = Console.ReadLine();
        return CheckingNumber(userNumber);
    }
}



void LookNumber(string userNumber)
{
    int length = userNumber.Length - 1;
    int i = 0;
    while(i <= userNumber.Length - 1)
    {
        if(userNumber[i] == userNumber[length] && i < userNumber.Length - 1)
        {
            i ++;
            length --;
        }
        else if(userNumber[i] == userNumber[length] && i == userNumber.Length - 1)
        {
            Console.WriteLine($"Поздравляю! Число {userNumber} является палиндромом!");
            break;   
        }
        else
        {
            Console.WriteLine($"Число {userNumber} не является палиндромом");
            break;   
        } 
    }
}



//Console.WriteLine($"Вы ввели число {corectNumber}");