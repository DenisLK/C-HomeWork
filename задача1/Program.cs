//Программа для нахождения большего и меньшего числа из двух
int a = 8, b = -3;
int max = a;
int min = b;
if (a > b) 
{
    max = a;
    min = b;
}
else
{
    max = b;
    min = a;
} 


Console.Write("max= ");
Console.WriteLine(max);
Console.Write("min= ");
Console.WriteLine(min);
