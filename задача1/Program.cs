//Программа для нахождения максимального из 3 чисел
int a = 22, b = 3, c = 9;
int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.Write("max= ");
Console.WriteLine(max);
