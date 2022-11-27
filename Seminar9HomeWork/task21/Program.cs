//Программа принимает на вход координаты двух точек и
// находит расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53



double Line(double x1, double y1,
           double z1, double x2,
           double y2, double z2)
{
    double A = x2 - x1;
    double B = y2 - y1;
    double C = z1 - z2;
    double Lends = Math.Sqrt(A * A + B * B + C * C);
    Lends = Math.Round(Lends, 2);
    Console.WriteLine($"{Lends}");
    return Lends;
}

Console.WriteLine("Введите ккординату х1");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите ккординату y1");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите ккординату z1");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите ккординату х2");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите ккординату y2");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите ккординату z2");
double z2 = Convert.ToDouble(Console.ReadLine());
Line(x1, y1, z1, x2, y2, z2);

