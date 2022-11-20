//Программа для нахождения большего и меньшего числа из двух
int a = 2, b = -38;
int max = a;
int min = b;
if (a > max) max = a;
if (b > max) max = b;


if (a < min) min = a;
if (b < min) min = b;


Console.Write("max= ");
Console.WriteLine(max);
Console.Write("min= ");
Console.WriteLine(min);
