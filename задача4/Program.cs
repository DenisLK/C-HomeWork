// программа вывода четных чисел в дипазоне от 1 до указанного числа
int i = 1;
            Console.Write("Введите число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            while(i <= n)
            {
                if(i%2 == 0)
                {
                    Console.WriteLine(i);
                }
;
                i++;
            }
