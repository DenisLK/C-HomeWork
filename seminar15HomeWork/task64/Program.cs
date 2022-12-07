// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
void Num (int n, int m)
{
    for (int i = 0; i < m; i++)    
    {
        
        Console.Write($"{n} ");
        n--;
    }
}
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int m = n;
Console.WriteLine();
Num(n, m);