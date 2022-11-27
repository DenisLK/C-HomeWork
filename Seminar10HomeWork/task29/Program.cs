// Программа которая задаёт массив из N элементов и выводит их на экран.
//5 -> [1, 2, 5, 7, 19]
//3 -> [6, 1, 33]

// int lenArray = ReadInt("Введите длинну массива: ");

// int[] randomArray = new int[lenArray];
// for (int i = 0; i < randomArray.Length; i++)
// {
//     randomArray[i] = new Random().Next(1,9);
//     Console.Write(randomArray[i] + " ");
// }


// // Функция ввода
// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }
int[] lenArray(int size, int minValue, int maxValue)
{
    int[]newArray = new int [size];
    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return newArray;
}    
void showArray(int[] array)
 {
    
        Console.Write("Получившийся массив -> ");
        for(int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    
 }

Console.WriteLine("Размер массива ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Минимальное значение ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Максимальное значение ");
int maxValue = Convert.ToInt32(Console.ReadLine());
int[] myArray = lenArray(size, minValue, maxValue);
showArray(myArray);

