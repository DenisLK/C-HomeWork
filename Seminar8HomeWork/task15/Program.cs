// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет
void weekend(int day)
{
    if(day == 7 || day == 6)
    {
        Console.WriteLine("Это выходной день");
    }
    else
    {
        Console.WriteLine("Это рабочий день");
    }

}

Console.Write("Введите число дня недели: ");
weekend(Convert.ToInt32(Console.ReadLine()));