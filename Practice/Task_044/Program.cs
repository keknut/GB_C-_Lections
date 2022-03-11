// Найти точку пересечения двух прямых заданных уравнением
// y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы

double IntersectionPoint(double k1, double b1, double k2, double b2)
{
    double x = 0;
    double y = 0;

    x = (b1 - b2) / (k2 - k1);
    y = k2 * x - b2;

    return x;
    return y;
}

Console.Write("Input k1: ");
double k1 = int.Parse(Console.ReadLine());
Console.Write("Input b1: ");
double b1 = int.Parse(Console.ReadLine());
Console.Write("Input k2: ");
double k2 = int.Parse(Console.ReadLine());
Console.Write("Input b2: ");
double b2 = int.Parse(Console.ReadLine());

Console.WriteLine($"Intersection point: {IntersectionPoint(k1, b1, k2, b2)}");