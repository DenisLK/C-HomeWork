// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет
bool day(int day)
{
    if(day % 7 == 0 && day % 6 == 0)
    {
        return true;
        
    }
    else
    {
        return false;
        
    }
    
}

Console.Write("Введите число дня недели: ");
day(Convert.ToInt32(Console.ReadLine()));

Console.WriteLine($"{otv}");