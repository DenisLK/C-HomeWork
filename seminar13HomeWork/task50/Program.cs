// Программа принимает на вход позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void PrintDigit(int[,]array, int rows, int colums)
{
    if (rows < array.GetLength(0) && colums < array.GetLength(1)) Console.WriteLine
    ($"Число в {rows} строке и {colums} столбце  => {array[rows, colums]}");
    else Console.WriteLine($"{rows},{colums} -> такого числа в массиве нет");

}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

Console.WriteLine("Введите номер строки: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца: ");
int colums = Convert.ToInt32(Console.ReadLine());
int[,]array = new int[6, 8];
FillArray(array);
PrintArray(array);
PrintDigit(array, rows, colums);
