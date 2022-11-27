// Программа принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


int tabl(int num)
{
    for (int i = 1; i <= num; i++)
    Console.Write($"{i*i*i} ");
    return Convert.ToInt32(Console.ReadLine());
}


Console.WriteLine("Введите число N: ");
int num = Convert.ToInt32(Console.ReadLine()); 
tabl(num);





 