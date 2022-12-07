// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

void Sum(int n, int k)
{
    int result = 0;
    for (int i = 0; i <= k; i++)    
    {
        result = result + n++;
    }
    Console.WriteLine($"Сумма всех элементов в диапазоне от М до N равна {result}");
}


Console.WriteLine("Введите число M: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int m = Convert.ToInt32(Console.ReadLine());
int k = m - n;
Sum(n, k);
