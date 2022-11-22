// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

void ThirdDigit(int number)
    {
        int result = -1;
        if (number >= 100)
        {
            while (number > 999)
            {
                number = number / 10;
            }
            result = number % 10;
            Console.WriteLine($"Третья цифра числа: {result}");
        }
        else 
        {
            Console.WriteLine("Третьей цифры нет ");
        }
             
    }
    

Console.Write("Введите число: ");
ThirdDigit(Convert.ToInt32(Console.ReadLine()));

