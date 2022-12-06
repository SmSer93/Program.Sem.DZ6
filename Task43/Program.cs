// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


// k1*x+b1=k2*x+b2
// k1*x-(k2*x)=b2-b1
// x(k1-k2)=b2-b1
// x=(b2-b1)/(k1-k2)

Console.WriteLine("введите значение b1");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите число k1");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите значение b2");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите число k2");
double k2 = Convert.ToDouble(Console.ReadLine());

double CrossingX (double bx1, double by2, double kx1, double ky2)
{
    double x = (by2 - bx1) / (kx1 - ky2);
 
    return x;
}
double CrossingY (double x,double bx1, double by2, double kx1, double ky2)
{
    double y = ky2 * x + by2;
    return y;
}
if (k1 != k2) 
{
double resX = Math.Round(CrossingX(b1, b2, k1, k2), 1);
double resY = Math.Round(CrossingY(resX, b1, b2, k1, k2), 1);
Console.WriteLine($"Точка пересечения прямых: ({resX},{resY})");
}
else Console.WriteLine ("Прямые параллельные");


