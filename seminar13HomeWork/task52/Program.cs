//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void PrintDigit(int[,] array, double arithMean)
{
    
    for (int j = 0; j < array.GetLength(1); j++)
   {
    double result = 0;
       for (int i = 0; i < array.GetLength(0); i++)
        {
            result += array[i, j];
            arithMean = result / array.GetLength(1);
           
        }
        Console.Write($"{arithMean} ");
       
   }
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


int[,]array = new int[4, 4];

FillArray(array);
PrintArray(array);
double arithMean = 0;
PrintDigit(array, arithMean);


