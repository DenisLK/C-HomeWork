//Программа для нахождения большего и меньшего числа из двух
int a = 5, b = 7;
int max = 0;
int min = 0;
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
