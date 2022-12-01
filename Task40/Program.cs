// на вход три числа и 
// проверяет, может ли существовать треугольник с сторонами такой длины.

// каждая сторона треугольникa меньше суммы двух других сторон.

Console.WriteLine("Введите три числа");
Console.Write("Первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

bool Triangle(int num1, int num2, int num3)
{
    return ((num1 < num2 + num3) && (num2 < num1 + num3) && (num3 < num1 + num2));
}

// bool triangle = Triangle(number1, number2, number3);
// Console.WriteLine(triangle);
Console.WriteLine(Triangle(number1, number2, number3) ? "Да" : "Нет");
