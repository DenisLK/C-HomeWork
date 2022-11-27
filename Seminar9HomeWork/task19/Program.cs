// Программа принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//14212 -> нет
//12821 -> да
//23432 -> да


void SearhP(string num)
{
int len = num.Length;
if (len == 5)
{
    if (num [0] == num [4] && num[1] == num[3])
    {
        Console.WriteLine($"Число {num} - Палиндром");
    }
    else
    {
        Console.WriteLine($"Число {num} - НЕ палиндром");
    }
}
else
{
    Console.WriteLine($"ОШИБКА:Число {num} - не является пятизначным");
}
}
Console.WriteLine("Введите число: ");
SearhP(Console.ReadLine());

