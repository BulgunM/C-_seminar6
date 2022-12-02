// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// k1 * x + b1 = k2 * x + b2
// k1 * x - (k2 * x) = b2 - b1
// x (k1 - k2) = b2 - b1
// x = (b2 - b1) / (k1 - k2)

Console.WriteLine("Введите значения");
Console.Write("b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.Write("k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

double CoordinateX(double ba, double ka, double bc, double kc)
{
    double x = (bc - ba) / (ka - kc);
    x = Math.Round(x, 1);
    return x;
}

double СoordinateY(double ka, double xa, double ba)
{
    double y = ka * xa + ba;
    y = Math.Round(y, 1);
    return y;
}

double resultX = CoordinateX(b1, k1, b2, k2);
Console.WriteLine($"Координата X: {resultX}");
double resultY = СoordinateY(k1, resultX, b1);
Console.WriteLine($"Координата Y: {resultY}");

if (resultX == resultY) Console.WriteLine($"Координата точки пересечения двух прямых -> {resultX},{resultY}");
Console.WriteLine("У заданных прямых нет точки пересечения");
