// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Задайте количество чисел для ввода");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите случайные числа через запятую");
string[] numbers = Console.ReadLine().Split(',');

// int[] ArrayInt(string[] num)
// {
//     int[] arr = Array.ConvertAll(num, int.Parse);
//     return arr;
// }

int PositiveNumbers(string[] num)
{
    int[] arr = Array.ConvertAll(num, int.Parse);
    int digit = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) digit++;
    }
    return digit;
}

// void PrintArray(int[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length - 1; i++)
//     {
//         Console.Write($"{arr[i]}, ");
//     }
//     Console.Write(arr[arr.Length - 1]);
//     Console.WriteLine("]");
// }

// int[] array = ArrayInt(numbers);
// PrintArray(array);

int result = PositiveNumbers(numbers);
Console.WriteLine($"Количество чисел больше нуля равно {result}");